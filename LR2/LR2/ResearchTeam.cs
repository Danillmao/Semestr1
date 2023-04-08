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
        List<Paper> paperList = new();
        


        public ResearchTeam()
        {
            themeName = string.Empty;
            orgName = string.Empty;
            regNumber = 0;
            frame = new TimeFrame();
            paperList = new List<Paper>();
        }
        public ResearchTeam(string themeName, string orgName, int regNumber, TimeFrame frame, List<Paper> paperList)
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
        public List<Paper> PaperList
        { get { return paperList; }
          set{ paperList = value; }
        }
        public Paper? LastPaper
        {
            get
            {
                if(PaperList == null || PaperList.Count == 0)
                {
                    return null;
                }
                else
                {
                    DateTime max = DateTime.MinValue;
                    int maxIndex = 0;
                    for (int i = 0; i < PaperList.Count; i++)
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
            PaperList.AddRange(newPapers);
 
        }
        public string ToFullString()
        {
            return ($"Theme: {themeName}, OrgName: {orgName}, RegNumber: {regNumber}, ResearchTime: {frame}, PapersList {paperList}");
        }

        public string ToShortString()
        {
            return ($"Theme: {themeName}, OrgName: {orgName}, RegNumber: {regNumber}, ResearchTime: {frame}");
        }
    }
}
