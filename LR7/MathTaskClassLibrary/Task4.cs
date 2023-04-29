using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Task4
    {
        public string EmailChecker(string mail)
        {
            mail = "lol@mail.ru";
            Regex regex = new Regex(@"(\w+([-+._]\w+)*@\w+([.]\w+)*\.\w+([-.]\w+)*)$");
            if(regex.IsMatch(mail))
            {
                return mail;
            }
            else
            {
                return "Нет";
            }
        }
    }
}
