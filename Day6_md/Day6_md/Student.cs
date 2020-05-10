using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_md
{
    class Student
    {
        private static String name;
        private static String surname;
        private static int course;

        public static void setName(String name)
        {
            Student.name = name;
        }
        public static void setSurname(String surname)
        {
            Student.surname = surname;
        }
        public static void setCourse(int course)
        {
            if(course > 3)
            {
                course = 3;
            }

            if(course < 1)
            {
                course = 1;
            }
            Student.course = course;
        }
        public static void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(course);
        }
        public static string getName()
        {
            return name;
        }
        public static string getSurname()
        {
            return surname;
        }
        public static int getCourse()
        {
            return course;
        }
    }
}
