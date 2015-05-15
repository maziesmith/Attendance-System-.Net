using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database_1
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=attendance.accdb;
            Persist Security Info=False;";
        }
        private void login_Load(object sender, EventArgs e)
        {
        strt:
            loginbtn.Enabled = false;
            createbtn.Enabled = false;
            changebtn.Enabled = false;
            comboload();
            comboload();
            this.AcceptButton = loginbtn;
            this.AcceptButton = createbtn;
            this.AcceptButton = changebtn;
            try
            {
                connection.Open();
                status.Text = "Connected";
                connection.Close();
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Error(s) occure during connecting to Database. \n Press YES to Try again.Press No to Exit", "Connection Problem", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    goto strt;
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        private void pass_TextChanged(object sender, EventArgs e)
        {
            btn_Disable();
        }
        private void usr_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Disable();
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select * from USERS where User_Name='" + usr.Text + "' and Password='" + pass.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count >= 1)
                {
                    this.Hide();
                    Main f3 = new Main();
                    Login f2 = new Login();
                    f3.Show();
                    f2.Close();
                    
                }
                if (count < 1)
                    MessageBox.Show("Username or Password Incorrect.!");
            connection.Close();
        }
        private void btn_Disable()
        {
            if (creatusr.Text.Length<3 || creatpass.Text == "" || creatpass.Text != confcreatpass.Text)
            {
                createbtn.Enabled = false;
                if (creatpass.Text != "" && creatpass.Text != confcreatpass.Text)
                {
                    this.match.ForeColor = System.Drawing.Color.Red;
                    match.Text = "Not Match";
                }
                else
                {
                    match.Text = "";
                }
            }
            else
            {
                createbtn.Enabled = true;
            }
            if (creatpass.Text !="" && creatpass.Text == confcreatpass.Text)
            {
                this.match.ForeColor = System.Drawing.Color.LimeGreen;
                match.Text = "Match";
            }
            if (usr.Text=="" || pass.Text=="")
            {
                loginbtn.Enabled = false;
            }
            else
            {
                loginbtn.Enabled = true;
            }
            if (oldpass.Text =="" || changpass.Text == "" || changpass.Text != cnfcngpas.Text)
            {
                changebtn.Enabled = false;
                if (changpass.Text != "" && changpass.Text != cnfcngpas.Text)
                {
                    this.match1.ForeColor = System.Drawing.Color.Red;
                    match1.Text = "Not Match";
                }
                else
                {
                    match1.Text = "";
                }
            }
            else
            {
                changebtn.Enabled = true;
            }
            if (changpass.Text != "" && changpass.Text == cnfcngpas.Text)
            {
                this.match1.ForeColor = System.Drawing.Color.LimeGreen;
                match1.Text = "Match";
            }
        }
        private void createbtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select * from USERS where User_Name='" + creatusr.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                connection.Close();
                if (count >= 1)
                {
                    MessageBox.Show("UserName already Exist. \n Try another user","Already Exists");
                    creatusr.Clear();
                    creatpass.Clear();
                    confcreatpass.Clear();
                }
                if (count < 1)
                {
                    MessageBox.Show("Need Administrator Access.!","Information");
                    Admin f3 = new Admin();
                    f3.Show();
                    f3.FormClosed += new FormClosedEventHandler(f3_FormClosed);    
                }
            }
            catch (OleDbException ex2)
            {
                MessageBox.Show("Error :\n\n " + ex2, "Error");
            }
            finally
            {
                connection.Close();
            }
        }
        void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (Admin.adminaccess == true)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "Insert into USERS values ('" + creatusr.Text + "','" + creatpass.Text + "')";
                    command.ExecuteNonQuery();
                    comboload();
                    MessageBox.Show("New User successfully added.!");
                    Admin.adminaccess = false;
                }
            }
            catch (OleDbException ex2)
            {
                MessageBox.Show("Error :\n\n " + ex2, "Error");
            }
            finally
            {
                connection.Close();
            }
        }
        private void comboload()
        {
            connection.Open();
            OleDbDataAdapter d = new OleDbDataAdapter("select [User_Name] from USERS", connection);
            DataTable dt = new DataTable();
            d.Fill(dt);
            usr.DataSource = dt;
            usr.DisplayMember = "User_Name";
            changeusr.DataSource = dt;
            changeusr.DisplayMember = "User_Name";
            connection.Close();
        }
        private void creatusr_TextChanged(object sender, EventArgs e)
        {
            btn_Disable();
        }
        private void creatpass_TextChanged(object sender, EventArgs e)
        {
            btn_Disable();
        }
        private void confcreatpass_TextChanged(object sender, EventArgs e)
        {
            btn_Disable();
        }

        private void changpass_TextChanged(object sender, EventArgs e)
        {
            btn_Disable();
        }

        private void cnfcngpas_TextChanged(object sender, EventArgs e)
        {
            btn_Disable();
        }

        private void changeusr_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Disable();
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "Update USERS set [Password]='" + changpass.Text + "' where [User_Name]='" + changeusr.Text + "' AND [Password]='" + oldpass.Text + "'";
            int num1 = command.ExecuteNonQuery();
            connection.Close();
            if (num1 >= 1 || num1 < 0)
            {
                if (num1 == 1)
                {
                    MessageBox.Show("Password change Successfully for User : " + changeusr.Text, "Successfully Changed");
                }
                else
                {
                    MessageBox.Show("Somthing is Wrong..!! \n \n Contact your Administrator.", "ERROR..!!");
                }
            }
            if (num1 == 0)
            {
                MessageBox.Show("Usermane or Old_Password incorrect", "Faild");
            }
        }  
    }
}
