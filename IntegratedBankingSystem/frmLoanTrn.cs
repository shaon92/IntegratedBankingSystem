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
    public partial class frmLoanTrn : Form
    {
        public frmLoanTrn()
        {
            InitializeComponent();
        }
        string lnsts="", disbSts="", prFeeSts="";
        double ftAmt=0, intrPinst=0;
        private DataTable getGridLnTrn()
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

            String queryGrid = "SELECT batno as BatchNo, acno as AccountNumber, IFNULL(ELT(FIELD(ntcod,1, 2, 3, 4),'Processing Fee','Disbursement','Installment','Settlement'),'') AS TransactionType, noi as NumberofInstallment, trnamt as Amount, trndt as Date,vcno as VoucherNo, trndes as Description FROM tloantrn where trndt = '" + DateTime.Today.ToShortDateString() + "'";
            MySqlCommand cmdGrid = new MySqlCommand(queryGrid, con);
            MySqlDataReader reader = cmdGrid.ExecuteReader();
            dtSV.Load(reader);
            return dtSV;
        }

        private void cmbTrnTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrnTyp.Text == "Processing Fee")
            {
                txtTrnamt.Text = "";
                txtNOI.Text = "";
                txttrnDes.Text = "";
                txtTrnamt.ReadOnly = false;
                txtNOI.ReadOnly = true;               
                if (disbSts == "Y")
                {
                    MessageBox.Show("Processing fee can not be taken after disbirsement");
                }
                else if (prFeeSts == "Y")
                {
                    MessageBox.Show("Processing fee is already taken.");
                }
                else if (disbSts == "N" && prFeeSts == "N")
                {
                    txtTrnamt.Text = "1500";
                    txttrnDes.Text = "Processing Fee 1500tk for account no. " + txtAcno.Text;
                    txtTrnamt.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("There is a problem in this account please check backend");
                }
            }
            else if (cmbTrnTyp.Text == "Disbursement")
            {
                txtTrnamt.Text = "";
                txttrnDes.Text = "";
                txtTrnamt.ReadOnly = false;
                txtNOI.ReadOnly = true;
                txtNOI.Text = "";               
                if (disbSts == "Y")
                {
                    MessageBox.Show("Disbirsement transaction is already done.");
                }
                else if (prFeeSts == "N")
                {
                    MessageBox.Show("Please take Processing fee first");
                }
                else if (disbSts == "N" && prFeeSts == "Y")
                {
                    txttrnDes.Text = "Disbursment of amount " + lblSancAmt.Text + " tk for account no. " + txtAcno.Text;
                    txtTrnamt.Text = lblSancAmt.Text;
                    txtTrnamt.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("There is a problem in this account please check backend");
                }
            }
            else if (cmbTrnTyp.Text == "Installment")
            {
                txtTrnamt.Text = "";
                txtNOI.Text = "";
                txttrnDes.Text = "";
                txtTrnamt.ReadOnly = false;
                txtNOI.ReadOnly = false;
                if (disbSts == "N")
                {
                    MessageBox.Show("Disbirsement transaction is not done yet.");
                }
                else if (prFeeSts == "N")
                {
                    MessageBox.Show("Please take Processing fee first");
                }
                else if (disbSts == "Y" && prFeeSts == "Y")
                {
                    txtNOI.Focus();
                    txtTrnamt.ReadOnly = true;
                    txttrnDes.Text = "Installment for account no. " + txtAcno.Text;
                }
                else
                {
                    MessageBox.Show("There is a problem in this account please check backend");
                }
            }
            else if (cmbTrnTyp.Text == "Settlement")
            {
                txtTrnamt.Text = "";
                txtNOI.Text = "";
                txttrnDes.Text = "";
                txtTrnamt.ReadOnly = false;
                txtNOI.ReadOnly = true;
                if (disbSts == "N")
                {
                    MessageBox.Show("Disbirsement transaction is not done yet.");
                }
                else if (prFeeSts == "N")
                {
                    MessageBox.Show("Please take Processing fee first");
                }
                else if (disbSts == "Y" && prFeeSts == "Y")
                {
                    txttrnDes.Text = "Settlement for account no. " + txtAcno.Text;
                    txtTrnamt.Text = ((-1)*Convert.ToDouble(lblAcBal.Text)).ToString();
                    txtTrnamt.ReadOnly = true;
                }
                else
                {
                    txttrnDes.Text = "";
                    MessageBox.Show("There is a problem in this account please check backend");
                }
            }
            else
            {
                MessageBox.Show("There is a problem in this account please check backend");
            }
        }

        private void bxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNOI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txtNOI.Text == "" || txtNOI.Text == "0" || txtNOI.Text == null)
                {
                    MessageBox.Show("Number of installment Can not be Zero(0) or blank");
                }
                else
                {
                    if (Convert.ToInt32(txtNOI.Text) < Convert.ToInt32(lblNOIR.Text))
                    {
                        txtTrnamt.Text = (Convert.ToInt32(txtNOI.Text) * Convert.ToInt32(lblInsAmt.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Number of installment must be less then remaining installments");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtGridLNTrn.DataSource = getGridLnTrn();
            trnDt.Text = DateTime.Today.ToShortDateString();
            lblAcBal.Text = "";
            lblActitle.Text = "";
            lblExpDt.Text = "";
            lblInsAmt.Text = "";
            lblIntr.Text = "";
            lblLnSts.Text = "";
            lblNOI.Text = "";
            lblNOIR.Text = "";
            lblOpnDt.Text = "";
            lblPaidAmt.Text = "";
            lblSancAmt.Text = "";
            txtAcno.Text = "";
            txtBatno.Text = "";
            txtNOI.Text = "";
            txtTrnamt.Text = "";
            txttrnDes.Text = "";
            txtVC.Text = "";
            cmbTrnTyp.Text = "";
            txtNOI.ReadOnly = true;
            txtTrnamt.ReadOnly = false;
            cmbTrnTyp.Enabled = false;
            lnsts = "";
            disbSts = "";
            prFeeSts = "";
            ftAmt = 0;
            intrPinst = 0;
            txtAcno.Focus();
        }

        private void btnSaveLNtrn_Click(object sender, EventArgs e)
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

            if (lnsts == "R")
            {
                if (cmbTrnTyp.SelectedItem == "Processing Fee")
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
                            String query = "INSERT INTO tloantrn (batno, acno, ntcod, noi, trnamt, trndt, vcno, trndes) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', "+1+ ", '" + txtNOI.Text + "', " + Convert.ToDouble(txtTrnamt.Text) + ", '" + trnDt.Text + "', '" + txtVC.Text + "', '" + txttrnDes.Text + "')";
                            String qLnI = "INSERT INTO tloan_income(batno, acno,amt,year) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', " + Convert.ToDouble(txtTrnamt.Text) + ",'" + DateTime.Now.Year + "')";
                            String qULn = "update tloan set prFeeSts = 'Y' where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdLnI = new MySqlCommand(qLnI, con);
                            MySqlCommand cmdqULn = new MySqlCommand(qULn, con);
                            cmd.ExecuteNonQuery();
                            cmdLnI.ExecuteNonQuery();
                            cmdqULn.ExecuteNonQuery();
                            MessageBox.Show("Processing Fee Transaction Successfull");
                            dtGridLNTrn.DataSource = getGridLnTrn();
                            trnDt.Text = DateTime.Today.ToShortDateString();
                            lblAcBal.Text = "";
                            lblActitle.Text = "";
                            lblExpDt.Text = "";
                            lblInsAmt.Text = "";
                            lblIntr.Text = "";
                            lblLnSts.Text = "";
                            lblNOI.Text = "";
                            lblNOIR.Text = "";
                            lblOpnDt.Text = "";
                            lblPaidAmt.Text = "";
                            lblSancAmt.Text = "";
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtNOI.Text = "";
                            txtTrnamt.Text = "";
                            txttrnDes.Text = "";
                            txtVC.Text = "";
                            cmbTrnTyp.Text = "";
                            txtNOI.ReadOnly = true;
                            txtTrnamt.ReadOnly = false;
                            cmbTrnTyp.Enabled = false;
                            lnsts = "";
                            disbSts = "";
                            prFeeSts = "";
                            ftAmt = 0;
                            intrPinst = 0;
                            txtAcno.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (cmbTrnTyp.SelectedItem == "Disbursement")
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
                            String query = "INSERT INTO tloantrn (batno, acno, ntcod, noi, trnamt, trndt, vcno, trndes) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', " + 2 + ", '" + txtNOI.Text + "', " + Convert.ToDouble(txtTrnamt.Text) + ", '" + trnDt.Text + "', '" + txtVC.Text + "', '" + txttrnDes.Text + "')";                         
                            String qULn = "update tloan set disbSts = 'Y', acbal = "+(-1)*ftAmt+" where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdqULn = new MySqlCommand(qULn, con);
                            cmd.ExecuteNonQuery();
                            cmdqULn.ExecuteNonQuery();
                            MessageBox.Show("Disbursement Transaction Successfull");
                            dtGridLNTrn.DataSource = getGridLnTrn();
                            trnDt.Text = DateTime.Today.ToShortDateString();
                            lblAcBal.Text = "";
                            lblActitle.Text = "";
                            lblExpDt.Text = "";
                            lblInsAmt.Text = "";
                            lblIntr.Text = "";
                            lblLnSts.Text = "";
                            lblNOI.Text = "";
                            lblNOIR.Text = "";
                            lblOpnDt.Text = "";
                            lblPaidAmt.Text = "";
                            lblSancAmt.Text = "";
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtNOI.Text = "";
                            txtTrnamt.Text = "";
                            txttrnDes.Text = "";
                            txtVC.Text = "";
                            cmbTrnTyp.Text = "";
                            txtNOI.ReadOnly = true;
                            txtTrnamt.ReadOnly = false;
                            cmbTrnTyp.Enabled = false;
                            lnsts = "";
                            disbSts = "";
                            prFeeSts = "";
                            ftAmt = 0;
                            intrPinst = 0;
                            txtAcno.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }

                else if (cmbTrnTyp.SelectedItem == "Installment")
                {
                    if ((txtBatno.Text == "" || txtBatno.Text == null))
                    {
                        MessageBox.Show("Batch No can not be blank!! Please Generate!!");
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
                            String query = "INSERT INTO tloantrn (batno, acno, ntcod, noi, trnamt, trndt, vcno, trndes) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', " + 3 + ", '" + txtNOI.Text + "', " + Convert.ToDouble(txtTrnamt.Text) + ", '" + trnDt.Text + "', '" + txtVC.Text + "', '" + txttrnDes.Text + "')";
                            String qLnI = "INSERT INTO tloan_income(batno, acno,amt,year) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', " + intrPinst*(Convert.ToInt32(txtNOI.Text)) + ",'" + DateTime.Now.Year + "')";
                            String qULn = "update tloan set acbal = acbal + "+Convert.ToDouble(txtTrnamt.Text)+", noip = noip + "+Convert.ToInt32(txtNOI.Text)+" where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdLnI = new MySqlCommand(qLnI, con);
                            MySqlCommand cmdqULn = new MySqlCommand(qULn, con);
                            cmd.ExecuteNonQuery();
                            cmdLnI.ExecuteNonQuery();
                            cmdqULn.ExecuteNonQuery();
                            MessageBox.Show("Installment Transaction Successfull");
                            dtGridLNTrn.DataSource = getGridLnTrn();
                            trnDt.Text = DateTime.Today.ToShortDateString();
                            lblAcBal.Text = "";
                            lblActitle.Text = "";
                            lblExpDt.Text = "";
                            lblInsAmt.Text = "";
                            lblIntr.Text = "";
                            lblLnSts.Text = "";
                            lblNOI.Text = "";
                            lblNOIR.Text = "";
                            lblOpnDt.Text = "";
                            lblPaidAmt.Text = "";
                            lblSancAmt.Text = "";
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtNOI.Text = "";
                            txtTrnamt.Text = "";
                            txttrnDes.Text = "";
                            txtVC.Text = "";
                            cmbTrnTyp.Text = "";
                            txtNOI.ReadOnly = true;
                            txtTrnamt.ReadOnly = false;
                            cmbTrnTyp.Enabled = false;
                            lnsts = "";
                            disbSts = "";
                            prFeeSts = "";
                            ftAmt = 0;
                            intrPinst = 0;
                            txtAcno.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
                else if (cmbTrnTyp.SelectedItem == "Settlement")
                {
                    if ((txtBatno.Text == "" || txtBatno.Text == null))
                    {
                        MessageBox.Show("Batch No can not be blank!! Please Generate!!");
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
                            String query = "INSERT INTO tloantrn (batno, acno, ntcod, noi, trnamt, trndt, vcno, trndes) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', " + 4 + ", '" + txtNOI.Text + "', " + Convert.ToDouble(txtTrnamt.Text) + ", '" + trnDt.Text + "', '" + txtVC.Text + "', '" + txttrnDes.Text + "')";
                            String qLnI = "INSERT INTO tloan_income(batno, acno,amt,year) VALUES ( '" + txtBatno.Text + "', '" + txtAcno.Text + "', " + intrPinst * (Convert.ToInt32(lblNOIR.Text)) + ",'" + DateTime.Now.Year + "')";
                            String qULn = "update tloan set acbal = acbal + " + Convert.ToDouble(txtTrnamt.Text) + ", lnsts = 'C' where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlCommand cmdLnI = new MySqlCommand(qLnI, con);
                            MySqlCommand cmdqULn = new MySqlCommand(qULn, con);
                            cmd.ExecuteNonQuery();
                            cmdLnI.ExecuteNonQuery();
                            cmdqULn.ExecuteNonQuery();
                            MessageBox.Show("Settlement Transaction Successfull");
                            dtGridLNTrn.DataSource = getGridLnTrn();
                            trnDt.Text = DateTime.Today.ToShortDateString();
                            lblAcBal.Text = "";
                            lblActitle.Text = "";
                            lblExpDt.Text = "";
                            lblInsAmt.Text = "";
                            lblIntr.Text = "";
                            lblLnSts.Text = "";
                            lblNOI.Text = "";
                            lblNOIR.Text = "";
                            lblOpnDt.Text = "";
                            lblPaidAmt.Text = "";
                            lblSancAmt.Text = "";
                            txtAcno.Text = "";
                            txtBatno.Text = "";
                            txtNOI.Text = "";
                            txtTrnamt.Text = "";
                            txttrnDes.Text = "";
                            txtVC.Text = "";
                            cmbTrnTyp.Text = "";
                            txtNOI.ReadOnly = true;
                            txtTrnamt.ReadOnly = false;
                            cmbTrnTyp.Enabled = false;
                            lnsts = "";
                            disbSts = "";
                            prFeeSts = "";
                            ftAmt = 0;
                            intrPinst = 0;
                            txtAcno.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Transaction type selection is not correct.");
                }
            }
            else
            {
                MessageBox.Show("This Loan account is already Settled!!");
            }
        }

        private void frmLoanTrn_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.username;
            lblDate.Text = DateTime.Today.ToShortDateString();
            txtAcno.Focus();
            dtGridLNTrn.DataSource = getGridLnTrn();
            cmbTrnTyp.Enabled = false;
            txtNOI.ReadOnly = true;
            txtTrnamt.ReadOnly = false;
            trnDt.Text = DateTime.Today.ToShortDateString();
        }

        private void btnGenerateLNTrn_Click(object sender, EventArgs e)
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
                String query = "SELECT batno FROM tloantrn order by batno desc limit 1";
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
                    batno = 3001;
                }
                txtBatno.Text = batno.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void txtAcno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ftAmt = 0;
                intrPinst = 0;
                lnsts = "";
                disbSts = "";
                prFeeSts = "";
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
                    String query = "SELECT * FROM tloan where acno = " + Convert.ToInt32(txtAcno.Text) + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cmbTrnTyp.Enabled = true;
                        lnsts = dr["lnsts"].ToString();
                        intrPinst = Convert.ToDouble(dr["intrPinst"]);
                        ftAmt = Convert.ToDouble(dr["ftAmt"]);
                        disbSts = dr["disbSts"].ToString();
                        prFeeSts = dr["prFeeSts"].ToString();
                        lblActitle.Text = dr["actitle"].ToString();
                        lblAcBal.Text = dr["acbal"].ToString();
                        lblOpnDt.Text = dr["openDate"].ToString();
                        lblExpDt.Text = dr["expiryDate"].ToString();
                        lblSancAmt.Text = dr["sancAmt"].ToString();
                        lblLnSts.Text = dr["lnSts"].ToString();
                        lblIntr.Text = dr["intr"].ToString();
                        lblNOIR.Text = (Convert.ToInt32(dr["noi"]) - Convert.ToInt32(dr["noip"])).ToString();
                        lblInsAmt.Text = dr["instAmt"].ToString();
                        lblNOI.Text = dr["noi"].ToString();
                        if (disbSts == "Y")
                        {
                            lblPaidAmt.Text = (Convert.ToDouble(dr["ftamt"]) + Convert.ToDouble(dr["acbal"])).ToString();
                        }
                        else
                        {
                            lblPaidAmt.Text = "0";
                        }
                       // noip = Convert.ToInt32(dr["noip"]);
                       

                    }
                    else
                    {
                        cmbTrnTyp.Enabled = false;
                        MessageBox.Show("This Account No. does not exists");
                        txtAcno.Focus();
                    }
                    dr.Close();
                    if (lnsts == "C")
                    {
                        cmbTrnTyp.Enabled = false;
                        MessageBox.Show("This Loan account is already Settled!!");
                    }
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
