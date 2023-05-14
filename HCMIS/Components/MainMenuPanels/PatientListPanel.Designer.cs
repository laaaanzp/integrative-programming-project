namespace HCMIS.Components
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            tableGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            TotalVisit = new DataGridViewTextBoxColumn();
            removeButton = new Button();
            reloadDataButton = new Button();
            maritalStatusLabel = new Label();
            bloodTypeLabel = new Label();
            birthdayLabel = new Label();
            addressLabel = new Label();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            genderLabel = new Label();
            editButton = new Button();
            addButton = new Button();
            printButton = new Button();
            viewProfileButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(120, 34);
            label1.TabIndex = 0;
            label1.Text = "Patient List";
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
            tableGrid.ColumnHeadersHeight = 50;
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tableGrid.Columns.AddRange(new DataGridViewColumn[] { ID, PatientName, TotalVisit });
            tableGrid.Cursor = Cursors.Hand;
            tableGrid.GridColor = Color.WhiteSmoke;
            tableGrid.Location = new Point(13, 47);
            tableGrid.MultiSelect = false;
            tableGrid.Name = "tableGrid";
            tableGrid.ReadOnly = true;
            tableGrid.RowHeadersVisible = false;
            tableGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(41, 193, 140);
            tableGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            tableGrid.RowTemplate.Height = 25;
            tableGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableGrid.Size = new Size(479, 569);
            tableGrid.TabIndex = 1;
            tableGrid.SelectionChanged += tableGrid_SelectionChanged;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 193, 140);
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 50;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            ID.Width = 50;
            // 
            // PatientName
            // 
            PatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 193, 140);
            PatientName.DefaultCellStyle = dataGridViewCellStyle3;
            PatientName.FillWeight = 175F;
            PatientName.HeaderText = "Patient Name";
            PatientName.MinimumWidth = 175;
            PatientName.Name = "PatientName";
            PatientName.ReadOnly = true;
            PatientName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalVisit
            // 
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(41, 193, 140);
            TotalVisit.DefaultCellStyle = dataGridViewCellStyle4;
            TotalVisit.HeaderText = "Total Visit";
            TotalVisit.Name = "TotalVisit";
            TotalVisit.ReadOnly = true;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            removeButton.BackColor = Color.LightCoral;
            removeButton.Cursor = Cursors.Hand;
            removeButton.FlatAppearance.BorderSize = 0;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(914, 622);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(100, 40);
            removeButton.TabIndex = 11;
            removeButton.TabStop = false;
            removeButton.Text = "REMOVE";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // reloadDataButton
            // 
            reloadDataButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reloadDataButton.BackColor = Color.FromArgb(0, 192, 0);
            reloadDataButton.Cursor = Cursors.Hand;
            reloadDataButton.FlatAppearance.BorderSize = 0;
            reloadDataButton.FlatStyle = FlatStyle.Flat;
            reloadDataButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reloadDataButton.ForeColor = Color.White;
            reloadDataButton.Location = new Point(808, 622);
            reloadDataButton.Name = "reloadDataButton";
            reloadDataButton.Size = new Size(100, 40);
            reloadDataButton.TabIndex = 12;
            reloadDataButton.TabStop = false;
            reloadDataButton.Text = "RELOAD";
            reloadDataButton.UseVisualStyleBackColor = false;
            reloadDataButton.Click += reloadDataButton_Click;
            // 
            // maritalStatusLabel
            // 
            maritalStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maritalStatusLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maritalStatusLabel.ForeColor = SystemColors.ControlDarkDark;
            maritalStatusLabel.Location = new Point(498, 215);
            maritalStatusLabel.Name = "maritalStatusLabel";
            maritalStatusLabel.Size = new Size(516, 28);
            maritalStatusLabel.TabIndex = 38;
            maritalStatusLabel.Text = "Marital Status:";
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bloodTypeLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bloodTypeLabel.ForeColor = SystemColors.ControlDarkDark;
            bloodTypeLabel.Location = new Point(498, 187);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new Size(516, 28);
            bloodTypeLabel.TabIndex = 37;
            bloodTypeLabel.Text = "Blood Type:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            birthdayLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            birthdayLabel.ForeColor = SystemColors.ControlDarkDark;
            birthdayLabel.Location = new Point(498, 159);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(516, 28);
            birthdayLabel.TabIndex = 36;
            birthdayLabel.Text = "Birthdate:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.ForeColor = SystemColors.ControlDarkDark;
            addressLabel.Location = new Point(498, 131);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(516, 28);
            addressLabel.TabIndex = 35;
            addressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            phoneNumberLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = SystemColors.ControlDarkDark;
            phoneNumberLabel.Location = new Point(498, 103);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(516, 28);
            phoneNumberLabel.TabIndex = 34;
            phoneNumberLabel.Text = "Phone Number: ";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            emailLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.ControlDarkDark;
            emailLabel.Location = new Point(498, 75);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(516, 28);
            emailLabel.TabIndex = 33;
            emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            genderLabel.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            genderLabel.ForeColor = SystemColors.ControlDarkDark;
            genderLabel.Location = new Point(498, 47);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(516, 28);
            genderLabel.TabIndex = 32;
            genderLabel.Text = "Gender:";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.BackColor = Color.FromArgb(192, 192, 0);
            editButton.Cursor = Cursors.Hand;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(702, 622);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 40);
            editButton.TabIndex = 39;
            editButton.TabStop = false;
            editButton.Text = "EDIT";
            editButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(128, 128, 255);
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(596, 622);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 40);
            addButton.TabIndex = 40;
            addButton.TabStop = false;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
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
            printButton.TabIndex = 56;
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
            viewProfileButton.Location = new Point(440, 622);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(150, 40);
            viewProfileButton.TabIndex = 57;
            viewProfileButton.TabStop = false;
            viewProfileButton.Text = "VIEW PROFILE";
            viewProfileButton.UseVisualStyleBackColor = false;
            viewProfileButton.Click += viewProfileButton_Click;
            // 
            // PatientListPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(viewProfileButton);
            Controls.Add(printButton);
            Controls.Add(addButton);
            Controls.Add(editButton);
            Controls.Add(maritalStatusLabel);
            Controls.Add(bloodTypeLabel);
            Controls.Add(birthdayLabel);
            Controls.Add(addressLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(emailLabel);
            Controls.Add(genderLabel);
            Controls.Add(reloadDataButton);
            Controls.Add(removeButton);
            Controls.Add(tableGrid);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "PatientListPanel";
            Padding = new Padding(10);
            Size = new Size(1027, 675);
            ((System.ComponentModel.ISupportInitialize)tableGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tableGrid;
        private Button removeButton;
        private Button reloadDataButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn TotalVisit;
        private Label maritalStatusLabel;
        private Label bloodTypeLabel;
        private Label birthdayLabel;
        private Label addressLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label genderLabel;
        private Button editButton;
        private Button addButton;
        private Button printButton;
        private Button viewProfileButton;
    }
}
