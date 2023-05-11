namespace HCMIS.Components
{
    partial class QueueListPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeButton = new System.Windows.Forms.Button();
            this.reloadDataButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusLabel = new System.Windows.Forms.Label();
            this.bloodTypeLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.bloodPressureLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.approveButton = new System.Windows.Forms.Button();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableGrid
            // 
            this.tableGrid.AllowUserToAddRows = false;
            this.tableGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tableGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tableGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableGrid.ColumnHeadersHeight = 50;
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.tableGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.tableGrid.Location = new System.Drawing.Point(13, 47);
            this.tableGrid.MultiSelect = false;
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.ReadOnly = true;
            this.tableGrid.RowHeadersVisible = false;
            this.tableGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.tableGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tableGrid.RowTemplate.Height = 25;
            this.tableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableGrid.Size = new System.Drawing.Size(399, 615);
            this.tableGrid.TabIndex = 1;
            this.tableGrid.SelectionChanged += new System.EventHandler(this.tableGrid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.BackColor = System.Drawing.Color.LightCoral;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(809, 622);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 40);
            this.removeButton.TabIndex = 11;
            this.removeButton.TabStop = false;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // reloadDataButton
            // 
            this.reloadDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reloadDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadDataButton.FlatAppearance.BorderSize = 0;
            this.reloadDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadDataButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reloadDataButton.ForeColor = System.Drawing.Color.White;
            this.reloadDataButton.Location = new System.Drawing.Point(703, 622);
            this.reloadDataButton.Name = "reloadDataButton";
            this.reloadDataButton.Size = new System.Drawing.Size(100, 40);
            this.reloadDataButton.TabIndex = 12;
            this.reloadDataButton.TabStop = false;
            this.reloadDataButton.Text = "RELOAD";
            this.reloadDataButton.UseVisualStyleBackColor = false;
            this.reloadDataButton.Click += new System.EventHandler(this.reloadDataButton_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // maritalStatusLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.maritalStatusLabel, 3);
            this.maritalStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maritalStatusLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maritalStatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maritalStatusLabel.Location = new System.Drawing.Point(3, 192);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(590, 32);
            this.maritalStatusLabel.TabIndex = 26;
            this.maritalStatusLabel.Text = "Marital Status:";
            // 
            // bloodTypeLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bloodTypeLabel, 3);
            this.bloodTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodTypeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodTypeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bloodTypeLabel.Location = new System.Drawing.Point(3, 160);
            this.bloodTypeLabel.Name = "bloodTypeLabel";
            this.bloodTypeLabel.Size = new System.Drawing.Size(590, 32);
            this.bloodTypeLabel.TabIndex = 25;
            this.bloodTypeLabel.Text = "Blood Type:";
            // 
            // birthdateLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.birthdateLabel, 3);
            this.birthdateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthdateLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.birthdateLabel.Location = new System.Drawing.Point(3, 128);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(590, 32);
            this.birthdateLabel.TabIndex = 24;
            this.birthdateLabel.Text = "Birthdate:";
            // 
            // addressLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.addressLabel, 3);
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addressLabel.Location = new System.Drawing.Point(3, 96);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(590, 32);
            this.addressLabel.TabIndex = 23;
            this.addressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.phoneNumberLabel, 3);
            this.phoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phoneNumberLabel.Location = new System.Drawing.Point(3, 64);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(590, 32);
            this.phoneNumberLabel.TabIndex = 22;
            this.phoneNumberLabel.Text = "Phone No.:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.emailLabel, 3);
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailLabel.Location = new System.Drawing.Point(3, 32);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(590, 32);
            this.emailLabel.TabIndex = 21;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // genderLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.genderLabel, 3);
            this.genderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genderLabel.Location = new System.Drawing.Point(3, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.genderLabel.Size = new System.Drawing.Size(590, 32);
            this.genderLabel.TabIndex = 20;
            this.genderLabel.Text = "Gender:";
            // 
            // bloodPressureLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bloodPressureLabel, 3);
            this.bloodPressureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodPressureLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodPressureLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bloodPressureLabel.Location = new System.Drawing.Point(3, 224);
            this.bloodPressureLabel.Name = "bloodPressureLabel";
            this.bloodPressureLabel.Size = new System.Drawing.Size(590, 32);
            this.bloodPressureLabel.TabIndex = 27;
            this.bloodPressureLabel.Text = "Blood Pressure:";
            // 
            // weightLabel
            // 
            this.weightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.weightLabel.Location = new System.Drawing.Point(3, 256);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(192, 32);
            this.weightLabel.TabIndex = 28;
            this.weightLabel.Text = "Weight (kg):";
            // 
            // heightLabel
            // 
            this.heightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.heightLabel.Location = new System.Drawing.Point(201, 256);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(192, 32);
            this.heightLabel.TabIndex = 29;
            this.heightLabel.Text = "Height (ft):";
            // 
            // bmiLabel
            // 
            this.bmiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmiLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bmiLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bmiLabel.Location = new System.Drawing.Point(399, 256);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(194, 32);
            this.bmiLabel.TabIndex = 32;
            this.bmiLabel.Text = "BMI:";
            // 
            // approveButton
            // 
            this.approveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.approveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approveButton.FlatAppearance.BorderSize = 0;
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(915, 622);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(100, 40);
            this.approveButton.TabIndex = 33;
            this.approveButton.TabStop = false;
            this.approveButton.Text = "APPROVE";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // reasonLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.reasonLabel, 3);
            this.reasonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reasonLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reasonLabel.Location = new System.Drawing.Point(3, 288);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(590, 40);
            this.reasonLabel.TabIndex = 34;
            this.reasonLabel.Text = "Reason:";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(597, 622);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 35;
            this.addButton.TabStop = false;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.genderLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reasonLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.bmiLabel, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.phoneNumberLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.heightLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.addressLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.birthdateLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bloodTypeLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.weightLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.maritalStatusLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.bloodPressureLabel, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(418, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 328);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // QueueListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.reloadDataButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.tableGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QueueListPanel";
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
        private Button removeButton;
        private Button reloadDataButton;
        private DataGridViewTextBoxColumn ID;
        private Label maritalStatusLabel;
        private Label bloodTypeLabel;
        private Label birthdateLabel;
        private Label addressLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label genderLabel;
        private Label bloodPressureLabel;
        private Label weightLabel;
        private Label heightLabel;
        private Label bmiLabel;
        private Button approveButton;
        private Label reasonLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button addButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
