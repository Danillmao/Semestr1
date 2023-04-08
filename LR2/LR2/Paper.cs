using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Paper
    {
        public string Workname { get; set; }
        public Person Person { get; set; }
        public DateTime Pubdate { get; set; }

        public Paper()
        {
            this.Workname= string.Empty;
            this.Person = new Person();
            this.Pubdate = DateTime.Now;
        }
        public Paper(string workname, Person person, DateTime pubdate)
        {
            Workname = workname;
            Person = person;
            Pubdate = pubdate;
        }

        public string ToFullString()
        {
            return Workname + " " + Person.ToShortString() + " " + Pubdate.ToShortDateString();
        }
    }
}
