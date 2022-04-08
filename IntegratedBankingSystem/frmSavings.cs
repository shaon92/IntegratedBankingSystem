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
    public partial class frmSavings : Form
    {
        public frmSavings()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSavings_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtCustid.Focus();
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
                        cmbSVsts.Text = "Open";
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

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustid.Text = "";
            txtAcTitle.Text = "";
            txtFirstDep.Text = "";
            txtMonthlyInc.Text = "";
            txtNomineeName.Text = "";
            txtNomineeNID.Text = "";
            txtPercentage.Text = "";
            txtPurpose.Text = "";
            txtRelNominee.Text = "";
            txtSF.Text = "";
            txtSms.Text = "";
            cmbSVsts.Text = "";
            opDt.Text = DateTime.Today.ToShortDateString();
            txtAcno.Text = "";
        }

        private void btnGenerateSvAc_Click(object sender, EventArgs e)
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
                String query = "SELECT acno FROM tsavings order by acno desc limit 1";
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
                    acno = 1001;
                }
                txtAcno.Text = acno.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnSaveSavings_Click(object sender, EventArgs e)
        {
            if (txtCustid.Text == "" || txtCustid.Text == null)
            {
                MessageBox.Show("Customer Id can not be blank!");
            }
            else if(txtAcno.Text == "" || txtAcno.Text == null)
            {
                MessageBox.Show("Account number can not be blank!! Please Generate");
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
                    String query = "insert into tsavings (custid, actitle, acno, smsmobile, acbal, m_income, opendate, purpose, f_dep, sof, nominee_name, nominee_nid, relation_nominee, share_p, account_status) value('" +txtCustid.Text + "','" + txtAcTitle.Text + "','" +txtAcno.Text + "','" + txtSms.Text + "',0,'" +txtMonthlyInc.Text + "','" + opDt.Text + "','" + txtPurpose.Text + "','" + txtFirstDep.Text + "','" + txtSF.Text + "','" + txtNomineeName.Text + "','" + txtNomineeNID.Text + "','" + txtRelNominee.Text + "','" + txtPercentage.Text + "',1)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account No " + txtAcno.Text + " generated Successfully");
                    txtCustid.Text = "";
                    txtAcTitle.Text = "";
                    txtFirstDep.Text = "";
                    txtMonthlyInc.Text = "";
                    txtNomineeName.Text = "";
                    txtNomineeNID.Text = "";
                    txtPercentage.Text = "";
                    txtPurpose.Text = "";
                    txtRelNominee.Text = "";
                    txtSF.Text = "";
                    txtSms.Text = "";
                    cmbSVsts.Text = "";
                    opDt.Text = DateTime.Today.ToShortDateString();
                    txtAcno.Text = "";
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
