namespace HCMIS.Components
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            label1 = new Label();
            tableGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            JobPosition = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            removeButton = new Button();
            reloadDataButton = new Button();
            addButton = new Button();
            printButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(146, 34);
            label1.TabIndex = 0;
            label1.Text = "Employee List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableGrid
            // 
            tableGrid.AllowUserToAddRows = false;
            tableGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            tableGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableGrid.BackgroundColor = Color.WhiteSmoke;
            tableGrid.BorderStyle = BorderStyle.None;
            tableGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tableGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tableGrid.ColumnHeadersHeight = 50;
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tableGrid.Columns.AddRange(new DataGridViewColumn[] { ID, FirstName, MiddleName, LastName, JobPosition, Username, Password, Email, PhoneNumber });
            tableGrid.Cursor = Cursors.Hand;
            tableGrid.GridColor = Color.WhiteSmoke;
            tableGrid.Location = new Point(13, 47);
            tableGrid.MultiSelect = false;
            tableGrid.Name = "tableGrid";
            tableGrid.ReadOnly = true;
            tableGrid.RowHeadersVisible = false;
            tableGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(41, 193, 140);
            tableGrid.RowsDefaultCellStyle = dataGridViewCellStyle11;
            tableGrid.RowTemplate.Height = 25;
            tableGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableGrid.Size = new Size(1001, 569);
            tableGrid.TabIndex = 1;
            tableGrid.SelectionChanged += tableGrid_SelectionChanged;
            // 
            // ID
            // 
            dataGridViewCellStyle2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 193, 140);
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            ID.Width = 50;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 193, 140);
            FirstName.DefaultCellStyle = dataGridViewCellStyle3;
            FirstName.FillWeight = 120F;
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MiddleName
            // 
            MiddleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(41, 193, 140);
            MiddleName.DefaultCellStyle = dataGridViewCellStyle4;
            MiddleName.FillWeight = 120F;
            MiddleName.HeaderText = "Middle Name";
            MiddleName.Name = "MiddleName";
            MiddleName.ReadOnly = true;
            MiddleName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(41, 193, 140);
            LastName.DefaultCellStyle = dataGridViewCellStyle5;
            LastName.FillWeight = 120F;
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // JobPosition
            // 
            dataGridViewCellStyle6.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(41, 193, 140);
            JobPosition.DefaultCellStyle = dataGridViewCellStyle6;
            JobPosition.FillWeight = 120F;
            JobPosition.HeaderText = "Job Position";
            JobPosition.Name = "JobPosition";
            JobPosition.ReadOnly = true;
            JobPosition.SortMode = DataGridViewColumnSortMode.NotSortable;
            JobPosition.Width = 120;
            // 
            // Username
            // 
            dataGridViewCellStyle7.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(41, 193, 140);
            Username.DefaultCellStyle = dataGridViewCellStyle7;
            Username.FillWeight = 120F;
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.SortMode = DataGridViewColumnSortMode.NotSortable;
            Username.Width = 120;
            // 
            // Password
            // 
            dataGridViewCellStyle8.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(41, 193, 140);
            Password.DefaultCellStyle = dataGridViewCellStyle8;
            Password.FillWeight = 120F;
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.SortMode = DataGridViewColumnSortMode.NotSortable;
            Password.Width = 120;
            // 
            // Email
            // 
            dataGridViewCellStyle9.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(41, 193, 140);
            Email.DefaultCellStyle = dataGridViewCellStyle9;
            Email.FillWeight = 120F;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.SortMode = DataGridViewColumnSortMode.NotSortable;
            Email.Width = 120;
            // 
            // PhoneNumber
            // 
            dataGridViewCellStyle10.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(41, 193, 140);
            PhoneNumber.DefaultCellStyle = dataGridViewCellStyle10;
            PhoneNumber.FillWeight = 110F;
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            PhoneNumber.Width = 110;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            removeButton.BackColor = Color.LightCoral;
            removeButton.Cursor = Cursors.Hand;
            removeButton.FlatAppearance.BorderSize = 0;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(914, 622);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(100, 40);
            removeButton.TabIndex = 11;
            removeButton.Text = "REMOVE";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // reloadDataButton
            // 
            reloadDataButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reloadDataButton.BackColor = Color.FromArgb(0, 192, 0);
            reloadDataButton.Cursor = Cursors.Hand;
            reloadDataButton.FlatAppearance.BorderSize = 0;
            reloadDataButton.FlatStyle = FlatStyle.Flat;
            reloadDataButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reloadDataButton.ForeColor = Color.White;
            reloadDataButton.Location = new Point(808, 622);
            reloadDataButton.Name = "reloadDataButton";
            reloadDataButton.Size = new Size(100, 40);
            reloadDataButton.TabIndex = 12;
            reloadDataButton.Text = "RELOAD";
            reloadDataButton.UseVisualStyleBackColor = false;
            reloadDataButton.Click += reloadDataButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(128, 128, 255);
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(702, 622);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 40);
            addButton.TabIndex = 36;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // printButton
            // 
            printButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            printButton.BackColor = Color.FromArgb(128, 128, 255);
            printButton.Cursor = Cursors.Hand;
            printButton.FlatAppearance.BorderSize = 0;
            printButton.FlatStyle = FlatStyle.Flat;
            printButton.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            printButton.ForeColor = Color.White;
            printButton.Location = new Point(13, 622);
            printButton.Name = "printButton";
            printButton.Size = new Size(139, 40);
            printButton.TabIndex = 56;
            printButton.TabStop = false;
            printButton.Text = "SAVE REPORT";
            printButton.UseVisualStyleBackColor = false;
            printButton.Visible = false;
            printButton.Click += printButton_Click;
            // 
            // EmployeeListPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(printButton);
            Controls.Add(addButton);
            Controls.Add(reloadDataButton);
            Controls.Add(removeButton);
            Controls.Add(tableGrid);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "EmployeeListPanel";
            Padding = new Padding(10);
            Size = new Size(1027, 675);
            ((System.ComponentModel.ISupportInitialize)tableGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tableGrid;
        private Button removeButton;
        private Button reloadDataButton;
        private Button addButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn JobPosition;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private Button printButton;
    }
}
