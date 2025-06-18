using System;

namespace StudentGradeManagement
{
    // Enum for grade categories (optional for future extensions)
    public enum GradeCategory
    {
        Excellent,
        Good,
        Fair,
        Poor,
        Fail
    }

    // Student struct to encapsulate student data (optional for extensibility)
    public struct Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}