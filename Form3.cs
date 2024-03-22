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
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Visible = false;
            frm1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             
        }

         

        private void textBox2_Click(object sender, EventArgs e)
        {
             
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
             
        }

         

         

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text) || email.Text == "Admin ID")
            {
                e.Cancel = true;
                email.Focus();
                errorProvider2.SetError(email, "Please enter your Email id.");
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

         

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 obj = new Class1();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                bool a = email.Text.All(char.IsDigit);
                if (!a)
                {
                    MessageBox.Show("Please enter valid Admin ID");
                }
                String s1 = "select password from admin_info where password = '" + pass.Text + "' and Admin_id = '" + email.Text + "'";
                SqlCommand cmd = new SqlCommand(s1, obj.con);
                
                String s2 = (string)cmd.ExecuteScalar();
                 
                if (s2 == null)
                {
                    s2 = "Password";
                }
                string s3 = s2.Trim();
               
                if (pass.Text == s3)
                {
                    if (email.Text != "" && email.Text != "Admin ID")
                    {
                        if (pass.Text != "" && pass.Text != "Password")
                        {
                             
                            String s4 = "select Name from admin_info where password = '" + pass.Text + "' and Admin_ID = '" + email.Text + "'";
                            SqlCommand cmd1 = new SqlCommand(s4, obj.con);
                             
                            String s5 = (String)cmd1.ExecuteScalar();
                             
                            Form6 frm6 = new Form6();
                            Form6.insta.la7.Text = s5;
                            s1 = "select Admin_field from admin_info where password = '" + pass.Text + "' and Admin_id = '" + email.Text + "'";
                            SqlCommand cmd4 = new SqlCommand(s1, obj.con);
                            s2 = (String)cmd4.ExecuteScalar();
                            Form6.insta.l6.Text = s2;
                            Form6.insta.r1.Visible = false;
                            Form6.insta.r2.Visible = false;
                            Form6.insta.r3.Visible = false;
                            Form6.insta.r4.Visible = false;
                            Form6.insta.r5.Visible = false;
                            Form6.insta.r6.Visible = false;
                            Form6.insta.r7.Visible = false;
                            Form6.insta.bu1.Visible = false;
                            Form6.insta.b1.Visible = false;
                            Form6.insta.b2.Visible = false;
                            Form6.insta.t1.Visible = false;
                            Form6.insta.t2.Visible = false;
                            Form6.insta.t3.Visible = false;
                            Form6.insta.t4.Visible = false;
                            Form6.insta.t5.Visible = false;
                            Form6.insta.t6.Visible = false;
                            Form6.insta.t7.Visible = false;
                            Form6.insta.t8.Visible = false;
                            Form6.insta.t9.Visible = false;
                            Form6.insta.t10.Visible = false;
                            Form6.insta.l1.Visible = false;
                            Form6.insta.l2.Visible = false;
                            Form6.insta.l3.Visible = false;
                            Form6.insta.l4.Visible = false;
                            Form6.insta.l5.Visible = false;
                            Form6.insta.l6.Visible = false;
                            Form6.insta.l7.Visible = false;
                            Form6.insta.l8.Visible = false;
                            Form6.insta.l9.Visible = false;
                            Form6.insta.l10.Visible =false;
                            MessageBox.Show("Login Successful!");
                            
                            this.Visible = false;
                            frm6.ShowDialog();

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

        private void label4_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            this.Visible = false;
            frm9.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
