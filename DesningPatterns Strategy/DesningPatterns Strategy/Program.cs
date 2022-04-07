using System;

namespace DesningPatterns_Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student riyaziyyatci = new Student(EnumStudentChouseType.Riyaziyyatci);
            Console.WriteLine(riyaziyyatci.getStudents());
            Console.WriteLine("_________________________\n");

            Student dilci = new Student(EnumStudentChouseType.Dilci);
            Console.WriteLine(dilci.getStudents());
            Console.WriteLine("_________________________\n");


            Student avara = new Student(EnumStudentChouseType.Avara);
            Console.WriteLine(avara.getStudents());
        }
    }
}
