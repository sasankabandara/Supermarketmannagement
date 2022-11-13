using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Supermarket_Management_System_In_csharp
{
    public partial class frm_invoice : Form
    {
        public static string invoice_id;
        private DatabaseConnection connection;

        public frm_invoice()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
        }

        private void frm_invoice_Load(object sender, EventArgs e)
        {
            invoice_id = UC_Billing.invoiceid;

            txt_invoiceid.Text = invoice_id;


            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_invoiceid_TextChanged(object sender, EventArgs e)
        {

            connection.GetSqlConnection().Open();


            SqlDataAdapter da = new SqlDataAdapter("Select * From order_view Where invono = '" + txt_invoiceid.Text + "'", connection.GetSqlConnection());

            ds_print dsr = new ds_print();

            da.Fill(dsr, "order_view");

            ReportDataSource datasource = new ReportDataSource("DS_Invoice", dsr.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

            connection.GetSqlConnection().Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
