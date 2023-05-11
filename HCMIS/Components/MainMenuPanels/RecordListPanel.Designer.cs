namespace HCMIS.Components
{
    partial class RecordListPanel 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloadButton = new System.Windows.Forms.Button();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.bloodPressureLabel = new System.Windows.Forms.Label();
            this.maritalStatusLabel = new System.Windows.Forms.Label();
            this.bloodTypeLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.filterFullnameTextbox = new HCMIS.Components.CustomTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterAssignedWorkerTextbox = new HCMIS.Components.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.remarksLabel = new System.Windows.Forms.Label();
            this.deferredLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableGrid
            // 
            this.tableGrid.AllowUserToAddRows = false;
            this.tableGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tableGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tableGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tableGrid.ColumnHeadersHeight = 50;
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Fullname,
            this.Date,
            this.Time,
            this.AssignedWorker,
            this.Reason});
            this.tableGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableGrid.DefaultCellStyle = dataGridViewCellStyle20;
            this.tableGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.tableGrid.Location = new System.Drawing.Point(13, 47);
            this.tableGrid.MultiSelect = false;
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.tableGrid.RowHeadersVisible = false;
            this.tableGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.tableGrid.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.tableGrid.RowTemplate.Height = 25;
            this.tableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableGrid.Size = new System.Drawing.Size(560, 569);
            this.tableGrid.TabIndex = 1;
            this.tableGrid.TabStop = false;
            this.tableGrid.SelectionChanged += new System.EventHandler(this.tableGrid_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle14;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Patient ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.Fullname.DefaultCellStyle = dataGridViewCellStyle15;
            this.Fullname.FillWeight = 175F;
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.MinimumWidth = 175;
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.Date.DefaultCellStyle = dataGridViewCellStyle16;
            this.Date.FillWeight = 85F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 85;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 85;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.Time.DefaultCellStyle = dataGridViewCellStyle17;
            this.Time.FillWeight = 80F;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 80;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.Width = 80;
            // 
            // AssignedWorker
            // 
            this.AssignedWorker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.AssignedWorker.DefaultCellStyle = dataGridViewCellStyle18;
            this.AssignedWorker.HeaderText = "Assigned Worker";
            this.AssignedWorker.MinimumWidth = 100;
            this.AssignedWorker.Name = "AssignedWorker";
            this.AssignedWorker.ReadOnly = true;
            this.AssignedWorker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Reason
            // 
            this.Reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.Reason.DefaultCellStyle = dataGridViewCellStyle19;
            this.Reason.HeaderText = "Reason";
            this.Reason.MinimumWidth = 100;
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadButton.FlatAppearance.BorderSize = 0;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reloadButton.ForeColor = System.Drawing.Color.White;
            this.reloadButton.Location = new System.Drawing.Point(914, 622);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(100, 40);
            this.reloadButton.TabIndex = 12;
            this.reloadButton.TabStop = false;
            this.reloadButton.Text = "RELOAD";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadDataButton_Click);
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.reasonLabel, 3);
            this.reasonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reasonLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reasonLabel.Location = new System.Drawing.Point(3, 252);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(429, 31);
            this.reasonLabel.TabIndex = 46;
            this.reasonLabel.Text = "Reason:";
            this.reasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoEllipsis = true;
            this.bmiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmiLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bmiLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bmiLabel.Location = new System.Drawing.Point(293, 196);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(139, 28);
            this.bmiLabel.TabIndex = 45;
            this.bmiLabel.Text = "BMI:";
            this.bmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoEllipsis = true;
            this.heightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.heightLabel.Location = new System.Drawing.Point(148, 196);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(139, 28);
            this.heightLabel.TabIndex = 44;
            this.heightLabel.Text = "Height (ft):";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoEllipsis = true;
            this.weightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.weightLabel.Location = new System.Drawing.Point(3, 196);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(139, 28);
            this.weightLabel.TabIndex = 43;
            this.weightLabel.Text = "Weight (kg):";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bloodPressureLabel
            // 
            this.bloodPressureLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.bloodPressureLabel, 3);
            this.bloodPressureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodPressureLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodPressureLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bloodPressureLabel.Location = new System.Drawing.Point(3, 168);
            this.bloodPressureLabel.Name = "bloodPressureLabel";
            this.bloodPressureLabel.Size = new System.Drawing.Size(429, 28);
            this.bloodPressureLabel.TabIndex = 42;
            this.bloodPressureLabel.Text = "Blood Pressure:";
            this.bloodPressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maritalStatusLabel
            // 
            this.maritalStatusLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.maritalStatusLabel, 3);
            this.maritalStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maritalStatusLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maritalStatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maritalStatusLabel.Location = new System.Drawing.Point(3, 224);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(429, 28);
            this.maritalStatusLabel.TabIndex = 41;
            this.maritalStatusLabel.Text = "Marital Status:";
            this.maritalStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bloodTypeLabel
            // 
            this.bloodTypeLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.bloodTypeLabel, 3);
            this.bloodTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodTypeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodTypeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bloodTypeLabel.Location = new System.Drawing.Point(3, 140);
            this.bloodTypeLabel.Name = "bloodTypeLabel";
            this.bloodTypeLabel.Size = new System.Drawing.Size(429, 28);
            this.bloodTypeLabel.TabIndex = 40;
            this.bloodTypeLabel.Text = "Blood Type:";
            this.bloodTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.birthdateLabel, 3);
            this.birthdateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthdateLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.birthdateLabel.Location = new System.Drawing.Point(3, 84);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(429, 28);
            this.birthdateLabel.TabIndex = 39;
            this.birthdateLabel.Text = "Birthdate:";
            this.birthdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.addressLabel, 3);
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addressLabel.Location = new System.Drawing.Point(3, 112);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(429, 28);
            this.addressLabel.TabIndex = 38;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.phoneNumberLabel, 3);
            this.phoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phoneNumberLabel.Location = new System.Drawing.Point(3, 56);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(429, 28);
            this.phoneNumberLabel.TabIndex = 37;
            this.phoneNumberLabel.Text = "Phone No.:";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.emailLabel, 3);
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailLabel.Location = new System.Drawing.Point(3, 28);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(429, 28);
            this.emailLabel.TabIndex = 36;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.genderLabel, 3);
            this.genderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genderLabel.Location = new System.Drawing.Point(3, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(429, 28);
            this.genderLabel.TabIndex = 35;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filterFullnameTextbox
            // 
            this.filterFullnameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterFullnameTextbox.LabelName = "Fullname";
            this.filterFullnameTextbox.Location = new System.Drawing.Point(579, 490);
            this.filterFullnameTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.filterFullnameTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.filterFullnameTextbox.Name = "filterFullnameTextbox";
            this.filterFullnameTextbox.PasswordChar = '\0';
            this.filterFullnameTextbox.ReadOnly = false;
            this.filterFullnameTextbox.Size = new System.Drawing.Size(435, 60);
            this.filterFullnameTextbox.TabIndex = 1;
            this.filterFullnameTextbox.Value = "";
            this.filterFullnameTextbox.OnValueChanged += new System.EventHandler(this.onFilterTextboxValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.genderLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reasonLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.maritalStatusLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.bloodPressureLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.phoneNumberLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.birthdateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.addressLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bloodTypeLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.weightLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.heightLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.bmiLabel, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(579, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 283);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // filterAssignedWorkerTextbox
            // 
            this.filterAssignedWorkerTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterAssignedWorkerTextbox.LabelName = "Assigned Worker";
            this.filterAssignedWorkerTextbox.Location = new System.Drawing.Point(579, 556);
            this.filterAssignedWorkerTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.filterAssignedWorkerTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.filterAssignedWorkerTextbox.Name = "filterAssignedWorkerTextbox";
            this.filterAssignedWorkerTextbox.PasswordChar = '\0';
            this.filterAssignedWorkerTextbox.ReadOnly = false;
            this.filterAssignedWorkerTextbox.Size = new System.Drawing.Size(435, 60);
            this.filterAssignedWorkerTextbox.TabIndex = 2;
            this.filterAssignedWorkerTextbox.Value = "";
            this.filterAssignedWorkerTextbox.OnValueChanged += new System.EventHandler(this.onFilterTextboxValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(579, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 34);
            this.label2.TabIndex = 52;
            this.label2.Text = "Filter by";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remarksLabel
            // 
            this.remarksLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remarksLabel.AutoEllipsis = true;
            this.remarksLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remarksLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remarksLabel.Location = new System.Drawing.Point(582, 352);
            this.remarksLabel.Name = "remarksLabel";
            this.remarksLabel.Size = new System.Drawing.Size(429, 31);
            this.remarksLabel.TabIndex = 53;
            this.remarksLabel.Text = "Remarks: ";
            this.remarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deferredLabel
            // 
            this.deferredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deferredLabel.AutoEllipsis = true;
            this.deferredLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deferredLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deferredLabel.Location = new System.Drawing.Point(582, 383);
            this.deferredLabel.Name = "deferredLabel";
            this.deferredLabel.Size = new System.Drawing.Size(429, 31);
            this.deferredLabel.TabIndex = 54;
            this.deferredLabel.Text = "Deferred: ";
            this.deferredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(13, 622);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(139, 40);
            this.printButton.TabIndex = 55;
            this.printButton.TabStop = false;
            this.printButton.Text = "SAVE REPORT";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewProfileButton.FlatAppearance.BorderSize = 0;
            this.viewProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProfileButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewProfileButton.ForeColor = System.Drawing.Color.White;
            this.viewProfileButton.Location = new System.Drawing.Point(758, 622);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(150, 40);
            this.viewProfileButton.TabIndex = 58;
            this.viewProfileButton.TabStop = false;
            this.viewProfileButton.Text = "VIEW PROFILE";
            this.viewProfileButton.UseVisualStyleBackColor = false;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // RecordListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.deferredLabel);
            this.Controls.Add(this.remarksLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterAssignedWorkerTextbox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.filterFullnameTextbox);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.tableGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RecordListPanel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1027, 675);
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView tableGrid;
        private Button reloadButton;
        private Label reasonLabel;
        private Label bmiLabel;
        private Label heightLabel;
        private Label weightLabel;
        private Label bloodPressureLabel;
        private Label maritalStatusLabel;
        private Label bloodTypeLabel;
        private Label birthdateLabel;
        private Label addressLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label genderLabel;
        private CustomTextBox filterFullnameTextbox;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn AssignedWorker;
        private DataGridViewTextBoxColumn Reason;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomTextBox filterAssignedWorkerTextbox;
        private Label label2;
        private Label remarksLabel;
        private Label deferredLabel;
        private Button printButton;
        private Button viewProfileButton;
        private DataGridViewTextBoxColumn Column1;
    }
}
