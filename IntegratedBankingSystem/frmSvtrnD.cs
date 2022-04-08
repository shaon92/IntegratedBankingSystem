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
    public partial class frmSvtrnD : Form
    {
        public frmSvtrnD()
        {
            InitializeComponent();
        }

        private void frmSvtrnD_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtBatno.ReadOnly = false;
            txtBatno.Focus();
            lblRcvAc.Hide();
            txtRcvAcNo.Hide();
        }

        private void cmbTrnTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrnTyp.SelectedItem == "Cash")
            {
                lblRcvAc.Hide();
                txtRcvAcNo.Hide();
            }
            else
            {
                lblRcvAc.Show();
                txtRcvAcNo.Show();
            }
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
                    String query = "SELECT * FROM tsavingstrn where batno = " + Convert.ToInt32(txtBatno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cmbTrnTyp.Text = dr["trntyp"].ToString();
                        txtVC.Text = dr["vcno"].ToString();
                        txtTrnSign.Text = dr["trnsign"].ToString();
                        txttrnDes.Text = dr["trndes"].ToString();
                        txtTrnamt.Text = dr["trnamt"].ToString();
                        txtRcvAcNo.Text = dr["racno"].ToString();
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
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbTrnTyp.Text = "";
            txtVC.Text = "";
            txtTrnSign.Text = "";
            txttrnDes.Text = "";
            txtTrnamt.Text = "";
            txtRcvAcNo.Text = "";
            trnDt.Text = "";
            txtBatno.Text = "";
            txtAcno.Text = "";
            txtBatno.ReadOnly = false;
            txtBatno.Focus();
        }

        private double receiveAcBal()
        {
            double racbal;
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
                String query = "SELECT acbal FROM tsavings where acno = " + Convert.ToInt32(txtRcvAcNo.Text) + "";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    racbal = Convert.ToDouble(dr["acbal"]);
                    return racbal;
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

        private double MyAcBal()
        {
            double macbal;
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
                String query = "SELECT acbal FROM tsavings where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    macbal = Convert.ToDouble(dr["acbal"]);
                    return macbal;
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

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelSVtrn_Click(object sender, EventArgs e)
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

            if (cmbTrnTyp.Text == "Cash")
            {
                if ((txtBatno.Text == "" || txtBatno.Text == null))
                {
                    MessageBox.Show("Batch No can not be blank!!");
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
                        if (((MyAcBal() - trnamt) >= 500) && MyAcBal() !=  0.00001)
                        {
                            String query = "delete from tsavingstrn where batno = "+Convert.ToInt32(txtBatno.Text)+"";
                            String qUbal = "update tsavings set acbal = acbal - " + trnamt + " where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdubal = new MySqlCommand(qUbal, con);
                            cmd.ExecuteNonQuery();
                            cmdubal.ExecuteNonQuery();
                            MessageBox.Show("Transaction Deleted Successfully");
                            cmbTrnTyp.Text = "";
                            txtVC.Text = "";
                            txtTrnSign.Text = "";
                            txttrnDes.Text = "";
                            txtTrnamt.Text = "";
                            txtRcvAcNo.Text = "";
                            txtAcno.Text = "";
                            trnDt.Text = "";
                            txtBatno.Text = "";
                            txtBatno.ReadOnly = false;
                            txtBatno.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient Balance");
                            txtBatno.ReadOnly = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtBatno.ReadOnly = false;
                    }
                }
            }
            else if (cmbTrnTyp.Text == "Transfer")
            {
                if ((txtBatno.Text == "" || txtBatno.Text == null))
                {
                    MessageBox.Show("Batch No can not be blank!!");
                }
                else
                {

                    try
                    {
                        double trnamt;
                        trnamt = (-1) * Convert.ToDouble(txtTrnamt.Text);
                            if (((receiveAcBal() + trnamt) >= 500) && receiveAcBal() != 0.00001)
                            {
                                String query = "delete from tsavingstrn where batno = "+Convert.ToInt32(txtBatno.Text)+"";
                                String qUbalS = "update tsavings set acbal = acbal - " + trnamt + " where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                                String qUbalR = "update tsavings set acbal = acbal + " + trnamt + " where acno = " + Convert.ToInt32(txtRcvAcNo.Text) + "";
                                MySqlCommand cmd = new MySqlCommand(query, con);
                                MySqlCommand cmdubalS = new MySqlCommand(qUbalS, con);
                                MySqlCommand cmdubalR = new MySqlCommand(qUbalR, con);
                                cmd.ExecuteNonQuery();
                                cmdubalS.ExecuteNonQuery();
                                cmdubalR.ExecuteNonQuery();
                                MessageBox.Show("Transaction Deleted Successfully");
                                cmbTrnTyp.Text = "";
                                txtVC.Text = "";
                                txtTrnSign.Text = "";
                                txttrnDes.Text = "";
                                txtTrnamt.Text = "";
                                txtRcvAcNo.Text = "";
                                trnDt.Text = "";
                                txtBatno.Text = "";
                                txtAcno.Text = "";
                                txtBatno.ReadOnly = false;
                                txtBatno.Focus();
                        }
                            else
                            {
                                MessageBox.Show("Insufficient Balance");
                                txtBatno.ReadOnly = false;
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtBatno.ReadOnly = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Something Wenst Wrong");
                txtBatno.ReadOnly = false;
            }
        }
    }
}
