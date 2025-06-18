namespace StudentGradeManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.ListBox lstStudents;

        private void InitializeComponent()
        {
            this.components = null;
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();

            // TableLayoutPanel setup
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);

            // Name Row
            this.lblName.Text = "Name:";
            this.lblName.AutoSize = true;
            this.tableLayoutPanel.Controls.Add(this.lblName, 0, 0);
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel.Controls.Add(this.txtName, 1, 0);

            // Grade Row
            this.lblGrade.Text = "Grade (0-100):";
            this.lblGrade.AutoSize = true;
            this.tableLayoutPanel.Controls.Add(this.lblGrade, 0, 1);
            this.txtGrade.Size = new System.Drawing.Size(200, 20);
            this.txtGrade.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel.Controls.Add(this.txtGrade, 1, 1);
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.AutoSize = true;
            this.tableLayoutPanel.Controls.Add(this.btnAddStudent, 2, 0);
            this.tableLayoutPanel.SetColumnSpan(this.btnAddStudent, 1);
            this.tableLayoutPanel.SetRowSpan(this.btnAddStudent, 2);

            // Search Row
            this.lblSearch.Text = "Search Name:";
            this.lblSearch.AutoSize = true;
            this.tableLayoutPanel.Controls.Add(this.lblSearch, 0, 2);
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel.Controls.Add(this.txtSearch, 1, 2);
            this.btnSearch.Text = "Search";
            this.btnSearch.AutoSize = true;
            this.tableLayoutPanel.Controls.Add(this.btnSearch, 2, 2);

            // Action Buttons Row
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.AutoSize = true;
            this.tableLayoutPanel.Controls.Add(this.btnDisplayAll, 0, 3);
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.AutoSize = true;
            this.tableLayoutPanel.Controls.Add(this.btnAverage, 1, 3);
            this.btnMaxMin.Text = "Max/Min Grades";
            this.btnMaxMin.AutoSize = true;
            this.tableLayoutPanel.Controls.Add(this.btnMaxMin, 2, 3);

            // ListBox Row
            this.lstStudents.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel.Controls.Add(this.lstStudents, 0, 4);
            this.tableLayoutPanel.SetColumnSpan(this.lstStudents, 3);

            // Form properties
            this.Text = "Student Grade Management System";
            this.Size = new System.Drawing.Size(500, 600);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.tableLayoutPanel);

            // Event handlers
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
    }
}