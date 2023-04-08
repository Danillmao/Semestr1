using System;

namespace LR2
{
    internal class Program
    {
        static void Main()
        {
            Person Danil = new Person();
            Danil.FirstName = "Lion";
            Danil.LastName = "Tolstoy";
            Danil.BirthDate = new DateTime(2003, 09, 08);
            ///
            Paper Kniga2 = new Paper();
            Kniga2.Pubdate = DateTime.Now;
            Kniga2.Person = Danil;
            Kniga2.Workname = "Война и мир";

            Paper Kniga = new();
            Kniga.Pubdate = new DateTime(1863, 01 , 01);
            Kniga.Person = Danil;
            Kniga.Workname = "Voynaimir";

            ///
            ResearchTeam MyTeam = new ResearchTeam();
            MyTeam.ThemeName= "Overwatch";
            MyTeam.OrgName = "Blizzard";
            MyTeam.RegNumber = 1337;
            MyTeam.Frame = TimeFrame.Year;
            MyTeam.AddPapers(Kniga);
            //MyTeam.PaperList.Add(Kniga2);
            
            Console.WriteLine(MyTeam.ToFullString());
          
        }
    }
}