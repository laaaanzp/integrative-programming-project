namespace HCMIS
{
    partial class MainMenuForm
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
            this.draggablePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Panel();
            this.optionsContainer = new System.Windows.Forms.Panel();
            this.option8 = new System.Windows.Forms.Panel();
            this.option7 = new System.Windows.Forms.Panel();
            this.option6 = new System.Windows.Forms.Panel();
            this.option5 = new System.Windows.Forms.Panel();
            this.positionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.option4 = new System.Windows.Forms.Panel();
            this.option3 = new System.Windows.Forms.Panel();
            this.option2 = new System.Windows.Forms.Panel();
            this.option1 = new System.Windows.Forms.Panel();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.draggablePanel.SuspendLayout();
            this.optionsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // draggablePanel
            // 
            this.draggablePanel.BackColor = System.Drawing.Color.White;
            this.draggablePanel.Controls.Add(this.label1);
            this.draggablePanel.Controls.Add(this.minimizeButton);
            this.draggablePanel.Controls.Add(this.maximizeButton);
            this.draggablePanel.Controls.Add(this.clearButton);
            this.draggablePanel.Controls.Add(this.closeButton);
            this.draggablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.draggablePanel.Location = new System.Drawing.Point(0, 0);
            this.draggablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.draggablePanel.Name = "draggablePanel";
            this.draggablePanel.Size = new System.Drawing.Size(1280, 40);
            this.draggablePanel.TabIndex = 0;
            this.draggablePanel.DoubleClick += new System.EventHandler(this.toggleMaximizeWindow);
            this.draggablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDrag);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Information System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDrag);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackgroundImage = global::HCMIS.Properties.Resources.MinimizeButton;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Location = new System.Drawing.Point(1198, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackgroundImage = global::HCMIS.Properties.Resources.MaximizeButton;
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.Location = new System.Drawing.Point(1224, 10);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(20, 20);
            this.maximizeButton.TabIndex = 2;
            this.maximizeButton.Click += new System.EventHandler(this.toggleMaximizeWindow);
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
            this.clearButton.Location = new System.Drawing.Point(1102, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 31);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "LOGOUT";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = global::HCMIS.Properties.Resources.CloseButton;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(1250, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 1;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // optionsContainer
            // 
            this.optionsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.optionsContainer.Controls.Add(this.option8);
            this.optionsContainer.Controls.Add(this.option7);
            this.optionsContainer.Controls.Add(this.option6);
            this.optionsContainer.Controls.Add(this.option5);
            this.optionsContainer.Controls.Add(this.positionLabel);
            this.optionsContainer.Controls.Add(this.nameLabel);
            this.optionsContainer.Controls.Add(this.pictureBox1);
            this.optionsContainer.Controls.Add(this.option4);
            this.optionsContainer.Controls.Add(this.option3);
            this.optionsContainer.Controls.Add(this.option2);
            this.optionsContainer.Controls.Add(this.option1);
            this.optionsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsContainer.Location = new System.Drawing.Point(0, 40);
            this.optionsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.optionsContainer.Name = "optionsContainer";
            this.optionsContainer.Size = new System.Drawing.Size(250, 680);
            this.optionsContainer.TabIndex = 1;
            // 
            // option8
            // 
            this.option8.Location = new System.Drawing.Point(0, 600);
            this.option8.Name = "option8";
            this.option8.Size = new System.Drawing.Size(250, 50);
            this.option8.TabIndex = 11;
            // 
            // option7
            // 
            this.option7.Location = new System.Drawing.Point(0, 544);
            this.option7.Name = "option7";
            this.option7.Size = new System.Drawing.Size(250, 50);
            this.option7.TabIndex = 10;
            // 
            // option6
            // 
            this.option6.Location = new System.Drawing.Point(0, 488);
            this.option6.Name = "option6";
            this.option6.Size = new System.Drawing.Size(250, 50);
            this.option6.TabIndex = 3;
            // 
            // option5
            // 
            this.option5.Location = new System.Drawing.Point(0, 432);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(250, 50);
            this.option5.TabIndex = 3;
            // 
            // positionLabel
            // 
            this.positionLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionLabel.Location = new System.Drawing.Point(3, 156);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(244, 22);
            this.positionLabel.TabIndex = 5;
            this.positionLabel.Text = "Name";
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(3, 123);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(244, 33);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HCMIS.Properties.Resources.DefaultProfileImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(75, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // option4
            // 
            this.option4.Location = new System.Drawing.Point(0, 376);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(250, 50);
            this.option4.TabIndex = 2;
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(0, 320);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(250, 50);
            this.option3.TabIndex = 2;
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(0, 264);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(250, 50);
            this.option2.TabIndex = 1;
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(0, 208);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(250, 50);
            this.option1.TabIndex = 0;
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainContentPanel.Location = new System.Drawing.Point(250, 40);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(1027, 675);
            this.mainContentPanel.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.optionsContainer);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.draggablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenuForm_KeyPress);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainMenuForm_KeyPress);
            this.draggablePanel.ResumeLayout(false);
            this.draggablePanel.PerformLayout();
            this.optionsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel draggablePanel;
        private Panel closeButton;
        private Panel maximizeButton;
        private Panel minimizeButton;
        private Panel optionsContainer;
        private Panel option4;
        private Panel option3;
        private Panel option2;
        private Panel option1;
        private Panel mainContentPanel;
        private Label label1;
        private Label positionLabel;
        private Label nameLabel;
        private PictureBox pictureBox1;
        private Button clearButton;
        private Panel option7;
        private Panel option6;
        private Panel option5;
        private Panel option8;
    }
}