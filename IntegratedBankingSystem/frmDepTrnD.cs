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
    public partial class frmDepTrnD : Form
    {
        public frmDepTrnD()
        {
            InitializeComponent();
        }

        private int encashed;
        private double intamt;
        private void frmDepTrnD_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtBatno.ReadOnly = false;
            txtBatno.Focus();
            lblEncAc.Hide();
            txtEncAcNo.Hide();
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
                    String query = "SELECT * FROM tdeposittrn where batno = " + Convert.ToInt32(txtBatno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cmbTrnTyp.Text = dr["trntyp"].ToString();
                        txtVC.Text = dr["vcno"].ToString();
                        txtND.Text = dr["nod"].ToString();
                        txttrnDes.Text = dr["trndes"].ToString();
                        txtTrnamt.Text = dr["trnamt"].ToString();
                        txtEncAcNo.Text = dr["encacno"].ToString();
                        trnDt.Text = dr["trndt"].ToString();
                        txtAcno.Text = dr["acno"].ToString();
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

        private void cmbTrnTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrnTyp.SelectedItem == "Monthly Deposit")
            {
                lblEncAc.Hide();
                txtEncAcNo.Hide();
            }
            else
            {
                lblEncAc.Show();
                txtEncAcNo.Show();
            }
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbTrnTyp.Text = "";
            txtVC.Text ="";
            txtND.Text = "";
            txttrnDes.Text = "";
            txtTrnamt.Text = "";
            txtEncAcNo.Text = "";
            trnDt.Text = "";
            txtAcno.Text = "";
            txtBatno.Text = "";
            txtBatno.Focus();
            lblEncAc.Hide();
            txtEncAcNo.Hide();
            txtBatno.ReadOnly = false;
        }

        private double EncAcBal()
        {
            double encacbal;
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
                String query = "SELECT acbal FROM tsavings where acno = " + Convert.ToInt32(txtEncAcNo.Text) + " and account_status=1";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    encacbal = Convert.ToDouble(dr["acbal"]);
                    return encacbal;
                }
                else
                {
                    return 0.00001;
                }
                dr.Close();

                return 0.00001;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.00001;
            }
            con.Close();
        }

        private void btnDeleteDPtrn_Click(object sender, EventArgs e)
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
                String query = "SELECT * FROM tdeposit where acno = " + Convert.ToInt32(txtAcno.Text) + " and dep_sts = 'open'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    encashed = 0;
                }
                else
                {
                    encashed = 1;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                String query = "SELECT amt FROM tdep_expenditure where batno = " + Convert.ToInt32(txtBatno.Text) + "";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    intamt = Convert.ToDouble(dr["amt"]);
                }
                else
                {
                    intamt = 0;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (cmbTrnTyp.SelectedItem == "Monthly Deposit" && encashed == 1)
            {
                MessageBox.Show("This account has encashment transaction delete that one first!!");
            }
            else if (cmbTrnTyp.SelectedItem == "Monthly Deposit" && encashed == 0)
            {
                try
                {
                    String query = "DELETE from tdeposittrn where batno = "+Convert.ToInt32(txtBatno.Text)+"";
                    String qUbal = "update tdeposit set acbal = acbal - " + Convert.ToDouble(txtTrnamt.Text) + ", nodp = nodp - " + Convert.ToInt32(txtND.Text) + " where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlCommand cmduDep = new MySqlCommand(qUbal, con);
                    cmd.ExecuteNonQuery();
                    cmduDep.ExecuteNonQuery();
                    MessageBox.Show("Monthly Installment Transaction Deleted Successfully");
                    txtBatno.Focus();
                    lblEncAc.Hide();
                    txtEncAcNo.Hide();
                    trnDt.Text = DateTime.Today.ToShortDateString();
                    txtAcno.Text = "";
                    txtBatno.Text = "";
                    txtEncAcNo.Text = "";
                    txtND.Text = "";
                    txtTrnamt.Text = "";
                    txttrnDes.Text = "";
                    txtVC.Text = "";
                    trnDt.Text = "";
                    cmbTrnTyp.Text = "";
                    txtEncAcNo.Text = "";
                    txtBatno.ReadOnly = false;
                }
                catch (Exception ex)
                {
                    txtBatno.ReadOnly = false;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (((EncAcBal() - Convert.ToDouble(txtTrnamt.Text)) >= 500) && EncAcBal() != 0.00001)
                    {
                        String query = "DELETE from tdeposittrn where batno = " + Convert.ToInt32(txtBatno.Text) + "";
                        String qUbal = "update tdeposit set acbal = acbal + " + Convert.ToDouble(txtTrnamt.Text) + " - " + intamt + ", dep_sts = 'open' where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                        String qIdepE = "DELETE from tdep_expenditure where batno = " + Convert.ToInt32(txtBatno.Text) + "";
                        String qUbalSv = "update tsavings set acbal = acbal - " + Convert.ToDouble(txtTrnamt.Text) + " where acno = " + Convert.ToInt32(txtEncAcNo.Text) + "";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlCommand cmduDep = new MySqlCommand(qUbal, con);
                        MySqlCommand cmdqIdepE = new MySqlCommand(qIdepE, con);
                        MySqlCommand cmdqUbalSv = new MySqlCommand(qUbalSv, con);
                        cmdqIdepE.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        cmduDep.ExecuteNonQuery();                   
                        cmdqUbalSv.ExecuteNonQuery();
                        MessageBox.Show("Encashment Transaction Deleted Successfully");
                        txtBatno.Focus();
                        lblEncAc.Hide();
                        txtEncAcNo.Hide();
                        trnDt.Text = DateTime.Today.ToShortDateString();
                        txtAcno.Text = "";
                        txtBatno.Text = "";
                        txtEncAcNo.Text = "";
                        txtND.Text = "";
                        txtTrnamt.Text = "";
                        txttrnDes.Text = "";
                        txtVC.Text = "";
                        trnDt.Text = "";
                        cmbTrnTyp.Text = "";
                        txtEncAcNo.Text = "";
                        txtBatno.ReadOnly = false;
                    }
                    else
                    {
                        txtBatno.ReadOnly = false;
                        MessageBox.Show("Linked Savings account either have insufficient balance or it may be closed or dormanted!!");
                    }
                }
                catch (Exception ex)
                {
                    txtBatno.ReadOnly = false;
                    MessageBox.Show(ex.Message);
                }
            }
                con.Close();
        }
    }
}
