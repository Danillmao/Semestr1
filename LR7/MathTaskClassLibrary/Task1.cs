using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskLibrary
{
    public class Task1
    {
        public  string GetFirstNLetters(int n)
        {
            if (n < 1 || n > 26)
            {
                throw new ArgumentException("Параметр должен быть от 1 до 26");
            }

            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += (char)(65 + i);
            }
            return result;
        }



    }
}
