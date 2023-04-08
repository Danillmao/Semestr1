using LR5;
using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp 
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Zadanie.Z5b();
        }
    }
}
//Ответы 
/* 
1.
A)@"^[a]$" 
B)@"[a]{4,}[^ ]"
C)@"[a]{1}\s[a]{2}\s[a]{1}"
2.@"(\d|[a-z]){5,}"
3.@"[a-z]+[^ ][@]{1}[^ ][a-z]+[^ ]\W[a-z]+"
4.
C)@"([A-Za-z])+\s([A-Za-z])+\s([A-Za-z])+[,]\s([0-9]+)\s([A-Za-z])+[,]\s[g][.]([A-Za-z])+[.]"
 */