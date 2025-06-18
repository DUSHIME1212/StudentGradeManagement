using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManagement
{
    public class GradeManager
    {
        // Dictionary to store student name and grade
        private Dictionary<string, int> students = new Dictionary<string, int>();

        // Adds a student
        public void AddStudent(string name, int grade)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Student name cannot be empty.");

            if (grade < 0 || grade > 100)
                throw new ArgumentException("Grade must be between 0 and 100.");

            if (students.ContainsKey(name))
                throw new ArgumentException("Student already exists.");

            students[name] = grade;
        }

        // Returns all students and grades
        public Dictionary<string, int> GetAllStudents()
        {
            return new Dictionary<string, int>(students);
        }

        // Searches for a student's grade
        public int? SearchStudent(string name)
        {
            if (students.TryGetValue(name, out int grade))
                return grade;
            return null;
        }

        // Calculates average grade
        public double? CalculateAverage()
        {
            if (students.Count == 0)
                return null;
            return students.Values.Average();
        }

        // Finds max and min grades
        public (int? max, int? min) GetMaxMinGrades()
        {
            if (students.Count == 0)
                return (null, null);

            int max = students.Values.Max();
            int min = students.Values.Min();
            return (max, min);
        }
    }
}