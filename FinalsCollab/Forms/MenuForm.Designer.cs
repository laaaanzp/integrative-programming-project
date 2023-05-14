namespace FinalsCollab.Forms
{
    partial class MenuForm
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
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.optionPanel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cButton2 = new FinalsCollab.CustomControls.CButton();
            this.cButton1 = new FinalsCollab.CustomControls.CButton();
            this.optionPanel6 = new System.Windows.Forms.Panel();
            this.optionPanel5 = new System.Windows.Forms.Panel();
            this.optionPanel4 = new System.Windows.Forms.Panel();
            this.optionPanel3 = new System.Windows.Forms.Panel();
            this.optionPanel1 = new System.Windows.Forms.Panel();
            this.positionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profileImagePictureBox = new System.Windows.Forms.PictureBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.headerPanel.Controls.Add(this.minimizeButton);
            this.headerPanel.Controls.Add(this.iconPictureBox);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.formNameLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1280, 40);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = global::FinalsCollab.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(1224, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 7;
            this.minimizeButton.TabStop = false;
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
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::FinalsCollab.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(1250, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // formNameLabel
            // 
            this.formNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formNameLabel.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formNameLabel.ForeColor = System.Drawing.Color.White;
            this.formNameLabel.Location = new System.Drawing.Point(35, 3);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(1183, 34);
            this.formNameLabel.TabIndex = 0;
            this.formNameLabel.Text = "Form Name";
            this.formNameLabel.DoubleClick += new System.EventHandler(this.formNameLabel_DoubleClick);
            this.formNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Controls.Add(this.mainContentPanel);
            this.contentPanel.Controls.Add(this.sidePanel);
            this.contentPanel.Location = new System.Drawing.Point(1, 40);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1278, 679);
            this.contentPanel.TabIndex = 1;
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(300, 0);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(978, 679);
            this.mainContentPanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Controls.Add(this.optionPanel2);
            this.sidePanel.Controls.Add(this.tableLayoutPanel1);
            this.sidePanel.Controls.Add(this.optionPanel6);
            this.sidePanel.Controls.Add(this.optionPanel5);
            this.sidePanel.Controls.Add(this.optionPanel4);
            this.sidePanel.Controls.Add(this.optionPanel3);
            this.sidePanel.Controls.Add(this.optionPanel1);
            this.sidePanel.Controls.Add(this.positionLabel);
            this.sidePanel.Controls.Add(this.nameLabel);
            this.sidePanel.Controls.Add(this.profileImagePictureBox);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(300, 679);
            this.sidePanel.TabIndex = 0;
            // 
            // optionPanel2
            // 
            this.optionPanel2.BackColor = System.Drawing.Color.White;
            this.optionPanel2.Location = new System.Drawing.Point(0, 152);
            this.optionPanel2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.optionPanel2.Name = "optionPanel2";
            this.optionPanel2.Size = new System.Drawing.Size(300, 50);
            this.optionPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cButton1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(98, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(189, 33);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cButton2.BorderColor = System.Drawing.Color.LimeGreen;
            this.cButton2.BorderRadius = 5;
            this.cButton2.BorderSize = 0;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.Location = new System.Drawing.Point(94, 0);
            this.cButton2.Margin = new System.Windows.Forms.Padding(0);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(95, 33);
            this.cButton2.TabIndex = 10;
            this.cButton2.Text = "LOGOUT";
            this.cButton2.TextColor = System.Drawing.Color.White;
            this.cButton2.UseVisualStyleBackColor = false;
            this.cButton2.Click += new System.EventHandler(this.logoutButtonClick);
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cButton1.BorderColor = System.Drawing.Color.LimeGreen;
            this.cButton1.BorderRadius = 5;
            this.cButton1.BorderSize = 0;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.Location = new System.Drawing.Point(0, 0);
            this.cButton1.Margin = new System.Windows.Forms.Padding(0);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(94, 33);
            this.cButton1.TabIndex = 9;
            this.cButton1.Text = "EDIT";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.editButtonClick);
            // 
            // optionPanel6
            // 
            this.optionPanel6.BackColor = System.Drawing.Color.White;
            this.optionPanel6.Location = new System.Drawing.Point(0, 372);
            this.optionPanel6.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.optionPanel6.Name = "optionPanel6";
            this.optionPanel6.Size = new System.Drawing.Size(300, 50);
            this.optionPanel6.TabIndex = 7;
            // 
            // optionPanel5
            // 
            this.optionPanel5.BackColor = System.Drawing.Color.White;
            this.optionPanel5.Location = new System.Drawing.Point(0, 317);
            this.optionPanel5.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.optionPanel5.Name = "optionPanel5";
            this.optionPanel5.Size = new System.Drawing.Size(300, 50);
            this.optionPanel5.TabIndex = 7;
            // 
            // optionPanel4
            // 
            this.optionPanel4.BackColor = System.Drawing.Color.White;
            this.optionPanel4.Location = new System.Drawing.Point(0, 262);
            this.optionPanel4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.optionPanel4.Name = "optionPanel4";
            this.optionPanel4.Size = new System.Drawing.Size(300, 50);
            this.optionPanel4.TabIndex = 7;
            // 
            // optionPanel3
            // 
            this.optionPanel3.BackColor = System.Drawing.Color.White;
            this.optionPanel3.Location = new System.Drawing.Point(0, 207);
            this.optionPanel3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.optionPanel3.Name = "optionPanel3";
            this.optionPanel3.Size = new System.Drawing.Size(300, 50);
            this.optionPanel3.TabIndex = 7;
            // 
            // optionPanel1
            // 
            this.optionPanel1.BackColor = System.Drawing.Color.White;
            this.optionPanel1.Location = new System.Drawing.Point(0, 97);
            this.optionPanel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.optionPanel1.Name = "optionPanel1";
            this.optionPanel1.Size = new System.Drawing.Size(300, 50);
            this.optionPanel1.TabIndex = 6;
            // 
            // positionLabel
            // 
            this.positionLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.positionLabel.Location = new System.Drawing.Point(94, 31);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(196, 21);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "BARANGAY HEALTH WORKER";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.nameLabel.Location = new System.Drawing.Point(91, 3);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(199, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = " ";
            // 
            // profileImagePictureBox
            // 
            this.profileImagePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.profileImagePictureBox.Location = new System.Drawing.Point(10, 10);
            this.profileImagePictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.profileImagePictureBox.Name = "profileImagePictureBox";
            this.profileImagePictureBox.Size = new System.Drawing.Size(75, 75);
            this.profileImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImagePictureBox.TabIndex = 0;
            this.profileImagePictureBox.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private Panel contentPanel;
        private Panel sidePanel;
        private Label positionLabel;
        private Label nameLabel;
        private PictureBox profileImagePictureBox;
        private Panel mainContentPanel;
        private PictureBox iconPictureBox;
        private Label formNameLabel;
        private Panel optionPanel6;
        private Panel optionPanel5;
        private Panel optionPanel4;
        private Panel optionPanel3;
        private Panel optionPanel2;
        private Panel optionPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CButton cButton2;
        private CustomControls.CButton cButton1;
        private PictureBox minimizeButton;
        private PictureBox closeButton;
    }
}