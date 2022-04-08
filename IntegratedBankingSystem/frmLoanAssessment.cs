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
    public partial class frmLoanAssessment : Form
    {
        public frmLoanAssessment()
        {
            InitializeComponent();
        }

        private void frmLoanAssessment_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtSanno.Text = "IBS/"+ DateTime.Now.Year.ToString()+"/";
            txtSanno.Focus();
            btnSaveLA.Enabled = false;
            txtPAmt.ReadOnly = true;
        }

        private void cmbLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbLv.Text) <= 3)
            {
                lblLv.Text = "Unacceptable";
                lblLv.ForeColor = Color.Red;
            }
            else if(Convert.ToInt32(cmbLv.Text) <= 6)
            {
                lblLv.Text = "Good";
                lblLv.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbLv.Text) <= 10)
            {
                lblLv.Text = "Excellent";
                lblLv.ForeColor = Color.Green;
            }
            else
            {
                lblLv.Text = "";
            }
        }

        private void cmbLq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbLq.Text) <= 3)
            {
                lblLq.Text = "Unacceptable";
                lblLq.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbLq.Text) <= 6)
            {
                lblLq.Text = "Good";
                lblLq.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbLq.Text) <= 10)
            {
                lblLq.Text = "Excellent";
                lblLq.ForeColor = Color.Green;
            }
            else
            {
                lblLq.Text = "";
            }
        }

        private void cmbProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbProf.Text) <= 3)
            {
                lblProf.Text = "Unacceptable";
                lblProf.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbProf.Text) <= 6)
            {
                lblProf.Text = "Good";
                lblProf.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbProf.Text) <= 10)
            {
                lblProf.Text = "Excellent";
                lblProf.ForeColor = Color.Green;
            }
            else
            {
                lblProf.Text = "";
            }
        }

        private void cmbCov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCov.Text) <= 4)
            {
                lblCov.Text = "Unacceptable";
                lblCov.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbCov.Text) <= 10)
            {
                lblCov.Text = "Good";
                lblCov.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbCov.Text) <= 15)
            {
                lblCov.Text = "Excellent";
                lblCov.ForeColor = Color.Green;
            }
            else
            {
                lblCov.Text = "";
            }
        }

        private void cmbOE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbOE.Text) <= 3)
            {
                lblOE.Text = "Unacceptable";
                lblOE.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbOE.Text) <= 6)
            {
                lblOE.Text = "Good";
                lblOE.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbOE.Text) <= 10)
            {
                lblOE.Text = "Excellent";
                lblOE.ForeColor = Color.Green;
            }
            else
            {
                lblOE.Text = "";
            }
        }

        private void cmbEQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbEQ.Text) <= 1)
            {
                lblEQ.Text = "Unacceptable";
                lblEQ.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbEQ.Text) <= 2)
            {
                lblEQ.Text = "Good";
                lblEQ.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbEQ.Text) <= 5)
            {
                lblEQ.Text = "Excellent";
                lblEQ.ForeColor = Color.Green;
            }
            else
            {
                lblEQ.Text = "";
            }
        }

        private void cmbPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbPB.Text) <= 3)
            {
                lblPB.Text = "Unacceptable";
                lblPB.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbPB.Text) <= 6)
            {
                lblPB.Text = "Good";
                lblPB.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbPB.Text) <= 10)
            {
                lblPB.Text = "Excellent";
                lblPB.ForeColor = Color.Green;
            }
            else
            {
                lblPB.Text = "";
            }
        }

        private void cmbBR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbBR.Text) <= 2)
            {
                lblBR.Text = "Unacceptable";
                lblBR.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbBR.Text) <= 4)
            {
                lblBR.Text = "Good";
                lblBR.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbBR.Text) <= 7)
            {
                lblBR.Text = "Excellent";
                lblBR.ForeColor = Color.Green;
            }
            else
            {
                lblBR.Text = "";
            }
        }

        private void cmbMR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbMR.Text) <= 2)
            {
                lblMR.Text = "Unacceptable";
                lblMR.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbMR.Text) <= 4)
            {
                lblMR.Text = "Good";
                lblMR.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbMR.Text) <= 7)
            {
                lblMR.Text = "Excellent";
                lblMR.ForeColor = Color.Green;
            }
            else
            {
                lblMR.Text = "";
            }
        }

        private void cmbSR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbSR.Text) <= 3)
            {
                lblSR.Text = "Unacceptable";
                lblSR.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbSR.Text) <= 6)
            {
                lblSR.Text = "Good";
                lblSR.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbSR.Text) <= 11)
            {
                lblSR.Text = "Excellent";
                lblSR.ForeColor = Color.Green;
            }
            else
            {
                lblSR.Text = "";
            }
        }

        private void cmbRR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbRR.Text) <= 1)
            {
                lblRR.Text = "Unacceptable";
                lblRR.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(cmbRR.Text) <= 2)
            {
                lblRR.Text = "Good";
                lblRR.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbRR.Text) <= 3)
            {
                lblRR.Text = "Excellent";
                lblRR.ForeColor = Color.Green;
            }
            else
            {
                lblRR.Text = "";
            }
        }

        private void cmbCR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCR.Text) <= 1)
            {
                lblCR.Text = "Good";
                lblCR.ForeColor = Color.Blue;
            }
            else if (Convert.ToInt32(cmbCR.Text) <= 2)
            {
                lblCR.Text = "Excellent";
                lblCR.ForeColor = Color.Green;
            }
            else
            {
                lblCR.Text = "";
            }
            if (cmbBR.Text == "" || cmbCov.Text == "" || cmbCR.Text == "" || cmbEQ.Text == "" || cmbLq.Text == "" || cmbLv.Text == "" || cmbMR.Text == "" || cmbOE.Text == "" || cmbPB.Text == "" || cmbProf.Text == "" || cmbRR.Text == "" || cmbSR.Text == "")
            {
                MessageBox.Show("All selection fields must be inputed!!");
            }
            else
            {
                lblTS.Text = (Convert.ToInt32(cmbBR.Text) + Convert.ToInt32(cmbCov.Text) + Convert.ToInt32(cmbCR.Text) + Convert.ToInt32(cmbEQ.Text) + Convert.ToInt32(cmbLq.Text) + Convert.ToInt32(cmbLv.Text) + Convert.ToInt32(cmbMR.Text) + Convert.ToInt32(cmbOE.Text) + Convert.ToInt32(cmbPB.Text) + Convert.ToInt32(cmbProf.Text) + Convert.ToInt32(cmbRR.Text) + Convert.ToInt32(cmbSR.Text)).ToString();

                if (Convert.ToInt32(lblTS.Text) <= 30)
                {
                    lblAs.Text = "Unacceptable";
                    lblAs.ForeColor = Color.Red;
                }
                else if (Convert.ToInt32(lblTS.Text) <= 60)
                {
                    lblAs.Text = "Good";
                    lblAs.ForeColor = Color.Blue;
                    if (txtPAmt.Text == "")
                    {
                        MessageBox.Show("Propossed amount can not be blank!!");
                        txtPAmt.Focus();
                    }
                    else
                    {
                        txtSanAmt.Text = (Convert.ToInt32(txtPAmt.Text) * Convert.ToInt32(lblTS.Text) / 100).ToString();
                        btnSaveLA.Enabled = true;
                    }
                }
                else if (Convert.ToInt32(lblTS.Text) <= 100)
                {
                    lblAs.Text = "Excellent";
                    lblAs.ForeColor = Color.Green;
                    if (txtPAmt.Text == "")
                    {
                        MessageBox.Show("Propossed amount can not be blank!!");
                        txtPAmt.Focus();
                    }
                    else
                    {
                        txtSanAmt.Text = (Convert.ToInt32(txtPAmt.Text) * Convert.ToInt32(lblTS.Text) / 100).ToString();
                        btnSaveLA.Enabled = true;
                    }
                }
                else
                {
                    lblAs.Text = "";
                }
            }
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
                        txtPAmt.ReadOnly = false;
                        txtPAmt.Focus();
                    }
                    else
                    {
                        txtPAmt.ReadOnly = true;
                        MessageBox.Show("This Customer Id does not exists");
                        txtCustid.Focus();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSanno.Text = "IBS/" + DateTime.Now.Year.ToString() + "/";
            txtSanno.Focus();
            btnSaveLA.Enabled = false;
            txtPAmt.ReadOnly = true;
            cmbBR.Text = "";
            cmbCov.Text = "";
            cmbCR.Text = "";
            cmbEQ.Text = "";
            cmbLq.Text = "";
            cmbLv.Text = "";
            cmbMR.Text = "";
            cmbOE.Text = "";
            cmbPB.Text = "";
            cmbProf.Text = "";
            cmbRR.Text = "";
            cmbSR.Text = "";
            lblAs.Text = "";
            lblBR.Text = "";
            lblCov.Text = "";
            lblCR.Text = "";
            lblEQ.Text = "";
            lblLq.Text = "";
            lblLv.Text = "";
            lblMR.Text = "";
            lblOE.Text = "";
            lblPB.Text = "";
            lblProf.Text = "";
            lblRR.Text = "";
            lblSR.Text = "";
            lblTS.Text = "";
            txtCustid.Text = "";
            txtPAmt.Text = "";
            txtSanAmt.Text = "";
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveLA_Click(object sender, EventArgs e)
        {
            if (txtCustid.Text == "" || txtCustid.Text == null)
            {
                MessageBox.Show("Customer Id can not be blank!");
            }
            else if (txtSanno.Text == "" || txtSanno.Text == null)
            {
                MessageBox.Show("Sanction number can not be blank!!");
            }
            else if (txtSanAmt.Text == "" || txtSanAmt.Text == null)
            {
                MessageBox.Show("Sanction Amount can not be blank!!");
            }
            else if (lblTS.Text == "" || lblTS.Text == null)
            {
                MessageBox.Show("Total Score can not be blank!!");
            }
            else if (lblAs.Text == "" || lblAs.Text == null)
            {
                MessageBox.Show("Final Assessment can not be blank!!");
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
                    String query = "insert into tloanassessment (sancno, custid, pamt, tscore, fassessment, sancamt) value('" + txtSanno.Text + "','" + txtCustid.Text + "'," + Convert.ToInt32(txtPAmt.Text) + "," + Convert.ToInt32(lblTS.Text) + ",'" + lblAs.Text + "'," + Convert.ToDouble(txtSanAmt.Text)+")";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sanction No " + txtSanno.Text + " regestered Successfully");
                    txtSanno.Text = "IBS/" + DateTime.Now.Year.ToString() + "/";
                    txtSanno.Focus();
                    btnSaveLA.Enabled = false;
                    txtPAmt.ReadOnly = true;
                    cmbBR.Text = "";
                    cmbCov.Text = "";
                    cmbCR.Text = "";
                    cmbEQ.Text = "";
                    cmbLq.Text = "";
                    cmbLv.Text = "";
                    cmbMR.Text = "";
                    cmbOE.Text = "";
                    cmbPB.Text = "";
                    cmbProf.Text = "";
                    cmbRR.Text = "";
                    cmbSR.Text = "";
                    lblAs.Text = "";
                    lblBR.Text = "";
                    lblCov.Text = "";
                    lblCR.Text = "";
                    lblEQ.Text = "";
                    lblLq.Text = "";
                    lblLv.Text = "";
                    lblMR.Text = "";
                    lblOE.Text = "";
                    lblPB.Text = "";
                    lblProf.Text = "";
                    lblRR.Text = "";
                    lblSR.Text = "";
                    lblTS.Text = "";
                    txtCustid.Text = "";
                    txtPAmt.Text = "";
                    txtSanAmt.Text = "";
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
