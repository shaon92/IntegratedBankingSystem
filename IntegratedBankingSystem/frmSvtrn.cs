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
    public partial class frmSvtrn : Form
    {
        public frmSvtrn()
        {
            InitializeComponent();
        }

        private void frmSvtrn_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            trnDt.Text = DateTime.Today.ToShortDateString();
            txtAcno.Focus();
            txtTrnSign.Text = "+";
            lblRcvAc.Hide();
            txtRcvAcNo.Hide();
            dtGridSVTrn.DataSource = getGridSVTrn();
        }

        private DataTable getGridSVTrn()
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

            String queryGrid = "SELECT batno as BatchNo, acno as AccountNumber, trntyp as TransactionType, trnsign as Sign, trnamt as Amount, trndt as Date,vcno as VoucherNo,racno as ReceiverAccount FROM tsavingstrn where trndt = '" + DateTime.Today.ToShortDateString() + "'";
            MySqlCommand cmdGrid = new MySqlCommand(queryGrid, con);
            MySqlDataReader reader = cmdGrid.ExecuteReader();
            dtSV.Load(reader);        
            return dtSV;
        }

        private int receiveAc()
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
                String query = "SELECT * FROM tsavings where acno = " + Convert.ToInt32(txtRcvAcNo.Text) + "";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int acsts;
                    acsts = Convert.ToInt32(dr["account_status"]);
                    if (acsts == 1)
                    {
                        return 200;
                    }
                    else if (acsts == 2)
                    {
                        return 404;
                    }
                    else
                    {
                        return 404;
                    }
                }
                else
                {
                    return 404;
                }
                dr.Close();

                return 404;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 404;
            }
            con.Close();
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
                    String query = "SELECT * FROM tsavings where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        int acsts;
                        lblActitle.Text = dr["actitle"].ToString();
                        lblAcBal.Text = dr["acbal"].ToString();
                        acsts = Convert.ToInt32(dr["account_status"]);
                        if (acsts == 1)
                        {
                            lblAcsts.Text = "Open";
                            cmbTrnTyp.Focus();
                        }
                        else if (acsts == 2)
                        {
                            MessageBox.Show("This Account is Closed");
                            txtAcno.Focus();
                        }
                        else
                        {
                            MessageBox.Show("This Account is Dormanted");
                            txtAcno.Focus();
                        }                     
                    }
                    else
                    {
                        MessageBox.Show("This Account No. does not exists");
                        txtAcno.Focus();
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

        private void cmbTrnTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrnTyp.SelectedItem == "Cash")
            {
                lblRcvAc.Hide();
                txtRcvAcNo.Hide();
                txtTrnSign.Text = "+";
                txtTrnSign.Enabled = true;
            }
            else
            {
                lblRcvAc.Show();
                txtRcvAcNo.Show();
                txtTrnSign.Text = "-";
                txtTrnSign.Enabled = false;
            }
        }

        private void txtTrnSign_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnGenerateSvTrn_Click(object sender, EventArgs e)
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
                String query = "SELECT batno FROM tsavingstrn order by batno desc limit 1";
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
                    batno = 101;
                }
                txtBatno.Text = batno.ToString();
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
            txtAcno.Text = "";
            txtBatno.Text = "";
            txtRcvAcNo.Hide();
            lblAcBal.Text = "";
            lblAcsts.Text = "";
            txtTrnamt.Text = "";
            lblActitle.Text = "";
            lblRcvAc.Hide();
            txtRcvAcNo.Text = "";
            cmbTrnTyp.Text = "Cash";
            txttrnDes.Text= "";
            txtTrnSign.Text = "+";
            txtVC.Text = "";
            trnDt.Text = DateTime.Today.ToShortDateString();
        }

        private void btnSaveSVtrn_Click(object sender, EventArgs e)
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

            if (cmbTrnTyp.Text =="Cash")
            {
                if ((txtBatno.Text == "" || txtBatno.Text == null))
                {
                    MessageBox.Show("Batch No can not be blank!! Please Generate!!");
                }
                else
                {
                    try
                    {
                        double trnamt;
                        if (txtTrnSign.Text == "-")
                        {
                            trnamt = (-1) * (Convert.ToDouble(txtTrnamt.Text));
                        }
                        else
                        {
                            trnamt = Convert.ToDouble(txtTrnamt.Text);
                        }
                        if ((Convert.ToDouble(lblAcBal.Text) + trnamt) >= 500)
                        {
                            String query = "insert into tsavingstrn (batno,acno,trntyp,trnsign,trnamt,trndt,vcno,trndes) value('" + txtBatno.Text + "','" + txtAcno.Text + "','" + cmbTrnTyp.Text + "','" + txtTrnSign.Text + "'," + Convert.ToDouble(txtTrnamt.Text) + ",'" + trnDt.Text + "','" + txtVC.Text + "','" + txttrnDes.Text + "')";
                            String qUbal = "update tsavings set acbal = acbal + " + trnamt + " where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdubal = new MySqlCommand(qUbal, con);
                            cmd.ExecuteNonQuery();
                            cmdubal.ExecuteNonQuery();
                            MessageBox.Show("Cash Transaction Successfull");
                            dtGridSVTrn.DataSource = getGridSVTrn();
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtRcvAcNo.Hide();
                            lblAcBal.Text = "";
                            lblAcsts.Text = "";
                            txtTrnamt.Text = "";
                            lblActitle.Text = "";
                            lblRcvAc.Hide();
                            txtRcvAcNo.Text = "";
                            cmbTrnTyp.Text = "Cash";
                            txttrnDes.Text = "";
                            txtTrnSign.Text = "+";
                            txtVC.Text = "";
                            trnDt.Text = DateTime.Today.ToShortDateString();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient Balance");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (cmbTrnTyp.Text == "Transfer")
            {
                if ((txtBatno.Text == "" || txtBatno.Text == null))
                {
                    MessageBox.Show("Batch No can not be blank!! Please Generate!!");
                }
                else
                {

                    try
                    {
                        double trnamt;
                        trnamt = (-1) * Convert.ToDouble(txtTrnamt.Text);
                        if (receiveAc() == 200)
                        {
                            if ((Convert.ToDouble(lblAcBal.Text) + trnamt) >= 500)
                            {
                                String query = "insert into tsavingstrn (batno,acno,trntyp,trnsign,trnamt,trndt,vcno,racno,trndes) value('" + txtBatno.Text + "','" + txtAcno.Text + "','" + cmbTrnTyp.Text + "','" + txtTrnSign.Text + "'," + Convert.ToDouble(txtTrnamt.Text) + ",'" + trnDt.Text + "','" + txtVC.Text + "','" + txtRcvAcNo.Text + "','" + txttrnDes.Text + "')";
                                String qUbalS = "update tsavings set acbal = acbal + " + trnamt + " where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                                String qUbalR = "update tsavings set acbal = acbal - " + trnamt + " where acno = " + Convert.ToInt32(txtRcvAcNo.Text) + "";
                                MySqlCommand cmd = new MySqlCommand(query, con);
                                MySqlCommand cmdubalS = new MySqlCommand(qUbalS, con);
                                MySqlCommand cmdubalR = new MySqlCommand(qUbalR, con);
                                cmd.ExecuteNonQuery();
                                cmdubalS.ExecuteNonQuery();
                                cmdubalR.ExecuteNonQuery();
                                MessageBox.Show("Transfer Transaction Successfull");
                                dtGridSVTrn.DataSource = getGridSVTrn();
                                txtAcno.Text = "";
                                txtBatno.Text = "";
                                txtRcvAcNo.Hide();
                                lblAcBal.Text = "";
                                lblAcsts.Text = "";
                                txtTrnamt.Text = "";
                                lblActitle.Text = "";
                                lblRcvAc.Hide();
                                txtRcvAcNo.Text = "";
                                cmbTrnTyp.Text = "Cash";
                                txttrnDes.Text = "";
                                txtTrnSign.Text = "+";
                                txtVC.Text = "";
                                trnDt.Text = DateTime.Today.ToShortDateString();
                            }
                            else
                            {
                                MessageBox.Show("Insufficient Balance");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Receiver Account Not Exist/ Closed/ Dormanted");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Something Wenst Wrong");
            }
        }
    }
}
