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
    public partial class frmDepTrn : Form
    {
        public frmDepTrn()
        {
            InitializeComponent();
        }
        int matamt;
        int nodp;
        double intamt;
        string depsts;
        private void frmDepTrn_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtAcno.Focus();
            lblEncAc.Hide();
            txtEncAcNo.Hide();
            dtGridDPTrn.DataSource = getGriddpTrn();
            txtND.ReadOnly = true;
            txtTrnamt.ReadOnly = false;
            trnDt.Text = DateTime.Today.ToShortDateString();
        }

        private DataTable getGriddpTrn()
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

            String queryGrid = "SELECT batno as BatchNo, acno as AccountNumber, trntyp as TransactionType, nod as NumberofDeposit, trnamt as Amount, trndt as Date,vcno as VoucherNo,encacno as EncashmentAccount FROM tdeposittrn where trndt = '" + DateTime.Today.ToShortDateString() + "'";
            MySqlCommand cmdGrid = new MySqlCommand(queryGrid, con);
            MySqlDataReader reader = cmdGrid.ExecuteReader();
            dtSV.Load(reader);
            return dtSV;
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
                    String query = "SELECT * FROM tdeposit where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        lblActitle.Text = dr["actitle"].ToString();
                        lblAcBal.Text = dr["acbal"].ToString();
                        lblOpnDt.Text = dr["opndt"].ToString();
                        lblTPeriod.Text = dr["nod"].ToString();
                        lblMnDep.Text = dr["mdepamt"].ToString();
                        lblIntr.Text = dr["intr"].ToString();
                        lblRmPeriod.Text = (Convert.ToInt32(dr["nod"]) - Convert.ToInt32(dr["nodp"])).ToString();
                        txtEncAcNo.Text = dr["linksvac"].ToString();
                        matamt = Convert.ToInt32(dr["matamt"]);
                        nodp = Convert.ToInt32(dr["nodp"]);
                        depsts = dr["dep_sts"].ToString();
                        txtEncAcNo.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("This Account No. does not exists");
                        txtAcno.Focus();
                    }                 
                    dr.Close();
                    if (depsts == "encashed")
                    {
                        MessageBox.Show("This deposit account is already encashed!!");
                    }
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

        private void txtND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtND.Text) <= Convert.ToInt32(lblRmPeriod.Text))
                {
                    if (Convert.ToInt32(txtND.Text) == 0)
                    {
                        MessageBox.Show("Number of deposits can not be 0");
                    }
                    else
                    {
                        txtTrnamt.Text = (Convert.ToInt32(txtND.Text) * Convert.ToInt32(lblMnDep.Text)).ToString();
                    }
                }             
                else
                {
                    MessageBox.Show("Number of deposits must be less then or equal of remaining deposit");
                }
            }
        }

        private void cmbTrnTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrnTyp.SelectedItem == "Monthly Deposit")
            {
                lblEncAc.Hide();
                txtEncAcNo.Hide();
                txtND.ReadOnly = false;
                txtTrnamt.ReadOnly = false;
            }
            else
            {
                try
                {
                    if ((Convert.ToDouble(lblAcBal.Text) >= matamt) && (nodp >= 6))
                    {
                        txtND.ReadOnly = true;
                        lblEncAc.Show();
                        txtEncAcNo.Show();
                        intamt = Math.Round((Convert.ToDouble(lblIntr.Text) * nodp * Convert.ToDouble(lblAcBal.Text)) / 1200); // (Interest rate * number of deposit paid * total deposited amount) 12*100
                        txtTrnamt.Text = (Convert.ToDouble(lblAcBal.Text) + intamt).ToString();
                        txtTrnamt.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Premature Encashment!! Interest rate will be down to 2%");
                        txtND.ReadOnly = true;
                        lblEncAc.Show();
                        txtEncAcNo.Show();
                        intamt = Math.Round((2 * nodp * Convert.ToDouble(lblAcBal.Text)) / 1200); // (2 * number of deposit paid * total deposited amount) 12*100
                        txtTrnamt.Text = (Convert.ToDouble(lblAcBal.Text) + intamt).ToString();
                        txtTrnamt.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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
                String query = "SELECT batno FROM tdeposittrn order by batno desc limit 1";
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
                    batno = 2001;
                }
                txtBatno.Text = batno.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAcno.Focus();
            lblEncAc.Hide();
            txtEncAcNo.Hide();
            txtND.ReadOnly = true;
            txtTrnamt.ReadOnly = false;
            trnDt.Text = DateTime.Today.ToShortDateString();
            lblActitle.Text = "";
            lblAcBal.Text = "";
            lblOpnDt.Text = "";
            lblTPeriod.Text = "";
            lblMnDep.Text = "";
            lblIntr.Text = "";
            lblRmPeriod.Text = "";
            matamt = 0;
            nodp = 0;
            depsts = "";
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
        }

        private void btnSaveDPtrn_Click(object sender, EventArgs e)
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

            if (depsts == "open")
            {
                if (cmbTrnTyp.SelectedItem == "Monthly Deposit")
                {
                    if ((txtBatno.Text == "" || txtBatno.Text == null))
                    {
                        MessageBox.Show("Batch No can not be blank!! Please Generate!!");
                    }
                    else if ((txtAcno.Text == "" || txtAcno.Text == null))
                    {
                        MessageBox.Show("Account no No can not be blank!!");
                    }
                    else if ((txtND.Text == "" || txtND.Text == null))
                    {
                        MessageBox.Show("Number of deposit can not be blank!!");
                    }
                    else
                    {
                        try
                        {
                            String query = "INSERT INTO tdeposittrn (batno, acno, trntyp, nod, trnamt, trndt, vcno, encacno, trndes) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', '" + cmbTrnTyp.Text + "', '" + txtND.Text + "', " + Convert.ToDouble(txtTrnamt.Text) + ", '" + trnDt.Text + "', '" + txtVC.Text + "',NULL, '" + txttrnDes.Text + "')";
                            String qUbal = "update tdeposit set acbal = acbal + " + Convert.ToDouble(txtTrnamt.Text) + ", nodp = nodp + " + Convert.ToInt32(txtND.Text) + " where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmduDep = new MySqlCommand(qUbal, con);
                            cmd.ExecuteNonQuery();
                            cmduDep.ExecuteNonQuery();
                            MessageBox.Show("Deposit Transaction Successfull");
                            dtGridDPTrn.DataSource = getGriddpTrn();
                            txtAcno.Focus();
                            lblEncAc.Hide();
                            txtEncAcNo.Hide();
                            txtND.ReadOnly = true;
                            txtTrnamt.ReadOnly = false;
                            trnDt.Text = DateTime.Today.ToShortDateString();
                            lblActitle.Text = "";
                            lblAcBal.Text = "";
                            lblOpnDt.Text = "";
                            lblTPeriod.Text = "";
                            lblMnDep.Text = "";
                            lblIntr.Text = "";
                            lblRmPeriod.Text = "";
                            matamt = 0;
                            nodp = 0;
                            depsts = "";
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
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    if ((txtBatno.Text == "" || txtBatno.Text == null))
                    {
                        MessageBox.Show("Batch No can not be blank!! Please Generate!!");
                    }
                    else if ((txtAcno.Text == "" || txtAcno.Text == null))
                    {
                        MessageBox.Show("Account no No can not be blank!!");
                    }
                    else
                    {
                        try
                        {
                            String query = "INSERT INTO tdeposittrn (batno, acno, trntyp, nod, trnamt, trndt, vcno, encacno, trndes) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', '" + cmbTrnTyp.Text + "', NULL, " + Convert.ToDouble(txtTrnamt.Text) + ", '" + trnDt.Text + "', '" + txtVC.Text + "','" + txtEncAcNo.Text + "', '" + txttrnDes.Text + "')";
                            String qUbal = "update tdeposit set acbal = acbal - " + Convert.ToDouble(txtTrnamt.Text) + " + " + intamt + ", dep_sts = 'encashed' where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            String qIdepE = "INSERT INTO tdep_expenditure(batno, acno,amt,year) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', "+intamt+",'"+ DateTime.Now.Year+"')";
                            String qUbalSv = "update tsavings set acbal = acbal + " + Convert.ToDouble(txtTrnamt.Text) + " where acno = " + Convert.ToInt32(txtEncAcNo.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmduDep = new MySqlCommand(qUbal, con);
                            MySqlCommand cmdqIdepE = new MySqlCommand(qIdepE, con);
                            MySqlCommand cmdqUbalSv = new MySqlCommand(qUbalSv, con);
                            cmd.ExecuteNonQuery();
                            cmduDep.ExecuteNonQuery();
                            cmdqIdepE.ExecuteNonQuery();
                            cmdqUbalSv.ExecuteNonQuery();
                            MessageBox.Show("Encashment Transaction Successfull");
                            dtGridDPTrn.DataSource = getGriddpTrn();
                            txtAcno.Focus();
                            lblEncAc.Hide();
                            txtEncAcNo.Hide();
                            txtND.ReadOnly = true;
                            txtTrnamt.ReadOnly = false;
                            trnDt.Text = DateTime.Today.ToShortDateString();
                            lblActitle.Text = "";
                            lblAcBal.Text = "";
                            lblOpnDt.Text = "";
                            lblTPeriod.Text = "";
                            lblMnDep.Text = "";
                            lblIntr.Text = "";
                            lblRmPeriod.Text = "";
                            matamt = 0;
                            nodp = 0;
                            depsts = "";
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
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("This deposit account is already encashed!!");
            }
        }
    }
}
