namespace TaxTimeSheet
{
    public partial class FormMain : Form
    {
        List<(string ColumnName, Func<HolidayRecord, object> ValueLookup, Func<HolidayRecord, string> DisplayStringLookup)> columnMapping;
        public FormMain()
        {
            columnMapping = new List<(string ColumnName, Func<HolidayRecord, object> ValueLookup, Func<HolidayRecord, string> DisplayStringLookup)>()
            {
                ("Start", h => h.Start, h => $"{h.Start:dd/MM/yyyy}"),
                ("End", h => h.End, h => $"{h.End:dd/MM/yyyy}"),
                ("Days", h => h.Days, h => h.Days.ToString()),
                ("Desc", h => h.Desc, h => h.Desc)
            };

            InitializeComponent();
            uxHolidays = new ListViewEx<HolidayRecord>(columnMapping);
            uxHolidays.Top = 30;
            uxHolidays.Left = 10;
            uxHolidays.Width = 500;
            uxHolidays.Height = 600;
            uxHolidays.View = View.Details;
            uxHolidays.FullRowSelect = true;
            uxHolidays.DoubleClick += UxHolidays_DoubleClick;
            groupBox1.Controls.Add(uxHolidays);
        }

        private void UxHolidays_DoubleClick(object? sender, EventArgs e)
        {
            uxEditHoliday_Click(sender, e);
        }

        private void uxAddHoliday_Click(object sender, EventArgs e)
        {
            FormAddHoliday f = new FormAddHoliday(uxHolidays);
            f.IsRecuring = false;
            f.IsRange = false;
            f.ShowDialog(this);
            uxHolidays.RefreshContent();
        }

        private void uxAddRngHoliday_Click(object sender, EventArgs e)
        {
            FormAddHoliday f = new FormAddHoliday(uxHolidays);
            f.IsRecuring = false;
            f.IsRange = true;
            f.ShowDialog(this);
            uxHolidays.RefreshContent();
        }

        private void uxAddRecuringHoliday_Click(object sender, EventArgs e)
        {
            FormAddHoliday f = new FormAddHoliday(uxHolidays);
            f.IsRecuring = true;
            f.IsRange = true;
            f.ShowDialog(this);
            uxHolidays.RefreshContent();
        }

        private void uxEditHoliday_Click(object sender, EventArgs e)
        {
            if (uxHolidays.SelectedIndices.Count == 0)
                return;
            FormAddHoliday f = new FormAddHoliday(uxHolidays, true);
            f.ShowDialog(this);
            uxHolidays.RefreshContent();
        }

        private void uxRemoveHoliday_Click(object sender, EventArgs e)
        {
            if (uxHolidays.SelectedIndices.Count == 0)
                return;
            uxHolidays.Remove(uxHolidays.GetSelectedItems()[0]);
            uxHolidays.RefreshContent();
        }

        void Save(string path)
        {
            SaveData data = new SaveData()
            {
                StartDate = uxStartDate.Value,
                EndDate = uxEndDate.Value,
                Holidays = uxHolidays.GetItems()
            };
            File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(data));
        }
        void LoadSaved(string path)
        {
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<SaveData>(File.ReadAllText(path));
            uxStartDate.Value = data.StartDate;
            uxEndDate.Value = data.EndDate;
            uxHolidays.Items.Clear();
            foreach (var item in data.Holidays)
            {
                uxHolidays.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uxStartDate.Value = new DateTime(DateTime.Now.Year - 1, 7, 1);
            uxEndDate.Value = new DateTime(DateTime.Now.Year, 6, 30);
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "json|*.json";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Save(dlg.FileName);
            }
        }

        private void uxLoad_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "json|*.json";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                LoadSaved(dlg.FileName);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Save changes?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                uxSave_Click(sender, e);
            }
        }

        private void uxCalc_Click(object sender, EventArgs e)
        {
            FormCalc f = new FormCalc(uxStartDate.Value.Date, uxEndDate.Value.Date, uxHolidays.GetItems());
            f.ShowDialog();
        }
    }
}