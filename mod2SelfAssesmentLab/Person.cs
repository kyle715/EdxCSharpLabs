using System;

namespace selfLab
{
    abstract class Person
    {
            private string personsName;
            private string schoolAttending;
            private int Age;

            public string name
            {
                get
                {
                    return personsName;
                }
                set
                {
                    personsName = value;
                }
            }
            public string school
            {
                get
                {
                    return schoolAttending;
                }
                set
                {
                    schoolAttending = value;
                }
            }
            public int age
            {
                get
                {
                    return Age;
                }
                set
                {
                    Age = value;
                }
            }
            public Person(String Name, String School, int Agee)
            {
                this.name = Name;
                this.school = School;
                this.age = Agee;
            }
            public int homeWorkDue = 3;

            public virtual String toDoList()
            {
                return "You have this many assignments due" +  this.homeWorkDue;
            }
    }
}