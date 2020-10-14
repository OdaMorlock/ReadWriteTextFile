using System;
using System.Collections.Generic;
using System.Text;

namespace ReadWriteTextFile
{
    public class Person
    {

        public Person()
        {
                
        }

        public Person(string firstname,string lastname,int age, string condition,string status)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Condition = condition;
            Status = status;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Condition { get; set; }
        public string Status { get; set; }
    }
}
