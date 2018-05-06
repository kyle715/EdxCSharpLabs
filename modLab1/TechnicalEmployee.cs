using System;

namespace lab1
{
       class TechnicalEmployee : employee
    {       
           public int successfulCheckIns = 5; public TechnicalEmployee(String name) : base(name, 75000)
        {

        } 
        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}