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
    public partial class frmSavingsE : Form
    {
        public frmSavingsE()
        {
            InitializeComponent();
        }

        private void frmSavingsE_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtAcno.Focus();
            txtAcno.ReadOnly = false;
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAcTitle.Text = "";
            txtMonthlyInc.Text = "";
            txtNomineeName.Text = "";
            txtNomineeNID.Text = "";
            txtPercentage.Text = "";
            txtRelNominee.Text = "";
            txtSF.Text = "";
            txtSms.Text = "";
            cmbSVsts.Text = "";
            txtAcno.Text = "";
            txtAcno.ReadOnly = false;
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
                    String query = "SELECT * FROM tsavings where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        int acsts;
                        txtAcno.Text = dr["acno"].ToString();
                        txtAcTitle.Text = dr["actitle"].ToString();
                        txtMonthlyInc.Text = dr["m_income"].ToString();
                        txtNomineeName.Text = dr["nominee_name"].ToString();
                        txtNomineeNID.Text = dr["nominee_nid"].ToString();
                        txtPercentage.Text = dr["share_p"].ToString();
                        txtRelNominee.Text = dr["relation_nominee"].ToString();
                        txtSF.Text = dr["sof"].ToString();
                        txtSms.Text = dr["smsmobile"].ToString();
                        acsts = Convert.ToInt32(dr["account_status"]);
                        if (acsts == 1) {
                            cmbSVsts.Text = "Open";
                        }
                        else if (acsts == 2)
                        {
                            cmbSVsts.Text = "Closed";
                        }
                        else
                        {
                            cmbSVsts.Text = "Dormanted";
                        }
                        txtAcno.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("This Account No. does not exist");
                        txtAcno.ReadOnly = false;
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

        private void btnEditSavings_Click(object sender, EventArgs e)
        {
            if (txtAcno.Text == "" || txtAcno.Text == null)
            {
                MessageBox.Show("Account no. can not be blank!");
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
                    int acsts;
                    if (cmbSVsts.Text == "Open")
                    {
                        acsts = 1;
                    }
                    else if (cmbSVsts.Text == "Closed")
                    {
                        acsts = 2;
                    }
                    else
                    {
                        acsts = 3;
                    }
                    String query = "UPDATE tsavings SET actitle='" + txtAcTitle.Text + "',m_income='" + txtMonthlyInc.Text + "',nominee_name='" + txtNomineeName.Text + "',nominee_nid='" + txtNomineeNID.Text + "',share_p='" + txtPercentage.Text + "',relation_nominee='" + txtRelNominee.Text + "',sof='" + txtSF.Text + "',	smsmobile='" + txtSms.Text + "',account_status=" + acsts +" WHERE acno = " + Convert.ToInt32(txtAcno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account No " + txtAcno.Text + " Updated Successfully");
                    txtAcTitle.Text = "";
                    txtMonthlyInc.Text = "";
                    txtNomineeName.Text = "";
                    txtNomineeNID.Text = "";
                    txtPercentage.Text = "";
                    txtRelNominee.Text = "";
                    txtSF.Text = "";
                    txtSms.Text = "";
                    cmbSVsts.Text = "";
                    txtAcno.Text = "";
                    txtAcno.Focus();
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
