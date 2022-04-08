using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IntegratedBankingSystem
{
    public partial class frmLoanE : Form
    {
        public frmLoanE()
        {
            InitializeComponent();
        }
        private int custid;
        private string disbSts;
        double intPerIns = 0;

        private void frmLoanE_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtAcno.ReadOnly = false;
            txtAcno.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAcno.Text = "";
            txtAcTitle.Text = "";
            txtCustid.Text = "";
            txtExpDt.Text = "";
            txtFtAmt.Text = "";
            txtGrName.Text = "";
            txtGrNID.Text = "";
            txtInsAmt.Text = "";
            txtINTR.Text = "";
            txtNOI.Text = "";
            txtRelGr.Text = "";
            txtSancAmt.Text = "";
            txtSancNo.Text = "";
            txtSms.Text = "";
            cmbCalPer.Text = "";
            cmbCalTyp.Text = "";
            cmbGV.Text = "";
            txtAcno.ReadOnly = false;
            txtAcno.Focus();
            cmbCalPer.Enabled = true;
        }

        private void txtAcno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cs = "server=localhost;userid=root;database=integratedbankingsystem";
                var con = new MySqlConnection(cs);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    String query = "SELECT * FROM tloan where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        custid = Convert.ToInt32(dr["custid"]);
                        txtCustid.Text = custid.ToString();
                        txtAcTitle.Text = dr["actitle"].ToString();
                        txtSancNo.Text = dr["sancno"].ToString();
                        opDt.Text = dr["openDate"].ToString();
                        txtSms.Text = dr["smsMobile"].ToString();
                        txtSancAmt.Text = dr["sancAmt"].ToString();
                        txtExpDt.Text = dr["expiryDate"].ToString();
                        txtNOI.Text = dr["noi"].ToString();
                        txtINTR.Text = dr["intr"].ToString();
                        cmbCalTyp.Text = dr["calTyp"].ToString();
                        cmbCalPer.Text = dr["calPer"].ToString();
                        txtInsAmt.Text = dr["instAmt"].ToString();
                        txtFtAmt.Text = dr["ftAmt"].ToString();
                        txtGrName.Text = dr["guarantoName"].ToString();
                        txtGrNID.Text = dr["guarantorNID"].ToString();
                        txtRelGr.Text = dr["relGuarantor"].ToString();
                        disbSts = dr["disbSts"].ToString();
                        intPerIns = Convert.ToDouble(dr["intrPinst"]);
                        cmbGV.Text = "Yes";
                        txtAcno.ReadOnly = true;

                        if (disbSts == "Y")
                        {
                            MessageBox.Show("This loan is already disbursed. Editing informations will be limited.");
                            txtNOI.ReadOnly = true;
                            txtINTR.ReadOnly = true;
                            cmbCalTyp.Enabled = false;
                            cmbCalPer.Enabled = false;
                        }
                        else if(disbSts == "N")
                        {
                            txtNOI.ReadOnly = false;
                            txtINTR.ReadOnly = false;
                            cmbCalTyp.Enabled = true;
                            cmbCalPer.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Loan disbursement information is not provided. Editing informations will be limited.");
                            txtNOI.ReadOnly = true;
                            txtINTR.ReadOnly = true;
                            cmbCalTyp.Enabled = false;
                            cmbCalPer.Enabled = false;                        
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Account does not exists");
                        txtAcno.Text = "";
                        txtAcno.ReadOnly = false;
                        txtAcno.Focus();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    txtAcno.ReadOnly = false;
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNOI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtNOI.Text) < 12)
                {
                    MessageBox.Show("Loan period must be greater that or equal 12!");
                }
                else
                {
                    txtExpDt.Text = DateTime.Today.AddMonths(Convert.ToInt32(txtNOI.Text)).ToShortDateString();
                }
            }
        }

        private void cmbCalTyp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCalTyp.Text == "Simple")
            {
                cmbCalPer.Text = "Yearly";
                cmbCalPer.Enabled = false;
            }
            else if (cmbCalTyp.Text == "Compound")
            {
                cmbCalPer.Text = "Quarterly";
                cmbCalPer.Enabled = false;
            }
            else
            {
                cmbCalPer.Enabled = true;
            }
        }

        private void cmbCalPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            double insAmt = 0, ftamt = 0, intr, sanamt;
            int month;
            intPerIns = 0;
            if (txtSancAmt.Text == "" || txtSancAmt.Text == null)
            {
                MessageBox.Show("Sanction amount can not be blank!");
            }
            else if (txtNOI.Text == "" || txtNOI.Text == null)
            {
                MessageBox.Show("Loan period can not be blank!");
            }
            else if (Convert.ToInt32(txtNOI.Text) < 12)
            {
                MessageBox.Show("Loan period must be greater that or equal 12!");
            }
            else if (txtINTR.Text == "" || txtINTR.Text == null)
            {
                MessageBox.Show("Interest rate can not be blank!");
            }
            else if (cmbCalTyp.Text == "" || cmbCalTyp.Text == null)
            {
                MessageBox.Show("Please Select a Calculation Type!");
            }

            else
            {
                sanamt = Convert.ToDouble(txtSancAmt.Text);
                month = Convert.ToInt32(txtNOI.Text);
                intr = Convert.ToDouble(txtINTR.Text) / 100;
                if (cmbCalTyp.Text == "Simple" && cmbCalPer.Text == "Yearly")
                {
                    insAmt = Math.Ceiling((sanamt * (intr / 12)) / 2 + (sanamt / month)); // EMI Calculation formula for Yearly Simple method
                    ftamt = Math.Ceiling(insAmt * month);
                    intPerIns = Math.Ceiling((ftamt - sanamt) / month);
                    txtFtAmt.Text = ftamt.ToString();
                    txtInsAmt.Text = insAmt.ToString();
                }


                else if (cmbCalTyp.Text == "Compound" && cmbCalPer.Text == "Quarterly")
                {
                    insAmt = Math.Ceiling(sanamt * (intr / 4) * (Math.Pow((1 + (intr / 4)), month)) / Math.Pow((1 + (intr / 4)), month) - 1); // EMI Calculation formula for Quarterly Compound method
                    ftamt = Math.Ceiling(insAmt * month);
                    intPerIns = Math.Ceiling((ftamt - sanamt) / month);
                    txtFtAmt.Text = (insAmt * month).ToString();
                    txtInsAmt.Text = insAmt.ToString();
                }
                else
                {
                    MessageBox.Show("Wrong Input Choice!!");
                }
            }
        }

        private void btnSaveLoanE_Click(object sender, EventArgs e)
        {
            if (txtCustid.Text == "" || txtCustid.Text == null)
            {
                MessageBox.Show("Customer Id can not be blank!");
            }
            else if (txtAcno.Text == "" || txtAcno.Text == null)
            {
                MessageBox.Show("Account number can not be blank!! Please Generate");
            }
            else if (txtFtAmt.Text == "" || txtFtAmt.Text == null)
            {
                MessageBox.Show("Future Amount Can not be blank!!");
            }
            else if (txtINTR.Text == "" || txtINTR.Text == null)
            {
                MessageBox.Show("Interest Rate can not be blank!!");
            }
            else if (txtNOI.Text == "" || txtNOI.Text == null)
            {
                MessageBox.Show("Loan Period can not be blank!!");
            }
            else if (txtSancAmt.Text == "" || txtSancAmt.Text == null)
            {
                MessageBox.Show("Sanction Amount can not be blank!!");
            }
            else if (txtSancNo.Text == "" || txtSancNo.Text == null)
            {
                MessageBox.Show("Sanction No. can not be blank!!");
            }
            else if (cmbCalTyp.Text == "" || cmbCalTyp.Text == null)
            {
                MessageBox.Show("Please Select a Calculation Type!!");
            }
            else if (cmbCalPer.Text == "" || cmbCalPer.Text == null)
            {
                MessageBox.Show("Please Select a Calculation Period!!!");
            }
            else
            {
                string cs = "server=localhost;userid=root;database=integratedbankingsystem";
                var con = new MySqlConnection(cs);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    String query = "UPDATE tloan SET actitle='"+txtAcTitle.Text+ "',smsMobile='" + txtSms.Text + "',instAmt=" + Convert.ToDouble(txtInsAmt.Text) + ",intrPinst=" + intPerIns + ",ftAmt=" + Convert.ToDouble(txtFtAmt.Text) + ",noi=" + Convert.ToInt32(txtNOI.Text) + ",intr=" + Convert.ToDouble(txtINTR.Text) + ",calTyp='" + cmbCalTyp.Text + "',calPer='" + cmbCalPer.Text + "',guarantoName='" + txtGrName.Text + "',guarantorNID='" + txtGrNID.Text + "',relGuarantor='" + txtRelGr.Text + "',expiryDate = '"+txtExpDt.Text+"'  where acno = '" + txtAcno.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account No " + txtAcno.Text + " Edited Successfully");
                    txtAcno.Text = "";
                    txtAcTitle.Text = "";
                    txtCustid.Text = "";
                    txtExpDt.Text = "";
                    txtFtAmt.Text = "";
                    txtGrName.Text = "";
                    txtGrNID.Text = "";
                    txtInsAmt.Text = "";
                    txtINTR.Text = "";
                    txtNOI.Text = "";
                    txtRelGr.Text = "";
                    txtSancAmt.Text = "";
                    txtSancNo.Text = "";
                    txtSms.Text = "";
                    cmbCalPer.Text = "";
                    cmbCalTyp.Text = "";
                    cmbGV.Text = "";
                    txtAcno.ReadOnly = false;
                    txtAcno.Focus();
                    cmbCalPer.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtAcno.Text = "";
                    txtAcTitle.Text = "";
                    txtCustid.Text = "";
                    txtExpDt.Text = "";
                    txtFtAmt.Text = "";
                    txtGrName.Text = "";
                    txtGrNID.Text = "";
                    txtInsAmt.Text = "";
                    txtINTR.Text = "";
                    txtNOI.Text = "";
                    txtRelGr.Text = "";
                    txtSancAmt.Text = "";
                    txtSancNo.Text = "";
                    txtSms.Text = "";
                    cmbCalPer.Text = "";
                    cmbCalTyp.Text = "";
                    cmbGV.Text = "";
                    txtAcno.ReadOnly = false;
                    txtAcno.Focus();
                    cmbCalPer.Enabled = true;
                }
                con.Close();
            }
        }
    }
}
