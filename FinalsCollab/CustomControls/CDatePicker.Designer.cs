namespace FinalsCollab.CustomControls
{
    partial class CDatePicker
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
            this.chooseDateButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // chooseDateButton
            // 
            this.chooseDateButton.BackColor = System.Drawing.Color.LimeGreen;
            this.chooseDateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseDateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseDateButton.FlatAppearance.BorderSize = 0;
            this.chooseDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseDateButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseDateButton.ForeColor = System.Drawing.Color.White;
            this.chooseDateButton.Location = new System.Drawing.Point(0, 0);
            this.chooseDateButton.Name = "chooseDateButton";
            this.chooseDateButton.Size = new System.Drawing.Size(101, 30);
            this.chooseDateButton.TabIndex = 19;
            this.chooseDateButton.Text = "CHOOSE DATE";
            this.chooseDateButton.UseVisualStyleBackColor = false;
            this.chooseDateButton.Click += new System.EventHandler(this.chooseDateButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(0, 8);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(0, 23);
            this.datePicker.TabIndex = 20;
            this.datePicker.CloseUp += new System.EventHandler(this.datePicker_CloseUp);
            // 
            // CDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.chooseDateButton);
            this.Name = "CDatePicker";
            this.Size = new System.Drawing.Size(101, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Button chooseDateButton;
        private DateTimePicker datePicker;
    }
}
