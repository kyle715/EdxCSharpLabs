using System;

namespace selfLab
{
    class Teacher : Person
    {
        public int homeWorkToGrade = 23;
        public Teacher(String name, String School, int age) : base(name, School, age)
        {

        }
        public string gradeHomework()
        {
            return "you have " + this.homeWorkToGrade + " peice of homework left to grade";
        }
    }
}