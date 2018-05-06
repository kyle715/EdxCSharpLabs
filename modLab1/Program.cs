using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new employee("libby", 2000);

            var employee2 = new TechnicalEmployee("Zaynah");

            var employee3 = new BusinessEmployee("winter");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
