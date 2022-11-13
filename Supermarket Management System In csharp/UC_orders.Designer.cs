namespace Supermarket_Management_System_In_csharp
{
    partial class UC_orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_orders));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcb_search_by_customer_name = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcb_search_by_invoiceno = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_orders = new Supermarket_Management_System_In_csharp.ds_orders();
            this.db_ordersTableAdapter = new Supermarket_Management_System_In_csharp.ds_ordersTableAdapters.db_ordersTableAdapter();
            this.tableAdapterManager = new Supermarket_Management_System_In_csharp.ds_ordersTableAdapters.TableAdapterManager();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuButton1);
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Location = new System.Drawing.Point(807, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 100);
            this.panel4.TabIndex = 12;
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
            this.bunifuButton1.ButtonText = "Refresh";
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
            this.bunifuButton1.Location = new System.Drawing.Point(14, 25);
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
            this.bunifuButton1.Size = new System.Drawing.Size(200, 50);
            this.bunifuButton1.TabIndex = 175;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.BackColor = System.Drawing.Color.Purple;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(14, 25);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(200, 50);
            this.btn_refresh.TabIndex = 139;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(24, 42);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(304, 45);
            this.txt_customername.TabIndex = 48;
            this.txt_customername.TextChanged += new System.EventHandler(this.txt_customername_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "Customer Name :";
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(17, 42);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(304, 45);
            this.txt_invoiceno.TabIndex = 47;
            this.txt_invoiceno.TextChanged += new System.EventHandler(this.txt_invoiceno_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pcb_search_by_customer_name);
            this.panel2.Controls.Add(this.txt_customername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(405, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 100);
            this.panel2.TabIndex = 11;
            // 
            // pcb_search_by_customer_name
            // 
            this.pcb_search_by_customer_name.Image = global::Supermarket_Management_System_In_csharp.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_customer_name.Location = new System.Drawing.Point(346, 42);
            this.pcb_search_by_customer_name.Name = "pcb_search_by_customer_name";
            this.pcb_search_by_customer_name.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_customer_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_customer_name.TabIndex = 138;
            this.pcb_search_by_customer_name.TabStop = false;
            this.pcb_search_by_customer_name.Click += new System.EventHandler(this.pcb_search_by_customer_name_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 46;
            this.label2.Text = "Invoice No. :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcb_search_by_invoiceno);
            this.panel1.Controls.Add(this.txt_invoiceno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 100);
            this.panel1.TabIndex = 10;
            // 
            // pcb_search_by_invoiceno
            // 
            this.pcb_search_by_invoiceno.Image = global::Supermarket_Management_System_In_csharp.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_invoiceno.Location = new System.Drawing.Point(336, 42);
            this.pcb_search_by_invoiceno.Name = "pcb_search_by_invoiceno";
            this.pcb_search_by_invoiceno.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_invoiceno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_invoiceno.TabIndex = 138;
            this.pcb_search_by_invoiceno.TabStop = false;
            this.pcb_search_by_invoiceno.Click += new System.EventHandler(this.pcb_search_by_invoiceno_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.db_ordersDataGridView);
            this.panel3.Location = new System.Drawing.Point(3, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 531);
            this.panel3.TabIndex = 9;
            // 
            // db_ordersDataGridView
            // 
            this.db_ordersDataGridView.AllowUserToAddRows = false;
            this.db_ordersDataGridView.AutoGenerateColumns = false;
            this.db_ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_ordersDataGridView.ColumnHeadersHeight = 35;
            this.db_ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.db_ordersDataGridView.DataSource = this.db_ordersBindingSource;
            this.db_ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_ordersDataGridView.EnableHeadersVisualStyles = false;
            this.db_ordersDataGridView.GridColor = System.Drawing.Color.White;
            this.db_ordersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_ordersDataGridView.Name = "db_ordersDataGridView";
            this.db_ordersDataGridView.RowHeadersVisible = false;
            this.db_ordersDataGridView.RowHeadersWidth = 51;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_ordersDataGridView.RowTemplate.Height = 30;
            this.db_ordersDataGridView.Size = new System.Drawing.Size(1032, 531);
            this.db_ordersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invodate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "invono";
            this.dataGridViewTextBoxColumn2.HeaderText = "Invoice No.";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cusid";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cusname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contact";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "grandtotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "Grand Total";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // db_ordersBindingSource
            // 
            this.db_ordersBindingSource.DataMember = "db_orders";
            this.db_ordersBindingSource.DataSource = this.ds_orders;
            // 
            // ds_orders
            // 
            this.ds_orders.DataSetName = "ds_orders";
            this.ds_orders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_ordersTableAdapter
            // 
            this.db_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_ordersTableAdapter = this.db_ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Supermarket_Management_System_In_csharp.ds_ordersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UC_orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "UC_orders";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.UC_orders_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_search_by_customer_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.PictureBox pcb_search_by_invoiceno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private ds_orders ds_orders;
        private System.Windows.Forms.BindingSource db_ordersBindingSource;
        private ds_ordersTableAdapters.db_ordersTableAdapter db_ordersTableAdapter;
        private ds_ordersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}
