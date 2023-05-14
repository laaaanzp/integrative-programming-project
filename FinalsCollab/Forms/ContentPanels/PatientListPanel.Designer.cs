namespace FinalsCollab.Forms.ContentPanels
{
    partial class PatientListPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bloodtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._marital_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._number_of_kids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.maritalStatusLabel = new System.Windows.Forms.Label();
            this.bloodtypeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.editButton = new FinalsCollab.CustomControls.CButton();
            this.deleteButton = new FinalsCollab.CustomControls.CButton();
            this.addButton = new FinalsCollab.CustomControls.CButton();
            this.printButton = new FinalsCollab.CustomControls.CButton();
            this.fieldComboBox = new FinalsCollab.CustomControls.CComboBox();
            this.valueTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.totalVisitLabel = new System.Windows.Forms.Label();
            this.numberOfKidsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(5, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(591, 482);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._name,
            this._gender,
            this._address,
            this._birthday,
            this._bloodtype,
            this._marital_status,
            this._number_of_kids,
            this._email,
            this._phone});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // _id
            // 
            this._id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LimeGreen;
            this._id.DefaultCellStyle = dataGridViewCellStyle3;
            this._id.FillWeight = 10.09381F;
            this._id.HeaderText = "ID";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _name
            // 
            this._name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._name.FillWeight = 74.06013F;
            this._name.HeaderText = "NAME";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            this._name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _gender
            // 
            this._gender.HeaderText = "GENDER";
            this._gender.Name = "_gender";
            this._gender.ReadOnly = true;
            this._gender.Visible = false;
            // 
            // _address
            // 
            this._address.HeaderText = "ADDRESS";
            this._address.Name = "_address";
            this._address.ReadOnly = true;
            this._address.Visible = false;
            // 
            // _birthday
            // 
            this._birthday.HeaderText = "BIRTHDAY";
            this._birthday.Name = "_birthday";
            this._birthday.ReadOnly = true;
            this._birthday.Visible = false;
            // 
            // _bloodtype
            // 
            this._bloodtype.HeaderText = "BLOODTYPE";
            this._bloodtype.Name = "_bloodtype";
            this._bloodtype.ReadOnly = true;
            this._bloodtype.Visible = false;
            // 
            // _marital_status
            // 
            this._marital_status.HeaderText = "MARITAL STATUS";
            this._marital_status.Name = "_marital_status";
            this._marital_status.ReadOnly = true;
            this._marital_status.Visible = false;
            // 
            // _number_of_kids
            // 
            this._number_of_kids.HeaderText = "NUMBER OF KIDS";
            this._number_of_kids.Name = "_number_of_kids";
            this._number_of_kids.ReadOnly = true;
            this._number_of_kids.Visible = false;
            // 
            // _email
            // 
            this._email.HeaderText = "EMAIL";
            this._email.Name = "_email";
            this._email.ReadOnly = true;
            this._email.Visible = false;
            // 
            // _phone
            // 
            this._phone.HeaderText = "PHONE";
            this._phone.Name = "_phone";
            this._phone.ReadOnly = true;
            this._phone.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient List";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(606, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Basic Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genderLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.ForeColor = System.Drawing.Color.DimGray;
            this.genderLabel.Location = new System.Drawing.Point(605, 104);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(363, 28);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.UseCompatibleTextRendering = true;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.ForeColor = System.Drawing.Color.DimGray;
            this.addressLabel.Location = new System.Drawing.Point(605, 132);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(363, 49);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Address:";
            this.addressLabel.UseCompatibleTextRendering = true;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.birthdayLabel.Location = new System.Drawing.Point(606, 181);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(363, 28);
            this.birthdayLabel.TabIndex = 10;
            this.birthdayLabel.Text = "Birthday:";
            this.birthdayLabel.UseCompatibleTextRendering = true;
            // 
            // maritalStatusLabel
            // 
            this.maritalStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maritalStatusLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maritalStatusLabel.ForeColor = System.Drawing.Color.DimGray;
            this.maritalStatusLabel.Location = new System.Drawing.Point(606, 209);
            this.maritalStatusLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(363, 28);
            this.maritalStatusLabel.TabIndex = 11;
            this.maritalStatusLabel.Text = "Marital Status:";
            this.maritalStatusLabel.UseCompatibleTextRendering = true;
            // 
            // bloodtypeLabel
            // 
            this.bloodtypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bloodtypeLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodtypeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.bloodtypeLabel.Location = new System.Drawing.Point(606, 237);
            this.bloodtypeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.bloodtypeLabel.Name = "bloodtypeLabel";
            this.bloodtypeLabel.Size = new System.Drawing.Size(363, 28);
            this.bloodtypeLabel.TabIndex = 12;
            this.bloodtypeLabel.Text = "Bloodtype:";
            this.bloodtypeLabel.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(606, 341);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Contact";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.DimGray;
            this.emailLabel.Location = new System.Drawing.Point(606, 373);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(363, 28);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email:";
            this.emailLabel.UseCompatibleTextRendering = true;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.DimGray;
            this.phoneLabel.Location = new System.Drawing.Point(606, 401);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(363, 28);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Phone:";
            this.phoneLabel.UseCompatibleTextRendering = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.editButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.editButton.BorderRadius = 5;
            this.editButton.BorderSize = 0;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(653, 634);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 40);
            this.editButton.TabIndex = 18;
            this.editButton.TabStop = false;
            this.editButton.Text = "EDIT";
            this.editButton.TextColor = System.Drawing.Color.White;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.Coral;
            this.deleteButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.deleteButton.BorderRadius = 5;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(763, 634);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.addButton.BorderRadius = 5;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(873, 634);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 16;
            this.addButton.TabStop = false;
            this.addButton.Text = "ADD";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.printButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.printButton.BorderRadius = 5;
            this.printButton.BorderSize = 0;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(6, 634);
            this.printButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 40);
            this.printButton.TabIndex = 19;
            this.printButton.TabStop = false;
            this.printButton.Text = "PRINT";
            this.printButton.TextColor = System.Drawing.Color.White;
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.fieldComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fieldComboBox.BackColor = System.Drawing.Color.White;
            this.fieldComboBox.InactiveColor = System.Drawing.Color.DimGray;
            this.fieldComboBox.Items.AddRange(new object[] {
            "ID",
            "NAME"});
            this.fieldComboBox.LabelText = "Field";
            this.fieldComboBox.Location = new System.Drawing.Point(6, 556);
            this.fieldComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.fieldComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.ReadOnly = false;
            this.fieldComboBox.Size = new System.Drawing.Size(200, 60);
            this.fieldComboBox.TabIndex = 21;
            this.fieldComboBox.Value = "NAME";
            // 
            // valueTextbox
            // 
            this.valueTextbox._Text = "";
            this.valueTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.valueTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.valueTextbox.BackColor = System.Drawing.Color.White;
            this.valueTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.valueTextbox.LabelText = "Value";
            this.valueTextbox.Location = new System.Drawing.Point(209, 556);
            this.valueTextbox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.valueTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.valueTextbox.MaxLength = 32767;
            this.valueTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.valueTextbox.Name = "valueTextbox";
            this.valueTextbox.ReadOnly = false;
            this.valueTextbox.Size = new System.Drawing.Size(386, 60);
            this.valueTextbox.TabIndex = 20;
            this.valueTextbox.TextChanged += new System.EventHandler(this.valueTextbox_TextChanged);
            // 
            // totalVisitLabel
            // 
            this.totalVisitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalVisitLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalVisitLabel.ForeColor = System.Drawing.Color.DimGray;
            this.totalVisitLabel.Location = new System.Drawing.Point(606, 293);
            this.totalVisitLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.totalVisitLabel.Name = "totalVisitLabel";
            this.totalVisitLabel.Size = new System.Drawing.Size(363, 28);
            this.totalVisitLabel.TabIndex = 22;
            this.totalVisitLabel.Text = "Total Visit:";
            this.totalVisitLabel.UseCompatibleTextRendering = true;
            // 
            // numberOfKidsLabel
            // 
            this.numberOfKidsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfKidsLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfKidsLabel.ForeColor = System.Drawing.Color.DimGray;
            this.numberOfKidsLabel.Location = new System.Drawing.Point(606, 265);
            this.numberOfKidsLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.numberOfKidsLabel.Name = "numberOfKidsLabel";
            this.numberOfKidsLabel.Size = new System.Drawing.Size(363, 28);
            this.numberOfKidsLabel.TabIndex = 23;
            this.numberOfKidsLabel.Text = "Number of kids:";
            this.numberOfKidsLabel.UseCompatibleTextRendering = true;
            // 
            // PatientListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numberOfKidsLabel);
            this.Controls.Add(this.totalVisitLabel);
            this.Controls.Add(this.fieldComboBox);
            this.Controls.Add(this.valueTextbox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bloodtypeLabel);
            this.Controls.Add(this.maritalStatusLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PatientListPanel";
            this.Size = new System.Drawing.Size(978, 679);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label genderLabel;
        private Label addressLabel;
        private Label birthdayLabel;
        private Label maritalStatusLabel;
        private Label bloodtypeLabel;
        private Label label8;
        private Label emailLabel;
        private Label phoneLabel;
        private CustomControls.CButton editButton;
        private CustomControls.CButton deleteButton;
        private CustomControls.CButton addButton;
        private CustomControls.CButton printButton;
        private CustomControls.CComboBox fieldComboBox;
        private CustomControls.CTextbox valueTextbox;
        private Label totalVisitLabel;
        private Label numberOfKidsLabel;
        private DataGridViewTextBoxColumn _id;
        private DataGridViewTextBoxColumn _name;
        private DataGridViewTextBoxColumn _gender;
        private DataGridViewTextBoxColumn _address;
        private DataGridViewTextBoxColumn _birthday;
        private DataGridViewTextBoxColumn _bloodtype;
        private DataGridViewTextBoxColumn _marital_status;
        private DataGridViewTextBoxColumn _number_of_kids;
        private DataGridViewTextBoxColumn _email;
        private DataGridViewTextBoxColumn _phone;
    }
}
