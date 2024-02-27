using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WindowsFormsApp5
{
    internal class business_logic
    {
        double tot = 0;
        public double day_blast_cal(double day, double night)
        {

            if(day <= 50 & night <= 10)
                {
                tot = 400 + 200 + 200;
            }
                else if (day <= 50 & night > 10)
            {
                tot = 400 + 200 + ((night - 10) * 20) + 200;
            }
            else if (day > 50 & night <= 10)
            {
                tot = 400 + ((day - 50) * 10) + 200 + 200;
            }
            else if (day > 50 & night > 10)
            {
                tot = 400 + ((day - 50) * 10) + 200 + ((night - 10) * 20) + 200;
            }

            if (tot <= 1000)
            {
                tot = tot + 250;
            }
            else
            {
                tot = tot + 350;
            }

            return tot;
        }

        public double night_blast_cal(double day, double night)
        {
            if (day <= 10 & night <= 100)
            {
                tot = 200 + 600 + 400;
            }
            else if (day <= 10 & night > 100)
            {
                tot = 200 + 600 + ((night - 100) * 10) + 400;
            }
            else if (day > 10 & night <= 100)
            {
                tot = 200 + ((day - 10) * 20) + 600 + 200;
            }
            else if (day > 10 & night > 100)
            {
                tot = 200 + ((day - 10) * 20) + 600 + ((night - 100) * 10) + 400;
            }

            if (tot <= 1500)
            {
                tot = tot + 350;
            }
            else
            {
                tot = tot + 450;
            }

            return tot;
        }

       

    }
}
