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
    public partial class frmLoanTrnD : Form
    {
        public frmLoanTrnD()
        {
            InitializeComponent();
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
                    String query = "SELECT tloantrn.*, IFNULL(ELT(FIELD(ntcod,1, 2, 3, 4),'Processing Fee','Disbursement','Installment','Settlement'),'') AS trntyp FROM tloantrn where batno = " + Convert.ToInt32(txtBatno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cmbTrnTyp.Text = dr["trntyp"].ToString();
                        txtVC.Text = dr["vcno"].ToString();
                        txtNOI.Text = dr["noi"].ToString();
                        txttrnDes.Text = dr["trndes"].ToString();
                        txtTrnamt.Text = dr["trnamt"].ToString();
                        trnDt.Text = dr["trndt"].ToString();
                        txtAcno.Text = dr["acno"].ToString();
                        txtBatno.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Batcht No. does not exists");
                        cmbTrnTyp.Text = "";
                        txtAcno.Text = "";
                        txtBatno.Text = "";
                        txtNOI.Text = "";
                        txtTrnamt.Text = "";
                        txttrnDes.Text = "";
                        txtVC.Text = "";
                        trnDt.Text = "";
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

        private int maxNtcod(int acno)
        {
            int mxNtcod;
            string cs = "server=localhost;userid=root;database=integratedbankingsystem";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                String query = "SELECT max(ntcod) mxntcod FROM tloantrn where acno = "+acno+"";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                  return  mxNtcod = Convert.ToInt32(dr["mxntcod"]);
                }
                else
                {
                    MessageBox.Show("Account No. does not found");
                    return 0;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbTrnTyp.Text = "";
            txtAcno.Text = "";
            txtBatno.Text = "";
            txtNOI.Text = "";
            txtTrnamt.Text = "";
            txttrnDes.Text = "";
            txtVC.Text = "";
            trnDt.Text = "";
            txtBatno.ReadOnly = false;
            txtBatno.Focus();
        }

        private void frmLoanTrnD_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtBatno.ReadOnly = false;
            txtBatno.Focus();
        }

        private void btnDelLNtrn_Click(object sender, EventArgs e)
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
            int mxntcod = maxNtcod(Convert.ToInt32(txtAcno.Text));

            if (cmbTrnTyp.Text == "Processing Fee")
            {
                if(mxntcod == 4)
                {
                    MessageBox.Show("Delete Settlement Transaction first");
                }
                else if (mxntcod == 3)
                {
                    MessageBox.Show("Delete Installment Transaction first");
                }
                else if (mxntcod == 2)
                {
                    MessageBox.Show("Delete DIsbursement Transaction first");
                }
                else if (mxntcod == 1)
                {
                    if ((txtBatno.Text == "" || txtBatno.Text == null))
                    {
                        MessageBox.Show("Batch No can not be blank!!");
                    }
                    else if ((txtAcno.Text == "" || txtAcno.Text == null))
                    {
                        MessageBox.Show("Account no No can not be blank!!");
                    }
                    else
                    {
                        try
                        {
                            String qLnI = "DELETE from tloan_income  where batno =  " + Convert.ToInt32(txtBatno.Text) + "";
                            String query = "DELETE from tloantrn where batno =  "+Convert.ToInt32(txtBatno.Text)+"";
                            String qULn = "update tloan set prFeeSts = 'N' where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmdLnI = new MySqlCommand(qLnI, con);
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdqULn = new MySqlCommand(qULn, con);
                            cmdLnI.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            cmdqULn.ExecuteNonQuery();
                            MessageBox.Show("Processing Fee Transaction Deleted Successfully");
                            cmbTrnTyp.Text = "";
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtNOI.Text = "";
                            txtTrnamt.Text = "";
                            txttrnDes.Text = "";
                            txtVC.Text = "";
                            trnDt.Text = "";
                            txtBatno.ReadOnly = false;
                            txtBatno.Focus();
                        }
                        catch (Exception ex)
                        {
                            txtBatno.ReadOnly = false;
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    txtBatno.ReadOnly = false;
                    MessageBox.Show("Transaction type for this Transaction is not correct");
                }             
            }
            else if (cmbTrnTyp.Text == "Disbursement")
            {
                if (mxntcod == 4)
                {
                    MessageBox.Show("Delete Settlement Transaction first");
                }
                else if (mxntcod == 3)
                {
                    MessageBox.Show("Delete Installment Transaction first");
                }
                else if (mxntcod == 2)
                {
                    if ((txtBatno.Text == "" || txtBatno.Text == null))
                    {
                        MessageBox.Show("Batch No can not be blank!!");
                    }
                    else if ((txtAcno.Text == "" || txtAcno.Text == null))
                    {
                        MessageBox.Show("Account no No can not be blank!!");
                    }
                    else
                    {
                        try
                        {
                            String query = "DELETE from tloantrn where batno =  " + Convert.ToInt32(txtBatno.Text) + "";
                            String qULn = "update tloan set disbSts = 'N', acbal = 0 where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdqULn = new MySqlCommand(qULn, con);
                            cmd.ExecuteNonQuery();
                            cmdqULn.ExecuteNonQuery();
                            MessageBox.Show("Disbursement Transaction Deleted Successfully");
                            cmbTrnTyp.Text = "";
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtNOI.Text = "";
                            txtTrnamt.Text = "";
                            txttrnDes.Text = "";
                            txtVC.Text = "";
                            trnDt.Text = "";
                            txtBatno.ReadOnly = false;
                            txtBatno.Focus();
                        }
                        catch (Exception ex)
                        {
                            txtBatno.ReadOnly = false;
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    txtBatno.ReadOnly = false;
                    MessageBox.Show("Transaction type for this Transaction is not correct");
                }
            }
            else if (cmbTrnTyp.Text == "Installment")
            {
                if (mxntcod == 4)
                {
                    MessageBox.Show("Delete Settlement Transaction first");
                }
                else if (mxntcod == 3)
                {
                    if ((txtBatno.Text == "" || txtBatno.Text == null))
                    {
                        MessageBox.Show("Batch No can not be blank!!");
                    }
                    else if ((txtAcno.Text == "" || txtAcno.Text == null))
                    {
                        MessageBox.Show("Account no No can not be blank!!");
                    }
                    else if ((txtNOI.Text == "" || txtNOI.Text == null))
                    {
                        MessageBox.Show("Number of Installments can not be blank!!");
                    }
                    else if ((txtTrnamt.Text == "" || txtTrnamt.Text == null))
                    {
                        MessageBox.Show("Installment amount can not be blank!!");
                    }
                    else
                    {
                        try
                        {
                            String qLnI =  "DELETE from tloan_income where batno =  " + Convert.ToInt32(txtBatno.Text) + "";
                            String query = "DELETE from tloantrn where batno =  " + Convert.ToInt32(txtBatno.Text) + "";
                            String qULn = "update tloan set acbal = acbal - " + Convert.ToDouble(txtTrnamt.Text) + ", noip = noip - " + Convert.ToInt32(txtNOI.Text) + " where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmdLnI = new MySqlCommand(qLnI, con);
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdqULn = new MySqlCommand(qULn, con);
                            cmdLnI.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            cmdqULn.ExecuteNonQuery();
                            MessageBox.Show("Installment Transaction Deleted Successfully");
                            cmbTrnTyp.Text = "";
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtNOI.Text = "";
                            txtTrnamt.Text = "";
                            txttrnDes.Text = "";
                            txtVC.Text = "";
                            trnDt.Text = "";
                            txtBatno.ReadOnly = false;
                            txtBatno.Focus();
                        }
                        catch (Exception ex)
                        {
                            txtBatno.ReadOnly = false;
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    txtBatno.ReadOnly = false;
                    MessageBox.Show("Transaction type for this Transaction is not correct");
                }
            }
            else if (cmbTrnTyp.Text == "Settlement")
            {
                if (mxntcod == 4)
                {
                    if ((txtBatno.Text == "" || txtBatno.Text == null))
                    {
                        MessageBox.Show("Batch No can not be blank!!");
                    }
                    else if ((txtAcno.Text == "" || txtAcno.Text == null))
                    {
                        MessageBox.Show("Account no No can not be blank!!");
                    }
                    else if ((txtTrnamt.Text == "" || txtTrnamt.Text == null))
                    {
                        MessageBox.Show("Settlement amount can not be blank!!");
                    }
                    else
                    {
                        try
                        {
                            String qLnI = "DELETE from tloan_income where batno =  " + Convert.ToInt32(txtBatno.Text) + "";
                            String query = "DELETE from tloantrn where batno =  " + Convert.ToInt32(txtBatno.Text) + "";
                            String qULn = "update tloan set acbal = acbal - " + Convert.ToDouble(txtTrnamt.Text) + ", lnsts = 'R' where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmdLnI = new MySqlCommand(qLnI, con);
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdqULn = new MySqlCommand(qULn, con);
                            cmdLnI.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            cmdqULn.ExecuteNonQuery();
                            MessageBox.Show("Settlement Transaction Deleted Successfully");
                            cmbTrnTyp.Text = "";
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtNOI.Text = "";
                            txtTrnamt.Text = "";
                            txttrnDes.Text = "";
                            txtVC.Text = "";
                            trnDt.Text = "";
                            txtBatno.ReadOnly = false;
                            txtBatno.Focus();
                        }
                        catch (Exception ex)
                        {
                            txtBatno.ReadOnly = false;
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    txtBatno.ReadOnly = false;
                    MessageBox.Show("Transaction type for this Transaction is not correct");
                }
            }
            else
            {
                txtBatno.ReadOnly = false;
                MessageBox.Show("Transaction type for this Transaction is not correct");
            }
        }
    }
}
