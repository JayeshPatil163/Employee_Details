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
using Twilio.TwiML.Voice;

namespace Employee_Details
{
    public partial class Form2 : Form
    {
        public static Form2 instance; 
        Form7 form = new Form7();
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Visible = false;
            frm4.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Visible = false;
            frm1.ShowDialog();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
             
        }

         

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            try
            {
                Class1 obj = new Class1();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                bool a = email.Text.All(char.IsDigit);
                if(!a)
                {
                    MessageBox.Show("Please enter valid Employee ID");
                }
                String s1 = "select password from emp_info where password = '" + pass.Text + "' and Employee_ID = '" + email.Text + "'";
                SqlCommand cmd = new SqlCommand(s1, obj.con);
                String s2 = (String)cmd.ExecuteScalar();
                 
                if(s2 == null)
                {
                    s2 = "Password";
                }
                string s3 = s2.Trim();
                if (pass.Text == s3)
                {
                         if (email.Text != "" && email.Text != "Employee ID")
                         {
                             if (pass.Text != "" && pass.Text != "Password")
                             {
                                   String s4 = "select Full_name from emp_info where password = '" + pass.Text + "' and Employee_ID = '" + email.Text + "'";
                                   SqlCommand cmd1 = new SqlCommand(s4, obj.con);
                                   String s5 = (String)cmd1.ExecuteScalar();
                                   s1 = "select Field_of_working from emp_info where password = '" + pass.Text + "' and Employee_ID = '" + email.Text + "'";
                                   SqlCommand cmd4 = new SqlCommand(s1, obj.con);
                                   s2 = (String)cmd4.ExecuteScalar();
                                   Form7.insta.l6.Text = s2;
                                   s1 = "select Employee_ID from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                                   SqlCommand cmd6 = new SqlCommand(s1, obj.con);
                                   s2 = cmd6.ExecuteScalar().ToString();

                                   Form7.insta.l8.Text = s2;
                                   s1 = "select Employee_ID from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                                   SqlCommand cmd7 = new SqlCommand(s1, obj.con);
                                   s2 = cmd7.ExecuteScalar().ToString();
                                   Form7.insta.l8.Text = s2;
                                   Form7.insta.label7.Text = s5;
                                   Form7.insta.r1.Visible = false;
                                   Form7.insta.r2.Visible = false;
                                   Form7.insta.r3.Visible = false;
                                   Form7.insta.r4.Visible = false;
                                   Form7.insta.r5.Visible = false;
                                   Form7.insta.pb1.Visible = false;
                                   Form7.insta.r1.Visible = false;
                                   Form7.insta.pb1.Visible = false;
                                   Form7.insta.o1.Visible = false;
                                   Form7.insta.o2.Visible = false;
                                   Form7.insta.o3.Visible = false;
                                   Form7.insta.o4.Visible = false;
                                   Form7.insta.b1.Visible = false;
                                   Form7.insta.b2.Visible = false;
                                   Form7.insta.b3.Visible = false;
                                   Form7.insta.b4.Visible = false;
                                   Form7.insta.p1.Visible = false;
                                   Form7.insta.p2.Visible = false;
                                   Form7.insta.p3.Visible = false;
                                   Form7.insta.p4.Visible = false;
                                   Form7.insta.d1.Visible = false;
                                   Form7.insta.d2.Visible = false;
                                   Form7.insta.d3.Visible = false;
                                   Form7.insta.d4.Visible = false;
                                   Form7.insta.task.Visible = false;
                                   Form7.insta.f.Visible = false;
                                   Form7.insta.emi.Visible = false;
                                   Form7.insta.db.Visible = false;
                                   Form7.insta.g.Visible = false;
                                   Form7.insta.bg.Visible = false;
                                   Form7.insta.fw.Visible = false;
                                   Form7.insta.pe.Visible = false;
                                   Form7.insta.ei.Visible = false;
                                   Form7.insta.jd.Visible = false;
                                   Form7.insta.cn.Visible = false;
                                   Form7.insta.ec.Visible = false;
                                   Form7.insta.rs.Visible = false;
                                   Form7.insta.l1.Visible = false;
                                   Form7.insta.l2.Visible = false;
                                   Form7.insta.l3.Visible = false;
                                   Form7.insta.l4.Visible = false;
                                   Form7.insta.l5.Visible = false;
                                   Form7.insta.l6.Visible = false;
                                   Form7.insta.l7.Visible = false;
                                   Form7.insta.l8.Visible = false;
                                   Form7.insta.l9.Visible = false;
                                   Form7.insta.l10.Visible = false;
                                   Form7.insta.l11.Visible = false;
                                   Form7.insta.l12.Visible = false;
                                   MessageBox.Show("Login Successful!");
                                            this.Visible = false;
                                            frm7.ShowDialog();
                             }
                             else
                                 MessageBox.Show("Incorrect ID or Password.");
                         }
                }
                else 
                {
                    MessageBox.Show("Incorrect ID or Password.");
                }
                obj.con.Close();
            }    
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
             
        }

        private void textBox3_Click_1(object sender, EventArgs e)
        {
             
        }

         

         

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text) || email.Text == "Employee ID")
            {
                e.Cancel = true;
                email.Focus();
                errorProvider2.SetError(email, "Please enter your Employee ID.");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(pass.Text) || pass.Text == "Password")
            {
                e.Cancel = true;
                pass.Focus();
                errorProvider3.SetError(pass, "Please enter the password.");
            }
        }

         

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
