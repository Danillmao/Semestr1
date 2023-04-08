using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class ResearchTeam
    {
        string themeName;
        string orgName;
        int regNumber;
        TimeFrame frame;
        Paper[] paperList = new Paper[0];
    

        public ResearchTeam()
        {
            themeName = string.Empty;
            orgName = string.Empty;
            regNumber = 0;
            frame = new TimeFrame();
            paperList = new Paper[0];
        }
        public ResearchTeam(string themeName, string orgName, int regNumber, TimeFrame frame, Paper[] paperList)
        {
            this.themeName = themeName;
            this.orgName = orgName;
            this.regNumber = regNumber;
            this.frame = frame;
            this.paperList = paperList;
        }
        public string ThemeName
        {
            get { return themeName; }
            set { themeName = value; }
        }
        public string OrgName
        {
            get { return orgName; }
            set { orgName = value; }
        }
        public int RegNumber
        {
            get { return regNumber; }
            set { regNumber = value; }
        }
        public TimeFrame Frame
        {
            get { return frame; }
            set { frame = value; }
        }
        public Paper[] PaperList
        { get { return paperList; }
          set { paperList = value; }
        }
        public Paper? LastPaper
        {
            get
            {
                if(PaperList == null || PaperList.Length == 0)
                {
                    return null;
                }
                else
                {
                    DateTime max = DateTime.MinValue;
                    int maxIndex = 0;
                    for (int i = 0; i < PaperList.Length; i++)
                    {
                        if (PaperList[i].Pubdate>max)
                        {
                            maxIndex = i;
                            
                        }
                    }
                    return PaperList[maxIndex];
                }
                
            }
        }
        public void AddPapers(params Paper[] newPapers)
        {
            //создать новый массив с размером = старому + новый
            //copy old elements PaperList[] - old
            //copy new elements 
            Paper[] shit = new Paper[PaperList.Length + newPapers.Length];
            Array.Copy(PaperList, 0, shit, 0, PaperList.Length);
            Array.Copy(newPapers, 0, shit, PaperList.Length, newPapers.Length);
            PaperList = shit;
 
        }
        public string ToFullString()
        {
            
            
            var result = string.Empty;
            for (int i = 0; i < PaperList.Length; i++)
            {
                result += ", " +  PaperList[i].ToFullString();
            }
            return ($"Theme: {themeName}, OrgName: {orgName}, RegNumber: {regNumber}, ResearchTime: {frame}, PapersList: {result}");
        }

        public string ToShortString()
        {
            return ($"Theme: {themeName}, OrgName: {orgName}, RegNumber: {regNumber}, ResearchTime: {frame}");
        }
    }
}
