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
    public partial class frmDOthrExp : Form
    {
        public frmDOthrExp()
        {
            InitializeComponent();
        }

        private void frmDOthrExp_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtBatno.ReadOnly = false;
            txtBatno.Focus();
        }

        private void txtBatno_KeyDown(object sender, KeyEventArgs e)
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
                    String query = "SELECT * FROM tothr_expenditure where batno = " + Convert.ToInt32(txtBatno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cmbTrnTyp.Text = dr["type"].ToString();
                        txtVC.Text = dr["vcno"].ToString();
                        txttrnDes.Text = dr["description"].ToString();
                        txtTrnamt.Text = dr["amount"].ToString();
                        txtMnth.Text = dr["month"].ToString();
                        txtYr.Text = dr["year"].ToString();
                        txtBatno.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Batcht No. does not exists");
                        txtBatno.ReadOnly = false;
                        txtBatno.Focus();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    txtBatno.ReadOnly = false;
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
            cmbTrnTyp.Text = "";
            txtVC.Text = "";
            txttrnDes.Text = "";
            txtTrnamt.Text = "";
            txtMnth.Text = "";
            txtYr.Text = "";
            txtBatno.Text = "";
            txtBatno.ReadOnly = false;
            txtBatno.Focus();
        }

        private void btnDeleteExptrn_Click(object sender, EventArgs e)
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
            if ((txtBatno.Text == "" || txtBatno.Text == null))
            {
                MessageBox.Show("Batch No can not be blank!!");
            }
            else
            {
                try
                {
                    String query = "DELETE from tothr_expenditure where batno = "+Convert.ToInt32(txtBatno.Text)+"";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expenditure Transaction Deleted Successfully");
                    cmbTrnTyp.Text = "";
                    txtVC.Text = "";
                    txttrnDes.Text = "";
                    txtTrnamt.Text = "";
                    txtMnth.Text = "";
                    txtYr.Text = "";
                    txtBatno.Text = "";
                    txtBatno.ReadOnly = false;
                    txtBatno.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
