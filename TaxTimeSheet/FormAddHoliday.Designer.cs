namespace TaxTimeSheet
{
    partial class FormAddHoliday
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
            uxEndDate = new DateTimePicker();
            label2 = new Label();
            uxStartDate = new DateTimePicker();
            label1 = new Label();
            uxRecuring = new CheckBox();
            uxRecuringPanel = new GroupBox();
            label5 = new Label();
            uxRecuringNum = new TextBox();
            label3 = new Label();
            uxRangeCkeck = new CheckBox();
            uxOK = new Button();
            uxCancel = new Button();
            label4 = new Label();
            uxDesc = new TextBox();
            uxRecuringPanel.SuspendLayout();
            SuspendLayout();
            // 
            // uxEndDate
            // 
            uxEndDate.CustomFormat = "yyyy/MM/dd";
            uxEndDate.Format = DateTimePickerFormat.Custom;
            uxEndDate.Location = new Point(107, 83);
            uxEndDate.Name = "uxEndDate";
            uxEndDate.Size = new Size(216, 31);
            uxEndDate.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 83);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 7;
            label2.Text = "End Date:";
            // 
            // uxStartDate
            // 
            uxStartDate.CustomFormat = "yyyy/MM/dd";
            uxStartDate.Format = DateTimePickerFormat.Custom;
            uxStartDate.Location = new Point(107, 12);
            uxStartDate.Name = "uxStartDate";
            uxStartDate.Size = new Size(216, 31);
            uxStartDate.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 5;
            label1.Text = "Start Date:";
            // 
            // uxRecuring
            // 
            uxRecuring.AutoSize = true;
            uxRecuring.Location = new Point(362, 16);
            uxRecuring.Name = "uxRecuring";
            uxRecuring.Size = new Size(106, 29);
            uxRecuring.TabIndex = 9;
            uxRecuring.Text = "Recuring";
            uxRecuring.UseVisualStyleBackColor = true;
            uxRecuring.CheckedChanged += uxRecuring_CheckedChanged;
            // 
            // uxRecuringPanel
            // 
            uxRecuringPanel.Controls.Add(label5);
            uxRecuringPanel.Controls.Add(uxRecuringNum);
            uxRecuringPanel.Controls.Add(label3);
            uxRecuringPanel.Location = new Point(356, 50);
            uxRecuringPanel.Name = "uxRecuringPanel";
            uxRecuringPanel.Size = new Size(310, 66);
            uxRecuringPanel.TabIndex = 10;
            uxRecuringPanel.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 21);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 2;
            label5.Text = "Week";
            // 
            // uxRecuringNum
            // 
            uxRecuringNum.Location = new Point(66, 18);
            uxRecuringNum.Name = "uxRecuringNum";
            uxRecuringNum.Size = new Size(80, 31);
            uxRecuringNum.TabIndex = 1;
            uxRecuringNum.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 0;
            label3.Text = "Every";
            // 
            // uxRangeCkeck
            // 
            uxRangeCkeck.AutoSize = true;
            uxRangeCkeck.Location = new Point(12, 51);
            uxRangeCkeck.Name = "uxRangeCkeck";
            uxRangeCkeck.Size = new Size(88, 29);
            uxRangeCkeck.TabIndex = 11;
            uxRangeCkeck.Text = "Range";
            uxRangeCkeck.UseVisualStyleBackColor = true;
            uxRangeCkeck.CheckedChanged += uxRangeCheck_CheckedChanged;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(155, 202);
            uxOK.Name = "uxOK";
            uxOK.Size = new Size(112, 34);
            uxOK.TabIndex = 12;
            uxOK.Text = "OK";
            uxOK.UseVisualStyleBackColor = true;
            uxOK.Click += uxOK_Click;
            // 
            // uxCancel
            // 
            uxCancel.Location = new Point(362, 199);
            uxCancel.Name = "uxCancel";
            uxCancel.Size = new Size(112, 34);
            uxCancel.TabIndex = 13;
            uxCancel.Text = "Cancel";
            uxCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 130);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 14;
            label4.Text = "Description:";
            // 
            // uxDesc
            // 
            uxDesc.Location = new Point(123, 130);
            uxDesc.Name = "uxDesc";
            uxDesc.Size = new Size(281, 31);
            uxDesc.TabIndex = 3;
            // 
            // FormAddHoliday
            // 
            AcceptButton = uxOK;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = uxCancel;
            ClientSize = new Size(679, 248);
            Controls.Add(uxDesc);
            Controls.Add(label4);
            Controls.Add(uxCancel);
            Controls.Add(uxOK);
            Controls.Add(uxRangeCkeck);
            Controls.Add(uxRecuring);
            Controls.Add(uxRecuringPanel);
            Controls.Add(uxEndDate);
            Controls.Add(label2);
            Controls.Add(uxStartDate);
            Controls.Add(label1);
            Name = "FormAddHoliday";
            Text = "FormAddHoliday";
            uxRecuringPanel.ResumeLayout(false);
            uxRecuringPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker uxEndDate;
        private Label label2;
        private DateTimePicker uxStartDate;
        private Label label1;
        private CheckBox uxRecuring;
        private GroupBox uxRecuringPanel;
        private TextBox uxRecuringNum;
        private Label label3;
        private CheckBox uxRangeCkeck;
        private Button uxOK;
        private Button uxCancel;
        private Label label5;
        private Label label4;
        private TextBox uxDesc;
    }
}