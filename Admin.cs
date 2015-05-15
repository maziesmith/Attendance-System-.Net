using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Data.OleDb;

namespace Database_1
{
    public partial class Admin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public static bool adminaccess = false;
        public Admin()
        {
            InitializeComponent();
            this.AcceptButton = adminlogin;
        }
        int count = 4;
        private void adminlogin_Click(object sender, EventArgs e)
        {
            if (adminpass.Text == "UVPCE")
            {
                adminaccess = true;
                this.Close();
            }
            else
            {
                adminaccess = false;
                if (count >= 0)
                {
                    MessageBox.Show("Incorrect Password !", "FAILED");
                    adminpass.Clear();
                    count--;
                    attempt.Text = +count + " Try Left !!";
                }
                if (count == 0)
                {

                    attempt.Text = "Administrator is temporarily locked \n try again after 1 minute";
                    adminlogin.Enabled = false;
                    MessageBox.Show("Too much Wrong Attempt Performed..!!!", "THREAD LOCKED");
                    count--;
                }
                if (count == -1)
                {
                    Thread.Sleep(6000);
                    attempt.Text = "";
                    adminlogin.Enabled = true;
                    MessageBox.Show("NO Admin access.!");
                    this.Close();
                }
            }
        }
    }
}
