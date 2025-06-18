using System;
using System.Windows.Forms;

namespace StudentGradeManagement
{
    public partial class MainForm : Form
    {
        private GradeManager gradeManager = new GradeManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                try
                {
                    int grade = int.Parse(txtGrade.Text);
                    gradeManager.AddStudent(txtName.Text, grade);
                    lstStudents.Items.Add($"{txtName.Text}: {grade}");
                    txtName.Clear();
                    txtGrade.Clear();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid grade.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter both name and grade.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            var students = gradeManager.GetAllStudents();
            if (students.Count == 0)
            {
                MessageBox.Show("No students to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, students.Select(s => $"{s.Key}: {s.Value}")), "All Students", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Please enter a name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? grade = gradeManager.SearchStudent(searchQuery);
            if (grade.HasValue)
            {
                MessageBox.Show($"{searchQuery}: {grade.Value}", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No matching students found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double? average = gradeManager.CalculateAverage();
            if (average.HasValue)
            {
                MessageBox.Show($"The average grade is: {average:F2}", "Average Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No valid grades to calculate average.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            var (max, min) = gradeManager.GetMaxMinGrades();
            if (max.HasValue && min.HasValue)
            {
                MessageBox.Show($"Highest Grade: {max}\nLowest Grade: {min}", "Max/Min Grades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No valid grades to determine max/min.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}