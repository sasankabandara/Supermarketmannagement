﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Supermarket_Management_System_In_csharp
{
    public partial class UC_products : UserControl
    {
        public static string invoiceid;
        private DatabaseConnection connection;
        public UC_products()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txt_productid.Text = "" + GetUniqueKey(5);
        }


        private void UC_products_Load(object sender, EventArgs e)
        {
            loadcategory();
            auto();
            showdata();
        }

        public void loadcategory()
        {
            try
            {
                connection.GetSqlConnection().Open();



                String str = "Select catname From db_categories";

                SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txt_categoriename.Items.Add(dr["catname"].ToString());
                }
                connection.GetSqlConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.GetSqlConnection().Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_productid.Text == "" || txt_productname.Text == "" || txt_productquantity.Text == "" || txt_productprice.Text == "" || txt_description.Text == "" || txt_categoriename.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    connection.GetSqlConnection().Open();



                    String str = "Insert Into db_product (proid,proname,proqut,proprice,prodesc,procategorie)Values('" + txt_productid.Text + "','" + txt_productname.Text + "','" + txt_productquantity.Text + "','" + txt_productprice.Text + "','" + txt_description.Text + "','" + txt_categoriename.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                    cmd.ExecuteNonQuery();

                    connection.GetSqlConnection().Close();
                    connection.GetSqlConnection().Open();

                    String str2 = "Select max(proid) From db_product";

                    SqlCommand cmd2 = new SqlCommand(str2, connection.GetSqlConnection());

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        connection.GetSqlConnection().Close();
                        showdata();
                        connection.GetSqlConnection().Open();

                        MessageBox.Show("Product Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        auto();

                        connection.GetSqlConnection().Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.GetSqlConnection().Close();
            }
        }

        private void clear()
        {
            txt_categoriename.Text = "";
            txt_description.Clear();
            txt_productid.Clear();
            txt_productname.Clear();
            txt_productprice.Clear();
            txt_productquantity.Clear();
        }

        private void showdata()
        {
            connection.GetSqlConnection().Open();

            

            String str = "Select * From db_product";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_productDataGridView.DataSource = dt;

            connection.GetSqlConnection().Close();
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_productid.Text == "" || txt_productname.Text == "" || txt_productquantity.Text == "" || txt_productprice.Text == "" || txt_description.Text == "" || txt_categoriename.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    connection.GetSqlConnection().Open();

                    

                    String str = "Update db_product Set proname = '" + txt_productname.Text + "' ,proqut = '" + txt_productquantity.Text + "',proprice = '" + txt_productprice.Text + "',prodesc = '" + txt_description.Text + "',procategorie = '" + txt_categoriename.Text + "' Where proid = '" + txt_productid.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(proid) From db_product";

                    SqlCommand cmd2 = new SqlCommand(str2, connection.GetSqlConnection());

                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        connection.GetSqlConnection().Close(); 
                        showdata();
                        connection.GetSqlConnection().Open();

                        MessageBox.Show("Product Updated Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        auto();

                        connection.GetSqlConnection().Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.GetSqlConnection().Close();
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_productid.Text == "" || txt_productname.Text == "" || txt_productquantity.Text == "" || txt_productprice.Text == "" || txt_description.Text == "" || txt_categoriename.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    connection.GetSqlConnection().Open();

                    

                    String str = "Delete From db_product Where proid = '" + txt_productid.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

                    cmd.ExecuteNonQuery();

                    connection.GetSqlConnection().Close();
                    showdata();
                    connection.GetSqlConnection().Open();

                    MessageBox.Show("User Delete Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    auto();

                    connection.GetSqlConnection().Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.GetSqlConnection().Close();
            }

        }

        private void pcb_search_Click(object sender, EventArgs e)
        {
            connection.GetSqlConnection().Open();

            

            String str = "Select proid,proname,proqut,proprice,prodesc,procategorie From db_product Where proid = '" + txt_productid.Text + "'";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_productid.Text = dr.GetValue(0).ToString();
                txt_productname.Text = dr.GetValue(1).ToString();
                txt_productquantity.Text = dr.GetValue(2).ToString();
                txt_productprice.Text = dr.GetValue(3).ToString();
                txt_description.Text = dr.GetValue(4).ToString();
                txt_categoriename.Text = dr.GetValue(5).ToString();
            }

            connection.GetSqlConnection().Close();
        
        }

        private void pcb_search1_Click(object sender, EventArgs e)
        {

            connection.GetSqlConnection().Open();

            

            String str = "Select proid,proname,proqut,proprice,prodesc,procategorie From db_product Where proname = '" + txt_productname.Text + "'";

            SqlCommand cmd = new SqlCommand(str, connection.GetSqlConnection());

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_productid.Text = dr.GetValue(0).ToString();
                txt_productname.Text = dr.GetValue(1).ToString();
                txt_productquantity.Text = dr.GetValue(2).ToString();
                txt_productprice.Text = dr.GetValue(3).ToString();
                txt_description.Text = dr.GetValue(4).ToString();
                txt_categoriename.Text = dr.GetValue(5).ToString();
            }

            connection.GetSqlConnection().Close();
      
        }

        private void db_productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_product);

        }

        private void txt_categoriename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_productquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_productid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
