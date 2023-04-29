using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6WF
{
    public static class Global
    {
		private static double Goblax1;
		private static double Goblax2;
		private static int Goblax3;

       
        public static double GoblalPropx1
        {
            get { return Goblax1; }
            set { Goblax1 = value; }
        }

        public static double GoblalPropx2
        {
            get { return Goblax2; }
            set { Goblax2 = value; }
        }
        public static int GoblalPropxN
        {
            get { return Goblax3; }
            set { Goblax3 = value; }
        }
    }
        
    
}
