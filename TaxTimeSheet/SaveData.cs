using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxTimeSheet
{
    public class SaveData
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<HolidayRecord> Holidays { get; set; }
    }
}
