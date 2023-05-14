namespace FinalsCollab
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.passwordTextbox = new FinalsCollab.CustomControls.CPasswordTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new FinalsCollab.CustomControls.CButton();
            this.rememberCredentialsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.usernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextbox.BackColor = System.Drawing.Color.White;
            this.usernameTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.usernameTextbox.LabelText = "Username";
            this.usernameTextbox.Location = new System.Drawing.Point(50, 242);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.usernameTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.usernameTextbox.MaxLength = 32767;
            this.usernameTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.ReadOnly = false;
            this.usernameTextbox.Size = new System.Drawing.Size(300, 60);
            this.usernameTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.BackColor = System.Drawing.Color.White;
            this.passwordTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.passwordTextbox.LabelText = "Password";
            this.passwordTextbox.Location = new System.Drawing.Point(50, 321);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.passwordTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.ReadOnly = false;
            this.passwordTextbox.Size = new System.Drawing.Size(300, 60);
            this.passwordTextbox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FinalsCollab.Properties.Resources.healthcare;
            this.pictureBox1.Location = new System.Drawing.Point(144, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::FinalsCollab.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(370, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = global::FinalsCollab.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(344, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Poppins", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "SIGN IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LimeGreen;
            this.submitButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.submitButton.BorderRadius = 5;
            this.submitButton.BorderSize = 1;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(50, 431);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(300, 60);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.TextColor = System.Drawing.Color.White;
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // rememberCredentialsCheckBox
            // 
            this.rememberCredentialsCheckBox.AutoSize = true;
            this.rememberCredentialsCheckBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rememberCredentialsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rememberCredentialsCheckBox.FlatAppearance.BorderSize = 0;
            this.rememberCredentialsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rememberCredentialsCheckBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rememberCredentialsCheckBox.ForeColor = System.Drawing.Color.DimGray;
            this.rememberCredentialsCheckBox.Location = new System.Drawing.Point(50, 384);
            this.rememberCredentialsCheckBox.Name = "rememberCredentialsCheckBox";
            this.rememberCredentialsCheckBox.Size = new System.Drawing.Size(110, 26);
            this.rememberCredentialsCheckBox.TabIndex = 8;
            this.rememberCredentialsCheckBox.Text = "Remember Me";
            this.rememberCredentialsCheckBox.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 504);
            this.Controls.Add(this.rememberCredentialsCheckBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.LoginForm_Deactivate);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CTextbox usernameTextbox;
        private CustomControls.CPasswordTextbox passwordTextbox;
        private PictureBox pictureBox1;
        private PictureBox closeButton;
        private PictureBox minimizeButton;
        private Label label1;
        private CustomControls.CButton submitButton;
        private CheckBox rememberCredentialsCheckBox;
    }
}