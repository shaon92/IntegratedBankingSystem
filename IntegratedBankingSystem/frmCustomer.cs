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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnGenerateCust_Click(object sender, EventArgs e)
        {
            int custid;
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
                String query = "SELECT custid FROM tcustomer order by custid desc limit 1";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    custid = Convert.ToInt32(dr["custid"]);
                    dr.Close();
                    custid = custid + 1;
                }
                else
                {
                    custid = 1;
                }
                txtCustid.Text = custid.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            if(txtCustid.Text=="" || txtCustid.Text == null)
            {
                MessageBox.Show("Customer Id can not be blank, please generate!!");
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
                    String query = "insert into tcustomer (custid, fullname, f_name, m_name,gender,dob,religion, nid,tin,email,contact,address,profession) values ('" +txtCustid.Text + "','" + txtFLname.Text + "','" + txtFname.Text + "','" + txtMname.Text + "','" + cmbGender.Text + "','" + dob.Text + "','" + cmbRl.Text + "','" + txtNid.Text + "','" + txtTin.Text + "','" + txtEmail.Text + "','" + txtContact.Text + "','" + txtAddress.Text + "','" + txtProf.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Id "+txtCustid.Text+" generated Successfully");
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
        }
    }
}
