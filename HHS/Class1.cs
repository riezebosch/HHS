using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHS
{
    public class Class1
    {
        public static int Bereken(DateTime geboortedatum)
        {
            var today = DateTime.Today;
            var leeftijd =  DateTime.Today.Year - geboortedatum.Year;

            if (geboortedatum.Month > today.Month)
            {
                leeftijd--;
            }

            if (geboortedatum.Month == today.Month && geboortedatum.Day > today.Day)
            {
                leeftijd--;
            }

            //if (DateTime.Today.Month < geboortedatum.Month )

            return leeftijd;

        }
    }
}
