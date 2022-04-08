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
    public partial class frmLoan : Form
    {
        public frmLoan()
        {
            InitializeComponent();
        }

        double intPerIns = 0;

        private void frmLoan_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtSancNo.Focus();
            btnSaveLoan.Enabled = false;
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
            if(cmbCalTyp.Text == "Simple")
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
            double insAmt = 0, ftamt = 0, intr,sanamt;
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
            else if (Convert.ToInt32(txtNOI.Text) < 12 )
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
                    insAmt = Math.Ceiling((sanamt * (intr/12)) / 2 + (sanamt / month)); // EMI Calculation formula for Yearly Simple method
                    ftamt = Math.Ceiling(insAmt*month);                
                    intPerIns = Math.Ceiling((ftamt-sanamt)/month);
                    txtFtAmt.Text = ftamt.ToString();
                    txtInsAmt.Text = insAmt.ToString();
                }


                else if (cmbCalTyp.Text == "Compound" && cmbCalPer.Text == "Quarterly")
                {
                    insAmt = Math.Ceiling((sanamt * (intr/4) * (Math.Pow((1 + (intr / 4)), month))) / (Math.Pow((1 + (intr / 4)), month) - 1)); // EMI Calculation formula for Quarterly Compound method
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

        private void txtSancNo_KeyDown(object sender, KeyEventArgs e)
        {
            int flag = 0;
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
                    String query = "SELECT * FROM tloanassessment where sancno = '"+txtSancNo.Text +"'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtCustid.Text = dr["custid"].ToString();
                        txtSancAmt.Text = dr["sancamt"].ToString();
                        opDt.Text = DateTime.Today.ToShortDateString();
                        flag = 1;
                    }
                    else
                    {
                        txtCustid.Text = "";
                        txtAcTitle.Text = "";
                        txtSms.Text = "";
                        txtSancAmt.Text = "";
                        MessageBox.Show("This Sanction No. does not exists");
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (flag == 1)
                {
                    try
                    {
                        String query = "SELECT * FROM tcustomer where custid = " + Convert.ToInt32(txtCustid.Text) + "";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            txtAcTitle.Text = dr["fullname"].ToString();
                            txtSms.Text = dr["contact"].ToString();

                        }
                        else
                        {
                            txtCustid.Text = "";
                            txtAcTitle.Text = "";
                            txtSms.Text = "";
                            txtSancAmt.Text = "";
                            MessageBox.Show("This Customer Id does not exists");
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                con.Close();
            }
        }

        private void btnGenerateLnAc_Click(object sender, EventArgs e)
        {
            if (txtFtAmt.Text == "" || txtFtAmt.Text == null)
            {
                MessageBox.Show("Fill all necessary informations first!");
            }
            else if(cmbGV.Text == "" || cmbGV.Text == "No" || txtFtAmt.Text == null)
            {
                MessageBox.Show("Guarantor must be verified!");
                btnSaveLoan.Enabled = false;
            }
            else
            {
                int acno;
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
                    String query = "SELECT acno FROM tloan order by acno desc limit 1";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        acno = Convert.ToInt32(dr["acno"]);
                        dr.Close();
                        acno = acno + 1;
                    }
                    else
                    {
                        acno = 30001;
                    }
                    txtAcno.Text = acno.ToString();
                    btnSaveLoan.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtSancNo.Focus();
            btnSaveLoan.Enabled = false;
            cmbCalPer.Enabled = true;
        }

        private void cmbGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGV.Text == "" || cmbGV.Text == "No" || txtFtAmt.Text == null)
            {
                MessageBox.Show("Guarantor must be verified!");
                txtAcno.Text = "";
                btnSaveLoan.Enabled = false;
            }
        }

        private void btnSaveLoan_Click(object sender, EventArgs e)
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
                    String query = "INSERT INTO tloan (custid, actitle, acno, smsMobile, sancno, openDate, expiryDate, instAmt, intrPinst, sancAmt, ftAmt, noi, intr, calTyp, calPer, guarantoName, guarantorNID, relGuarantor) VALUES ( '"+txtCustid.Text+"', '"+txtAcTitle.Text+ "', '" + txtAcno.Text + "', '" + txtSms.Text + "', '" + txtSancNo.Text + "', '" + opDt.Text + "', '" + txtExpDt.Text + "'," + Convert.ToDouble(txtInsAmt.Text) + " ,"+intPerIns+ " ," + Convert.ToDouble(txtSancAmt.Text) + " ," + Convert.ToDouble(txtFtAmt.Text) + " ," + Convert.ToInt32(txtNOI.Text) + " , " + Convert.ToDouble(txtINTR.Text) + ", '" + cmbCalTyp.Text + "', '" + cmbCalPer.Text + "','" + txtGrName.Text + "', '" + txtGrNID.Text + "', '" + txtRelGr.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account No " + txtAcno.Text + " generated Successfully");
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
                    txtSancNo.Focus();
                    btnSaveLoan.Enabled = false;
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
                    txtSancNo.Focus();
                    btnSaveLoan.Enabled = false;
                    cmbCalPer.Enabled = true;
                }
                con.Close();
            }
        }
    }
}
