namespace FinalsCollab.CustomControls
{
    partial class CComboBox
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
            this.comboBox = new FinalsCollab.CustomControls._CComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.BorderColor = System.Drawing.Color.White;
            this.comboBox.BorderSize = 1;
            this.comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox.IconColor = System.Drawing.Color.DimGray;
            this.comboBox.ListBackColor = System.Drawing.Color.White;
            this.comboBox.ListTextColor = System.Drawing.Color.LimeGreen;
            this.comboBox.Location = new System.Drawing.Point(-7, 29);
            this.comboBox.MinimumSize = new System.Drawing.Size(200, 32);
            this.comboBox.Name = "comboBox";
            this.comboBox.Padding = new System.Windows.Forms.Padding(1);
            this.comboBox.Size = new System.Drawing.Size(259, 32);
            this.comboBox.TabIndex = 5;
            this.comboBox.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Label Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 3);
            this.panel1.TabIndex = 6;
            // 
            // CComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(0, 60);
            this.MinimumSize = new System.Drawing.Size(0, 60);
            this.Name = "CComboBox";
            this.Size = new System.Drawing.Size(250, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _CComboBox comboBox;
        private Label label1;
        private Panel panel1;
    }
}
