using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxTimeSheet
{
    public partial class FormCalc : Form
    {
        public DateTime Start { get; }
        public DateTime End { get; }
        public List<HolidayRecord> Holidays { get; }

        public FormCalc(DateTime start, DateTime end, List<HolidayRecord> holidays)
        {
            Start = start;
            End = end;
            Holidays = holidays;
            InitializeComponent();
        }
        public int Days { get; set; }
        private void FormCalc_Load(object sender, EventArgs e)
        {
            Days = GetDays();
            label1.Text = $"Number of days between {Start} and {End} excludnig holidays: {Days}";
            UpdateCost();
        }
        int GetDays()
        {
            uxAllDays.Text = "";
            int days = 0;
            for (var d = Start; d <= End; d = d.AddDays(1))
            {
                if (d.DayOfWeek == DayOfWeek.Sunday || d.DayOfWeek == DayOfWeek.Saturday)
                    continue;
                bool isHoliday = false;
                foreach (var h in Holidays)
                {
                    if (d >= h.Start && d <= h.End)
                    {
                        isHoliday = true;
                        break;
                    }
                }
                if (!isHoliday)
                {
                    uxAllDays.Text += d.ToString("dd/MM/yyyy") + "\r\n";
                    days++;
                }
            }
            return days;
        }
        void UpdateCost()
        {
            if (!float.TryParse(uxHoursPerDay.Text, out var hpd))
                return;
            lblHours.Text = $"{Days * hpd} hours";
            if (!float.TryParse(uxCentsPerHour.Text, out var cph))
                return;
            uxCost.Text = (Days * hpd *  cph/ 100).ToString("#,###.00");
        }
        
        private void uxHoursPerDay_TextChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void uxCentsPerHour_TextChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }
    }
}
