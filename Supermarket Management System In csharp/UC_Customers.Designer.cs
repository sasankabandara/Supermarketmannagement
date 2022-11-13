namespace Supermarket_Management_System_In_csharp
{
    partial class UC_Customers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_customers = new Supermarket_Management_System_In_csharp.ds_customers();
            this.pcb_search = new System.Windows.Forms.PictureBox();
            this.pcb_search1 = new System.Windows.Forms.PictureBox();
            this.db_customersTableAdapter = new Supermarket_Management_System_In_csharp.ds_customersTableAdapters.db_customersTableAdapter();
            this.tableAdapterManager = new Supermarket_Management_System_In_csharp.ds_customersTableAdapters.TableAdapterManager();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.Purple;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(853, 143);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(154, 50);
            this.btn_remove.TabIndex = 135;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.BackColor = System.Drawing.Color.Purple;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(853, 87);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(154, 50);
            this.btn_edit.TabIndex = 132;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.Purple;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(853, 31);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(154, 50);
            this.btn_save.TabIndex = 131;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contact.BackColor = System.Drawing.Color.White;
            this.txt_contact.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.ForeColor = System.Drawing.Color.Black;
            this.txt_contact.Location = new System.Drawing.Point(486, 53);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(341, 45);
            this.txt_contact.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(468, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 127;
            this.label1.Text = "Address :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(468, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 128;
            this.label4.Text = "Contact :";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_address.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(486, 146);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(341, 45);
            this.txt_address.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(32, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 27);
            this.label3.TabIndex = 123;
            this.label3.Text = "Customer Name :";
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(50, 146);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(341, 45);
            this.txt_customername.TabIndex = 125;
            this.txt_customername.TextChanged += new System.EventHandler(this.txt_customername_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 124;
            this.label2.Text = "Customer ID :";
            // 
            // txt_customerid
            // 
            this.txt_customerid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customerid.BackColor = System.Drawing.Color.White;
            this.txt_customerid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerid.ForeColor = System.Drawing.Color.Black;
            this.txt_customerid.Location = new System.Drawing.Point(50, 53);
            this.txt_customerid.Multiline = true;
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(341, 45);
            this.txt_customerid.TabIndex = 126;
            this.txt_customerid.TextChanged += new System.EventHandler(this.txt_customerid_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.db_customersDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 447);
            this.panel1.TabIndex = 122;
            // 
            // db_customersDataGridView
            // 
            this.db_customersDataGridView.AllowUserToAddRows = false;
            this.db_customersDataGridView.AutoGenerateColumns = false;
            this.db_customersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_customersDataGridView.ColumnHeadersHeight = 40;
            this.db_customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.db_customersDataGridView.DataSource = this.db_customersBindingSource;
            this.db_customersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_customersDataGridView.EnableHeadersVisualStyles = false;
            this.db_customersDataGridView.GridColor = System.Drawing.Color.White;
            this.db_customersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_customersDataGridView.Name = "db_customersDataGridView";
            this.db_customersDataGridView.RowHeadersVisible = false;
            this.db_customersDataGridView.RowHeadersWidth = 51;
            this.db_customersDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_customersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_customersDataGridView.RowTemplate.Height = 30;
            this.db_customersDataGridView.Size = new System.Drawing.Size(1032, 447);
            this.db_customersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cusid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cusname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cuscontact";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cusaddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // db_customersBindingSource
            // 
            this.db_customersBindingSource.DataMember = "db_customers";
            this.db_customersBindingSource.DataSource = this.ds_customers;
            // 
            // ds_customers
            // 
            this.ds_customers.DataSetName = "ds_customers";
            this.ds_customers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcb_search
            // 
            this.pcb_search.Image = global::Supermarket_Management_System_In_csharp.Properties.Resources.icons8_search_48px_1;
            this.pcb_search.Location = new System.Drawing.Point(403, 53);
            this.pcb_search.Name = "pcb_search";
            this.pcb_search.Size = new System.Drawing.Size(45, 45);
            this.pcb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search.TabIndex = 134;
            this.pcb_search.TabStop = false;
            this.pcb_search.Click += new System.EventHandler(this.pcb_search_Click);
            // 
            // pcb_search1
            // 
            this.pcb_search1.Image = global::Supermarket_Management_System_In_csharp.Properties.Resources.icons8_search_48px_1;
            this.pcb_search1.Location = new System.Drawing.Point(403, 146);
            this.pcb_search1.Name = "pcb_search1";
            this.pcb_search1.Size = new System.Drawing.Size(45, 45);
            this.pcb_search1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search1.TabIndex = 133;
            this.pcb_search1.TabStop = false;
            this.pcb_search1.Click += new System.EventHandler(this.pcb_search1_Click);
            // 
            // db_customersTableAdapter
            // 
            this.db_customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_customersTableAdapter = this.db_customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Supermarket_Management_System_In_csharp.ds_customersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Save";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 35;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(844, 31);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 35;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 35;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 35;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 35;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(174, 50);
            this.bunifuButton1.TabIndex = 174;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Edit";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges2;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleBorderRadius = 35;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(844, 87);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 35;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.BorderRadius = 35;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.BorderRadius = 35;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 35;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(174, 50);
            this.bunifuButton2.TabIndex = 175;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowAnimations = true;
            this.bunifuButton3.AllowMouseEffects = true;
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.AutoRoundBorders = false;
            this.bunifuButton3.AutoSizeLeftIcon = true;
            this.bunifuButton3.AutoSizeRightIcon = true;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.ButtonText = "Remove";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges3;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton3.IconSize = 25;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.IdleBorderRadius = 35;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(844, 141);
            this.bunifuButton3.Name = "bunifuButton3";
            this.bunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.OnDisabledState.BorderRadius = 35;
            this.bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnDisabledState.BorderThickness = 1;
            this.bunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.OnDisabledState.IconLeftImage = null;
            this.bunifuButton3.OnDisabledState.IconRightImage = null;
            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton3.onHoverState.BorderRadius = 35;
            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.onHoverState.BorderThickness = 1;
            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.onHoverState.IconLeftImage = null;
            this.bunifuButton3.onHoverState.IconRightImage = null;
            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.OnIdleState.BorderRadius = 35;
            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnIdleState.BorderThickness = 1;
            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnIdleState.IconLeftImage = null;
            this.bunifuButton3.OnIdleState.IconRightImage = null;
            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.BorderRadius = 35;
            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnPressedState.BorderThickness = 1;
            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnPressedState.IconLeftImage = null;
            this.bunifuButton3.OnPressedState.IconRightImage = null;
            this.bunifuButton3.Size = new System.Drawing.Size(174, 50);
            this.bunifuButton3.TabIndex = 176;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            // 
            // UC_Customers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.pcb_search);
            this.Controls.Add(this.pcb_search1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.UC_Customers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.PictureBox pcb_search;
        private System.Windows.Forms.PictureBox pcb_search1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.Panel panel1;
        private ds_customers ds_customers;
        private System.Windows.Forms.BindingSource db_customersBindingSource;
        private ds_customersTableAdapters.db_customersTableAdapter db_customersTableAdapter;
        private ds_customersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
    }
}
