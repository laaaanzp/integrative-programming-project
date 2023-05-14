namespace FinalsCollab.Forms.DialogForms
{
    partial class PatientForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.maritalStatusComboBox = new FinalsCollab.CustomControls.CComboBox();
            this.bloodtypeComboBox = new FinalsCollab.CustomControls.CComboBox();
            this.genderComboBox = new FinalsCollab.CustomControls.CComboBox();
            this.numberOfKidsNumericTextbox = new FinalsCollab.CustomControls.CNumericTextbox();
            this.addressTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.cDatePicker1 = new FinalsCollab.CustomControls.CDatePicker();
            this.cancelButton = new FinalsCollab.CustomControls.CButton();
            this.submitButton = new FinalsCollab.CustomControls.CButton();
            this.idNumericTextbox = new FinalsCollab.CustomControls.CNumericTextbox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.emailTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.phoneNumericTextbox = new FinalsCollab.CustomControls.CNumericTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.birthdayTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.fullnameTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.mainContentPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.headerPanel.Controls.Add(this.iconPictureBox);
            this.headerPanel.Controls.Add(this.formNameLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 40);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::FinalsCollab.Properties.Resources.healthcare;
            this.iconPictureBox.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(33, 33);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 6;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // formNameLabel
            // 
            this.formNameLabel.AutoSize = true;
            this.formNameLabel.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formNameLabel.ForeColor = System.Drawing.Color.White;
            this.formNameLabel.Location = new System.Drawing.Point(35, 3);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(124, 34);
            this.formNameLabel.TabIndex = 0;
            this.formNameLabel.Text = "Edit Patient";
            this.formNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainContentPanel.Controls.Add(this.tableLayoutPanel2);
            this.mainContentPanel.Controls.Add(this.addressTextbox);
            this.mainContentPanel.Controls.Add(this.cDatePicker1);
            this.mainContentPanel.Controls.Add(this.cancelButton);
            this.mainContentPanel.Controls.Add(this.submitButton);
            this.mainContentPanel.Controls.Add(this.idNumericTextbox);
            this.mainContentPanel.Controls.Add(this.tableLayoutPanel3);
            this.mainContentPanel.Controls.Add(this.label3);
            this.mainContentPanel.Controls.Add(this.label1);
            this.mainContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainContentPanel.Location = new System.Drawing.Point(1, 41);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(1);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(798, 407);
            this.mainContentPanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.maritalStatusComboBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bloodtypeComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.genderComboBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numberOfKidsNumericTextbox, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 177);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 60);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // maritalStatusComboBox
            // 
            this.maritalStatusComboBox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.maritalStatusComboBox.BackColor = System.Drawing.Color.White;
            this.maritalStatusComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maritalStatusComboBox.InactiveColor = System.Drawing.Color.DimGray;
            this.maritalStatusComboBox.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.maritalStatusComboBox.LabelText = "Marital Status";
            this.maritalStatusComboBox.Location = new System.Drawing.Point(394, 0);
            this.maritalStatusComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.maritalStatusComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.maritalStatusComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.maritalStatusComboBox.Name = "maritalStatusComboBox";
            this.maritalStatusComboBox.ReadOnly = false;
            this.maritalStatusComboBox.Size = new System.Drawing.Size(192, 60);
            this.maritalStatusComboBox.TabIndex = 7;
            this.maritalStatusComboBox.Value = "";
            // 
            // bloodtypeComboBox
            // 
            this.bloodtypeComboBox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.bloodtypeComboBox.BackColor = System.Drawing.Color.White;
            this.bloodtypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodtypeComboBox.InactiveColor = System.Drawing.Color.DimGray;
            this.bloodtypeComboBox.Items.AddRange(new object[] {
            "a+",
            "a-",
            "b+",
            "b-",
            "ab+",
            "ab-",
            "o+",
            "o-"});
            this.bloodtypeComboBox.LabelText = "Bloodtype";
            this.bloodtypeComboBox.Location = new System.Drawing.Point(197, 0);
            this.bloodtypeComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bloodtypeComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.bloodtypeComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.bloodtypeComboBox.Name = "bloodtypeComboBox";
            this.bloodtypeComboBox.ReadOnly = false;
            this.bloodtypeComboBox.Size = new System.Drawing.Size(192, 60);
            this.bloodtypeComboBox.TabIndex = 6;
            this.bloodtypeComboBox.Value = "";
            // 
            // genderComboBox
            // 
            this.genderComboBox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.genderComboBox.BackColor = System.Drawing.Color.White;
            this.genderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderComboBox.InactiveColor = System.Drawing.Color.DimGray;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.genderComboBox.LabelText = "Gender";
            this.genderComboBox.Location = new System.Drawing.Point(0, 0);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.genderComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.genderComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.ReadOnly = false;
            this.genderComboBox.Size = new System.Drawing.Size(192, 60);
            this.genderComboBox.TabIndex = 5;
            this.genderComboBox.Value = "";
            // 
            // numberOfKidsNumericTextbox
            // 
            this.numberOfKidsNumericTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.numberOfKidsNumericTextbox.BackColor = System.Drawing.Color.White;
            this.numberOfKidsNumericTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfKidsNumericTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.numberOfKidsNumericTextbox.LabelText = "Number of kids";
            this.numberOfKidsNumericTextbox.Location = new System.Drawing.Point(591, 0);
            this.numberOfKidsNumericTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.numberOfKidsNumericTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.numberOfKidsNumericTextbox.MaxLength = 32767;
            this.numberOfKidsNumericTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.numberOfKidsNumericTextbox.Name = "numberOfKidsNumericTextbox";
            this.numberOfKidsNumericTextbox.ReadOnly = false;
            this.numberOfKidsNumericTextbox.Size = new System.Drawing.Size(197, 60);
            this.numberOfKidsNumericTextbox.TabIndex = 8;
            this.numberOfKidsNumericTextbox.Value = ((long)(0));
            // 
            // addressTextbox
            // 
            this.addressTextbox._Text = "";
            this.addressTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.addressTextbox.BackColor = System.Drawing.Color.White;
            this.addressTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.addressTextbox.LabelText = "Address";
            this.addressTextbox.Location = new System.Drawing.Point(5, 114);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.addressTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.addressTextbox.MaxLength = 32767;
            this.addressTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.ReadOnly = false;
            this.addressTextbox.Size = new System.Drawing.Size(788, 60);
            this.addressTextbox.TabIndex = 3;
            // 
            // cDatePicker1
            // 
            this.cDatePicker1.Location = new System.Drawing.Point(692, 16);
            this.cDatePicker1.Name = "cDatePicker1";
            this.cDatePicker1.Size = new System.Drawing.Size(101, 30);
            this.cDatePicker1.TabIndex = 19;
            this.cDatePicker1.TabStop = false;
            this.cDatePicker1.OnValueChanged += new System.EventHandler<System.DateOnly>(this.cDatePicker1_OnValueChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Coral;
            this.cancelButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.cancelButton.BorderRadius = 5;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(583, 362);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.BackColor = System.Drawing.Color.LimeGreen;
            this.submitButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.submitButton.BorderRadius = 5;
            this.submitButton.BorderSize = 0;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(693, 362);
            this.submitButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 40);
            this.submitButton.TabIndex = 12;
            this.submitButton.TabStop = false;
            this.submitButton.Text = "SAVE";
            this.submitButton.TextColor = System.Drawing.Color.White;
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // idNumericTextbox
            // 
            this.idNumericTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.idNumericTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.idNumericTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.idNumericTextbox.LabelText = "ID";
            this.idNumericTextbox.Location = new System.Drawing.Point(5, 49);
            this.idNumericTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.idNumericTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.idNumericTextbox.MaxLength = 32767;
            this.idNumericTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.idNumericTextbox.Name = "idNumericTextbox";
            this.idNumericTextbox.ReadOnly = true;
            this.idNumericTextbox.Size = new System.Drawing.Size(60, 60);
            this.idNumericTextbox.TabIndex = 0;
            this.idNumericTextbox.Value = ((long)(0));
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Controls.Add(this.emailTextbox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.phoneNumericTextbox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 287);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 60);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // emailTextbox
            // 
            this.emailTextbox._Text = "";
            this.emailTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.emailTextbox.BackColor = System.Drawing.Color.White;
            this.emailTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.emailTextbox.LabelText = "Email";
            this.emailTextbox.Location = new System.Drawing.Point(0, 0);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.emailTextbox.MaxLength = 250;
            this.emailTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.ReadOnly = false;
            this.emailTextbox.Size = new System.Drawing.Size(433, 60);
            this.emailTextbox.TabIndex = 10;
            // 
            // phoneNumericTextbox
            // 
            this.phoneNumericTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.phoneNumericTextbox.BackColor = System.Drawing.Color.White;
            this.phoneNumericTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumericTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.phoneNumericTextbox.LabelText = "Phone";
            this.phoneNumericTextbox.Location = new System.Drawing.Point(438, 0);
            this.phoneNumericTextbox.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.phoneNumericTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.phoneNumericTextbox.MaxLength = 12;
            this.phoneNumericTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.phoneNumericTextbox.Name = "phoneNumericTextbox";
            this.phoneNumericTextbox.ReadOnly = false;
            this.phoneNumericTextbox.Size = new System.Drawing.Size(350, 60);
            this.phoneNumericTextbox.TabIndex = 11;
            this.phoneNumericTextbox.Value = ((long)(0));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(5, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Basic Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.birthdayTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fullnameTextbox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // birthdayTextbox
            // 
            this.birthdayTextbox._Text = "";
            this.birthdayTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.birthdayTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.birthdayTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthdayTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.birthdayTextbox.LabelText = "Birthday";
            this.birthdayTextbox.Location = new System.Drawing.Point(364, 0);
            this.birthdayTextbox.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.birthdayTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.birthdayTextbox.MaxLength = 50;
            this.birthdayTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.birthdayTextbox.Name = "birthdayTextbox";
            this.birthdayTextbox.ReadOnly = true;
            this.birthdayTextbox.Size = new System.Drawing.Size(354, 60);
            this.birthdayTextbox.TabIndex = 3;
            // 
            // fullnameTextbox
            // 
            this.fullnameTextbox._Text = "";
            this.fullnameTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.fullnameTextbox.BackColor = System.Drawing.Color.White;
            this.fullnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullnameTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.fullnameTextbox.LabelText = "Fullname";
            this.fullnameTextbox.Location = new System.Drawing.Point(0, 0);
            this.fullnameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.fullnameTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.fullnameTextbox.MaxLength = 50;
            this.fullnameTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.fullnameTextbox.Name = "fullnameTextbox";
            this.fullnameTextbox.ReadOnly = false;
            this.fullnameTextbox.Size = new System.Drawing.Size(359, 60);
            this.fullnameTextbox.TabIndex = 2;
            // 
            // PatientForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private PictureBox iconPictureBox;
        private Label formNameLabel;
        private Panel mainContentPanel;
        private CustomControls.CNumericTextbox idNumericTextbox;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.CTextbox emailTextbox;
        private CustomControls.CNumericTextbox phoneNumericTextbox;
        private Label label3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CTextbox birthdayTextbox;
        private CustomControls.CTextbox fullnameTextbox;
        private CustomControls.CButton cancelButton;
        private CustomControls.CButton submitButton;
        private CustomControls.CDatePicker cDatePicker1;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.CComboBox maritalStatusComboBox;
        private CustomControls.CComboBox bloodtypeComboBox;
        private CustomControls.CComboBox genderComboBox;
        private CustomControls.CNumericTextbox numberOfKidsNumericTextbox;
        private CustomControls.CTextbox addressTextbox;
    }
}