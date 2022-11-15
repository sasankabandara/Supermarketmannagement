namespace Supermarket_Management_System_In_csharp
{
    partial class UC_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_dashboard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lbl_total_amount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_user_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ds_orders = new Supermarket_Management_System_In_csharp.ds_orders();
            this.db_ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ordersTableAdapter = new Supermarket_Management_System_In_csharp.ds_ordersTableAdapters.db_ordersTableAdapter();
            this.tableAdapterManager = new Supermarket_Management_System_In_csharp.ds_ordersTableAdapters.TableAdapterManager();
            this.db_ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_customer_count = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_product_count = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_orders_count = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCircleProgress2 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.bunifuCircleProgress3 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.bunifuCircleProgress4 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.bunifuCircleProgress5 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_total_amount
            // 
            this.lbl_total_amount.AutoSize = true;
            this.lbl_total_amount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lbl_total_amount.Location = new System.Drawing.Point(808, 6);
            this.lbl_total_amount.Name = "lbl_total_amount";
            this.lbl_total_amount.Size = new System.Drawing.Size(48, 41);
            this.lbl_total_amount.TabIndex = 23;
            this.lbl_total_amount.Text = "00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lbl_total_amount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(737, 562);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 57);
            this.panel3.TabIndex = 26;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(18, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total Orders Amount";
            // 
            // lbl_user_count
            // 
            this.lbl_user_count.AutoSize = true;
            this.lbl_user_count.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_count.ForeColor = System.Drawing.Color.Black;
            this.lbl_user_count.Location = new System.Drawing.Point(808, 5);
            this.lbl_user_count.Name = "lbl_user_count";
            this.lbl_user_count.Size = new System.Drawing.Size(48, 41);
            this.lbl_user_count.TabIndex = 23;
            this.lbl_user_count.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total Sellers Count";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lbl_user_count);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(727, 224);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 59);
            this.panel5.TabIndex = 27;
            // 
            // ds_orders
            // 
            this.ds_orders.DataSetName = "ds_orders";
            this.ds_orders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_ordersBindingSource
            // 
            this.db_ordersBindingSource.DataMember = "db_orders";
            this.db_ordersBindingSource.DataSource = this.ds_orders;
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
            // db_ordersDataGridView
            // 
            this.db_ordersDataGridView.AutoGenerateColumns = false;
            this.db_ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.db_ordersDataGridView.DataSource = this.db_ordersBindingSource;
            this.db_ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.db_ordersDataGridView.Location = new System.Drawing.Point(0, 650);
            this.db_ordersDataGridView.Name = "db_ordersDataGridView";
            this.db_ordersDataGridView.RowHeadersWidth = 51;
            this.db_ordersDataGridView.RowTemplate.Height = 24;
            this.db_ordersDataGridView.Size = new System.Drawing.Size(1026, 10);
            this.db_ordersDataGridView.TabIndex = 31;
            this.db_ordersDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invodate";
            this.dataGridViewTextBoxColumn1.HeaderText = "invodate";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "invono";
            this.dataGridViewTextBoxColumn2.HeaderText = "invono";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cusid";
            this.dataGridViewTextBoxColumn3.HeaderText = "cusid";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cusname";
            this.dataGridViewTextBoxColumn4.HeaderText = "cusname";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contact";
            this.dataGridViewTextBoxColumn5.HeaderText = "contact";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "grandtotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "grandtotal";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
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
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Refresh";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges1;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bunifuButton2.IdleBorderRadius = 35;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(379, 410);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 35;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bunifuButton2.onHoverState.BorderRadius = 35;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bunifuButton2.OnIdleState.BorderRadius = 35;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 35;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(112)))), ((int)(((byte)(136)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(259, 63);
            this.bunifuButton2.TabIndex = 169;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // bunifuCircleProgress1
            // 
            this.bunifuCircleProgress1.Animated = true;
            this.bunifuCircleProgress1.AnimationInterval = 1;
            this.bunifuCircleProgress1.AnimationSpeed = 1;
            this.bunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.CircleMargin = 10;
            this.bunifuCircleProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress1.IsPercentage = false;
            this.bunifuCircleProgress1.LineProgressThickness = 10;
            this.bunifuCircleProgress1.LineThickness = 10;
            this.bunifuCircleProgress1.Location = new System.Drawing.Point(64, 34);
            this.bunifuCircleProgress1.Maximum = 1000;
            this.bunifuCircleProgress1.Name = "bunifuCircleProgress1";
            this.bunifuCircleProgress1.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress1.Size = new System.Drawing.Size(184, 184);
            this.bunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress1.SubScriptText = "";
            this.bunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress1.SuperScriptText = "";
            this.bunifuCircleProgress1.TabIndex = 16;
            this.bunifuCircleProgress1.Text = "0";
            this.bunifuCircleProgress1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress1.ValueByTransition = 0;
            this.bunifuCircleProgress1.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total Customer Count";
            // 
            // lbl_customer_count
            // 
            this.lbl_customer_count.AutoSize = true;
            this.lbl_customer_count.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_count.ForeColor = System.Drawing.Color.Black;
            this.lbl_customer_count.Location = new System.Drawing.Point(808, 6);
            this.lbl_customer_count.Name = "lbl_customer_count";
            this.lbl_customer_count.Size = new System.Drawing.Size(48, 41);
            this.lbl_customer_count.TabIndex = 23;
            this.lbl_customer_count.Text = "00";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.lbl_customer_count);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(379, 224);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 55);
            this.panel7.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.label14.Location = new System.Drawing.Point(27, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = "Total Product Count";
            // 
            // lbl_product_count
            // 
            this.lbl_product_count.AutoSize = true;
            this.lbl_product_count.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lbl_product_count.Location = new System.Drawing.Point(808, 6);
            this.lbl_product_count.Name = "lbl_product_count";
            this.lbl_product_count.Size = new System.Drawing.Size(48, 41);
            this.lbl_product_count.TabIndex = 23;
            this.lbl_product_count.Text = "00";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.lbl_product_count);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(32, 563);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(260, 56);
            this.panel9.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Orders Count";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_orders_count
            // 
            this.lbl_orders_count.AutoSize = true;
            this.lbl_orders_count.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders_count.ForeColor = System.Drawing.Color.Black;
            this.lbl_orders_count.Location = new System.Drawing.Point(808, 3);
            this.lbl_orders_count.Name = "lbl_orders_count";
            this.lbl_orders_count.Size = new System.Drawing.Size(48, 41);
            this.lbl_orders_count.TabIndex = 23;
            this.lbl_orders_count.Text = "00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_orders_count);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 52);
            this.panel1.TabIndex = 25;
            // 
            // bunifuCircleProgress2
            // 
            this.bunifuCircleProgress2.Animated = true;
            this.bunifuCircleProgress2.AnimationInterval = 1;
            this.bunifuCircleProgress2.AnimationSpeed = 1;
            this.bunifuCircleProgress2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress2.CircleMargin = 10;
            this.bunifuCircleProgress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress2.IsPercentage = false;
            this.bunifuCircleProgress2.LineProgressThickness = 10;
            this.bunifuCircleProgress2.LineThickness = 10;
            this.bunifuCircleProgress2.Location = new System.Drawing.Point(64, 373);
            this.bunifuCircleProgress2.Maximum = 1000;
            this.bunifuCircleProgress2.Name = "bunifuCircleProgress2";
            this.bunifuCircleProgress2.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress2.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress2.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress2.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress2.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress2.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress2.Size = new System.Drawing.Size(184, 184);
            this.bunifuCircleProgress2.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress2.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress2.SubScriptText = "";
            this.bunifuCircleProgress2.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress2.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress2.SuperScriptText = "";
            this.bunifuCircleProgress2.TabIndex = 170;
            this.bunifuCircleProgress2.Text = "30";
            this.bunifuCircleProgress2.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress2.Value = 30;
            this.bunifuCircleProgress2.ValueByTransition = 30;
            this.bunifuCircleProgress2.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // bunifuCircleProgress3
            // 
            this.bunifuCircleProgress3.Animated = true;
            this.bunifuCircleProgress3.AnimationInterval = 1;
            this.bunifuCircleProgress3.AnimationSpeed = 1;
            this.bunifuCircleProgress3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress3.CircleMargin = 10;
            this.bunifuCircleProgress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress3.IsPercentage = false;
            this.bunifuCircleProgress3.LineProgressThickness = 10;
            this.bunifuCircleProgress3.LineThickness = 10;
            this.bunifuCircleProgress3.Location = new System.Drawing.Point(422, 34);
            this.bunifuCircleProgress3.Maximum = 1000;
            this.bunifuCircleProgress3.Name = "bunifuCircleProgress3";
            this.bunifuCircleProgress3.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress3.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress3.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress3.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress3.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress3.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress3.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress3.Size = new System.Drawing.Size(184, 184);
            this.bunifuCircleProgress3.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress3.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress3.SubScriptText = "";
            this.bunifuCircleProgress3.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress3.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress3.SuperScriptText = "";
            this.bunifuCircleProgress3.TabIndex = 171;
            this.bunifuCircleProgress3.Text = "30";
            this.bunifuCircleProgress3.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress3.Value = 30;
            this.bunifuCircleProgress3.ValueByTransition = 30;
            this.bunifuCircleProgress3.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress3.ProgressChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs>(this.bunifuCircleProgress3_ProgressChanged);
            // 
            // bunifuCircleProgress4
            // 
            this.bunifuCircleProgress4.Animated = true;
            this.bunifuCircleProgress4.AnimationInterval = 1;
            this.bunifuCircleProgress4.AnimationSpeed = 1;
            this.bunifuCircleProgress4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress4.CircleMargin = 10;
            this.bunifuCircleProgress4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress4.IsPercentage = false;
            this.bunifuCircleProgress4.LineProgressThickness = 10;
            this.bunifuCircleProgress4.LineThickness = 10;
            this.bunifuCircleProgress4.Location = new System.Drawing.Point(770, 34);
            this.bunifuCircleProgress4.Maximum = 1000;
            this.bunifuCircleProgress4.Name = "bunifuCircleProgress4";
            this.bunifuCircleProgress4.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress4.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress4.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress4.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress4.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress4.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress4.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress4.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress4.Size = new System.Drawing.Size(184, 184);
            this.bunifuCircleProgress4.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress4.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress4.SubScriptText = "";
            this.bunifuCircleProgress4.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress4.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress4.SuperScriptText = "";
            this.bunifuCircleProgress4.TabIndex = 172;
            this.bunifuCircleProgress4.Text = "30";
            this.bunifuCircleProgress4.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress4.Value = 30;
            this.bunifuCircleProgress4.ValueByTransition = 30;
            this.bunifuCircleProgress4.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress4.ProgressChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs>(this.bunifuCircleProgress4_ProgressChanged);
            // 
            // bunifuCircleProgress5
            // 
            this.bunifuCircleProgress5.Animated = true;
            this.bunifuCircleProgress5.AnimationInterval = 1;
            this.bunifuCircleProgress5.AnimationSpeed = 1;
            this.bunifuCircleProgress5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress5.CircleMargin = 10;
            this.bunifuCircleProgress5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress5.IsPercentage = false;
            this.bunifuCircleProgress5.LineProgressThickness = 10;
            this.bunifuCircleProgress5.LineThickness = 10;
            this.bunifuCircleProgress5.Location = new System.Drawing.Point(770, 373);
            this.bunifuCircleProgress5.Maximum = 100000;
            this.bunifuCircleProgress5.Name = "bunifuCircleProgress5";
            this.bunifuCircleProgress5.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress5.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress5.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress5.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress5.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress5.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress5.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress5.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress5.Size = new System.Drawing.Size(184, 184);
            this.bunifuCircleProgress5.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress5.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress5.SubScriptText = "";
            this.bunifuCircleProgress5.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress5.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress5.SuperScriptText = "";
            this.bunifuCircleProgress5.TabIndex = 173;
            this.bunifuCircleProgress5.Text = "30";
            this.bunifuCircleProgress5.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress5.Value = 30;
            this.bunifuCircleProgress5.ValueByTransition = 30;
            this.bunifuCircleProgress5.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress5.ProgressChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs>(this.bunifuCircleProgress5_ProgressChanged);
            // 
            // UC_dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCircleProgress5);
            this.Controls.Add(this.bunifuCircleProgress4);
            this.Controls.Add(this.bunifuCircleProgress3);
            this.Controls.Add(this.bunifuCircleProgress2);
            this.Controls.Add(this.bunifuCircleProgress1);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.db_ordersDataGridView);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Name = "UC_dashboard";
            this.Size = new System.Drawing.Size(1026, 660);
            this.Load += new System.EventHandler(this.UC_dashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_total_amount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_user_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_customer_count;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_product_count;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_orders_count;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress2;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress3;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress4;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress5;
    }
}
