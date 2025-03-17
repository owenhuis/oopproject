using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trein_maken;

namespace ConsoleApp1.classes
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void bemanTrein(Train trein)
        {
            // neem controlle over de trein
            trein.giveControl(this);
        }
    }
}
