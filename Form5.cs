using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Employee_Details
{
    public partial class Form5 : Form
    {
        Form4 f1;
        public Form5(Form4 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Your name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Employee ID")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (pass2.Text == "Re-enter password")
            {
                pass2.Text = "";
                pass2.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            if (pass.Text == pass2.Text)
            {
                if (f1.fn.Text != null && f1.em.Text != null)
                {
                    if (frm4.dt.Text != null && f1.bg.Text != null)
                    {
                        if (f1.fw.Text != null && f1.pe.Text != null)
                        {
                            if (f1.ei.Text != null && f1.jd.Text != null)
                            {
                                if (f1.cn.Text != null && f1.ecn.Text != null)
                                {
                                    if (f1.ra.Text != null)
                                    {
                                        if (pass.Text != null)
                                        {
                                            try
                                            {
                                                Class1 obj = new Class1();
                                                obj.con.ConnectionString = obj.locate;
                                                obj.con.Open();
                                                string insertdata = "insert into emp_info values('" + f1.fn.Text + "' ,'" + f1.em.Text + "', '" + f1.dt.Text + "' , '" + f1.bg.Text + "' , '" + f1.fw.Text + "' , '" + f1.pe.Text + "' , '" + f1.ei.Text + "' , '" + f1.jd.Text + "' , '" + f1.cn.Text + "' , '" + f1.ecn.Text + "' , '" + f1.ra.Text + "' , '" + pass.Text + "' , '" + f1.s1 + "')";
                                                obj.cmd.Connection = obj.con;
                                                obj.cmd.CommandText = insertdata;
                                                obj.cmd.ExecuteNonQuery();
                                                obj.con.Close();
                                                if (textBox1.Text is not "" and not "Your name")
                                                {
                                                    if (pass.Text != "" && pass.Text != "Password")
                                                    {
                                                        if (pass2.Text != "" && pass2.Text != "Re-enter password")
                                                        {
                                                            if (textBox4.Text != "" && textBox4.Text != "Your Email")
                                                            {
                                                                string message = "Account created successfuly!";
                                                                MessageBox.Show(message);
                                                                Form2 frm = new Form2();
                                                                this.Visible = false;
                                                                frm.ShowDialog();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            { MessageBox.Show("Please enter valid data."); }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please re-enter correct password.");
            }
            /*if (textBox1.Text is not "" and not "Your name")
            {
                if (textBox2.Text != "" && textBox2.Text != "Password")
                {
                    if (textBox3.Text != "" && textBox3.Text != "Re-enter password")
                    {
                        if (textBox4.Text != "" && textBox4.Text != "Your Email")
                        {
                            string message = "Account created successfuly!";
                            MessageBox.Show(message);
                            Form7 frm7 = new Form7();
                            this.Visible = false;
                            frm7.ShowDialog();
                        }
                    }
                }
            }*/
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Your name")
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter your name.");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox4.Text) || textBox4.Text == "Your Email")
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "Please enter your Email.");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(pass.Text) || pass.Text == "Password")
            {
                e.Cancel = true;
                pass.Focus();
                errorProvider2.SetError(pass, "Please enter the password.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(pass2.Text) || pass2.Text == "Re-enter password")
            {
                e.Cancel = true;
                pass2.Focus();
                errorProvider3.SetError(pass2, "Re-enter the password.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Visible = false;
            frm4.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
