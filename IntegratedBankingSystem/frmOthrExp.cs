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
    public partial class frmOthrExp : Form
    {
        public frmOthrExp()
        {
            InitializeComponent();
        }

        int month,year; 

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable getGridExpTrn()
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

            String queryGrid = "SELECT batno as BatchNo, type as TransactionType, month as Month, year as Year,amount as Amount, vcno as VoucherNo,description as Description FROM tothr_expenditure where month = " + DateTime.Now.Month + "";
            MySqlCommand cmdGrid = new MySqlCommand(queryGrid, con);
            MySqlDataReader reader = cmdGrid.ExecuteReader();
            dtSV.Load(reader);
            return dtSV;
        }

        private void btnGenerateDPTrn_Click(object sender, EventArgs e)
        {
            int batno;
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
                String query = "SELECT batno FROM tothr_expenditure order by batno desc limit 1";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    batno = Convert.ToInt32(dr["batno"]);
                    dr.Close();
                    batno = batno + 1;
                }
                else
                {
                    batno = 40001;
                }
                txtBatno.Text = batno.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbTrnTyp_SelectedIndexChanged(object sender, EventArgs e)
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

            if (cmbTrnTyp.SelectedItem == "Salary Expenditure")
            {
                try
                {
                    String query = "SELECT * FROM tothr_expenditure where type = 'Salary Expenditure' and month = "+month+" and year = "+year+"";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This month's Salary Expenditure is already posted");
                    }
                    else
                    {
                        txttrnDes.Text = "Salary Expenditure";
                        txtTrnamt.Focus();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (cmbTrnTyp.SelectedItem == "Allowance Expenditure")
            {
                try
                {
                    String query = "SELECT * FROM tothr_expenditure where type = 'Allowance Expenditure' and month = " + month + " and year = " + year + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This month's Allowance Expenditure is already posted");
                    }
                    else
                    {
                        txttrnDes.Text = "Allowance Expenditure";
                        txtTrnamt.Focus();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (cmbTrnTyp.SelectedItem == "Miscellaneous Expenditure")
            {
                try
                {
                    String query = "SELECT * FROM tothr_expenditure where type = 'Miscellaneous Expenditure' and month = " + month + " and year = " + year + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This month's Miscellaneous Expenditure is already posted");
                    }
                    else
                    {
                        txttrnDes.Text = "Miscellaneous Expenditure";
                        txtTrnamt.Focus();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Wrong selection!!");
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBatno.Text = "";
            txtTrnamt.Text = "";
            txttrnDes.Text = "";
            txtVC.Text = "";
            cmbTrnTyp.Text = "";
            cmbTrnTyp.Focus();
        }

        private void btnSaveExptrn_Click(object sender, EventArgs e)
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
                MessageBox.Show("Batch No can not be blank!! Please Generate!!");
            }
            else if ((txtTrnamt.Text == "" || txtTrnamt.Text == null || Convert.ToDouble(txtTrnamt.Text)<=0))
            {
                MessageBox.Show("Transaction Amount can not be blank, zero or negative!!");
            }
            else
            {
                try
                {
                    String query = "INSERT INTO tothr_expenditure (type,month, year,amount, batno, vcno, description) VALUES ( '" + cmbTrnTyp.Text + "', " + Convert.ToInt32(txtMnth.Text) + ", " + Convert.ToInt32(txtYr.Text) + ", " + Convert.ToDouble(txtTrnamt.Text) + ", " + Convert.ToInt32(txtBatno.Text) + ", '" + txtVC.Text + "', '" + txttrnDes.Text + "')";              
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expenditure Transaction Successfull");
                    dtGridExpTrn.DataSource = getGridExpTrn();
                    txtBatno.Text = "";
                    txtTrnamt.Text = "";
                    txttrnDes.Text = "";
                    txtVC.Text = "";
                    cmbTrnTyp.Text = "";
                    cmbTrnTyp.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmOthrExp_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            cmbTrnTyp.Focus();
            dtGridExpTrn.DataSource = getGridExpTrn();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            txtMnth.Text = month.ToString();
            txtYr.Text = year.ToString();
        }
    }
}
