namespace Database_1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loginbtn = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usr = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.match = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.creatusr = new System.Windows.Forms.TextBox();
            this.confcreatpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.creatpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.match1 = new System.Windows.Forms.Label();
            this.changebtn = new System.Windows.Forms.Button();
            this.cnfcngpas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.changpass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.changeusr = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-5, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 271);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.loginbtn);
            this.tabPage1.Controls.Add(this.pass);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.usr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(92, 160);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(98, 35);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(142, 107);
            this.pass.MaxLength = 10;
            this.pass.Name = "pass";
            this.pass.ShortcutsEnabled = false;
            this.pass.Size = new System.Drawing.Size(132, 26);
            this.pass.TabIndex = 1;
            this.pass.UseSystemPasswordChar = true;
            this.pass.WordWrap = false;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name";
            // 
            // usr
            // 
            this.usr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.usr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr.FormattingEnabled = true;
            this.usr.Location = new System.Drawing.Point(142, 59);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(132, 28);
            this.usr.TabIndex = 0;
            this.usr.SelectedIndexChanged += new System.EventHandler(this.usr_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.match);
            this.tabPage2.Controls.Add(this.createbtn);
            this.tabPage2.Controls.Add(this.creatusr);
            this.tabPage2.Controls.Add(this.confcreatpass);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.creatpass);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // match
            // 
            this.match.AutoSize = true;
            this.match.Location = new System.Drawing.Point(165, 165);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(0, 13);
            this.match.TabIndex = 12;
            // 
            // createbtn
            // 
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.Location = new System.Drawing.Point(100, 195);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(106, 28);
            this.createbtn.TabIndex = 6;
            this.createbtn.Text = "Create User";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // creatusr
            // 
            this.creatusr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.creatusr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.creatusr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatusr.Location = new System.Drawing.Point(142, 54);
            this.creatusr.MaxLength = 3;
            this.creatusr.Name = "creatusr";
            this.creatusr.ShortcutsEnabled = false;
            this.creatusr.Size = new System.Drawing.Size(132, 21);
            this.creatusr.TabIndex = 3;
            this.creatusr.WordWrap = false;
            this.creatusr.TextChanged += new System.EventHandler(this.creatusr_TextChanged);
            // 
            // confcreatpass
            // 
            this.confcreatpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confcreatpass.Location = new System.Drawing.Point(142, 131);
            this.confcreatpass.MaxLength = 10;
            this.confcreatpass.Name = "confcreatpass";
            this.confcreatpass.ShortcutsEnabled = false;
            this.confcreatpass.Size = new System.Drawing.Size(132, 21);
            this.confcreatpass.TabIndex = 5;
            this.confcreatpass.UseSystemPasswordChar = true;
            this.confcreatpass.WordWrap = false;
            this.confcreatpass.TextChanged += new System.EventHandler(this.confcreatpass_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Conform Password";
            // 
            // creatpass
            // 
            this.creatpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatpass.Location = new System.Drawing.Point(142, 94);
            this.creatpass.MaxLength = 10;
            this.creatpass.Name = "creatpass";
            this.creatpass.ShortcutsEnabled = false;
            this.creatpass.Size = new System.Drawing.Size(132, 21);
            this.creatpass.TabIndex = 4;
            this.creatpass.UseSystemPasswordChar = true;
            this.creatpass.WordWrap = false;
            this.creatpass.TextChanged += new System.EventHandler(this.creatpass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "User Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.match1);
            this.tabPage3.Controls.Add(this.changebtn);
            this.tabPage3.Controls.Add(this.cnfcngpas);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.changpass);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.oldpass);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.changeusr);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(312, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Change Password";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // match1
            // 
            this.match1.AutoSize = true;
            this.match1.ForeColor = System.Drawing.Color.Red;
            this.match1.Location = new System.Drawing.Point(156, 154);
            this.match1.Name = "match1";
            this.match1.Size = new System.Drawing.Size(0, 13);
            this.match1.TabIndex = 13;
            // 
            // changebtn
            // 
            this.changebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changebtn.Location = new System.Drawing.Point(71, 184);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(137, 30);
            this.changebtn.TabIndex = 10;
            this.changebtn.Text = "Change Password";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // cnfcngpas
            // 
            this.cnfcngpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnfcngpas.Location = new System.Drawing.Point(127, 120);
            this.cnfcngpas.MaxLength = 10;
            this.cnfcngpas.Name = "cnfcngpas";
            this.cnfcngpas.ShortcutsEnabled = false;
            this.cnfcngpas.Size = new System.Drawing.Size(132, 21);
            this.cnfcngpas.TabIndex = 9;
            this.cnfcngpas.UseSystemPasswordChar = true;
            this.cnfcngpas.WordWrap = false;
            this.cnfcngpas.TextChanged += new System.EventHandler(this.cnfcngpas_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Confirm Password";
            this.label10.UseMnemonic = false;
            // 
            // changpass
            // 
            this.changpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changpass.Location = new System.Drawing.Point(127, 93);
            this.changpass.MaxLength = 10;
            this.changpass.Name = "changpass";
            this.changpass.ShortcutsEnabled = false;
            this.changpass.Size = new System.Drawing.Size(132, 21);
            this.changpass.TabIndex = 8;
            this.changpass.UseSystemPasswordChar = true;
            this.changpass.WordWrap = false;
            this.changpass.TextChanged += new System.EventHandler(this.changpass_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "New Password";
            // 
            // oldpass
            // 
            this.oldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpass.Location = new System.Drawing.Point(127, 58);
            this.oldpass.MaxLength = 10;
            this.oldpass.Name = "oldpass";
            this.oldpass.ShortcutsEnabled = false;
            this.oldpass.Size = new System.Drawing.Size(132, 21);
            this.oldpass.TabIndex = 7;
            this.oldpass.UseSystemPasswordChar = true;
            this.oldpass.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Old Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "User Name";
            // 
            // changeusr
            // 
            this.changeusr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.changeusr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.changeusr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeusr.FormattingEnabled = true;
            this.changeusr.Location = new System.Drawing.Point(127, 19);
            this.changeusr.Name = "changeusr";
            this.changeusr.Size = new System.Drawing.Size(132, 23);
            this.changeusr.TabIndex = 6;
            this.changeusr.SelectedIndexChanged += new System.EventHandler(this.changeusr_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.LimeGreen;
            this.status.Location = new System.Drawing.Point(57, 287);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(59, 13);
            this.status.TabIndex = 1;
            this.status.Text = "Connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status : ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox usr;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confcreatpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox creatpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.TextBox creatusr;
        private System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox changeusr;
        private System.Windows.Forms.TextBox cnfcngpas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox changpass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button changebtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label match;
        private System.Windows.Forms.Label match1;
    }
}
