namespace TaxTimeSheet
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxCalc = new Button();
            label1 = new Label();
            uxStartDate = new DateTimePicker();
            uxEndDate = new DateTimePicker();
            label2 = new Label();
            groupBox1 = new GroupBox();
            uxAddRecuringHoliday = new Button();
            uxRemoveHoliday = new Button();
            uxEditHoliday = new Button();
            uxAddRngHoliday = new Button();
            uxAddHoliday = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            uxSave = new Button();
            uxLoad = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uxCalc
            // 
            uxCalc.Location = new Point(460, 9);
            uxCalc.Name = "uxCalc";
            uxCalc.Size = new Size(112, 34);
            uxCalc.TabIndex = 0;
            uxCalc.Text = "Calculate";
            uxCalc.UseVisualStyleBackColor = true;
            uxCalc.Click += uxCalc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "Start Date:";
            // 
            // uxStartDate
            // 
            uxStartDate.CustomFormat = "yyyy/MM/dd";
            uxStartDate.Format = DateTimePickerFormat.Custom;
            uxStartDate.Location = new Point(108, 9);
            uxStartDate.Name = "uxStartDate";
            uxStartDate.Size = new Size(300, 31);
            uxStartDate.TabIndex = 2;
            // 
            // uxEndDate
            // 
            uxEndDate.CustomFormat = "yyyy/MM/dd";
            uxEndDate.Format = DateTimePickerFormat.Custom;
            uxEndDate.Location = new Point(108, 46);
            uxEndDate.Name = "uxEndDate";
            uxEndDate.Size = new Size(300, 31);
            uxEndDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 3;
            label2.Text = "End Date:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(uxAddRecuringHoliday);
            groupBox1.Controls.Add(uxRemoveHoliday);
            groupBox1.Controls.Add(uxEditHoliday);
            groupBox1.Controls.Add(uxAddRngHoliday);
            groupBox1.Controls.Add(uxAddHoliday);
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 791);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Holidays";
            // 
            // uxAddRecuringHoliday
            // 
            uxAddRecuringHoliday.Location = new Point(525, 123);
            uxAddRecuringHoliday.Name = "uxAddRecuringHoliday";
            uxAddRecuringHoliday.Size = new Size(159, 34);
            uxAddRecuringHoliday.TabIndex = 5;
            uxAddRecuringHoliday.Text = "Add Recuring";
            uxAddRecuringHoliday.UseVisualStyleBackColor = true;
            uxAddRecuringHoliday.Click += uxAddRecuringHoliday_Click;
            // 
            // uxRemoveHoliday
            // 
            uxRemoveHoliday.Location = new Point(548, 268);
            uxRemoveHoliday.Name = "uxRemoveHoliday";
            uxRemoveHoliday.Size = new Size(112, 34);
            uxRemoveHoliday.TabIndex = 4;
            uxRemoveHoliday.Text = "Remove";
            uxRemoveHoliday.UseVisualStyleBackColor = true;
            uxRemoveHoliday.Click += uxRemoveHoliday_Click;
            // 
            // uxEditHoliday
            // 
            uxEditHoliday.Location = new Point(548, 199);
            uxEditHoliday.Name = "uxEditHoliday";
            uxEditHoliday.Size = new Size(112, 34);
            uxEditHoliday.TabIndex = 3;
            uxEditHoliday.Text = "Edit";
            uxEditHoliday.UseVisualStyleBackColor = true;
            uxEditHoliday.Click += uxEditHoliday_Click;
            // 
            // uxAddRngHoliday
            // 
            uxAddRngHoliday.Location = new Point(548, 77);
            uxAddRngHoliday.Name = "uxAddRngHoliday";
            uxAddRngHoliday.Size = new Size(112, 34);
            uxAddRngHoliday.TabIndex = 2;
            uxAddRngHoliday.Text = "Add Range";
            uxAddRngHoliday.UseVisualStyleBackColor = true;
            uxAddRngHoliday.Click += uxAddRngHoliday_Click;
            // 
            // uxAddHoliday
            // 
            uxAddHoliday.Location = new Point(548, 30);
            uxAddHoliday.Name = "uxAddHoliday";
            uxAddHoliday.Size = new Size(112, 34);
            uxAddHoliday.TabIndex = 1;
            uxAddHoliday.Text = "Add";
            uxAddHoliday.UseVisualStyleBackColor = true;
            uxAddHoliday.Click += uxAddHoliday_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Start";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "End";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Num";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Description";
            columnHeader4.Width = 130;
            // 
            // uxSave
            // 
            uxSave.Location = new Point(602, 60);
            uxSave.Name = "uxSave";
            uxSave.Size = new Size(112, 34);
            uxSave.TabIndex = 6;
            uxSave.Text = "Save";
            uxSave.UseVisualStyleBackColor = true;
            uxSave.Click += uxSave_Click;
            // 
            // uxLoad
            // 
            uxLoad.Location = new Point(602, 9);
            uxLoad.Name = "uxLoad";
            uxLoad.Size = new Size(112, 34);
            uxLoad.TabIndex = 7;
            uxLoad.Text = "Load";
            uxLoad.UseVisualStyleBackColor = true;
            uxLoad.Click += uxLoad_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 907);
            Controls.Add(uxLoad);
            Controls.Add(uxSave);
            Controls.Add(groupBox1);
            Controls.Add(uxEndDate);
            Controls.Add(label2);
            Controls.Add(uxStartDate);
            Controls.Add(label1);
            Controls.Add(uxCalc);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormMain";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxCalc;
        private Label label1;
        private DateTimePicker uxStartDate;
        private DateTimePicker uxEndDate;
        private Label label2;
        private GroupBox groupBox1;
        private ListViewEx<HolidayRecord> uxHolidays;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button uxRemoveHoliday;
        private Button uxEditHoliday;
        private Button uxAddRngHoliday;
        private Button uxAddHoliday;
        private Button uxAddRecuringHoliday;
        private Button uxSave;
        private Button uxLoad;
    }
}