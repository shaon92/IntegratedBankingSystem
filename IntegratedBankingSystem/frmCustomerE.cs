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
    public partial class frmCustomerE : Form
    {
        public frmCustomerE()
        {
            InitializeComponent();
        }

        private void frmCustomerE_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtCustid.ReadOnly = false;
            txtCustid.Focus();
        }

        private void txtCustid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
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
                    String query = "SELECT * FROM tcustomer where custid = "+Convert.ToInt32(txtCustid.Text)+"";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtAddress.Text = dr["address"].ToString();
                        txtContact.Text = dr["contact"].ToString();
                        txtEmail.Text = dr["email"].ToString();
                        txtFLname.Text = dr["fullname"].ToString();
                        txtFname.Text = dr["f_name"].ToString();
                        txtMname.Text = dr["m_name"].ToString();
                        txtNid.Text = dr["nid"].ToString();
                        txtProf.Text = dr["profession"].ToString();
                        txtTin.Text = dr["tin"].ToString();
                        cmbGender.Text = dr["gender"].ToString();
                        cmbRl.Text = dr["religion"].ToString();
                        dob.Text = dr["dob"].ToString();
                        txtCustid.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("This Customer Id does not exist");
                        txtCustid.ReadOnly = false;
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    txtCustid.ReadOnly = false;
                    MessageBox.Show(ex.Message);
                }              
                con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtContact.Text = "";
            txtCustid.Text = "";
            txtEmail.Text = "";
            txtFLname.Text = "";
            txtFname.Text = "";
            txtMname.Text = "";
            txtNid.Text = "";
            txtProf.Text = "";
            txtTin.Text = "";
            cmbGender.Text = "";
            cmbRl.Text = "";
            dob.Text = "";
            txtCustid.Focus();
            txtCustid.ReadOnly = false;
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            if (txtCustid.Text == "" || txtCustid.Text == null)
            {
                MessageBox.Show("Customer Id can not be blank");
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
                    String query = "UPDATE tcustomer SET fullname='"+txtFLname.Text+"',f_name='"+txtFname.Text+"',m_name='"+txtMname.Text+"',gender='"+cmbGender.Text+"',dob='"+dob.Text+"',religion='"+cmbRl.Text+"',nid='"+txtNid.Text+"',tin='"+txtTin.Text+"',email='"+txtEmail.Text+"',contact='"+txtContact.Text+"',address='"+txtAddress.Text+"',profession='"+txtProf.Text+"' WHERE custid = "+Convert.ToInt32(txtCustid.Text)+"";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Id " + txtCustid.Text + " Updated Successfully");
                    txtAddress.Text = "";
                    txtContact.Text = "";
                    txtCustid.Text = "";
                    txtEmail.Text = "";
                    txtFLname.Text = "";
                    txtFname.Text = "";
                    txtMname.Text = "";
                    txtNid.Text = "";
                    txtProf.Text = "";
                    txtTin.Text = "";
                    cmbGender.Text = "";
                    cmbRl.Text = "";
                    dob.Text = "";
                    txtCustid.Focus();
                    txtCustid.ReadOnly = false;
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
