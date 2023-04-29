using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Task3
    {
        public string UgadayGod(int year)
        {
           
            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return "Вискок";
            }
            else
            {
                return "Нувисокос";
            }    
        }

    }
}
