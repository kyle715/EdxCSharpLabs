using System;

namespace lab1
{
    class BusinessEmployee : employee
    {
        public double bonusBudget = 1000;
        public BusinessEmployee(String name) :base(name,50000)
        {
        }
        public override String employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
