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
    public partial class UC_Stocker_Keepers : UserControl
    {
        public static string invoiceid;
        private DatabaseConnection connection;
        public UC_Stocker_Keepers()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
        }

        private void db_userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_user);

        }

        private void UC_Stocker_Keepers_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void showdata()
        {
            connection.GetSqlConnection().Open();



            String str = "Select * From db_stock_keeper";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_userDataGridView.DataSource = dt;

            connection.GetSqlConnection().Close();
        }

        private void pcb_serchbyname_Click(object sender, EventArgs e)
        {
            connection.GetSqlConnection().Open();



            String str = "select sk_name, sk_password from db_stock_keeper where sk_name = '" + txt_Username.Text + "';";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_Username.Text = dr.GetValue(0).ToString();
                txt_password.Text = dr.GetValue(1).ToString();
            }

            connection.GetSqlConnection().Close();

        }

        private void clear()
        {
            txt_password.Clear();
            txt_Username.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


            try
            {
                if (txt_Username.Text == "" || txt_password.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    connection.GetSqlConnection().Open();



                    String str = "insert into db_stock_keeper (sk_name, sk_password) values ('" + txt_Username.Text +  "', '" + txt_password.Text + "');";

                    SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(sk_name) From db_stock_keeper;";

                    SqlCommand cmd2 = new SqlCommand(str2, connection.GetSqlConnection());

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        connection.GetSqlConnection().Close();
                        showdata();
                        connection.GetSqlConnection().Open();

                        MessageBox.Show("User Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        connection.GetSqlConnection().Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Username.Text == "" || txt_password.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    connection.GetSqlConnection().Open();


                    String str = "update db_stock_keeper set sk_name = '" + txt_Username.Text + "', sk_password = '" + txt_password.Text + "' where sk_name = '" + txt_Username.Text + "';";

                    SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(sk_name) From db_stock_keeper;";

                    SqlCommand cmd2 = new SqlCommand(str2, connection.GetSqlConnection());

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        connection.GetSqlConnection().Close();
                        showdata();
                        connection.GetSqlConnection().Open();

                        MessageBox.Show("User Updated Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        connection.GetSqlConnection().Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "" || txt_password.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    connection.GetSqlConnection().Open();



                    String str = "Delete From db_stock_keeper Where sk_name = '" + txt_Username.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                    cmd.ExecuteNonQuery();

                    connection.GetSqlConnection().Close();
                    showdata();
                    connection.GetSqlConnection().Open();

                    MessageBox.Show("User Delete Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();

                    connection.GetSqlConnection().Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_mobailno_TextChanged(object sender, EventArgs e)
        {

        }

        private void db_userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
