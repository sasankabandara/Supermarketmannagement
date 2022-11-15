using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket_Management_System_In_csharp
{
    public partial class frmlogin : Form
    {
        public static string invoiceid;
        private DatabaseConnection connection;

        SqlConnection con;

        SqlCommand cmd = new SqlCommand();

        DataTable dt = new DataTable();

        public frmlogin()
        {
            InitializeComponent();
            con = new DatabaseConnection().GetSqlConnection();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
            btn_login_2.Visible = false;
            label5.Visible = false;
            button2.Visible = false;
            lbl_admin.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    con.Open();

                    cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "Select * From db_user Where username = '" + txt_Username.Text + "' and upassword = '" + txt_Password.Text + "'";

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        this.Hide();
                        frmHome fh = new frmHome();
                        fh.btn_sellers.Visible = false;
                        fh.button1.Visible = false;
                        fh.pictureBox6.Visible = false;
                        fh.pictureBox7.Visible = false;
                        fh.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
     
        }

        private void label6_Click(object sender, EventArgs e)
        {
            lbl_admin.Visible = true;
            btn_login_2.Visible = true;
            label5.Visible = false;
            button2.Visible = false;
            btn_login.Visible = false;
        }

        private void lbl_userlogin_Click(object sender, EventArgs e)
        {

            lbl_admin.Visible = false;
            btn_login_2.Visible = false;
            btn_login.Visible = true;
            label5.Visible = false;
            label5.Visible = false;
            label2.Visible = true;
            button2.Visible = false;
        }

        private void btn_login_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "admin" || txt_Password.Text == "admin")
                {
                    this.Hide();
                    frmHome fh = new frmHome();
                    fh.btn_billing.Visible = false;
                    fh.ShowDialog();
                 
                }
                else
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            lbl_admin.Visible = false;
            label2.Visible=false;
            btn_login_2.Visible = false;
            btn_login.Visible = false;
            label5.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string inp_name = txt_Username.Text;
                string inp_password = txt_Password.Text;
                string query = "select * from db_stock_keeper where sk_name = '" + inp_name + "' and sk_password = '" + inp_password + "';";
                string sk_name = string.Empty;
                string sk_password = string.Empty;
                
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    sk_name = reader.GetValue(1).ToString();
                    sk_password = reader.GetValue(2).ToString();
                }
                con.Close();
                if (txt_Username.Text == sk_name && txt_Password.Text == sk_password)
                {
                    this.Hide();
                    frmHome fh = new frmHome();
                    fh.btn_billing.Visible = false;
                    fh.btn_Orders.Visible = false;
                    fh.btn_sellers.Visible = false;
                    fh.pictureBox6.Visible = false;
                    fh.button1.Visible = false;
                    fh.pictureBox7.Visible = false;
                    fh.pictureBox5.Visible = false;
                    fh.pictureBox4.Visible = false;
                    fh.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
