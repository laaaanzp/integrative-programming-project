namespace HCMIS
{
    partial class AddQueueForm
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
            this.closeButton = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.draggablePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.genderLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.maritalStatusLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.bloodTypeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.findPatientByFullNameButton = new System.Windows.Forms.Button();
            this.findPatientByIDButton = new System.Windows.Forms.Button();
            this.fullnameTextBox = new HCMIS.Components.CustomTextBox();
            this.idNumericUpDown = new HCMIS.Components.CustomNumericUpDown();
            this.clearButton = new System.Windows.Forms.Button();
            this.bloodPressureNumericUpDown = new HCMIS.Components.CustomNumericUpDown();
            this.weightKGNumericTextBox = new HCMIS.Components.CustomNumericTextBox();
            this.bmiTextBox = new HCMIS.Components.CustomTextBox();
            this.heightFTNumericTextBox = new HCMIS.Components.CustomNumericTextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.reasonComboBox = new HCMIS.Components.CustomComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.draggablePanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = global::HCMIS.Properties.Resources.CloseButton;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(1020, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 1;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackgroundImage = global::HCMIS.Properties.Resources.MinimizeButton;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Location = new System.Drawing.Point(1215, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Queue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDrag);
            // 
            // draggablePanel
            // 
            this.draggablePanel.BackColor = System.Drawing.Color.White;
            this.draggablePanel.Controls.Add(this.label1);
            this.draggablePanel.Controls.Add(this.minimizeButton);
            this.draggablePanel.Controls.Add(this.closeButton);
            this.draggablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.draggablePanel.Location = new System.Drawing.Point(0, 0);
            this.draggablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.draggablePanel.Name = "draggablePanel";
            this.draggablePanel.Size = new System.Drawing.Size(1050, 40);
            this.draggablePanel.TabIndex = 0;
            this.draggablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDrag);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.genderLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.emailLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.addressLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.phoneNumberLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.maritalStatusLabel, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.birthdateLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.bloodTypeLabel, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 116);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1026, 190);
            this.tableLayoutPanel3.TabIndex = 54;
            // 
            // genderLabel
            // 
            this.genderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genderLabel.Location = new System.Drawing.Point(0, 0);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(513, 31);
            this.genderLabel.TabIndex = 29;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailLabel.Location = new System.Drawing.Point(0, 31);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(513, 31);
            this.emailLabel.TabIndex = 34;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLabel
            // 
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addressLabel.Location = new System.Drawing.Point(0, 62);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(513, 31);
            this.addressLabel.TabIndex = 36;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phoneNumberLabel.Location = new System.Drawing.Point(513, 31);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(513, 31);
            this.phoneNumberLabel.TabIndex = 35;
            this.phoneNumberLabel.Text = "Phone No.:";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maritalStatusLabel
            // 
            this.maritalStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maritalStatusLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maritalStatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maritalStatusLabel.Location = new System.Drawing.Point(0, 155);
            this.maritalStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(513, 35);
            this.maritalStatusLabel.TabIndex = 39;
            this.maritalStatusLabel.Text = "Marital Status:";
            this.maritalStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthdateLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.birthdateLabel.Location = new System.Drawing.Point(0, 93);
            this.birthdateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(513, 31);
            this.birthdateLabel.TabIndex = 37;
            this.birthdateLabel.Text = "Birthdate:";
            this.birthdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bloodTypeLabel
            // 
            this.bloodTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodTypeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodTypeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bloodTypeLabel.Location = new System.Drawing.Point(0, 124);
            this.bloodTypeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bloodTypeLabel.Name = "bloodTypeLabel";
            this.bloodTypeLabel.Size = new System.Drawing.Size(513, 31);
            this.bloodTypeLabel.TabIndex = 38;
            this.bloodTypeLabel.Text = "Blood Type:";
            this.bloodTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.84982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.15018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.findPatientByFullNameButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.findPatientByIDButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.fullnameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.idNumericUpDown, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 60);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // findPatientByFullNameButton
            // 
            this.findPatientByFullNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.findPatientByFullNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findPatientByFullNameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findPatientByFullNameButton.FlatAppearance.BorderSize = 0;
            this.findPatientByFullNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findPatientByFullNameButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findPatientByFullNameButton.ForeColor = System.Drawing.Color.White;
            this.findPatientByFullNameButton.Location = new System.Drawing.Point(860, 3);
            this.findPatientByFullNameButton.Name = "findPatientByFullNameButton";
            this.findPatientByFullNameButton.Size = new System.Drawing.Size(163, 54);
            this.findPatientByFullNameButton.TabIndex = 30;
            this.findPatientByFullNameButton.Text = "FIND BY FULLNAME";
            this.findPatientByFullNameButton.UseVisualStyleBackColor = false;
            this.findPatientByFullNameButton.Click += new System.EventHandler(this.findPatientByFullnameButton_Click);
            // 
            // findPatientByIDButton
            // 
            this.findPatientByIDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.findPatientByIDButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findPatientByIDButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findPatientByIDButton.FlatAppearance.BorderSize = 0;
            this.findPatientByIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findPatientByIDButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findPatientByIDButton.ForeColor = System.Drawing.Color.White;
            this.findPatientByIDButton.Location = new System.Drawing.Point(750, 3);
            this.findPatientByIDButton.Name = "findPatientByIDButton";
            this.findPatientByIDButton.Size = new System.Drawing.Size(104, 54);
            this.findPatientByIDButton.TabIndex = 28;
            this.findPatientByIDButton.Text = "FIND BY ID";
            this.findPatientByIDButton.UseVisualStyleBackColor = false;
            this.findPatientByIDButton.Click += new System.EventHandler(this.findPatientByIDButton_Click);
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullnameTextBox.LabelName = "Fullname";
            this.fullnameTextBox.Location = new System.Drawing.Point(155, 0);
            this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.fullnameTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.fullnameTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.PasswordChar = '\0';
            this.fullnameTextBox.ReadOnly = false;
            this.fullnameTextBox.Size = new System.Drawing.Size(592, 60);
            this.fullnameTextBox.TabIndex = 2;
            this.fullnameTextBox.Value = "";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idNumericUpDown.LabelName = "ID";
            this.idNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.idNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.idNumericUpDown.Maximum = 99999;
            this.idNumericUpDown.MaximumSize = new System.Drawing.Size(0, 60);
            this.idNumericUpDown.Minimum = 1;
            this.idNumericUpDown.MinimumSize = new System.Drawing.Size(0, 60);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = false;
            this.idNumericUpDown.Size = new System.Drawing.Size(155, 60);
            this.idNumericUpDown.TabIndex = 1;
            this.idNumericUpDown.TimeFormat = false;
            this.idNumericUpDown.Value = 0;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.LightCoral;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(805, 548);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 40);
            this.clearButton.TabIndex = 52;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bloodPressureNumericUpDown
            // 
            this.bloodPressureNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodPressureNumericUpDown.LabelName = "Blood Pressure";
            this.bloodPressureNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.bloodPressureNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.bloodPressureNumericUpDown.Maximum = 99999;
            this.bloodPressureNumericUpDown.MaximumSize = new System.Drawing.Size(0, 60);
            this.bloodPressureNumericUpDown.Minimum = 0;
            this.bloodPressureNumericUpDown.MinimumSize = new System.Drawing.Size(0, 60);
            this.bloodPressureNumericUpDown.Name = "bloodPressureNumericUpDown";
            this.bloodPressureNumericUpDown.ReadOnly = false;
            this.bloodPressureNumericUpDown.Size = new System.Drawing.Size(251, 60);
            this.bloodPressureNumericUpDown.TabIndex = 4;
            this.bloodPressureNumericUpDown.TimeFormat = false;
            this.bloodPressureNumericUpDown.Value = 0;
            // 
            // weightKGNumericTextBox
            // 
            this.weightKGNumericTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightKGNumericTextBox.LabelName = "Weight (kg)";
            this.weightKGNumericTextBox.Location = new System.Drawing.Point(251, 0);
            this.weightKGNumericTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.weightKGNumericTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.weightKGNumericTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.weightKGNumericTextBox.Name = "weightKGNumericTextBox";
            this.weightKGNumericTextBox.ReadOnly = false;
            this.weightKGNumericTextBox.Size = new System.Drawing.Size(205, 60);
            this.weightKGNumericTextBox.TabIndex = 5;
            this.weightKGNumericTextBox.OnValueChanged += new System.EventHandler<double>(this.calculateBMI);
            // 
            // bmiTextbox
            // 
            this.bmiTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmiTextBox.LabelName = "BMI";
            this.bmiTextBox.Location = new System.Drawing.Point(661, 0);
            this.bmiTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.bmiTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.bmiTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.bmiTextBox.Name = "bmiTextbox";
            this.bmiTextBox.PasswordChar = '\0';
            this.bmiTextBox.ReadOnly = true;
            this.bmiTextBox.Size = new System.Drawing.Size(112, 60);
            this.bmiTextBox.TabIndex = 41;
            this.bmiTextBox.Value = "0";
            // 
            // heightFTNumericTextBox
            // 
            this.heightFTNumericTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightFTNumericTextBox.LabelName = "Height (ft)";
            this.heightFTNumericTextBox.Location = new System.Drawing.Point(456, 0);
            this.heightFTNumericTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.heightFTNumericTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.heightFTNumericTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.heightFTNumericTextBox.Name = "heightFTNumericTextBox";
            this.heightFTNumericTextBox.ReadOnly = false;
            this.heightFTNumericTextBox.Size = new System.Drawing.Size(205, 60);
            this.heightFTNumericTextBox.TabIndex = 6;
            this.heightFTNumericTextBox.OnValueChanged += new System.EventHandler<double>(this.calculateBMI);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.49809F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.01744F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.01744F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.97382F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.4932F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.reasonComboBox, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.bloodPressureNumericUpDown, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.weightKGNumericTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bmiTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.heightFTNumericTextBox, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 312);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1026, 60);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // reasonComboBox
            // 
            this.reasonComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonComboBox.Items.AddRange(new object[] {
            "Checkup",
            "Vaccine"});
            this.reasonComboBox.LabelText = "Reason";
            this.reasonComboBox.Location = new System.Drawing.Point(773, 0);
            this.reasonComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.reasonComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.reasonComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.reasonComboBox.Name = "reasonComboBox";
            this.reasonComboBox.ReadOnly = false;
            this.reasonComboBox.Size = new System.Drawing.Size(253, 60);
            this.reasonComboBox.TabIndex = 56;
            this.reasonComboBox.Value = "";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(923, 548);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 40);
            this.addButton.TabIndex = 55;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.draggablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1050, 600);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "AddQueueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.draggablePanel.ResumeLayout(false);
            this.draggablePanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel closeButton;
        private Panel minimizeButton;
        private Label label1;
        private Panel draggablePanel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label genderLabel;
        private Label emailLabel;
        private Label addressLabel;
        private Label phoneNumberLabel;
        private Label maritalStatusLabel;
        private Label birthdateLabel;
        private Label bloodTypeLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button findPatientByFullNameButton;
        private Button findPatientByIDButton;
        private Components.CustomTextBox fullnameTextBox;
        private Components.CustomNumericUpDown idNumericUpDown;
        private Button clearButton;
        private Components.CustomNumericUpDown bloodPressureNumericUpDown;
        private Components.CustomNumericTextBox weightKGNumericTextBox;
        private Components.CustomTextBox bmiTextBox;
        private Components.CustomNumericTextBox heightFTNumericTextBox;
        private DataGridViewTextBoxColumn ID;
        private TableLayoutPanel tableLayoutPanel2;
        private Button addButton;
        private Components.CustomComboBox reasonComboBox;
    }
}