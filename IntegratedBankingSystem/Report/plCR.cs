using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedBankingSystem.Report
{
    public partial class plCR : Form
    {
        public plCR()
        {
            InitializeComponent();
        }

        private void plRptV_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "" || txtYear.Text == null)
            {
                MessageBox.Show("Year can not be blank");
                txtYear.Text = "";
                txtYear.Focus();
            }
            else
            {
                string cs = "server=localhost;userid=root;database=integratedbankingsystem";
                var con = new MySqlConnection(cs);
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("select (select IFNULL(sum(amt),0) from tloan_income where year = " + txtYear.Text + ") as incLoan, (select IFNULL(sum(amount),0) from  tsvacmnfee where year = " + txtYear.Text + ") as incSav, (select IFNULL(sum(amt),0) from  tdep_expenditure where year = " + txtYear.Text + ") as expDep, (select IFNULL(sum(amount),0) from  tothr_expenditure where type = 'Salary Expenditure' and year = " + txtYear.Text + ") as expSal, (select IFNULL(sum(amount),0) from  tothr_expenditure where type = 'Allowance Expenditure' and year = " + txtYear.Text + ") as expAllw, (select IFNULL(sum(amount),0) from  tothr_expenditure where type = 'Miscellaneous Expenditure' and year = " + txtYear.Text + ") as expMisc", con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    con.Close();
                    plRp pl = new plRp();
                    TextObject year = (TextObject)pl.ReportDefinition.Sections["Section1"].ReportObjects["txtYearRep"];
                    TextObject user = (TextObject)pl.ReportDefinition.Sections["Section5"].ReportObjects["txtUserRep"];
                    year.Text = txtYear.Text;
                    user.Text = frmLogin.username;
                    pl.Database.Tables["plData"].SetDataSource(dtbl);                  
                    plRptV.ReportSource = null;
                    plRptV.ReportSource = pl;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtYear.Text = "";
                txtYear.Focus();
            }
        }

        private void plCR_Load(object sender, EventArgs e)
        {
            txtYear.Focus();
        }
    }
}
