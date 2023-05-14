namespace FinalsCollab.Forms.DialogForms
{
    partial class QueueForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bloodPressureTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.weightKgNumericTextbox = new FinalsCollab.CustomControls.CNumericTextbox();
            this.heightFtNumericTextbox = new FinalsCollab.CustomControls.CNumericTextbox2();
            this.bmiNumericTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.cButton1 = new FinalsCollab.CustomControls.CButton();
            this.reasonComboBox = new FinalsCollab.CustomControls.CComboBox();
            this.fullnameTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.cancelButton = new FinalsCollab.CustomControls.CButton();
            this.submitButton = new FinalsCollab.CustomControls.CButton();
            this.patientIdNumericTextbox = new FinalsCollab.CustomControls.CNumericTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.mainContentPanel.SuspendLayout();
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
            this.formNameLabel.Size = new System.Drawing.Size(125, 34);
            this.formNameLabel.TabIndex = 0;
            this.formNameLabel.Text = "Add Queue";
            this.formNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainContentPanel.Controls.Add(this.label3);
            this.mainContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainContentPanel.Controls.Add(this.label2);
            this.mainContentPanel.Controls.Add(this.cButton1);
            this.mainContentPanel.Controls.Add(this.reasonComboBox);
            this.mainContentPanel.Controls.Add(this.fullnameTextbox);
            this.mainContentPanel.Controls.Add(this.cancelButton);
            this.mainContentPanel.Controls.Add(this.submitButton);
            this.mainContentPanel.Controls.Add(this.patientIdNumericTextbox);
            this.mainContentPanel.Controls.Add(this.label1);
            this.mainContentPanel.Location = new System.Drawing.Point(1, 41);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(1);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(798, 411);
            this.mainContentPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(5, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reason";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.bloodPressureTextbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.weightKgNumericTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.heightFtNumericTextbox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bmiNumericTextbox, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 60);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // bloodPressureTextbox
            // 
            this.bloodPressureTextbox._Text = "";
            this.bloodPressureTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.bloodPressureTextbox.BackColor = System.Drawing.Color.White;
            this.bloodPressureTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodPressureTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.bloodPressureTextbox.LabelText = "Blood Pressure";
            this.bloodPressureTextbox.Location = new System.Drawing.Point(0, 0);
            this.bloodPressureTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bloodPressureTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.bloodPressureTextbox.MaxLength = 32767;
            this.bloodPressureTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.bloodPressureTextbox.Name = "bloodPressureTextbox";
            this.bloodPressureTextbox.ReadOnly = false;
            this.bloodPressureTextbox.Size = new System.Drawing.Size(192, 60);
            this.bloodPressureTextbox.TabIndex = 1;
            // 
            // weightKgNumericTextbox
            // 
            this.weightKgNumericTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.weightKgNumericTextbox.BackColor = System.Drawing.Color.White;
            this.weightKgNumericTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightKgNumericTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.weightKgNumericTextbox.LabelText = "Weight (kg)";
            this.weightKgNumericTextbox.Location = new System.Drawing.Point(197, 0);
            this.weightKgNumericTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.weightKgNumericTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.weightKgNumericTextbox.MaxLength = 32767;
            this.weightKgNumericTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.weightKgNumericTextbox.Name = "weightKgNumericTextbox";
            this.weightKgNumericTextbox.ReadOnly = false;
            this.weightKgNumericTextbox.Size = new System.Drawing.Size(192, 60);
            this.weightKgNumericTextbox.TabIndex = 2;
            this.weightKgNumericTextbox.Value = ((long)(0));
            this.weightKgNumericTextbox.TextChanged += new System.EventHandler(this.cNumericTextbox1_TextChanged);
            // 
            // heightFtNumericTextbox
            // 
            this.heightFtNumericTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.heightFtNumericTextbox.BackColor = System.Drawing.Color.White;
            this.heightFtNumericTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightFtNumericTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.heightFtNumericTextbox.LabelText = "Height (ft)";
            this.heightFtNumericTextbox.Location = new System.Drawing.Point(394, 0);
            this.heightFtNumericTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.heightFtNumericTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.heightFtNumericTextbox.MaxLength = 32767;
            this.heightFtNumericTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.heightFtNumericTextbox.Name = "heightFtNumericTextbox";
            this.heightFtNumericTextbox.ReadOnly = false;
            this.heightFtNumericTextbox.Size = new System.Drawing.Size(192, 60);
            this.heightFtNumericTextbox.TabIndex = 3;
            this.heightFtNumericTextbox.Value = 0D;
            this.heightFtNumericTextbox.TextChanged += new System.EventHandler(this.cNumericTextbox21_TextChanged);
            // 
            // bmiNumericTextbox
            // 
            this.bmiNumericTextbox._Text = "";
            this.bmiNumericTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.bmiNumericTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.bmiNumericTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmiNumericTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.bmiNumericTextbox.LabelText = "BMI";
            this.bmiNumericTextbox.Location = new System.Drawing.Point(591, 0);
            this.bmiNumericTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.bmiNumericTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.bmiNumericTextbox.MaxLength = 32767;
            this.bmiNumericTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.bmiNumericTextbox.Name = "bmiNumericTextbox";
            this.bmiNumericTextbox.ReadOnly = true;
            this.bmiNumericTextbox.Size = new System.Drawing.Size(197, 60);
            this.bmiNumericTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Additional Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.cButton1.BorderColor = System.Drawing.Color.LimeGreen;
            this.cButton1.BorderRadius = 5;
            this.cButton1.BorderSize = 0;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.Location = new System.Drawing.Point(189, 49);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(89, 60);
            this.cButton1.TabIndex = 15;
            this.cButton1.Text = "FIND";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // reasonComboBox
            // 
            this.reasonComboBox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.reasonComboBox.BackColor = System.Drawing.Color.White;
            this.reasonComboBox.InactiveColor = System.Drawing.Color.DimGray;
            this.reasonComboBox.Items.AddRange(new object[] {
            "Checkup",
            "Vaccine"});
            this.reasonComboBox.LabelText = "Reason";
            this.reasonComboBox.Location = new System.Drawing.Point(5, 274);
            this.reasonComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.reasonComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.reasonComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.reasonComboBox.Name = "reasonComboBox";
            this.reasonComboBox.ReadOnly = false;
            this.reasonComboBox.Size = new System.Drawing.Size(197, 60);
            this.reasonComboBox.TabIndex = 4;
            this.reasonComboBox.Value = "Checkup";
            // 
            // fullnameTextbox
            // 
            this.fullnameTextbox._Text = "";
            this.fullnameTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.fullnameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullnameTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.fullnameTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.fullnameTextbox.LabelText = "Fullname";
            this.fullnameTextbox.Location = new System.Drawing.Point(286, 49);
            this.fullnameTextbox.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.fullnameTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.fullnameTextbox.MaxLength = 32767;
            this.fullnameTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.fullnameTextbox.Name = "fullnameTextbox";
            this.fullnameTextbox.ReadOnly = true;
            this.fullnameTextbox.Size = new System.Drawing.Size(507, 60);
            this.fullnameTextbox.TabIndex = 14;
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
            this.cancelButton.Location = new System.Drawing.Point(583, 366);
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
            this.submitButton.Location = new System.Drawing.Point(693, 366);
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
            // patientIdNumericTextbox
            // 
            this.patientIdNumericTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.patientIdNumericTextbox.BackColor = System.Drawing.Color.White;
            this.patientIdNumericTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.patientIdNumericTextbox.LabelText = "Patient ID";
            this.patientIdNumericTextbox.Location = new System.Drawing.Point(5, 49);
            this.patientIdNumericTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.patientIdNumericTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.patientIdNumericTextbox.MaxLength = 32767;
            this.patientIdNumericTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.patientIdNumericTextbox.Name = "patientIdNumericTextbox";
            this.patientIdNumericTextbox.ReadOnly = false;
            this.patientIdNumericTextbox.Size = new System.Drawing.Size(176, 60);
            this.patientIdNumericTextbox.TabIndex = 0;
            this.patientIdNumericTextbox.Value = ((long)(0));
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
            // QueueForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "QueueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private PictureBox iconPictureBox;
        private Label formNameLabel;
        private Panel mainContentPanel;
        private CustomControls.CNumericTextbox patientIdNumericTextbox;
        private Label label1;
        private CustomControls.CButton cancelButton;
        private CustomControls.CButton submitButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private CustomControls.CButton cButton1;
        private CustomControls.CTextbox fullnameTextbox;
        private CustomControls.CTextbox bloodPressureTextbox;
        private CustomControls.CNumericTextbox weightKgNumericTextbox;
        private CustomControls.CNumericTextbox2 heightFtNumericTextbox;
        private CustomControls.CTextbox bmiNumericTextbox;
        private CustomControls.CComboBox reasonComboBox;
        private Label label3;
    }
}