using System;

namespace Day6_md
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet vārdu!");
            Student.setName(Console.ReadLine());

            Console.WriteLine("Ievadiet uzvārdu!");
            Student.setSurname(Console.ReadLine());

            Console.WriteLine("Ievadiet kursu!");
            try
            {
                Student.setCourse(Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade");
                return;
            }

            Student.print();
            
        }
    }
}
