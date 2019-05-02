using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    class GetSelected
    {
        public static String  Month(int Month)
        {
            String MonthSelected = "";

           // YearSelected = dt.Year.ToString();
            if (Month == 1)
            {
                MonthSelected = "January";
            }

            else if (Month == 2)
            {
                MonthSelected = "February";
            }
            else if (Month == 3)
            {
                MonthSelected = "March";
            }
            else if (Month == 4)
            {
                MonthSelected = "April";
            }
            else if (Month == 5)
            {
                MonthSelected = "May";
            }
            else if (Month == 6)
            {
                MonthSelected = "June";
            }
            else if (Month == 7)
            {
                MonthSelected = "July";
            }
            else if (Month == 8)
            {
                MonthSelected = "August";
            }
            else if (Month == 9)
            {
                MonthSelected = "September";
            }
            else if (Month == 10)
            {
                MonthSelected = "October";
            }
            else if (Month == 11)
            {
                MonthSelected = "November";
            }
            else if (Month == 12)
            {
                MonthSelected = "December";
            }

            return MonthSelected;
        }

    }
}
