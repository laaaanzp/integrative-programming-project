namespace FinalsCollab.CustomControls
{
    partial class CPasswordTextbox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textVisibilityToggle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textVisibilityToggle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 3);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Label Text";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(7, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this._setAsActive);
            this.textBox1.Leave += new System.EventHandler(this._setAsInactive);
            // 
            // textVisibilityToggle
            // 
            this.textVisibilityToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textVisibilityToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textVisibilityToggle.Image = global::FinalsCollab.Properties.Resources.show;
            this.textVisibilityToggle.Location = new System.Drawing.Point(221, 32);
            this.textVisibilityToggle.Margin = new System.Windows.Forms.Padding(0);
            this.textVisibilityToggle.Name = "textVisibilityToggle";
            this.textVisibilityToggle.Size = new System.Drawing.Size(24, 24);
            this.textVisibilityToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.textVisibilityToggle.TabIndex = 3;
            this.textVisibilityToggle.TabStop = false;
            this.textVisibilityToggle.Click += new System.EventHandler(this.textVisibilityToggle_Click);
            // 
            // CPasswordTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textVisibilityToggle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 60);
            this.MinimumSize = new System.Drawing.Size(0, 60);
            this.Name = "CPasswordTextbox";
            this.Size = new System.Drawing.Size(250, 60);
            ((System.ComponentModel.ISupportInitialize)(this.textVisibilityToggle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox textVisibilityToggle;
    }
}
