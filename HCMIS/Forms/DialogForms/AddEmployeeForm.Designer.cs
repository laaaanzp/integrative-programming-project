namespace HCMIS
{
    partial class AddEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.draggablePanel = new System.Windows.Forms.Panel();
            this.jobPosition = new HCMIS.Components.CustomComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.password = new HCMIS.Components.CustomTextBox();
            this.username = new HCMIS.Components.CustomTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lastName = new HCMIS.Components.CustomTextBox();
            this.middleName = new HCMIS.Components.CustomTextBox();
            this.firstName = new HCMIS.Components.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new HCMIS.Components.CustomTextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.phoneNumber = new HCMIS.Components.CustomTextBox();
            this.draggablePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = global::HCMIS.Properties.Resources.CloseButton;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(870, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 1;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDrag);
            // 
            // draggablePanel
            // 
            this.draggablePanel.BackColor = System.Drawing.Color.White;
            this.draggablePanel.Controls.Add(this.label1);
            this.draggablePanel.Controls.Add(this.closeButton);
            this.draggablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.draggablePanel.Location = new System.Drawing.Point(0, 0);
            this.draggablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.draggablePanel.Name = "draggablePanel";
            this.draggablePanel.Size = new System.Drawing.Size(900, 40);
            this.draggablePanel.TabIndex = 0;
            this.draggablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDrag);
            // 
            // jobPosition
            // 
            this.jobPosition.Items.AddRange(new object[] {
            "Doctor",
            "Nurse",
            "Barangay Health Worker"});
            this.jobPosition.LabelText = "Job Position";
            this.jobPosition.Location = new System.Drawing.Point(12, 393);
            this.jobPosition.MaximumSize = new System.Drawing.Size(0, 60);
            this.jobPosition.MinimumSize = new System.Drawing.Size(0, 60);
            this.jobPosition.Name = "jobPosition";
            this.jobPosition.ReadOnly = false;
            this.jobPosition.Size = new System.Drawing.Size(300, 60);
            this.jobPosition.TabIndex = 28;
            this.jobPosition.Value = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.password, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.username, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 185);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(876, 60);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // password
            // 
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.LabelName = "Password";
            this.password.Location = new System.Drawing.Point(438, 0);
            this.password.Margin = new System.Windows.Forms.Padding(0);
            this.password.MaximumSize = new System.Drawing.Size(0, 60);
            this.password.MinimumSize = new System.Drawing.Size(0, 60);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(438, 60);
            this.password.TabIndex = 6;
            this.password.Value = "";
            // 
            // username
            // 
            this.username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username.LabelName = "Username";
            this.username.Location = new System.Drawing.Point(0, 0);
            this.username.Margin = new System.Windows.Forms.Padding(0);
            this.username.MaximumSize = new System.Drawing.Size(0, 60);
            this.username.MinimumSize = new System.Drawing.Size(0, 60);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.ReadOnly = false;
            this.username.Size = new System.Drawing.Size(438, 60);
            this.username.TabIndex = 5;
            this.username.Value = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lastName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.middleName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 60);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // lastName
            // 
            this.lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastName.LabelName = "Last Name";
            this.lastName.Location = new System.Drawing.Point(584, 0);
            this.lastName.Margin = new System.Windows.Forms.Padding(0);
            this.lastName.MaximumSize = new System.Drawing.Size(0, 60);
            this.lastName.MinimumSize = new System.Drawing.Size(0, 60);
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.ReadOnly = false;
            this.lastName.Size = new System.Drawing.Size(292, 60);
            this.lastName.TabIndex = 2;
            this.lastName.Value = "";
            // 
            // middleName
            // 
            this.middleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleName.LabelName = "Middle Name";
            this.middleName.Location = new System.Drawing.Point(292, 0);
            this.middleName.Margin = new System.Windows.Forms.Padding(0);
            this.middleName.MaximumSize = new System.Drawing.Size(0, 60);
            this.middleName.MinimumSize = new System.Drawing.Size(0, 60);
            this.middleName.Name = "middleName";
            this.middleName.PasswordChar = '\0';
            this.middleName.ReadOnly = false;
            this.middleName.Size = new System.Drawing.Size(292, 60);
            this.middleName.TabIndex = 1;
            this.middleName.Value = "";
            // 
            // firstName
            // 
            this.firstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstName.LabelName = "First Name";
            this.firstName.Location = new System.Drawing.Point(0, 0);
            this.firstName.Margin = new System.Windows.Forms.Padding(0);
            this.firstName.MaximumSize = new System.Drawing.Size(0, 60);
            this.firstName.MinimumSize = new System.Drawing.Size(0, 60);
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.ReadOnly = false;
            this.firstName.Size = new System.Drawing.Size(292, 60);
            this.firstName.TabIndex = 0;
            this.firstName.Value = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Job Position";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.clearButton.Location = new System.Drawing.Point(658, 548);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 40);
            this.clearButton.TabIndex = 22;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(776, 548);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 40);
            this.addButton.TabIndex = 23;
            this.addButton.TabStop = false;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contact";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email
            // 
            this.email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email.LabelName = "Email";
            this.email.Location = new System.Drawing.Point(0, 0);
            this.email.Margin = new System.Windows.Forms.Padding(0);
            this.email.MaximumSize = new System.Drawing.Size(0, 60);
            this.email.MinimumSize = new System.Drawing.Size(0, 60);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ReadOnly = false;
            this.email.Size = new System.Drawing.Size(438, 60);
            this.email.TabIndex = 5;
            this.email.Value = "";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.accountLabel.Location = new System.Drawing.Point(9, 154);
            this.accountLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(81, 28);
            this.accountLabel.TabIndex = 20;
            this.accountLabel.Text = "Account";
            this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameLabel.Location = new System.Drawing.Point(9, 50);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 28);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.phoneNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.email, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 289);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(876, 60);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumber.LabelName = "Phone Number";
            this.phoneNumber.Location = new System.Drawing.Point(438, 0);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(0);
            this.phoneNumber.MaximumSize = new System.Drawing.Size(0, 60);
            this.phoneNumber.MinimumSize = new System.Drawing.Size(0, 60);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.PasswordChar = '\0';
            this.phoneNumber.ReadOnly = false;
            this.phoneNumber.Size = new System.Drawing.Size(438, 60);
            this.phoneNumber.TabIndex = 6;
            this.phoneNumber.Value = "";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.jobPosition);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.draggablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.draggablePanel.ResumeLayout(false);
            this.draggablePanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel closeButton;
        private Label label1;
        private Panel draggablePanel;
        private Components.CustomComboBox jobPosition;
        private TableLayoutPanel tableLayoutPanel2;
        private Components.CustomTextBox password;
        private Components.CustomTextBox username;
        private TableLayoutPanel tableLayoutPanel1;
        private Components.CustomTextBox lastName;
        private Components.CustomTextBox middleName;
        private Components.CustomTextBox firstName;
        private Label label3;
        private Button clearButton;
        private Button addButton;
        private Label label2;
        private Components.CustomTextBox email;
        private Label accountLabel;
        private Label nameLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Components.CustomTextBox phoneNumber;
    }
}