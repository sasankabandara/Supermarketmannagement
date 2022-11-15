using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket_Management_System_In_csharp
{
    public partial class UC_orders : UserControl
    {
        public static string invoiceid;
        private DatabaseConnection connection;
        public UC_orders()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
        }

        private void UC_orders_Load(object sender, EventArgs e)
        {

           connection.GetSqlConnection().Open();

            

            String str = "Select invodate, invono, cusname, contact, address, grandtotal From db_orders ";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_ordersDataGridView.DataSource = dt;

            connection.GetSqlConnection().Close();
      
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
           connection.GetSqlConnection().Open();

            

            String str = "Select invodate, invono, cusname, contact, address, grandtotal From db_orders ";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_ordersDataGridView.DataSource = dt;

            connection.GetSqlConnection().Close();

        }

        private void pcb_search_by_invoiceno_Click(object sender, EventArgs e)
        {
           connection.GetSqlConnection().Open();

            

            String str = "Select invodate, invono, cusname, contact, address, grandtotal From db_orders Where invono = '" + txt_invoiceno.Text + "'";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_ordersDataGridView.DataSource = dt;

            connection.GetSqlConnection().Close();
      
        }

        private void pcb_search_by_customer_name_Click(object sender, EventArgs e)
        {
           connection.GetSqlConnection().Open();

            

            String str = "Select invodate, invono, cusname, contact, address, grandtotal From db_orders Where cusname = '" + txt_customername.Text + "'";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_ordersDataGridView.DataSource = dt;

            connection.GetSqlConnection().Close();
      
        }

        private void txt_invoiceno_TextChanged(object sender, EventArgs e)
        {
            if (txt_invoiceno.Text == "")
            {

               connection.GetSqlConnection().Open();

                

                String str = "Select invodate, invono, cusname, contact, address, grandtotal From db_orders ";

                SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                db_ordersDataGridView.DataSource = dt;

                connection.GetSqlConnection().Close();
            }
  
        }

        private void txt_customername_TextChanged(object sender, EventArgs e)
        {

            if (txt_customername.Text == "")
            {

               connection.GetSqlConnection().Open();

                

                String str = "Select invodate, invono, cusname, contact, address, grandtotal From db_orders ";

                SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                db_ordersDataGridView.DataSource = dt;

                connection.GetSqlConnection().Close();
            }
        }

        private void db_ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_orders);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            connection.GetSqlConnection().Open();



            String str = "Select invodate, invono, cusname, contact, address, grandtotal From db_orders ";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_ordersDataGridView.DataSource = dt;

            connection.GetSqlConnection().Close();

        }
    }
}
