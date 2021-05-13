using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
   public  class DataFirtingcs
    {
        public void fitleringBrand()
        {

        }
        public void filteringScreen()
        {

        }
        public string CalculateAspectRadio(string screenResolution)
        {
            /*string value = "1920x1080";*/
            string [] sp = screenResolution.Split('x').ToArray();
            if (Int32.Parse(sp[2])==0)
            {
                return sp[0];
            }
            else
            {
                return NWD(sp[0], sp[1]);
            }
        }
        public string NWD(string first, string second)
        {
            double a = double.Parse(first);
            double b = double.Parse(second);
            double w;
            while (b != 0)
            {
                w = a % b;
                a = b;
                b = w;
            }
            return a.ToString();
        }

    }
}
