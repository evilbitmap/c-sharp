using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass student = new StudentClass();
            student.Name = "matyas";
            student.Age = 16;
            student.Phone = "+420 775 626 290";
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Phone);
        }
    }
}
