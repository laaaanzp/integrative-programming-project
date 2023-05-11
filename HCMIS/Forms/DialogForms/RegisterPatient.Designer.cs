namespace HCMIS
{
    partial class RegisterPatient
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
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numberOfKidsNumericUpDown = new HCMIS.Components.CustomNumericUpDown();
            this.bdayDatePicker = new HCMIS.Components.CustomDatePicker();
            this.bdayYear = new HCMIS.Components.CustomTextBox();
            this.bdayDay = new HCMIS.Components.CustomTextBox();
            this.bdayMonth = new HCMIS.Components.CustomTextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.phoneNumberTextBox = new HCMIS.Components.CustomTextBox();
            this.emailTextBox = new HCMIS.Components.CustomTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fullnameTextBox = new HCMIS.Components.CustomTextBox();
            this.genderComboBox = new HCMIS.Components.CustomComboBox();
            this.addressTextBox = new HCMIS.Components.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maritalStatusComboBox = new HCMIS.Components.CustomComboBox();
            this.bloodTypeComboBox = new HCMIS.Components.CustomComboBox();
            this.draggablePanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = global::HCMIS.Properties.Resources.CloseButton;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(806, 10);
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
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Patient";
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
            this.draggablePanel.Size = new System.Drawing.Size(836, 40);
            this.draggablePanel.TabIndex = 0;
            this.draggablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDrag);
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
            this.clearButton.Location = new System.Drawing.Point(594, 548);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 40);
            this.clearButton.TabIndex = 15;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            this.addButton.Location = new System.Drawing.Point(712, 548);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 40);
            this.addButton.TabIndex = 16;
            this.addButton.TabStop = false;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.maritalStatusComboBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.numberOfKidsNumericUpDown, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(333, 329);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(480, 60);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // numberOfKidsNumericUpDown
            // 
            this.numberOfKidsNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfKidsNumericUpDown.LabelName = "Number of kids";
            this.numberOfKidsNumericUpDown.Location = new System.Drawing.Point(240, 0);
            this.numberOfKidsNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.numberOfKidsNumericUpDown.Maximum = 100;
            this.numberOfKidsNumericUpDown.MaximumSize = new System.Drawing.Size(0, 60);
            this.numberOfKidsNumericUpDown.Minimum = 0;
            this.numberOfKidsNumericUpDown.MinimumSize = new System.Drawing.Size(0, 60);
            this.numberOfKidsNumericUpDown.Name = "numberOfKidsNumericUpDown";
            this.numberOfKidsNumericUpDown.ReadOnly = false;
            this.numberOfKidsNumericUpDown.Size = new System.Drawing.Size(240, 60);
            this.numberOfKidsNumericUpDown.TabIndex = 13;
            this.numberOfKidsNumericUpDown.TimeFormat = false;
            this.numberOfKidsNumericUpDown.Value = 0;
            // 
            // bdayDatePicker
            // 
            this.bdayDatePicker.Location = new System.Drawing.Point(90, 293);
            this.bdayDatePicker.Name = "bdayDatePicker";
            this.bdayDatePicker.Size = new System.Drawing.Size(101, 30);
            this.bdayDatePicker.TabIndex = 52;
            this.bdayDatePicker.OnValueChanged += new System.EventHandler<System.DateOnly>(this.SetBirthdayDate);
            // 
            // bdayYear
            // 
            this.bdayYear.LabelName = "Year";
            this.bdayYear.Location = new System.Drawing.Point(225, 329);
            this.bdayYear.MaximumSize = new System.Drawing.Size(0, 60);
            this.bdayYear.MinimumSize = new System.Drawing.Size(0, 60);
            this.bdayYear.Name = "bdayYear";
            this.bdayYear.PasswordChar = '\0';
            this.bdayYear.ReadOnly = true;
            this.bdayYear.Size = new System.Drawing.Size(90, 60);
            this.bdayYear.TabIndex = 10;
            this.bdayYear.Value = "";
            // 
            // bdayDay
            // 
            this.bdayDay.LabelName = "Day";
            this.bdayDay.Location = new System.Drawing.Point(140, 329);
            this.bdayDay.MaximumSize = new System.Drawing.Size(0, 60);
            this.bdayDay.MinimumSize = new System.Drawing.Size(0, 60);
            this.bdayDay.Name = "bdayDay";
            this.bdayDay.PasswordChar = '\0';
            this.bdayDay.ReadOnly = true;
            this.bdayDay.Size = new System.Drawing.Size(79, 60);
            this.bdayDay.TabIndex = 9;
            this.bdayDay.Value = "";
            // 
            // bdayMonth
            // 
            this.bdayMonth.LabelName = "Month";
            this.bdayMonth.Location = new System.Drawing.Point(9, 329);
            this.bdayMonth.MaximumSize = new System.Drawing.Size(0, 60);
            this.bdayMonth.MinimumSize = new System.Drawing.Size(0, 60);
            this.bdayMonth.Name = "bdayMonth";
            this.bdayMonth.PasswordChar = '\0';
            this.bdayMonth.ReadOnly = true;
            this.bdayMonth.Size = new System.Drawing.Size(125, 60);
            this.bdayMonth.TabIndex = 8;
            this.bdayMonth.Value = "";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.birthdayLabel.Location = new System.Drawing.Point(6, 298);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(81, 28);
            this.birthdayLabel.TabIndex = 48;
            this.birthdayLabel.Text = "Birthday";
            this.birthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.phoneNumberTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.emailTextBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 148);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 60);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumberTextBox.LabelName = "Phone Number";
            this.phoneNumberTextBox.Location = new System.Drawing.Point(402, 0);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.phoneNumberTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.phoneNumberTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PasswordChar = '\0';
            this.phoneNumberTextBox.ReadOnly = false;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(402, 60);
            this.phoneNumberTextBox.TabIndex = 6;
            this.phoneNumberTextBox.Value = "";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTextBox.LabelName = "Email";
            this.emailTextBox.Location = new System.Drawing.Point(0, 0);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.emailTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.ReadOnly = false;
            this.emailTextBox.Size = new System.Drawing.Size(402, 60);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Value = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.Controls.Add(this.fullnameTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.genderComboBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullnameTextBox.LabelName = "Fullname";
            this.fullnameTextBox.Location = new System.Drawing.Point(0, 0);
            this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.fullnameTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.fullnameTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.PasswordChar = '\0';
            this.fullnameTextBox.ReadOnly = false;
            this.fullnameTextBox.Size = new System.Drawing.Size(468, 60);
            this.fullnameTextBox.TabIndex = 2;
            this.fullnameTextBox.Value = "";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.genderComboBox.LabelText = "Gender";
            this.genderComboBox.Location = new System.Drawing.Point(468, 0);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.genderComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.genderComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.ReadOnly = false;
            this.genderComboBox.Size = new System.Drawing.Size(336, 60);
            this.genderComboBox.TabIndex = 3;
            this.genderComboBox.Value = "";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.LabelName = "Address";
            this.addressTextBox.Location = new System.Drawing.Point(9, 228);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.addressTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.addressTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.ReadOnly = false;
            this.addressTextBox.Size = new System.Drawing.Size(804, 60);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.Value = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Contact";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maritalStatusComboBox
            // 
            this.maritalStatusComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maritalStatusComboBox.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.maritalStatusComboBox.LabelText = "Marital Status";
            this.maritalStatusComboBox.Location = new System.Drawing.Point(0, 0);
            this.maritalStatusComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.maritalStatusComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.maritalStatusComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.maritalStatusComboBox.Name = "maritalStatusComboBox";
            this.maritalStatusComboBox.ReadOnly = false;
            this.maritalStatusComboBox.Size = new System.Drawing.Size(240, 60);
            this.maritalStatusComboBox.TabIndex = 12;
            this.maritalStatusComboBox.Value = "";
            this.maritalStatusComboBox.OnValueChanged += new System.EventHandler(this.maritalStatusComboBox_OnValueChanged);
            // 
            // bloodTypeComboBox
            // 
            this.bloodTypeComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodTypeComboBox.LabelText = "Blood Type";
            this.bloodTypeComboBox.Location = new System.Drawing.Point(9, 412);
            this.bloodTypeComboBox.Margin = new System.Windows.Forms.Padding(0, 20, 18, 0);
            this.bloodTypeComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.bloodTypeComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.bloodTypeComboBox.Name = "bloodTypeComboBox";
            this.bloodTypeComboBox.ReadOnly = false;
            this.bloodTypeComboBox.Size = new System.Drawing.Size(222, 60);
            this.bloodTypeComboBox.TabIndex = 14;
            this.bloodTypeComboBox.Value = "";
            // 
            // RegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 600);
            this.Controls.Add(this.bloodTypeComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.bdayDatePicker);
            this.Controls.Add(this.bdayYear);
            this.Controls.Add(this.bdayDay);
            this.Controls.Add(this.bdayMonth);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.draggablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "RegisterPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.draggablePanel.ResumeLayout(false);
            this.draggablePanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel closeButton;
        private Label label1;
        private Panel draggablePanel;
        private Button clearButton;
        private Button addButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Components.CustomNumericUpDown numberOfKidsNumericUpDown;
        private Components.CustomDatePicker bdayDatePicker;
        private Components.CustomTextBox bdayYear;
        private Components.CustomTextBox bdayDay;
        private Components.CustomTextBox bdayMonth;
        private Label birthdayLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Components.CustomTextBox phoneNumberTextBox;
        private Components.CustomTextBox emailTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Components.CustomTextBox fullnameTextBox;
        private Components.CustomComboBox genderComboBox;
        private Components.CustomTextBox addressTextBox;
        private Label label2;
        private Components.CustomComboBox maritalStatusComboBox;
        private Components.CustomComboBox bloodTypeComboBox;
    }
}