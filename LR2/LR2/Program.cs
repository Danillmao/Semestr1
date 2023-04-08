using System;

namespace LR2
{
    internal class Program
    {
        static void Main()
        {
            Person Danil = new Person();
            Danil.FirstName = "Данон";
            Danil.LastName = "Маразмов";
            Danil.BirthDate = new DateTime(2003, 09, 08);
            ///
            Paper Papers = new Paper();
            Papers.Pubdate = DateTime.Now;
            Papers.Person = Danil;
            Papers.Workname = "Война и мир";
            Paper Kniga = new();
            Kniga.Pubdate = DateTime.Now;
            Kniga.Person = Danil;
            Kniga.Workname = "Бровтф";

            ///
            ResearchTeam MyTeam = new ResearchTeam();
            MyTeam.ThemeName= "Лоли ";
            MyTeam.OrgName = "Лолихантерс ";
            MyTeam.RegNumber = 1337;
            MyTeam.Frame = TimeFrame.Year;
            
            
            Console.WriteLine(MyTeam.ToFullString());
          
        }
    }
}