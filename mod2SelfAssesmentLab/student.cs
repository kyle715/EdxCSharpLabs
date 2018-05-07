using System;

namespace selfLab
{
    class Student : Person
    {
        public int homeWorkToDo = 2;

        public Student(String Name, String School, int age) : base(Name, School, age)
        {

        }
        public String doHomework()
        {
            return "you have " + this.homeWorkToDo + " peices of homework left to do";
        }
    }
}