using HCMIS.Components;

namespace HCMIS
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
            label3 = new Label();
            pictureBox1 = new PictureBox();
            submitButton = new Button();
            closeButton = new Panel();
            minimizeButton = new Panel();
            usernameTextBox = new CustomTextBox();
            passwordTextBox = new CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Poppins SemiBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(160, 143);
            label3.Name = "label3";
            label3.Size = new Size(253, 84);
            label3.TabIndex = 2;
            label3.Text = "SIGN IN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.MouseMove += MouseDrag;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(236, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += MouseDrag;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(41, 193, 140);
            submitButton.Cursor = Cursors.Hand;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(132, 423);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(308, 56);
            submitButton.TabIndex = 6;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackgroundImage = Properties.Resources.CloseButton;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Location = new Point(542, 10);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(20, 20);
            closeButton.TabIndex = 7;
            closeButton.Click += closeButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButton.BackgroundImage = Properties.Resources.MinimizeButton;
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.Location = new Point(516, 10);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(20, 20);
            minimizeButton.TabIndex = 4;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.LabelName = "Username";
            usernameTextBox.Location = new Point(132, 245);
            usernameTextBox.MaximumSize = new Size(0, 60);
            usernameTextBox.MinimumSize = new Size(0, 60);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PasswordChar = '\0';
            usernameTextBox.ReadOnly = false;
            usernameTextBox.Size = new Size(308, 60);
            usernameTextBox.TabIndex = 8;
            usernameTextBox.Value = "";
            usernameTextBox.Load += usernameTextBox_Load;
            // 
            // passwordTextBox
            // 
            passwordTextBox.LabelName = "Password";
            passwordTextBox.Location = new Point(132, 325);
            passwordTextBox.MaximumSize = new Size(0, 60);
            passwordTextBox.MinimumSize = new Size(0, 60);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.ReadOnly = false;
            passwordTextBox.Size = new Size(308, 60);
            passwordTextBox.TabIndex = 9;
            passwordTextBox.Value = "";
            // 
            // LoginForm
            // 
            AcceptButton = submitButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(572, 507);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(minimizeButton);
            Controls.Add(closeButton);
            Controls.Add(submitButton);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Shown += LoginForm_Shown;
            MouseMove += MouseDrag;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Button submitButton;
        private Panel closeButton;
        private Panel minimizeButton;
        private CustomTextBox usernameTextBox;
        private CustomTextBox passwordTextBox;
    }
}