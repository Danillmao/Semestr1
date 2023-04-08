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
        public Person ()
        {
            firstName = string.Empty;
            lastName = string.Empty;
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
        int Bdate
        {
            get
            {
                return Convert.ToInt32(birthDate);
            }
            set
            {
                birthDate = Convert.ToDateTime(value);
            }
        }
        public string ToFullString()
        {
            return firstName + " " + lastName + " " + birthDate;
        }

        public string ToShortString()
        {
            return firstName + " " + lastName;
        }

    }
}
