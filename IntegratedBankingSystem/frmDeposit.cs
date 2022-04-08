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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtCustid.Focus();
            btnSaveDeposit.Enabled = false;
            txtLnkSvAc.ReadOnly = false;
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustid.Text = "";
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
            btnSaveDeposit.Enabled = false;
            txtLnkSvAc.ReadOnly = false;
        }

        private void txtCustid_KeyDown(object sender, KeyEventArgs e)
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
                    String query = "SELECT * FROM tcustomer where custid = " + Convert.ToInt32(txtCustid.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtAcTitle.Text = dr["fullname"].ToString();
                        txtSms.Text = dr["contact"].ToString();
                        opDt.Text = DateTime.Today.ToShortDateString();                        
                    }
                    else
                    {
                        MessageBox.Show("This Customer Id does not exists");
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
                    String query = "select * from (select custid from tsavings where acno = "+Convert.ToInt32(txtLnkSvAc.Text)+" and account_status = 1) c where c.custid = "+Convert.ToInt32(txtCustid.Text)+"";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNomineeName.Focus();
                        btnSaveDeposit.Enabled = true;
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

        private void btnGenerateDpAc_Click(object sender, EventArgs e)
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
                String query = "SELECT acno FROM tdeposit order by acno desc limit 1";
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
                    acno = 20001;
                }
                txtAcno.Text = acno.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void txtNOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatAmt.Text = (Convert.ToInt32(txtDepAmt.Text) * Convert.ToInt32(txtNOD.Text)).ToString();
            }
        }

        private void btnSaveDeposit_Click(object sender, EventArgs e)
        {
            if (txtCustid.Text == "" || txtCustid.Text == null)
            {
                MessageBox.Show("Customer Id can not be blank!");
            }
            else if (txtAcno.Text == "" || txtAcno.Text == null)
            {
                MessageBox.Show("Account number can not be blank!! Please Generate");
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
                    String query = "INSERT INTO tdeposit (custid, acno, actitle, smsmobile,opndt, matamt, mdepamt, intr, nod, nodp, linkSvAc, acbal, nominee_name, nominee_nid, relation_nominee, share_p, dep_sts) VALUES ( '" + txtCustid.Text + "', '" + txtAcno.Text + "','"+txtAcTitle.Text+ "', '" + txtSms.Text + "','"+opDt.Text+"', " + Convert.ToInt32(txtMatAmt.Text) + ", " + Convert.ToInt32(txtDepAmt.Text) + ", " + Convert.ToDouble(txtINTR.Text) + "," + Convert.ToInt32(txtNOD.Text) + ", 0, '" + txtLnkSvAc.Text + "', 0, '" + txtNomineeName.Text + "', '" + txtNomineeNID.Text + "', '" + txtRelNominee.Text + "', '" + txtPercentage.Text + "', 'open')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account No " + txtAcno.Text + " generated Successfully");
                    txtCustid.Text = "";
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
                    btnSaveDeposit.Enabled = false;
                    txtLnkSvAc.ReadOnly = false;

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
