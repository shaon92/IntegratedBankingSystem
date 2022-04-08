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
    public partial class frmSvAcMnFee : Form
    {
        public frmSvAcMnFee()
        {
            InitializeComponent();
        }

        private void frmSvAcMnFee_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtYear.Text = DateTime.Now.Year.ToString();
            dtGridMnTrn.DataSource = getGridMnTrn();
            lblGridTitle.Text = "Posted Account Maintenance Fee for Year: " + DateTime.Now.Year.ToString();
        }

        private DataTable getGridMnTrn()
        {
            DataTable dtSV = new DataTable();
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

            String queryGrid = "SELECT acno as AccountNo, amount as Amount, year as Year from tsvacmnfee where amount = 250 and year = '"+DateTime.Now.Year.ToString()+ "'";
            MySqlCommand cmdGrid = new MySqlCommand(queryGrid, con);
            MySqlDataReader reader = cmdGrid.ExecuteReader();
            dtSV.Load(reader);
            return dtSV;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtYear.Text = DateTime.Now.Year.ToString();
            dtGridMnTrn.DataSource = getGridMnTrn();
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlSvAcMn_Click(object sender, EventArgs e)
        {
            string[] acno = new string[99999999];
            string[] nacno = new string[99999999];
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            string cs = "server=localhost;userid=root;database=integratedbankingsystem";
            var con = new MySqlConnection(cs);
            MySqlCommand cmd = con.CreateCommand();
            MySqlCommand cmd1 = con.CreateCommand();
            MySqlCommand cmd2 = con.CreateCommand();
            MySqlCommand cmd3 = con.CreateCommand();
            MySqlCommand cmd4 = con.CreateCommand();
            MySqlCommand cmd5 = con.CreateCommand();
            MySqlCommand cmd6 = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select year from tsvacmnfee where year =  " + Convert.ToInt32(txtYear.Text) + "";
            cmd.ExecuteNonQuery();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                MessageBox.Show("Process is already done for year: " + txtYear.Text);
                dr.Close();
            }
            else
            {
                dr.Close();
                try
                {
                    cmd1.CommandText = "select acno from tsavings where acbal >= 250 and account_status = 1";
                    cmd1.ExecuteNonQuery();
                    cmd4.CommandText = "select acno from tsavings where acbal < 250  and account_status = 1";
                    cmd4.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MySqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    acno[i] = dr1["acno"].ToString();
                    i++;
                }
                dr1.Close();
                MySqlDataReader dr2 = cmd4.ExecuteReader();
                while (dr2.Read())
                {
                    nacno[k] = dr2["acno"].ToString();
                    k++;
                }
                dr2.Close();
                for (j = 0; j < i; j++)
                {
                    cmd2.CommandText = "insert into tsvacmnfee (acno, amount, year) values (" + Convert.ToUInt32(acno[j]) + ",250," + Convert.ToInt32(txtYear.Text) + ")";
                    cmd3.CommandText = "update tsavings set acbal = acbal -250 where acno = " + Convert.ToUInt32(acno[j]) + "";
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                }
                for (l = 0; l < k; l++)
                {
                    cmd5.CommandText = "insert into tsvacmnfee (acno, amount, year) values (" + Convert.ToUInt32(nacno[l]) + ",0," + Convert.ToInt32(txtYear.Text) + ")";
                    cmd6.CommandText = "update tsavings set account_status = 3 where acno = " + Convert.ToUInt32(nacno[l])+"";
                    cmd5.ExecuteNonQuery();
                    cmd6.ExecuteNonQuery();
                }
                MessageBox.Show("Account Maintenance Fee Posting successfull");
                txtYear.Text = DateTime.Now.Year.ToString();
                dtGridMnTrn.DataSource = getGridMnTrn();
            }
            con.Close();
        }

        private void btnDelMn_Click(object sender, EventArgs e)
        {
            string[] acno = new string[99999999];
            string[] nacno = new string[99999999];
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            string cs = "server=localhost;userid=root;database=integratedbankingsystem";
            var con = new MySqlConnection(cs);
            MySqlCommand cmd = con.CreateCommand();
            MySqlCommand cmd1 = con.CreateCommand();
            MySqlCommand cmd2 = con.CreateCommand();
            MySqlCommand cmd3 = con.CreateCommand();
            MySqlCommand cmd4 = con.CreateCommand();
            MySqlCommand cmd5 = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select year from tsvacmnfee where year =  " + Convert.ToInt32(txtYear.Text) + "";
            cmd.ExecuteNonQuery();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                dr.Close();
                try
                {
                    cmd1.CommandText = "select acno from tsvacmnfee where amount = 250 and year = " + Convert.ToInt32(txtYear.Text) + "";
                    cmd1.ExecuteNonQuery();
                    cmd4.CommandText = "select acno from tsvacmnfee where amount = 0 and year = " + Convert.ToInt32(txtYear.Text) + "";
                    cmd4.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MySqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    acno[i] = dr1["acno"].ToString();
                    i++;
                }
                dr1.Close();
                MySqlDataReader dr2 = cmd4.ExecuteReader();
                while (dr2.Read())
                {
                    nacno[k] = dr2["acno"].ToString();
                    k++;
                }
                dr2.Close();
                for (j = 0; j < i; j++)
                {
                    cmd2.CommandText = "delete from tsvacmnfee where year = " + Convert.ToInt32(txtYear.Text) + "";
                    cmd3.CommandText = "update tsavings set acbal = acbal + 250 where acno = " + Convert.ToUInt32(acno[j]) + "";
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                }
                for (l = 0; l < k; l++)
                {
                    cmd5.CommandText = "update tsavings set account_status = 1 where acno = " + Convert.ToUInt32(nacno[l]) + "";
                    cmd5.ExecuteNonQuery();
                }
                MessageBox.Show("Account Maintenance Fee Posting Deleted successfully");
                txtYear.Text = DateTime.Now.Year.ToString();
                dtGridMnTrn.DataSource = getGridMnTrn();
            }
            else
            {
                MessageBox.Show("Process is not done for year: " + txtYear.Text);
                dr.Close();
            }
            con.Close();

        }


    }
}
