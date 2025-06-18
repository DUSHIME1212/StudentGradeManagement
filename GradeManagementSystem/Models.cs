using System;

namespace StudentGradeManagement
{

    public enum GradeCategory
    {
        Excellent,
        Good,
        Fair,
        Poor,
        Fail
    }


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