using System;

namespace task_4_17
{
    class HigherEducationInstitution
    {
        public string Name { get; set; }
        public int EnrolledStudents { get; set; }
        public int Graduates { get; set; }

        public HigherEducationInstitution(string name, int enrolledStudents, int graduates)
        {
            Name = name;
            EnrolledStudents = enrolledStudents;
            Graduates = graduates;
        }

        public double CalculateQuality()
        {
            return (double)Graduates / EnrolledStudents;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Higher Education Institution: {Name}");
            Console.WriteLine($"Enrolled students: {EnrolledStudents}");
            Console.WriteLine($"Graduates: {Graduates}");
            Console.WriteLine($"Quality: {CalculateQuality()}");
        }
    }
}
