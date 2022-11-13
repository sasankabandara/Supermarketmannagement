namespace Supermarket_Management_System_In_csharp
{
    partial class frmlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.cbshowpassword = new System.Windows.Forms.CheckBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_adminlogin = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_userlogin = new System.Windows.Forms.Label();
            this.btn_login_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbshowpassword
            // 
            this.cbshowpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbshowpassword.AutoSize = true;
            this.cbshowpassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbshowpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.cbshowpassword.Location = new System.Drawing.Point(842, 392);
            this.cbshowpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbshowpassword.Name = "cbshowpassword";
            this.cbshowpassword.Size = new System.Drawing.Size(178, 31);
            this.cbshowpassword.TabIndex = 64;
            this.cbshowpassword.Text = "Show Password";
            this.cbshowpassword.UseVisualStyleBackColor = true;
            this.cbshowpassword.CheckedChanged += new System.EventHandler(this.cbshowpassword_CheckedChanged);
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.Location = new System.Drawing.Point(625, 255);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(395, 45);
            this.txt_Username.TabIndex = 0;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(477, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(458, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 60;
            this.label2.Text = "User Name :";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(625, 433);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(185, 50);
            this.btn_login.TabIndex = 63;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(625, 343);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(395, 45);
            this.txt_Password.TabIndex = 61;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(835, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 50);
            this.button1.TabIndex = 65;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(539, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 41);
            this.label1.TabIndex = 66;
            this.label1.Text = "KYC Supermarket Management System ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 735);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 44);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_adminlogin
            // 
            this.lbl_adminlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_adminlogin.AutoSize = true;
            this.lbl_adminlogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_adminlogin.Location = new System.Drawing.Point(753, 515);
            this.lbl_adminlogin.Name = "lbl_adminlogin";
            this.lbl_adminlogin.Size = new System.Drawing.Size(148, 27);
            this.lbl_adminlogin.TabIndex = 71;
            this.lbl_adminlogin.Text = "Admin login";
            this.lbl_adminlogin.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_admin
            // 
            this.lbl_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_admin.Location = new System.Drawing.Point(431, 263);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(173, 27);
            this.lbl_admin.TabIndex = 72;
            this.lbl_admin.Text = "Admin Name :";
            // 
            // lbl_userlogin
            // 
            this.lbl_userlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_userlogin.AutoSize = true;
            this.lbl_userlogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_userlogin.Location = new System.Drawing.Point(769, 515);
            this.lbl_userlogin.Name = "lbl_userlogin";
            this.lbl_userlogin.Size = new System.Drawing.Size(121, 27);
            this.lbl_userlogin.TabIndex = 73;
            this.lbl_userlogin.Text = "User login";
            this.lbl_userlogin.Click += new System.EventHandler(this.lbl_userlogin_Click);
            // 
            // btn_login_2
            // 
            this.btn_login_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btn_login_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_2.ForeColor = System.Drawing.Color.White;
            this.btn_login_2.Location = new System.Drawing.Point(625, 433);
            this.btn_login_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login_2.Name = "btn_login_2";
            this.btn_login_2.Size = new System.Drawing.Size(185, 50);
            this.btn_login_2.TabIndex = 74;
            this.btn_login_2.Text = "Log in";
            this.btn_login_2.UseVisualStyleBackColor = false;
            this.btn_login_2.Click += new System.EventHandler(this.btn_login_2_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 735);
            this.Controls.Add(this.btn_login_2);
            this.Controls.Add(this.lbl_userlogin);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_adminlogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbshowpassword);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbshowpassword;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_adminlogin;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_userlogin;
        private System.Windows.Forms.Button btn_login_2;
    }
}