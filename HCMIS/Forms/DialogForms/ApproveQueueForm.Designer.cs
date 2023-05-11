namespace HCMIS
{
    partial class ApproveQueueForm
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
            this.remarksTextBox = new HCMIS.Components.CustomTextBox();
            this.deferredCheckBox = new System.Windows.Forms.CheckBox();
            this.approveButton = new System.Windows.Forms.Button();
            this.draggablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = global::HCMIS.Properties.Resources.CloseButton;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(570, 10);
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
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Approve Form";
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
            this.draggablePanel.Size = new System.Drawing.Size(600, 40);
            this.draggablePanel.TabIndex = 0;
            this.draggablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDrag);
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.LabelName = "Remarks";
            this.remarksTextBox.Location = new System.Drawing.Point(12, 57);
            this.remarksTextBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.remarksTextBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.PasswordChar = '\0';
            this.remarksTextBox.ReadOnly = false;
            this.remarksTextBox.Size = new System.Drawing.Size(576, 60);
            this.remarksTextBox.TabIndex = 1;
            this.remarksTextBox.Value = "";
            // 
            // deferredCheckBox
            // 
            this.deferredCheckBox.AutoSize = true;
            this.deferredCheckBox.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deferredCheckBox.ForeColor = System.Drawing.Color.Gray;
            this.deferredCheckBox.Location = new System.Drawing.Point(12, 123);
            this.deferredCheckBox.Name = "deferredCheckBox";
            this.deferredCheckBox.Size = new System.Drawing.Size(110, 32);
            this.deferredCheckBox.TabIndex = 2;
            this.deferredCheckBox.Text = "Deferred?";
            this.deferredCheckBox.UseVisualStyleBackColor = true;
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
            this.approveButton.Location = new System.Drawing.Point(488, 178);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(100, 40);
            this.approveButton.TabIndex = 34;
            this.approveButton.TabStop = false;
            this.approveButton.Text = "APPROVE";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // ApproveQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 230);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.deferredCheckBox);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.draggablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "ApproveQueueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.draggablePanel.ResumeLayout(false);
            this.draggablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel closeButton;
        private Label label1;
        private Panel draggablePanel;
        private Components.CustomTextBox remarksTextBox;
        private CheckBox deferredCheckBox;
        private Button approveButton;
    }
}