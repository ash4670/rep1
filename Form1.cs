using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rep1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=nrcweb;User ID=sa;Password=123456");
            conn.Open();
            SqlCommand qmd = new SqlCommand("select * from items where stock_code='01' ",conn);
            SqlDataAdapter da = new SqlDataAdapter(qmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\ashwork\blazors\rep1\reports\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=nrcweb;User ID=sa;Password=123456");
            conn.Open();
            SqlCommand qmd = new SqlCommand("select * from items where stock_code='01' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(qmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            //LocalReport lr = new LocalReport();
            //var result=lr.Execute(
        }
    }
}