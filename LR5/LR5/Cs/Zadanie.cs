using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace LR5.Cs
{
    internal class Zadanie
    {
        public static void Z1()
        {
            //1.Написать регулярное выражение, которые проверят строки на соответствие

            //TODO: в одну регулярку
            string path = "AllValues.txt";
            string[] input = File.ReadAllLines(path); 
            for (int i = 0; i < input.Length; ++i)
            {
                Regex regex = new Regex(@"(^a$)|(^a{5}$)|(^a aa a$)");
                if (regex.IsMatch(input[i]))
                {
                    Console.WriteLine(regex.Match(input[i]));
                }
            }
        }
        //2.Написать регулярное выражение, заставляющее вводить не менее 5 алфавитно - цифровых символов.
        public static void Z2()
        {
            string path = "AllValues.txt";
            //TODO: проверять всю строку целиком
            string[] input = File.ReadAllLines(path); 
            for (int i = 0; i < input.Length; ++i)
            {
                Regex regex = new Regex(@"^\w{5,}$");
                if (regex.IsMatch(input[i]))
                {
                    Console.WriteLine(regex.Match(input[i]));
                }
            }
        }
        //3.Написать регулярное выражение, которое проверят email простого вида
        public static void Z3()
        {
            string path = "AllValues.txt";
            string[] input = File.ReadAllLines(path); 
            for (int i = 0; i < input.Length; ++i)
            {
                //TODO: регулярка пропустит слишком много лишнего
                Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                if (regex.IsMatch(input[i]))
                {
                    Console.WriteLine(regex.Match(input[i]));
                }
            }
        }
        //4.Выполните одно из заданий, приведенных ниже.
        public static void Z4()
        {
            string path = "AllValues.txt";
            string[] input = File.ReadAllLines(path); 
            for (int i = 0; i < input.Length; ++i)
            {
                //TODO: регулярка не подходит ни под один из вариантов
                //TODO: выводить результат нужно отдельно,каждую группу
                Regex regex = new Regex(@"ул\.\s*(.+)\s+д\.\s*(\d+/\d+)");
                Match match = regex.Match(input[i]);
                if (regex.IsMatch(input[i]))
                {
                    Console.WriteLine(regex.Match(input[i]));
                }
            }
        }



        public static void Z5a()
        {
            string path = "C:\\Labs\\AllLabs\\LR5\\LR5\\testData.xml";
            Regex regex = new Regex(@"[А-Яа-я]+\s[А-Яа-я]+\s[А-Яа-я]+[,]\s[1-9][0-9]+\s[А-Яа-я]+[,]\s[г][.]\s[А-Яа-я]+[.]");
            string[] input = File.ReadAllLines(path); 
            for (int i = 0; i < input.Length; ++i)
            {
                if (regex.IsMatch(input[i]))
                {
                    Console.WriteLine(regex.Match(input[i]));
                }
                else
                {
                    Console.WriteLine("Такого не знаем");
                }

            }

        }
        public static void Z5b()
        {
            string path = "C:\\Labs\\AllLabs\\LR5\\LR5\\testData.xml";
            Regex regex = new Regex(@"(([1-9].))+");
            string[] input = File.ReadAllLines(path);
            for (int i = 0; i < input.Length; ++i)
            {
                if (regex.IsMatch(input[i]))
                {
                    Console.WriteLine(regex.Match(input[i]));
                }
                else
                {

                }

            }

        }
    }
}
