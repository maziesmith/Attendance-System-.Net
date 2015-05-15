namespace Database_1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.status = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.detail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rolln = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Instant_Attendance = new System.Windows.Forms.TabPage();
            this.labtit = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.insrt = new System.Windows.Forms.RadioButton();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.preabs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Inquiry = new System.Windows.Forms.TabPage();
            this.laben = new System.Windows.Forms.Label();
            this.labper = new System.Windows.Forms.Label();
            this.labnam = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Instant_Attendance.SuspendLayout();
            this.Inquiry.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.status.Location = new System.Drawing.Point(12, 305);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            this.status.TabIndex = 4;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(129, 211);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 35);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 238);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Absent";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 201);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Present";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(85, 83);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(103, 23);
            this.detail.TabIndex = 11;
            this.detail.Text = "Show Detail";
            this.detail.UseVisualStyleBackColor = true;
            this.detail.Click += new System.EventHandler(this.detail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(138, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "DATE :";
            // 
            // date2
            // 
            this.date2.CustomFormat = "DD/MM/YY";
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(197, 39);
            this.date2.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(102, 23);
            this.date2.TabIndex = 9;
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(18, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enrpllment No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roll No. :";
            // 
            // rolln
            // 
            this.rolln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rolln.Location = new System.Drawing.Point(78, 39);
            this.rolln.MaxLength = 2;
            this.rolln.Name = "rolln";
            this.rolln.Size = new System.Drawing.Size(28, 23);
            this.rolln.TabIndex = 0;
            this.rolln.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rolln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.er_keypress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Instant_Attendance);
            this.tabControl1.Controls.Add(this.Inquiry);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 301);
            this.tabControl1.TabIndex = 8;
            // 
            // Instant_Attendance
            // 
            this.Instant_Attendance.Controls.Add(this.labtit);
            this.Instant_Attendance.Controls.Add(this.btn_view);
            this.Instant_Attendance.Controls.Add(this.num);
            this.Instant_Attendance.Controls.Add(this.view);
            this.Instant_Attendance.Controls.Add(this.submit);
            this.Instant_Attendance.Controls.Add(this.insrt);
            this.Instant_Attendance.Controls.Add(this.date1);
            this.Instant_Attendance.Controls.Add(this.label5);
            this.Instant_Attendance.Controls.Add(this.preabs);
            this.Instant_Attendance.Controls.Add(this.label4);
            this.Instant_Attendance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Instant_Attendance.Location = new System.Drawing.Point(4, 22);
            this.Instant_Attendance.Name = "Instant_Attendance";
            this.Instant_Attendance.Padding = new System.Windows.Forms.Padding(3);
            this.Instant_Attendance.Size = new System.Drawing.Size(321, 275);
            this.Instant_Attendance.TabIndex = 0;
            this.Instant_Attendance.Text = "Instant Attendance";
            this.Instant_Attendance.UseVisualStyleBackColor = true;
            // 
            // labtit
            // 
            this.labtit.AutoSize = true;
            this.labtit.Location = new System.Drawing.Point(6, 111);
            this.labtit.Name = "labtit";
            this.labtit.Size = new System.Drawing.Size(0, 13);
            this.labtit.TabIndex = 11;
            // 
            // btn_view
            // 
            this.btn_view.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_view.Location = new System.Drawing.Point(167, 220);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 34);
            this.btn_view.TabIndex = 10;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.num.Location = new System.Drawing.Point(9, 127);
            this.num.Multiline = true;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(295, 87);
            this.num.TabIndex = 2;
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_keypress);
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.ForeColor = System.Drawing.SystemColors.ControlText;
            this.view.Location = new System.Drawing.Point(167, 19);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(48, 17);
            this.view.TabIndex = 9;
            this.view.TabStop = true;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submit.Location = new System.Drawing.Point(31, 220);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 34);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // insrt
            // 
            this.insrt.AutoSize = true;
            this.insrt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insrt.Location = new System.Drawing.Point(9, 16);
            this.insrt.Name = "insrt";
            this.insrt.Size = new System.Drawing.Size(65, 17);
            this.insrt.TabIndex = 8;
            this.insrt.TabStop = true;
            this.insrt.Text = "Insertion";
            this.insrt.UseVisualStyleBackColor = true;
            this.insrt.CheckedChanged += new System.EventHandler(this.insrt_CheckedChanged);
            // 
            // date1
            // 
            this.date1.Checked = false;
            this.date1.CustomFormat = "DD/MM/YY";
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date1.Location = new System.Drawing.Point(167, 66);
            this.date1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(102, 23);
            this.date1.TabIndex = 5;
            this.date1.Value = new System.DateTime(2015, 4, 12, 0, 0, 0, 0);
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(164, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select Date";
            // 
            // preabs
            // 
            this.preabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.preabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.preabs.FormattingEnabled = true;
            this.preabs.Items.AddRange(new object[] {
            "Absent Numbrs",
            "Present Numbers"});
            this.preabs.Location = new System.Drawing.Point(9, 65);
            this.preabs.Name = "preabs";
            this.preabs.Size = new System.Drawing.Size(141, 24);
            this.preabs.TabIndex = 1;
            this.preabs.SelectedIndexChanged += new System.EventHandler(this.preabs_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Present/Absent";
            // 
            // Inquiry
            // 
            this.Inquiry.Controls.Add(this.laben);
            this.Inquiry.Controls.Add(this.labper);
            this.Inquiry.Controls.Add(this.labnam);
            this.Inquiry.Controls.Add(this.update);
            this.Inquiry.Controls.Add(this.label1);
            this.Inquiry.Controls.Add(this.radioButton2);
            this.Inquiry.Controls.Add(this.rolln);
            this.Inquiry.Controls.Add(this.radioButton1);
            this.Inquiry.Controls.Add(this.label3);
            this.Inquiry.Controls.Add(this.detail);
            this.Inquiry.Controls.Add(this.label6);
            this.Inquiry.Controls.Add(this.label2);
            this.Inquiry.Controls.Add(this.date2);
            this.Inquiry.Location = new System.Drawing.Point(4, 22);
            this.Inquiry.Name = "Inquiry";
            this.Inquiry.Padding = new System.Windows.Forms.Padding(3);
            this.Inquiry.Size = new System.Drawing.Size(321, 275);
            this.Inquiry.TabIndex = 1;
            this.Inquiry.Text = "Inquiry";
            this.Inquiry.UseVisualStyleBackColor = true;
            // 
            // laben
            // 
            this.laben.AutoSize = true;
            this.laben.Location = new System.Drawing.Point(138, 156);
            this.laben.Name = "laben";
            this.laben.Size = new System.Drawing.Size(0, 13);
            this.laben.TabIndex = 17;
            // 
            // labper
            // 
            this.labper.AutoSize = true;
            this.labper.Location = new System.Drawing.Point(112, 138);
            this.labper.Name = "labper";
            this.labper.Size = new System.Drawing.Size(0, 13);
            this.labper.TabIndex = 16;
            // 
            // labnam
            // 
            this.labnam.AutoSize = true;
            this.labnam.Location = new System.Drawing.Point(82, 123);
            this.labnam.Name = "labnam";
            this.labnam.Size = new System.Drawing.Size(0, 13);
            this.labnam.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 336);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "UVPCE Attendance Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Instant_Attendance.ResumeLayout(false);
            this.Instant_Attendance.PerformLayout();
            this.Inquiry.ResumeLayout(false);
            this.Inquiry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rolln;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Instant_Attendance;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.RadioButton view;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RadioButton insrt;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox preabs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Inquiry;
        private System.Windows.Forms.Label labtit;
        private System.Windows.Forms.Label labnam;
        private System.Windows.Forms.Label labper;
        private System.Windows.Forms.Label laben;
    }
}

