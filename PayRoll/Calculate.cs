using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    class Calculate
    {
       


        public static void Salary(int BasicSalary, ref int ConvenceAllowance, ref int HouseRentAllowance, ref int MedicalAllowance)
        {

        if (BasicSalary >= 40000)
	    {
            ConvenceAllowance = (int)(BasicSalary * 0.25);
            MedicalAllowance = (int)(BasicSalary * 0.15);
            HouseRentAllowance = (int)(BasicSalary * 0.10);
	    }

        else if (BasicSalary >= 30000)
        {
            ConvenceAllowance = (int)(BasicSalary * 0.20);
            MedicalAllowance = (int)(BasicSalary * 0.12);
            HouseRentAllowance = (int)(BasicSalary * 0.10);
        }


        else if (BasicSalary < 30000)
        {
            ConvenceAllowance = 2000;
            MedicalAllowance = 1500;
            HouseRentAllowance = 1000;
        }

       }

        public static int GetTotalDaysOfMonth(DateTime MonthYear)
        {

            DateTime dt = MonthYear;


            int Count = int.Parse(DateTime.DaysInMonth(Int32.Parse(dt.Year.ToString()), Int32.Parse(dt.Month.ToString())).ToString());
             return Count;
            
        }

        public static int GetSunday(DateTime MonthYear)
        {

            DateTime today = MonthYear;
            DateTime endOfMonth = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
            int day = endOfMonth.Day;

            DateTime now = MonthYear;
            int count;
            count = 0;
            for (int i = 0; i < day; ++i)
            {
                DateTime d = new DateTime(now.Year, now.Month, i + 1);
                //Compare date with sunday
                //MessageBox.Show("d " + d);
                //MessageBox.Show("d.DayOfWeek " + d.DayOfWeek);
                //MessageBox.Show("DayOfWeek.Sunday " + DayOfWeek.Sunday);
                if (d.DayOfWeek == DayOfWeek.Sunday)
                {
                    count = count + 1;
                }
            }
            return count;

        }

        public static int IncomeText(int GrossPay)
        {
            if (GrossPay >= 60000)
            {
                return (int)(GrossPay * 0.3);
            }
            else if (GrossPay >= 50000)
            {
                return (int)(GrossPay * 0.2);
            }
            else
            {
                return 0;
            }

        }


    }
}
