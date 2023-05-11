namespace HCMIS.Components
{
    partial class CustomNumericUpDown
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
            this.borderPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.decrementButton = new System.Windows.Forms.Button();
            this.incrementButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPanel
            // 
            this.borderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderPanel.BackColor = System.Drawing.Color.Gray;
            this.borderPanel.Location = new System.Drawing.Point(3, 56);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(352, 3);
            this.borderPanel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.decrementButton);
            this.panel3.Controls.Add(this.incrementButton);
            this.panel3.Controls.Add(this.textBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 53);
            this.panel3.TabIndex = 4;
            // 
            // decrementButton
            // 
            this.decrementButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.decrementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.decrementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decrementButton.FlatAppearance.BorderSize = 0;
            this.decrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrementButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decrementButton.ForeColor = System.Drawing.Color.White;
            this.decrementButton.Location = new System.Drawing.Point(319, 28);
            this.decrementButton.Name = "decrementButton";
            this.decrementButton.Size = new System.Drawing.Size(30, 23);
            this.decrementButton.TabIndex = 32;
            this.decrementButton.TabStop = false;
            this.decrementButton.Text = "▼";
            this.decrementButton.UseVisualStyleBackColor = false;
            this.decrementButton.Click += new System.EventHandler(this.decrementButton_Click);
            // 
            // incrementButton
            // 
            this.incrementButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.incrementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.incrementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incrementButton.FlatAppearance.BorderSize = 0;
            this.incrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incrementButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.incrementButton.ForeColor = System.Drawing.Color.White;
            this.incrementButton.Location = new System.Drawing.Point(319, 2);
            this.incrementButton.Name = "incrementButton";
            this.incrementButton.Size = new System.Drawing.Size(30, 23);
            this.incrementButton.TabIndex = 31;
            this.incrementButton.TabStop = false;
            this.incrementButton.Text = "▲";
            this.incrementButton.UseVisualStyleBackColor = false;
            this.incrementButton.Click += new System.EventHandler(this.incrementButton_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.Color.Gray;
            this.textBox.Location = new System.Drawing.Point(2, 24);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(318, 29);
            this.textBox.TabIndex = 1;
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.borderPanel);
            this.MaximumSize = new System.Drawing.Size(0, 60);
            this.MinimumSize = new System.Drawing.Size(0, 60);
            this.Name = "CustomNumericUpDown";
            this.Size = new System.Drawing.Size(358, 60);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel borderPanel;
        private Panel panel3;
        private TextBox textBox;
        private Label label1;
        private Button decrementButton;
        private Button incrementButton;
    }
}
