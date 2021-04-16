using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs
{
    class Program
    {
        static void CheckYear(int Year, int Age)
        {
            var StartDateTime = new DateTime(Year, 1, 1);
            do
            {
                if (ValidDate(StartDateTime, Age))
                    Console.WriteLine(StartDateTime);
                StartDateTime = StartDateTime.AddDays(1);


            } while (StartDateTime.Year == Year);



        }

        static bool ValidDate(DateTime CheckedDate, int Age)
        {
            var YearSqr = 0;
            var CurentYear = CheckedDate.Year;
            while (CurentYear > 0)
            {
                var LastDiget = CurentYear % 10;
                YearSqr += (int)Math.Pow(LastDiget, 2);
                CurentYear = (int)Math.Ceiling((double)(CurentYear / 10));

            }
            return (YearSqr - (int)Math.Pow(CheckedDate.Day, 2)) == Age;

        }

    }
}