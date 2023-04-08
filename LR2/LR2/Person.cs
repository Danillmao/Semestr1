using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        public Person()
        {
            firstName = "";
            lastName = "";
            birthDate = new DateTime(2023, 01, 01); 
        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
        //Свойства
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public int Bdate
        {
            get { return birthDate.Year; }
            set { birthDate = new DateTime(value, birthDate.Month, birthDate.Day); }
        }
        public string ToFullString()
        {
            return FirstName + " " + LastName + " " + BirthDate;
        }

        public string ToShortString()
        {
            return FirstName + " " + LastName;
        }

    }
}
