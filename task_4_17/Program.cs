using System;

namespace task_4_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HigherEducationInstitution hei = new HigherEducationInstitution("ABC University", 1000, 500);
            hei.PrintInfo();

            SpecializedHigherEducationInstitution shei = new SpecializedHigherEducationInstitution("XYZ College", 500, 200, 0.8);
            shei.PrintInfo();


            Console.ReadKey();
        }
    }
}
