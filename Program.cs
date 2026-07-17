using System;

namespace StudentAdmissionSystem
{
    class Student
    {
        public int AdmissionNo;
        public string Name;
        public string Course;
        public int Semester;
        public double Fees;

        public Student(int admissionNo, string name, string course, int semester, double fees)
        {
            AdmissionNo = admissionNo;
            Name = name;
            Course = course;
            Semester = semester;
            Fees = fees;
        }

        public void Display()
        {
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("         STUDENT ADMISSION DETAILS");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Admission Number : " + AdmissionNo);
            Console.WriteLine("Student Name     : " + Name);
            Console.WriteLine("Course           : " + Course);
            Console.WriteLine("Semester         : " + Semester);
            Console.WriteLine("Admission Fees   : " + Fees);

           

            Console.WriteLine("-----------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("         STUDENT ADMISSION SYSTEM");
            Console.WriteLine("-----------------------------------------------");

            Console.Write("Enter Admission Number : ");
            int admissionNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name     : ");
            string name = Console.ReadLine();

            Console.Write("Enter Course           : ");
            string course = Console.ReadLine();

            Console.Write("Enter Semester         : ");
            int semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Admission Fees   : ");
            double fees = Convert.ToDouble(Console.ReadLine());

            Student s = new Student(admissionNo, name, course, semester, fees);

            Console.WriteLine("\nStudent Object Created Successfully.");

            s.Display();

            Console.ReadKey();
        }
    }
}