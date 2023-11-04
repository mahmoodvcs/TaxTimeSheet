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
    public partial class FormAddHoliday : Form
    {
        public ListViewEx<HolidayRecord> HolidaysListView { get; }

        public FormAddHoliday(ListViewEx<HolidayRecord> holidaysListView, bool edit = false)
        {
            HolidaysListView = holidaysListView;
            InitializeComponent();
            if (edit)
            {
                var h = holidaysListView.GetSelectedItems()[0];
                uxStartDate.Value = h.Start;
                uxEndDate.Value = h.End;
                uxDesc.Text = h.Desc;
                if (h.Start == h.End)
                    IsRange = false;
                else
                    IsRange = true;
                IsRecuring = false;
            }
            this.edit = edit;
        }
        bool edit;

        public bool IsRange
        {
            get => uxRangeCkeck.Checked;
            set => uxEndDate.Enabled = uxRangeCkeck.Checked = value;
        }
        public bool IsRecuring
        {
            get => uxRecuring.Checked;
            set => uxRecuringPanel.Enabled = uxRecuring.Checked = value;
        }

        private void uxRangeCheck_CheckedChanged(object sender, EventArgs e)
        {
            uxEndDate.Enabled = uxRangeCkeck.Checked;
        }

        private void uxRecuring_CheckedChanged(object sender, EventArgs e)
        {
            uxRecuringPanel.Enabled = uxRecuring.Checked;
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if (uxRecuring.Checked)
            {
                if (!uxRangeCkeck.Checked)
                {
                    MessageBox.Show(this, "You should specify the end time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (edit)
                {
                    HolidaysListView.Remove(HolidaysListView.GetSelectedItems().FirstOrDefault());
                }
                var daysToSkip = int.Parse(uxRecuringNum.Text) * 7;
                for (var d = uxStartDate.Value.Date; d <= uxEndDate.Value.Date; d = d.AddDays(daysToSkip))
                {
                    HolidaysListView.Add(new HolidayRecord()
                    {
                        Start = d,
                        End = d,
                        Desc = uxDesc.Text,
                    });
                }

            }
            else
            {
                var h = new HolidayRecord();
                if (edit)
                {
                    h = HolidaysListView.GetSelectedItems()[0];
                }
                h.Desc = uxDesc.Text;
                h.Start = uxStartDate.Value.Date;
                h.End = uxRangeCkeck.Checked ? uxEndDate.Value.Date : uxStartDate.Value.Date;
                if (!edit)
                    HolidaysListView.Add(h);
            }
            DialogResult = DialogResult.OK;
        }

    }
}
