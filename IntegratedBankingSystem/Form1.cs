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
    public partial class frmLogin : Form
    {
        static public string username;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtUser.Text == null)
            {
                MessageBox.Show("User name Can not be blank");
            }
            else if (txtPass.Text == "" || txtPass.Text == null)
            {
                MessageBox.Show("Password Can not be blank");
            }
            else
            {
                string cs = "server=localhost;userid=root;database=integratedbankingsystem";
                var con = new MySqlConnection(cs);
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select * from tuser where userid = '" + txtUser.Text + "' and pass = '" + txtPass.Text + "'";
                    cmd.ExecuteNonQuery();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        username = txtUser.Text;
                        Hide();
                        frmMain main = new frmMain();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("User Id or Password is incorrect");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
