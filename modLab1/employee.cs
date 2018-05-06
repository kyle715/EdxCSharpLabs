using System;

namespace lab1
{
    public class employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }
        public employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;

        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.ID;
        }
        private static int employeeCount = 1;
        public string toString()
        {
            return this.ID + " " + this.Name;
        }
        public virtual String employeeStatus()
        {
            return toString() + " is in the company's sysytem";
        }
    }
}