using System;

namespace selfLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var Student1 = new Student("kyle", "lincoln", 23);
            var Teacher1 = new Teacher("Mrs.Jones", "Lincoln", 42);

            Console.WriteLine(Student1.name + " " + Student1.doHomework());
            Console.WriteLine(Teacher1.name + " at the " + Teacher1.school + " campus " + Teacher1.gradeHomework());
        }
    }
}