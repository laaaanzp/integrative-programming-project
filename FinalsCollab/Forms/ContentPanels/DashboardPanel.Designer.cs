namespace FinalsCollab.Forms.ContentPanels
{
    partial class DashboardPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.totalVisit = new FinalsCollab.CustomControls.CDashboardContent();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.currentQueueVisit = new FinalsCollab.CustomControls.CDashboardContent();
            this.last30DaysVisit = new FinalsCollab.CustomControls.CDashboardContent();
            this.last7DaysVisit = new FinalsCollab.CustomControls.CDashboardContent();
            this.todayVisit = new FinalsCollab.CustomControls.CDashboardContent();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.othersPatients = new FinalsCollab.CustomControls.CDashboardContent();
            this.femalePatients = new FinalsCollab.CustomControls.CDashboardContent();
            this.malePatients = new FinalsCollab.CustomControls.CDashboardContent();
            this.totalPatients = new FinalsCollab.CustomControls.CDashboardContent();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.onlineEmployees = new FinalsCollab.CustomControls.CDashboardContent();
            this.totalEmployees = new FinalsCollab.CustomControls.CDashboardContent();
            this.bhwEmployees = new FinalsCollab.CustomControls.CDashboardContent();
            this.nurseEmployees = new FinalsCollab.CustomControls.CDashboardContent();
            this.doctorEmployees = new FinalsCollab.CustomControls.CDashboardContent();
            this.adminEmployees = new FinalsCollab.CustomControls.CDashboardContent();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // totalVisit
            // 
            this.totalVisit.BackColor = System.Drawing.Color.White;
            this.totalVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalVisit.LabelColor = System.Drawing.Color.DimGray;
            this.totalVisit.LabelText = "Total";
            this.totalVisit.Location = new System.Drawing.Point(3, 3);
            this.totalVisit.MaximumSize = new System.Drawing.Size(0, 70);
            this.totalVisit.MinimumSize = new System.Drawing.Size(0, 70);
            this.totalVisit.Name = "totalVisit";
            this.totalVisit.SidebarColor = System.Drawing.Color.LimeGreen;
            this.totalVisit.Size = new System.Drawing.Size(187, 70);
            this.totalVisit.TabIndex = 1;
            this.totalVisit.ValueText = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.currentQueueVisit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.last30DaysVisit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.last7DaysVisit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.todayVisit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalVisit, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 94);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 76);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // currentQueueVisit
            // 
            this.currentQueueVisit.BackColor = System.Drawing.Color.White;
            this.currentQueueVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentQueueVisit.LabelColor = System.Drawing.Color.DimGray;
            this.currentQueueVisit.LabelText = "Current Queue";
            this.currentQueueVisit.Location = new System.Drawing.Point(196, 3);
            this.currentQueueVisit.MaximumSize = new System.Drawing.Size(0, 70);
            this.currentQueueVisit.MinimumSize = new System.Drawing.Size(0, 70);
            this.currentQueueVisit.Name = "currentQueueVisit";
            this.currentQueueVisit.SidebarColor = System.Drawing.Color.LimeGreen;
            this.currentQueueVisit.Size = new System.Drawing.Size(187, 70);
            this.currentQueueVisit.TabIndex = 5;
            this.currentQueueVisit.ValueText = "0";
            // 
            // last30DaysVisit
            // 
            this.last30DaysVisit.BackColor = System.Drawing.Color.White;
            this.last30DaysVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.last30DaysVisit.LabelColor = System.Drawing.Color.DimGray;
            this.last30DaysVisit.LabelText = "Last 30 Days";
            this.last30DaysVisit.Location = new System.Drawing.Point(775, 3);
            this.last30DaysVisit.MaximumSize = new System.Drawing.Size(0, 70);
            this.last30DaysVisit.MinimumSize = new System.Drawing.Size(0, 70);
            this.last30DaysVisit.Name = "last30DaysVisit";
            this.last30DaysVisit.SidebarColor = System.Drawing.Color.LimeGreen;
            this.last30DaysVisit.Size = new System.Drawing.Size(190, 70);
            this.last30DaysVisit.TabIndex = 4;
            this.last30DaysVisit.ValueText = "0";
            // 
            // last7DaysVisit
            // 
            this.last7DaysVisit.BackColor = System.Drawing.Color.White;
            this.last7DaysVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.last7DaysVisit.LabelColor = System.Drawing.Color.DimGray;
            this.last7DaysVisit.LabelText = "Last 7 Days";
            this.last7DaysVisit.Location = new System.Drawing.Point(582, 3);
            this.last7DaysVisit.MaximumSize = new System.Drawing.Size(0, 70);
            this.last7DaysVisit.MinimumSize = new System.Drawing.Size(0, 70);
            this.last7DaysVisit.Name = "last7DaysVisit";
            this.last7DaysVisit.SidebarColor = System.Drawing.Color.LimeGreen;
            this.last7DaysVisit.Size = new System.Drawing.Size(187, 70);
            this.last7DaysVisit.TabIndex = 3;
            this.last7DaysVisit.ValueText = "0";
            // 
            // todayVisit
            // 
            this.todayVisit.BackColor = System.Drawing.Color.White;
            this.todayVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todayVisit.LabelColor = System.Drawing.Color.DimGray;
            this.todayVisit.LabelText = "Today";
            this.todayVisit.Location = new System.Drawing.Point(389, 3);
            this.todayVisit.MaximumSize = new System.Drawing.Size(0, 70);
            this.todayVisit.MinimumSize = new System.Drawing.Size(0, 70);
            this.todayVisit.Name = "todayVisit";
            this.todayVisit.SidebarColor = System.Drawing.Color.LimeGreen;
            this.todayVisit.Size = new System.Drawing.Size(187, 70);
            this.todayVisit.TabIndex = 2;
            this.todayVisit.ValueText = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visit";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(5, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patients";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.othersPatients, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.femalePatients, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.malePatients, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalPatients, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 217);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(968, 76);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // othersPatients
            // 
            this.othersPatients.BackColor = System.Drawing.Color.White;
            this.othersPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.othersPatients.LabelColor = System.Drawing.Color.DimGray;
            this.othersPatients.LabelText = "Others";
            this.othersPatients.Location = new System.Drawing.Point(729, 3);
            this.othersPatients.MaximumSize = new System.Drawing.Size(0, 70);
            this.othersPatients.MinimumSize = new System.Drawing.Size(0, 70);
            this.othersPatients.Name = "othersPatients";
            this.othersPatients.SidebarColor = System.Drawing.Color.LimeGreen;
            this.othersPatients.Size = new System.Drawing.Size(236, 70);
            this.othersPatients.TabIndex = 4;
            this.othersPatients.ValueText = "0";
            // 
            // femalePatients
            // 
            this.femalePatients.BackColor = System.Drawing.Color.White;
            this.femalePatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.femalePatients.LabelColor = System.Drawing.Color.DimGray;
            this.femalePatients.LabelText = "Female";
            this.femalePatients.Location = new System.Drawing.Point(487, 3);
            this.femalePatients.MaximumSize = new System.Drawing.Size(0, 70);
            this.femalePatients.MinimumSize = new System.Drawing.Size(0, 70);
            this.femalePatients.Name = "femalePatients";
            this.femalePatients.SidebarColor = System.Drawing.Color.LimeGreen;
            this.femalePatients.Size = new System.Drawing.Size(236, 70);
            this.femalePatients.TabIndex = 3;
            this.femalePatients.ValueText = "0";
            // 
            // malePatients
            // 
            this.malePatients.BackColor = System.Drawing.Color.White;
            this.malePatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.malePatients.LabelColor = System.Drawing.Color.DimGray;
            this.malePatients.LabelText = "Male";
            this.malePatients.Location = new System.Drawing.Point(245, 3);
            this.malePatients.MaximumSize = new System.Drawing.Size(0, 70);
            this.malePatients.MinimumSize = new System.Drawing.Size(0, 70);
            this.malePatients.Name = "malePatients";
            this.malePatients.SidebarColor = System.Drawing.Color.LimeGreen;
            this.malePatients.Size = new System.Drawing.Size(236, 70);
            this.malePatients.TabIndex = 2;
            this.malePatients.ValueText = "0";
            // 
            // totalPatients
            // 
            this.totalPatients.BackColor = System.Drawing.Color.White;
            this.totalPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPatients.LabelColor = System.Drawing.Color.DimGray;
            this.totalPatients.LabelText = "Total";
            this.totalPatients.Location = new System.Drawing.Point(3, 3);
            this.totalPatients.MaximumSize = new System.Drawing.Size(0, 70);
            this.totalPatients.MinimumSize = new System.Drawing.Size(0, 70);
            this.totalPatients.Name = "totalPatients";
            this.totalPatients.SidebarColor = System.Drawing.Color.LimeGreen;
            this.totalPatients.Size = new System.Drawing.Size(236, 70);
            this.totalPatients.TabIndex = 1;
            this.totalPatients.ValueText = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(5, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employees";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.onlineEmployees, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.totalEmployees, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bhwEmployees, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.nurseEmployees, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.doctorEmployees, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.adminEmployees, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 343);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(968, 76);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // onlineEmployees
            // 
            this.onlineEmployees.BackColor = System.Drawing.Color.White;
            this.onlineEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlineEmployees.LabelColor = System.Drawing.Color.DimGray;
            this.onlineEmployees.LabelText = "Online";
            this.onlineEmployees.Location = new System.Drawing.Point(164, 3);
            this.onlineEmployees.MaximumSize = new System.Drawing.Size(0, 70);
            this.onlineEmployees.MinimumSize = new System.Drawing.Size(0, 70);
            this.onlineEmployees.Name = "onlineEmployees";
            this.onlineEmployees.SidebarColor = System.Drawing.Color.LimeGreen;
            this.onlineEmployees.Size = new System.Drawing.Size(155, 70);
            this.onlineEmployees.TabIndex = 10;
            this.onlineEmployees.ValueText = "0";
            // 
            // totalEmployees
            // 
            this.totalEmployees.BackColor = System.Drawing.Color.White;
            this.totalEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalEmployees.LabelColor = System.Drawing.Color.DimGray;
            this.totalEmployees.LabelText = "Total";
            this.totalEmployees.Location = new System.Drawing.Point(3, 3);
            this.totalEmployees.MaximumSize = new System.Drawing.Size(0, 70);
            this.totalEmployees.MinimumSize = new System.Drawing.Size(0, 70);
            this.totalEmployees.Name = "totalEmployees";
            this.totalEmployees.SidebarColor = System.Drawing.Color.LimeGreen;
            this.totalEmployees.Size = new System.Drawing.Size(155, 70);
            this.totalEmployees.TabIndex = 1;
            this.totalEmployees.ValueText = "0";
            // 
            // bhwEmployees
            // 
            this.bhwEmployees.BackColor = System.Drawing.Color.White;
            this.bhwEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhwEmployees.LabelColor = System.Drawing.Color.DimGray;
            this.bhwEmployees.LabelText = "Brgy. Health Worker";
            this.bhwEmployees.Location = new System.Drawing.Point(808, 3);
            this.bhwEmployees.MaximumSize = new System.Drawing.Size(0, 70);
            this.bhwEmployees.MinimumSize = new System.Drawing.Size(0, 70);
            this.bhwEmployees.Name = "bhwEmployees";
            this.bhwEmployees.SidebarColor = System.Drawing.Color.LimeGreen;
            this.bhwEmployees.Size = new System.Drawing.Size(157, 70);
            this.bhwEmployees.TabIndex = 9;
            this.bhwEmployees.ValueText = "0";
            // 
            // nurseEmployees
            // 
            this.nurseEmployees.BackColor = System.Drawing.Color.White;
            this.nurseEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurseEmployees.LabelColor = System.Drawing.Color.DimGray;
            this.nurseEmployees.LabelText = "Nurse";
            this.nurseEmployees.Location = new System.Drawing.Point(647, 3);
            this.nurseEmployees.MaximumSize = new System.Drawing.Size(0, 70);
            this.nurseEmployees.MinimumSize = new System.Drawing.Size(0, 70);
            this.nurseEmployees.Name = "nurseEmployees";
            this.nurseEmployees.SidebarColor = System.Drawing.Color.LimeGreen;
            this.nurseEmployees.Size = new System.Drawing.Size(155, 70);
            this.nurseEmployees.TabIndex = 8;
            this.nurseEmployees.ValueText = "0";
            // 
            // doctorEmployees
            // 
            this.doctorEmployees.BackColor = System.Drawing.Color.White;
            this.doctorEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorEmployees.LabelColor = System.Drawing.Color.DimGray;
            this.doctorEmployees.LabelText = "Doctor";
            this.doctorEmployees.Location = new System.Drawing.Point(486, 3);
            this.doctorEmployees.MaximumSize = new System.Drawing.Size(0, 70);
            this.doctorEmployees.MinimumSize = new System.Drawing.Size(0, 70);
            this.doctorEmployees.Name = "doctorEmployees";
            this.doctorEmployees.SidebarColor = System.Drawing.Color.LimeGreen;
            this.doctorEmployees.Size = new System.Drawing.Size(155, 70);
            this.doctorEmployees.TabIndex = 3;
            this.doctorEmployees.ValueText = "0";
            // 
            // adminEmployees
            // 
            this.adminEmployees.BackColor = System.Drawing.Color.White;
            this.adminEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminEmployees.LabelColor = System.Drawing.Color.DimGray;
            this.adminEmployees.LabelText = "Admin";
            this.adminEmployees.Location = new System.Drawing.Point(325, 3);
            this.adminEmployees.MaximumSize = new System.Drawing.Size(0, 70);
            this.adminEmployees.MinimumSize = new System.Drawing.Size(0, 70);
            this.adminEmployees.Name = "adminEmployees";
            this.adminEmployees.SidebarColor = System.Drawing.Color.LimeGreen;
            this.adminEmployees.Size = new System.Drawing.Size(155, 70);
            this.adminEmployees.TabIndex = 2;
            this.adminEmployees.ValueText = "0";
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "DashboardPanel";
            this.Size = new System.Drawing.Size(978, 679);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CustomControls.CDashboardContent totalVisit;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CDashboardContent last30DaysVisit;
        private CustomControls.CDashboardContent last7DaysVisit;
        private CustomControls.CDashboardContent todayVisit;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.CDashboardContent othersPatients;
        private CustomControls.CDashboardContent femalePatients;
        private CustomControls.CDashboardContent malePatients;
        private CustomControls.CDashboardContent totalPatients;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.CDashboardContent doctorEmployees;
        private CustomControls.CDashboardContent adminEmployees;
        private CustomControls.CDashboardContent totalEmployees;
        private CustomControls.CDashboardContent bhwEmployees;
        private CustomControls.CDashboardContent nurseEmployees;
        private CustomControls.CDashboardContent currentQueueVisit;
        private CustomControls.CDashboardContent onlineEmployees;
    }
}
