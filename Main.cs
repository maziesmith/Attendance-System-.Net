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
    public partial class Main : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        public Main()
        {
            InitializeComponent();
            preabs.SelectedIndex = 0;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=attendance.accdb;
            Persist Security Info=False;";
        }
        int tn = 61;
        private void Form1_Load(object sender, EventArgs e)
        {
        strt:
            try
            {
                connection.Open();
                status.Text = "Status : Connected";
                insrt.Checked = true;
                date2.Value = DateTime.Today;
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
            finally
            {
                connection.Close();
            }
        }
        int[] roll = new int[80];
        int i;
        public DateTimePicker valid_date(DateTimePicker date)
        {
            if (date.Value.DayOfWeek == DayOfWeek.Sunday || date2.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("Oops.! Its Holiday");
                date.Value =  date.Value.AddDays(-2);
            }
            return date;
        }
        private void num_keypress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            else
                if (e.KeyChar == '\b')
                    return;

            i = num.Text.Length;
            for (int j = 5; j < i + 5; j += 3)
            {
                if (i == 2 || i == j)
                {
                    num.Text += " ";
                    num.Select(num.Text.Length, 0);
                }
            }
        }
        string str = "";
        int n;
        private void submit_Click(object sender, EventArgs e)
        {
                str = num.Text;
                str = str.Replace(" ", "");
                i = 0;
                if (str.Length != 0 && str.Length % 2 != 0)
                {
                     MessageBox.Show("Textbox is Empty.!");
                     return;
                }
                while (str.Length != 0)
                {
                    roll[i] = Convert.ToInt32(str.Substring(str.Length - 2, 2));
                    str = str.Substring(0, str.Length - 2);
                    i++;
                }
                n = i;
                string str1;
                for (i = 0; i < n; i++)
                {
                    str += Convert.ToString(roll[i]) + "\t";
                }
                if (preabs.SelectedIndex == 0)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    try
                    {
                        str1 = "ALTER TABLE CE ADD COLUMN [" + date1.Value.ToShortDateString() + "] YesNo";
                        command.CommandText = str1;
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        for (i = 1; i < tn; i++)
                        {
                            str1 = "UPDATE CE SET [" + date1.Value.ToShortDateString() + "] = Yes where ID = " + i;
                            command.CommandText = str1;
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        for (i = 1; i < n; i++)
                        {
                            str1 = "UPDATE CE SET [" + date1.Value.ToShortDateString() + "] = No where ID = " + roll[i];
                            command.CommandText = str1;
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Attenance Successfully Submited\nTotal " + n + " Students are Absent :\n" + str + "", "Operation Successful");
                    }
                    catch (OleDbException ex)
                    {
                        if (ex.ErrorCode == -2147217887)
                        {
                            DialogResult dialog1 = MessageBox.Show("Attendance already submited for Date " + date1.Value.ToShortDateString() + ". \n\n Do you want to update existing record ?", "Recoed Exists", MessageBoxButtons.YesNo);
                            if (dialog1 == DialogResult.Yes)
                            {
                                for (i = 1; i < tn; i++)
                                {
                                    str1 = "UPDATE CE SET [" + date1.Value.ToShortDateString() + "] = Yes where ID = " + i;
                                    command.CommandText = str1;
                                    command.Connection = connection;
                                    command.ExecuteNonQuery();
                                }
                                for (i = 1; i < n; i++)
                                {
                                    str1 = "UPDATE CE SET [" + date1.Value.ToShortDateString() + "] = No where ID = " + roll[i];
                                    command.CommandText = str1;
                                    command.Connection = connection;
                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("Attenance Successfully Submited\nFollowing " + n + " Students are Absent :\n" + str + "", "Operation Successful");
                            }
                        }
                        else
                            MessageBox.Show("Error Occure" + ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                if (preabs.SelectedIndex == 1)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    try
                    {
                        str1 = "ALTER TABLE CE ADD COLUMN [" + date1.Value.ToShortDateString() + "] YesNo";
                        command.CommandText = str1;
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        for (i = 1; i < tn; i++)
                        {
                            str1 = "UPDATE CE SET [" + date1.Value.ToShortDateString() + "] = No where ID = " + i;
                            command.CommandText = str1;
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        for (i = 1; i < n; i++)
                        {
                            str1 = "UPDATE CE SET [" + date1.Value.ToShortDateString() + "] = Yes where ID = " + roll[i];
                            command.CommandText = str1;
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Attenance Successfully Submited\nTotal " + n + "Students are Present :\n" + str + "", "Operation Successful");
                    }
                    catch (OleDbException ex)
                    {
                        if (ex.ErrorCode == -2147217887)
                        {
                            DialogResult dialog1 = MessageBox.Show("Attendance already submited for Date " + date1.Value.ToShortDateString() + ". \n\n Do you want to update existing record ?", "Recoed Exists", MessageBoxButtons.YesNo);
                            if (dialog1 == DialogResult.Yes)
                            {
                                for (i = 1; i < tn; i++)
                                {
                                    str1 = "UPDATE CE SET [" + date1.Value.ToShortDateString() + "] = No where ID = " + i;
                                    command.CommandText = str1;
                                    command.Connection = connection;
                                    command.ExecuteNonQuery();
                                }
                                for (i = 1; i < n; i++)
                                {
                                    str1 = "UPDATE CE SET [" + date1.Value.ToShortDateString() + "] = Yes where ID = " + roll[i];
                                    command.CommandText = str1;
                                    command.Connection = connection;
                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("Attenance Successfully Submited\nFollowing " + n + " Students are Present :\n" + str + "", "Operation Successful");
                            }
                        }
                        else
                            MessageBox.Show("Error Occure" + ex);
                    }
                    command.Connection.Close();
                }
        }
        private void insrt_CheckedChanged(object sender, EventArgs e)
        {
            view.Enabled = true;
            if (view.Checked == true)
            {
                num.Clear();
                num.Enabled = false;
                submit.Enabled = false;
                btn_view.Enabled = true;
            }
            if (insrt.Checked == true)
            {
                num.Clear();
                num.Enabled = true;
                submit.Enabled = true;
                btn_view.Enabled = false;
            }
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            num.Text = "";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            try
            {
                if (preabs.SelectedIndex == 0)
                {
                    command.CommandText = "SELECT * FROM CE WHERE [" + date1.Value.ToShortDateString() + "] = 0";
                }
                if (preabs.SelectedIndex == 1)
                {
                    command.CommandText = "SELECT * FROM CE WHERE [" + date1.Value.ToShortDateString() + "] = -1";
                }
                command.Connection = connection;
                OleDbDataReader reader = command.ExecuteReader();
                str = "";
                while (reader.Read())
                {
                    str += "  " + Convert.ToString(reader["ID"]);
                }
                num.Text = str;
                view.Enabled = false;    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
        private void preabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (preabs.SelectedIndex == 0)
            {
                labtit.Text = "Absent Numbers :";
            }
            if (preabs.SelectedIndex == 1)
            {
                labtit.Text = "Present Numbers :";
            }
            view.Enabled = true;
        }
        private void detail_Click(object sender, EventArgs e)
        {
            try
            {
                int tmp1 = 5;
                OleDbCommand command = new OleDbCommand();
                command.CommandText = "SELECT * FROM CE WHERE [ID] ="+Convert.ToInt32(rolln.Text);
                //command.CommandText = "SELECT [" + date2.Value.ToShortDateString() + "] FROM CE ID =" + Convert.ToInt32(rolen.Text);
                command.Connection = connection;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    labnam.Text = Convert.ToString(reader["Student_Name"]);
                    laben.Text = Convert.ToString(reader["Enrollment"]);
                    tmp1 = Convert.ToInt32(reader[date2.Value.ToShortDateString()]);
                }
                
                if (tmp1 == 1)
                {
                    radioButton1.Checked = true;
                }
                if (tmp1 == 0)
                {
                    radioButton2.Checked = true;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error : " + ex);
               labnam.Text = "";
               labper.Text = "";
            }
            finally
            {
                connection.Close();
            }
        }
        private void er_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            else
                if (e.KeyChar == '\b')
                    return;
        }
        private void date2_ValueChanged(object sender, EventArgs e)
        {
            date2 = valid_date(date2);
            date1.Value = date2.Value;
        }
        private void date1_ValueChanged(object sender, EventArgs e)
        {
            view.Enabled = true;
            date2.Value = date1.Value;
        }
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                if (radioButton1.Checked == true)
                {
                    command.CommandText = "UPDATE CE SET [" + date2.Value.ToShortDateString() + "] = Yes where ID =" + rolln.Text;
                    MessageBox.Show(labnam.Text + " : Present","Successfully Updated");
                }
                if (radioButton2.Checked == true)
                {
                    command.CommandText = "UPDATE CE SET [" + date2.Value.ToShortDateString() + "] = No where ID =" + rolln.Text;
                    MessageBox.Show(labnam.Text + " : Absent", "Successfully Updated");
                }
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error during updating..!.\n No changes were made \n Error: " + ex, "Error.!");
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
