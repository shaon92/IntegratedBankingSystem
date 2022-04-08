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
    public partial class frmDepositE : Form
    {
        public frmDepositE()
        {
            InitializeComponent();
        }

        private int custid;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAcTitle.Text = "";
            txtNomineeName.Text = "";
            txtNomineeNID.Text = "";
            txtPercentage.Text = "";
            txtRelNominee.Text = "";
            txtSms.Text = "";
            opDt.Text = DateTime.Today.ToShortDateString();
            txtAcno.Text = "";
            txtDepAmt.Text = "";
            txtINTR.Text = "";
            txtLnkSvAc.Text = "";
            txtMatAmt.Text = "";
            txtNOD.Text = "";
            txtAcno.ReadOnly = false;
            btnSaveDepositE.Enabled = false;
            txtLnkSvAc.ReadOnly = false;
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    String query = "SELECT * FROM tdeposit where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        custid = Convert.ToInt32(dr["custid"]);
                        txtAcTitle.Text = dr["actitle"].ToString();
                        txtNomineeName.Text = dr["nominee_name"].ToString();
                        txtNomineeNID.Text = dr["nominee_nid"].ToString();
                        txtPercentage.Text = dr["share_p"].ToString();
                        txtRelNominee.Text = dr["relation_nominee"].ToString();
                        txtSms.Text = dr["smsmobile"].ToString();
                        opDt.Text = dr["opndt"].ToString();
                        txtDepAmt.Text = dr["mdepamt"].ToString();
                        txtINTR.Text = dr["intr"].ToString();
                        txtLnkSvAc.Text = dr["linkSvAc"].ToString();
                        txtMatAmt.Text = dr["matamt"].ToString();
                        txtNOD.Text = dr["nod"].ToString();
                        btnSaveDepositE.Enabled = false;
                        txtLnkSvAc.ReadOnly = false;
                        txtAcno.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("This Account does not exists");
                        txtAcno.ReadOnly = false;
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtAcno.ReadOnly = false;
                }
                con.Close();
            }
        }

        private void txtNOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatAmt.Text = (Convert.ToInt32(txtDepAmt.Text) * Convert.ToInt32(txtNOD.Text)).ToString();
            }
        }

        private void frmDepositE_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtAcno.ReadOnly = false;
            txtAcno.Focus();
            btnSaveDepositE.Enabled = false;
            txtLnkSvAc.ReadOnly = false;
            opDt.Enabled = false;
        }

        private void txtLnkSvAc_KeyDown(object sender, KeyEventArgs e)
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
                    String query = "select * from (select custid from tsavings where acno = " + Convert.ToInt32(txtLnkSvAc.Text) + " and account_status = 1) c where c.custid = " + custid + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNomineeName.Focus();
                        btnSaveDepositE.Enabled = true;
                        txtLnkSvAc.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("This Savings account is not Normal or does not belong to this Customer");
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void btnSaveDepositE_Click(object sender, EventArgs e)
        {
            if (txtAcno.Text == "" || txtAcno.Text == null)
            {
                MessageBox.Show("Account No. can not be blank!");
            }
            else if (txtDepAmt.Text == "" || txtDepAmt.Text == null)
            {
                MessageBox.Show("Deposit Amount Can not be blank!!");
            }
            else if (txtINTR.Text == "" || txtINTR.Text == null)
            {
                MessageBox.Show("Interest Rate can not be blank!!");
            }
            else if (txtNOD.Text == "" || txtNOD.Text == null)
            {
                MessageBox.Show("Deposit Period can not be blank!!");
            }
            else if (txtLnkSvAc.Text == "" || txtLnkSvAc.Text == null)
            {
                MessageBox.Show("Link Savings Account number can not be blank!!");
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
                    String query = "UPDATE tdeposit set actitle = '" + txtAcTitle.Text + "', smsmobile = '" + txtSms.Text + "', matamt = "+Convert.ToInt32(txtMatAmt.Text)+ ", mdepamt = " + Convert.ToInt32(txtDepAmt.Text) + ", intr = "+Convert.ToDouble(txtINTR.Text)+ ", nod = " + Convert.ToInt32(txtNOD.Text) + ", linkSvAc =  '" + txtLnkSvAc.Text + "', nominee_name = '" + txtNomineeName.Text + "', nominee_nid='"+txtNomineeNID.Text+ "', relation_nominee = '" + txtRelNominee.Text + "', share_p = '" + txtPercentage.Text + "' where acno = '"+txtAcno.Text+"'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account No " + txtAcno.Text + " Edited Successfully");
                    txtAcTitle.Text = "";
                    txtNomineeName.Text = "";
                    txtNomineeNID.Text = "";
                    txtPercentage.Text = "";
                    txtRelNominee.Text = "";
                    txtSms.Text = "";
                    opDt.Text = DateTime.Today.ToShortDateString();
                    txtAcno.Text = "";
                    txtDepAmt.Text = "";
                    txtINTR.Text = "";
                    txtLnkSvAc.Text = "";
                    txtMatAmt.Text = "";
                    txtNOD.Text = "";
                    btnSaveDepositE.Enabled = false;
                    txtLnkSvAc.ReadOnly = false;
                    txtAcno.ReadOnly = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }     
    }
    }
}
