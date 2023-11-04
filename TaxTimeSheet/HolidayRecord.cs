using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxTimeSheet
{
    public class HolidayRecord
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Days => CalcDays();
        public string Desc { get; set; }

        private int CalcDays()
        {
            int days = 0;
            for (var d = Start; d <= End.AddHours(1); d = d.AddDays(1))
            {
                if (d.DayOfWeek != DayOfWeek.Sunday && d.DayOfWeek != DayOfWeek.Saturday)
                    days++;
            }
            return days;
        }
    }
}
