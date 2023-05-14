namespace FinalsCollab.Forms.DialogForms
{
    partial class ProfileForm
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
            this.cButton2 = new FinalsCollab.CustomControls.CButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cButton1 = new FinalsCollab.CustomControls.CButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new FinalsCollab.CustomControls.CButton();
            this.submitButton = new FinalsCollab.CustomControls.CButton();
            this.idNumericTextbox = new FinalsCollab.CustomControls.CNumericTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.passwordTextbox = new FinalsCollab.CustomControls.CPasswordTextbox();
            this.positionComboBox = new FinalsCollab.CustomControls.CComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.emailTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.phoneNumericTextbox = new FinalsCollab.CustomControls.CNumericTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lastnameTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.middlenameTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.firstnameTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.mainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.formNameLabel.Size = new System.Drawing.Size(116, 34);
            this.formNameLabel.TabIndex = 0;
            this.formNameLabel.Text = "Edit Profile";
            this.formNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainContentPanel.Controls.Add(this.cButton2);
            this.mainContentPanel.Controls.Add(this.label5);
            this.mainContentPanel.Controls.Add(this.cButton1);
            this.mainContentPanel.Controls.Add(this.pictureBox1);
            this.mainContentPanel.Controls.Add(this.cancelButton);
            this.mainContentPanel.Controls.Add(this.submitButton);
            this.mainContentPanel.Controls.Add(this.idNumericTextbox);
            this.mainContentPanel.Controls.Add(this.label4);
            this.mainContentPanel.Controls.Add(this.tableLayoutPanel2);
            this.mainContentPanel.Controls.Add(this.positionComboBox);
            this.mainContentPanel.Controls.Add(this.tableLayoutPanel3);
            this.mainContentPanel.Controls.Add(this.label3);
            this.mainContentPanel.Controls.Add(this.label2);
            this.mainContentPanel.Controls.Add(this.label1);
            this.mainContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainContentPanel.Location = new System.Drawing.Point(1, 41);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(1);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(798, 401);
            this.mainContentPanel.TabIndex = 2;
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.Coral;
            this.cButton2.BorderColor = System.Drawing.Color.Coral;
            this.cButton2.BorderRadius = 5;
            this.cButton2.BorderSize = 0;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.Location = new System.Drawing.Point(71, 199);
            this.cButton2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(66, 25);
            this.cButton2.TabIndex = 18;
            this.cButton2.TabStop = false;
            this.cButton2.Text = "REMOVE";
            this.cButton2.TextColor = System.Drawing.Color.White;
            this.cButton2.UseVisualStyleBackColor = false;
            this.cButton2.Click += new System.EventHandler(this.cButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(5, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Picture";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cButton1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.cButton1.BorderRadius = 5;
            this.cButton1.BorderSize = 0;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.Location = new System.Drawing.Point(71, 164);
            this.cButton1.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(66, 25);
            this.cButton1.TabIndex = 16;
            this.cButton1.TabStop = false;
            this.cButton1.Text = "EDIT";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            this.cancelButton.Location = new System.Drawing.Point(583, 356);
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
            this.submitButton.Location = new System.Drawing.Point(693, 356);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(232, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.usernameTextbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.passwordTextbox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(232, 281);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(561, 60);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox._Text = "";
            this.usernameTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.usernameTextbox.BackColor = System.Drawing.Color.White;
            this.usernameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.usernameTextbox.LabelText = "Username";
            this.usernameTextbox.Location = new System.Drawing.Point(0, 0);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.usernameTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.usernameTextbox.MaxLength = 50;
            this.usernameTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.ReadOnly = false;
            this.usernameTextbox.Size = new System.Drawing.Size(277, 60);
            this.usernameTextbox.TabIndex = 10;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox._Text = "";
            this.passwordTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.passwordTextbox.BackColor = System.Drawing.Color.White;
            this.passwordTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.passwordTextbox.LabelText = "Password";
            this.passwordTextbox.Location = new System.Drawing.Point(283, 0);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.passwordTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.passwordTextbox.MaxLength = 50;
            this.passwordTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.ReadOnly = false;
            this.passwordTextbox.Size = new System.Drawing.Size(278, 60);
            this.passwordTextbox.TabIndex = 11;
            // 
            // positionComboBox
            // 
            this.positionComboBox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.positionComboBox.BackColor = System.Drawing.Color.White;
            this.positionComboBox.InactiveColor = System.Drawing.Color.DimGray;
            this.positionComboBox.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Nurse",
            "BHW",
            "Resigned"});
            this.positionComboBox.LabelText = "Position";
            this.positionComboBox.Location = new System.Drawing.Point(5, 281);
            this.positionComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.positionComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.positionComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.ReadOnly = false;
            this.positionComboBox.Size = new System.Drawing.Size(219, 60);
            this.positionComboBox.TabIndex = 5;
            this.positionComboBox.Value = "BHW";
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(142, 164);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(651, 60);
            this.tableLayoutPanel3.TabIndex = 6;
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
            this.emailTextbox.Size = new System.Drawing.Size(358, 60);
            this.emailTextbox.TabIndex = 7;
            // 
            // phoneNumericTextbox
            // 
            this.phoneNumericTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.phoneNumericTextbox.BackColor = System.Drawing.Color.White;
            this.phoneNumericTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumericTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.phoneNumericTextbox.LabelText = "Phone";
            this.phoneNumericTextbox.Location = new System.Drawing.Point(363, 0);
            this.phoneNumericTextbox.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.phoneNumericTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.phoneNumericTextbox.MaxLength = 12;
            this.phoneNumericTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.phoneNumericTextbox.Name = "phoneNumericTextbox";
            this.phoneNumericTextbox.ReadOnly = false;
            this.phoneNumericTextbox.Size = new System.Drawing.Size(288, 60);
            this.phoneNumericTextbox.TabIndex = 8;
            this.phoneNumericTextbox.Value = ((long)(0));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(142, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Position";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lastnameTextbox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.middlenameTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstnameTextbox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox._Text = "";
            this.lastnameTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.lastnameTextbox.BackColor = System.Drawing.Color.White;
            this.lastnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastnameTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.lastnameTextbox.LabelText = "Lastname";
            this.lastnameTextbox.Location = new System.Drawing.Point(478, 0);
            this.lastnameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.lastnameTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.lastnameTextbox.MaxLength = 50;
            this.lastnameTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.ReadOnly = false;
            this.lastnameTextbox.Size = new System.Drawing.Size(240, 60);
            this.lastnameTextbox.TabIndex = 4;
            // 
            // middlenameTextbox
            // 
            this.middlenameTextbox._Text = "";
            this.middlenameTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.middlenameTextbox.BackColor = System.Drawing.Color.White;
            this.middlenameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlenameTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.middlenameTextbox.LabelText = "Middlename";
            this.middlenameTextbox.Location = new System.Drawing.Point(244, 0);
            this.middlenameTextbox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.middlenameTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.middlenameTextbox.MaxLength = 50;
            this.middlenameTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.middlenameTextbox.Name = "middlenameTextbox";
            this.middlenameTextbox.ReadOnly = false;
            this.middlenameTextbox.Size = new System.Drawing.Size(229, 60);
            this.middlenameTextbox.TabIndex = 3;
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox._Text = "";
            this.firstnameTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.firstnameTextbox.BackColor = System.Drawing.Color.White;
            this.firstnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstnameTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.firstnameTextbox.LabelText = "Firstname";
            this.firstnameTextbox.Location = new System.Drawing.Point(0, 0);
            this.firstnameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.firstnameTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.firstnameTextbox.MaxLength = 50;
            this.firstnameTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.ReadOnly = false;
            this.firstnameTextbox.Size = new System.Drawing.Size(239, 60);
            this.firstnameTextbox.TabIndex = 2;
            // 
            // ProfileForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.CTextbox usernameTextbox;
        private CustomControls.CPasswordTextbox passwordTextbox;
        private CustomControls.CComboBox positionComboBox;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.CTextbox emailTextbox;
        private CustomControls.CNumericTextbox phoneNumericTextbox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CTextbox lastnameTextbox;
        private CustomControls.CTextbox middlenameTextbox;
        private CustomControls.CTextbox firstnameTextbox;
        private CustomControls.CButton cancelButton;
        private CustomControls.CButton submitButton;
        private Label label5;
        private CustomControls.CButton cButton1;
        private PictureBox pictureBox1;
        private CustomControls.CButton cButton2;
    }
}