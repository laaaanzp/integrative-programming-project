namespace FinalsCollab.Forms.ContentPanels
{
    partial class EmployeeListPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new FinalsCollab.CustomControls.CButton();
            this.deleteButton = new FinalsCollab.CustomControls.CButton();
            this.editButton = new FinalsCollab.CustomControls.CButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printButton = new FinalsCollab.CustomControls.CButton();
            this.valueTextbox = new FinalsCollab.CustomControls.CTextbox();
            this.fieldComboBox = new FinalsCollab.CustomControls.CComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.middlename,
            this.lastname,
            this.position,
            this.email,
            this.phone});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(966, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LimeGreen;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.FillWeight = 40F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // firstname
            // 
            this.firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstname.FillWeight = 92.978F;
            this.firstname.HeaderText = "FIRSTNAME";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // middlename
            // 
            this.middlename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.middlename.FillWeight = 92.978F;
            this.middlename.HeaderText = "MIDDLENAME";
            this.middlename.Name = "middlename";
            this.middlename.ReadOnly = true;
            this.middlename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lastname
            // 
            this.lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastname.FillWeight = 92.978F;
            this.lastname.HeaderText = "LASTNAME";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // position
            // 
            this.position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.position.FillWeight = 92.978F;
            this.position.HeaderText = "POSITION";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.FillWeight = 120F;
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.FillWeight = 92.978F;
            this.phone.HeaderText = "PHONE";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee List";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.addButton.BorderRadius = 5;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(873, 634);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 2;
            this.addButton.TabStop = false;
            this.addButton.Text = "ADD";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.Coral;
            this.deleteButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.deleteButton.BorderRadius = 5;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(763, 634);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.editButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.editButton.BorderRadius = 5;
            this.editButton.BorderSize = 0;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(653, 634);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 40);
            this.editButton.TabIndex = 4;
            this.editButton.TabStop = false;
            this.editButton.Text = "EDIT";
            this.editButton.TextColor = System.Drawing.Color.White;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(5, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(968, 482);
            this.panel1.TabIndex = 5;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.printButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.printButton.BorderRadius = 5;
            this.printButton.BorderSize = 0;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(6, 634);
            this.printButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 40);
            this.printButton.TabIndex = 6;
            this.printButton.TabStop = false;
            this.printButton.Text = "PRINT";
            this.printButton.TextColor = System.Drawing.Color.White;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // valueTextbox
            // 
            this.valueTextbox._Text = "";
            this.valueTextbox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.valueTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.valueTextbox.BackColor = System.Drawing.Color.White;
            this.valueTextbox.InactiveColor = System.Drawing.Color.DimGray;
            this.valueTextbox.LabelText = "Value";
            this.valueTextbox.Location = new System.Drawing.Point(208, 559);
            this.valueTextbox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.valueTextbox.MaximumSize = new System.Drawing.Size(0, 60);
            this.valueTextbox.MaxLength = 32767;
            this.valueTextbox.MinimumSize = new System.Drawing.Size(0, 60);
            this.valueTextbox.Name = "valueTextbox";
            this.valueTextbox.ReadOnly = false;
            this.valueTextbox.Size = new System.Drawing.Size(339, 60);
            this.valueTextbox.TabIndex = 7;
            this.valueTextbox.TextChanged += new System.EventHandler(this.valueTextbox_TextChanged);
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.ActiveColor = System.Drawing.Color.LimeGreen;
            this.fieldComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fieldComboBox.BackColor = System.Drawing.Color.White;
            this.fieldComboBox.InactiveColor = System.Drawing.Color.DimGray;
            this.fieldComboBox.Items.AddRange(new object[] {
            "ID",
            "FIRSTNAME",
            "MIDDLENAME",
            "LASTNAME",
            "POSITION",
            "EMAIL",
            "PHONE"});
            this.fieldComboBox.LabelText = "Field";
            this.fieldComboBox.Location = new System.Drawing.Point(5, 559);
            this.fieldComboBox.MaximumSize = new System.Drawing.Size(0, 60);
            this.fieldComboBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.ReadOnly = false;
            this.fieldComboBox.Size = new System.Drawing.Size(200, 60);
            this.fieldComboBox.TabIndex = 8;
            this.fieldComboBox.Value = "ID";
            this.fieldComboBox.OnValueChanged += new System.EventHandler(this.fieldComboBox_OnValueChanged);
            // 
            // EmployeeListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldComboBox);
            this.Controls.Add(this.valueTextbox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeListPanel";
            this.Size = new System.Drawing.Size(978, 679);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private CustomControls.CButton addButton;
        private CustomControls.CButton deleteButton;
        private CustomControls.CButton editButton;
        private Panel panel1;
        private CustomControls.CButton printButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn middlename;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn position;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone;
        private CustomControls.CTextbox valueTextbox;
        private CustomControls.CComboBox fieldComboBox;
    }
}
