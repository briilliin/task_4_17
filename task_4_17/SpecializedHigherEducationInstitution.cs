using System;

namespace task_4_17
{
    class SpecializedHigherEducationInstitution : HigherEducationInstitution
    {
        public double WorkingGraduatesPercentage { get; set; }

        public SpecializedHigherEducationInstitution(string name, int enrolledStudents, int graduates, double workingGraduatesPercentage)
            : base(name, enrolledStudents, graduates)
        {
            WorkingGraduatesPercentage = workingGraduatesPercentage;
        }

        public new double CalculateQuality()
        {
            return WorkingGraduatesPercentage * base.CalculateQuality();
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Working graduates percentage: {WorkingGraduatesPercentage}");
            Console.WriteLine($"Quality with working graduates percentage: {CalculateQuality()}");
        }
    }
}
