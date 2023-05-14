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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            tableGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            AssignedWorker = new DataGridViewTextBoxColumn();
            Reason = new DataGridViewTextBoxColumn();
            reloadButton = new Button();
            reasonLabel = new Label();
            bmiLabel = new Label();
            heightLabel = new Label();
            weightLabel = new Label();
            bloodPressureLabel = new Label();
            maritalStatusLabel = new Label();
            bloodTypeLabel = new Label();
            birthdateLabel = new Label();
            addressLabel = new Label();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            genderLabel = new Label();
            filterFullnameTextbox = new CustomTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            filterAssignedWorkerTextbox = new CustomTextBox();
            label2 = new Label();
            remarksLabel = new Label();
            deferredLabel = new Label();
            printButton = new Button();
            viewProfileButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(119, 34);
            label1.TabIndex = 0;
            label1.Text = "Record List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableGrid
            // 
            tableGrid.AllowUserToAddRows = false;
            tableGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            tableGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableGrid.BackgroundColor = Color.WhiteSmoke;
            tableGrid.BorderStyle = BorderStyle.None;
            tableGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tableGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tableGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tableGrid.ColumnHeadersHeight = 50;
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tableGrid.Columns.AddRange(new DataGridViewColumn[] { ID, Column1, Fullname, Date, Time, AssignedWorker, Reason });
            tableGrid.Cursor = Cursors.Hand;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            tableGrid.DefaultCellStyle = dataGridViewCellStyle9;
            tableGrid.GridColor = Color.WhiteSmoke;
            tableGrid.Location = new Point(13, 47);
            tableGrid.MultiSelect = false;
            tableGrid.Name = "tableGrid";
            tableGrid.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            tableGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            tableGrid.RowHeadersVisible = false;
            tableGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(41, 193, 140);
            tableGrid.RowsDefaultCellStyle = dataGridViewCellStyle11;
            tableGrid.RowTemplate.Height = 25;
            tableGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableGrid.Size = new Size(560, 569);
            tableGrid.TabIndex = 1;
            tableGrid.TabStop = false;
            tableGrid.SelectionChanged += tableGrid_SelectionChanged;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 193, 140);
            ID.DefaultCellStyle = dataGridViewCellStyle3;
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 50;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            ID.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "Patient ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Fullname
            // 
            Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(41, 193, 140);
            Fullname.DefaultCellStyle = dataGridViewCellStyle4;
            Fullname.FillWeight = 175F;
            Fullname.HeaderText = "Fullname";
            Fullname.MinimumWidth = 175;
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            Fullname.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(41, 193, 140);
            Date.DefaultCellStyle = dataGridViewCellStyle5;
            Date.FillWeight = 85F;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 85;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.SortMode = DataGridViewColumnSortMode.NotSortable;
            Date.Width = 85;
            // 
            // Time
            // 
            Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(41, 193, 140);
            Time.DefaultCellStyle = dataGridViewCellStyle6;
            Time.FillWeight = 80F;
            Time.HeaderText = "Time";
            Time.MinimumWidth = 80;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.SortMode = DataGridViewColumnSortMode.NotSortable;
            Time.Width = 80;
            // 
            // AssignedWorker
            // 
            AssignedWorker.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(41, 193, 140);
            AssignedWorker.DefaultCellStyle = dataGridViewCellStyle7;
            AssignedWorker.HeaderText = "Assigned Worker";
            AssignedWorker.MinimumWidth = 100;
            AssignedWorker.Name = "AssignedWorker";
            AssignedWorker.ReadOnly = true;
            AssignedWorker.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Reason
            // 
            Reason.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(41, 193, 140);
            Reason.DefaultCellStyle = dataGridViewCellStyle8;
            Reason.HeaderText = "Reason";
            Reason.MinimumWidth = 100;
            Reason.Name = "Reason";
            Reason.ReadOnly = true;
            Reason.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // reloadButton
            // 
            reloadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reloadButton.BackColor = Color.FromArgb(0, 192, 0);
            reloadButton.Cursor = Cursors.Hand;
            reloadButton.FlatAppearance.BorderSize = 0;
            reloadButton.FlatStyle = FlatStyle.Flat;
            reloadButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reloadButton.ForeColor = Color.White;
            reloadButton.Location = new Point(914, 622);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(100, 40);
            reloadButton.TabIndex = 12;
            reloadButton.TabStop = false;
            reloadButton.Text = "RELOAD";
            reloadButton.UseVisualStyleBackColor = false;
            reloadButton.Click += reloadDataButton_Click;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(reasonLabel, 3);
            reasonLabel.Dock = DockStyle.Fill;
            reasonLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reasonLabel.ForeColor = SystemColors.ControlDarkDark;
            reasonLabel.Location = new Point(3, 252);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(429, 31);
            reasonLabel.TabIndex = 46;
            reasonLabel.Text = "Reason:";
            reasonLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bmiLabel
            // 
            bmiLabel.AutoEllipsis = true;
            bmiLabel.Dock = DockStyle.Fill;
            bmiLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bmiLabel.ForeColor = SystemColors.ControlDarkDark;
            bmiLabel.Location = new Point(293, 196);
            bmiLabel.Name = "bmiLabel";
            bmiLabel.Size = new Size(139, 28);
            bmiLabel.TabIndex = 45;
            bmiLabel.Text = "BMI:";
            bmiLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // heightLabel
            // 
            heightLabel.AutoEllipsis = true;
            heightLabel.Dock = DockStyle.Fill;
            heightLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            heightLabel.ForeColor = SystemColors.ControlDarkDark;
            heightLabel.Location = new Point(148, 196);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(139, 28);
            heightLabel.TabIndex = 44;
            heightLabel.Text = "Height (ft):";
            heightLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // weightLabel
            // 
            weightLabel.AutoEllipsis = true;
            weightLabel.Dock = DockStyle.Fill;
            weightLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            weightLabel.ForeColor = SystemColors.ControlDarkDark;
            weightLabel.Location = new Point(3, 196);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(139, 28);
            weightLabel.TabIndex = 43;
            weightLabel.Text = "Weight (kg):";
            weightLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bloodPressureLabel
            // 
            bloodPressureLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(bloodPressureLabel, 3);
            bloodPressureLabel.Dock = DockStyle.Fill;
            bloodPressureLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bloodPressureLabel.ForeColor = SystemColors.ControlDarkDark;
            bloodPressureLabel.Location = new Point(3, 168);
            bloodPressureLabel.Name = "bloodPressureLabel";
            bloodPressureLabel.Size = new Size(429, 28);
            bloodPressureLabel.TabIndex = 42;
            bloodPressureLabel.Text = "Blood Pressure:";
            bloodPressureLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maritalStatusLabel
            // 
            maritalStatusLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(maritalStatusLabel, 3);
            maritalStatusLabel.Dock = DockStyle.Fill;
            maritalStatusLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maritalStatusLabel.ForeColor = SystemColors.ControlDarkDark;
            maritalStatusLabel.Location = new Point(3, 224);
            maritalStatusLabel.Name = "maritalStatusLabel";
            maritalStatusLabel.Size = new Size(429, 28);
            maritalStatusLabel.TabIndex = 41;
            maritalStatusLabel.Text = "Marital Status:";
            maritalStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(bloodTypeLabel, 3);
            bloodTypeLabel.Dock = DockStyle.Fill;
            bloodTypeLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bloodTypeLabel.ForeColor = SystemColors.ControlDarkDark;
            bloodTypeLabel.Location = new Point(3, 140);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new Size(429, 28);
            bloodTypeLabel.TabIndex = 40;
            bloodTypeLabel.Text = "Blood Type:";
            bloodTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(birthdateLabel, 3);
            birthdateLabel.Dock = DockStyle.Fill;
            birthdateLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            birthdateLabel.ForeColor = SystemColors.ControlDarkDark;
            birthdateLabel.Location = new Point(3, 84);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new Size(429, 28);
            birthdateLabel.TabIndex = 39;
            birthdateLabel.Text = "Birthdate:";
            birthdateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addressLabel
            // 
            addressLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(addressLabel, 3);
            addressLabel.Dock = DockStyle.Fill;
            addressLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.ForeColor = SystemColors.ControlDarkDark;
            addressLabel.Location = new Point(3, 112);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(429, 28);
            addressLabel.TabIndex = 38;
            addressLabel.Text = "Address:";
            addressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(phoneNumberLabel, 3);
            phoneNumberLabel.Dock = DockStyle.Fill;
            phoneNumberLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = SystemColors.ControlDarkDark;
            phoneNumberLabel.Location = new Point(3, 56);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(429, 28);
            phoneNumberLabel.TabIndex = 37;
            phoneNumberLabel.Text = "Phone No.:";
            phoneNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            emailLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(emailLabel, 3);
            emailLabel.Dock = DockStyle.Fill;
            emailLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.ControlDarkDark;
            emailLabel.Location = new Point(3, 28);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(429, 28);
            emailLabel.TabIndex = 36;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genderLabel
            // 
            genderLabel.AutoEllipsis = true;
            tableLayoutPanel1.SetColumnSpan(genderLabel, 3);
            genderLabel.Dock = DockStyle.Fill;
            genderLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            genderLabel.ForeColor = SystemColors.ControlDarkDark;
            genderLabel.Location = new Point(3, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(429, 28);
            genderLabel.TabIndex = 35;
            genderLabel.Text = "Gender:";
            genderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // filterFullnameTextbox
            // 
            filterFullnameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterFullnameTextbox.LabelName = "Fullname";
            filterFullnameTextbox.Location = new Point(579, 490);
            filterFullnameTextbox.MaximumSize = new Size(0, 60);
            filterFullnameTextbox.MinimumSize = new Size(0, 60);
            filterFullnameTextbox.Name = "filterFullnameTextbox";
            filterFullnameTextbox.PasswordChar = '\0';
            filterFullnameTextbox.ReadOnly = false;
            filterFullnameTextbox.Size = new Size(435, 60);
            filterFullnameTextbox.TabIndex = 1;
            filterFullnameTextbox.Value = "";
            filterFullnameTextbox.OnValueChanged += onFilterTextboxValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(genderLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(emailLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(reasonLabel, 0, 9);
            tableLayoutPanel1.Controls.Add(maritalStatusLabel, 0, 8);
            tableLayoutPanel1.Controls.Add(bloodPressureLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(phoneNumberLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(birthdateLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(addressLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(bloodTypeLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(weightLabel, 0, 7);
            tableLayoutPanel1.Controls.Add(heightLabel, 1, 7);
            tableLayoutPanel1.Controls.Add(bmiLabel, 2, 7);
            tableLayoutPanel1.Location = new Point(579, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(435, 283);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // filterAssignedWorkerTextbox
            // 
            filterAssignedWorkerTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterAssignedWorkerTextbox.LabelName = "Assigned Worker";
            filterAssignedWorkerTextbox.Location = new Point(579, 556);
            filterAssignedWorkerTextbox.MaximumSize = new Size(0, 60);
            filterAssignedWorkerTextbox.MinimumSize = new Size(0, 60);
            filterAssignedWorkerTextbox.Name = "filterAssignedWorkerTextbox";
            filterAssignedWorkerTextbox.PasswordChar = '\0';
            filterAssignedWorkerTextbox.ReadOnly = false;
            filterAssignedWorkerTextbox.Size = new Size(435, 60);
            filterAssignedWorkerTextbox.TabIndex = 2;
            filterAssignedWorkerTextbox.Value = "";
            filterAssignedWorkerTextbox.OnValueChanged += onFilterTextboxValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(579, 453);
            label2.Name = "label2";
            label2.Size = new Size(91, 34);
            label2.TabIndex = 52;
            label2.Text = "Filter by";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // remarksLabel
            // 
            remarksLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            remarksLabel.AutoEllipsis = true;
            remarksLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            remarksLabel.ForeColor = SystemColors.ControlDarkDark;
            remarksLabel.Location = new Point(582, 352);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new Size(429, 31);
            remarksLabel.TabIndex = 53;
            remarksLabel.Text = "Remarks: ";
            remarksLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // deferredLabel
            // 
            deferredLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deferredLabel.AutoEllipsis = true;
            deferredLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deferredLabel.ForeColor = SystemColors.ControlDarkDark;
            deferredLabel.Location = new Point(582, 383);
            deferredLabel.Name = "deferredLabel";
            deferredLabel.Size = new Size(429, 31);
            deferredLabel.TabIndex = 54;
            deferredLabel.Text = "Deferred: ";
            deferredLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // printButton
            // 
            printButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            printButton.BackColor = Color.FromArgb(128, 128, 255);
            printButton.Cursor = Cursors.Hand;
            printButton.FlatAppearance.BorderSize = 0;
            printButton.FlatStyle = FlatStyle.Flat;
            printButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            printButton.ForeColor = Color.White;
            printButton.Location = new Point(13, 622);
            printButton.Name = "printButton";
            printButton.Size = new Size(139, 40);
            printButton.TabIndex = 55;
            printButton.TabStop = false;
            printButton.Text = "SAVE REPORT";
            printButton.UseVisualStyleBackColor = false;
            printButton.Visible = false;
            printButton.Click += printButton_Click;
            // 
            // viewProfileButton
            // 
            viewProfileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            viewProfileButton.BackColor = Color.FromArgb(0, 192, 192);
            viewProfileButton.Cursor = Cursors.Hand;
            viewProfileButton.FlatAppearance.BorderSize = 0;
            viewProfileButton.FlatStyle = FlatStyle.Flat;
            viewProfileButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewProfileButton.ForeColor = Color.White;
            viewProfileButton.Location = new Point(758, 622);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(150, 40);
            viewProfileButton.TabIndex = 58;
            viewProfileButton.TabStop = false;
            viewProfileButton.Text = "VIEW PROFILE";
            viewProfileButton.UseVisualStyleBackColor = false;
            viewProfileButton.Click += viewProfileButton_Click;
            // 
            // RecordListPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(viewProfileButton);
            Controls.Add(printButton);
            Controls.Add(deferredLabel);
            Controls.Add(remarksLabel);
            Controls.Add(label2);
            Controls.Add(filterAssignedWorkerTextbox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(filterFullnameTextbox);
            Controls.Add(reloadButton);
            Controls.Add(tableGrid);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "RecordListPanel";
            Padding = new Padding(10);
            Size = new Size(1027, 675);
            ((System.ComponentModel.ISupportInitialize)tableGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
