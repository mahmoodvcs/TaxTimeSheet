namespace TaxTimeSheet
{
    partial class FormCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            uxHoursPerDay = new TextBox();
            uxAllDays = new TextBox();
            label3 = new Label();
            uxCentsPerHour = new TextBox();
            label4 = new Label();
            uxCost = new TextBox();
            lblHours = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 1;
            label2.Text = "Hours per day:";
            // 
            // uxHoursPerDay
            // 
            uxHoursPerDay.Location = new Point(147, 74);
            uxHoursPerDay.Name = "uxHoursPerDay";
            uxHoursPerDay.Size = new Size(150, 31);
            uxHoursPerDay.TabIndex = 2;
            uxHoursPerDay.Text = "7.6";
            uxHoursPerDay.TextChanged += uxHoursPerDay_TextChanged;
            // 
            // uxAllDays
            // 
            uxAllDays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uxAllDays.Location = new Point(12, 170);
            uxAllDays.Multiline = true;
            uxAllDays.Name = "uxAllDays";
            uxAllDays.ReadOnly = true;
            uxAllDays.ScrollBars = ScrollBars.Both;
            uxAllDays.Size = new Size(603, 627);
            uxAllDays.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 111);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Total cost:";
            // 
            // uxCentsPerHour
            // 
            uxCentsPerHour.Location = new Point(147, 111);
            uxCentsPerHour.Name = "uxCentsPerHour";
            uxCentsPerHour.Size = new Size(150, 31);
            uxCentsPerHour.TabIndex = 6;
            uxCentsPerHour.Text = "67";
            uxCentsPerHour.TextChanged += uxCentsPerHour_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 5;
            label4.Text = "Cents per hour";
            // 
            // uxCost
            // 
            uxCost.Location = new Point(451, 105);
            uxCost.Name = "uxCost";
            uxCost.ReadOnly = true;
            uxCost.Size = new Size(150, 31);
            uxCost.TabIndex = 7;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(12, 34);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(0, 25);
            lblHours.TabIndex = 8;
            // 
            // FormCalc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 823);
            Controls.Add(lblHours);
            Controls.Add(uxCost);
            Controls.Add(uxCentsPerHour);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(uxAllDays);
            Controls.Add(uxHoursPerDay);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCalc";
            Text = "FormCalc";
            Load += FormCalc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox uxHoursPerDay;
        private TextBox uxAllDays;
        private Label label3;
        private TextBox uxCentsPerHour;
        private Label label4;
        private TextBox uxCost;
        private Label lblHours;
    }
}