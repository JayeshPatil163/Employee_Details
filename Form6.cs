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
    public partial class Form6 : Form
    {
        int temp = 0;
        public static Form6 insta;
        public Form6()
        {
            InitializeComponent();
            insta = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Visible = false;
            frm3.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            bu1.Visible = false;
            b1.Visible = false;
            b2.Visible = false;
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            la7.Visible = false;
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            if (temp == 0)
            {
                Class1 obj = new Class1();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                String s1 = "select Name from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd = new SqlCommand(s1, obj.con);
                String s2 = (String)cmd.ExecuteScalar();
                l1.Text = s2;
                s1 = "select mail from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd1 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd1.ExecuteScalar();
                l2.Text = s2;
                s1 = "select Date_of_birth from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd2 = new SqlCommand(s1, obj.con);
                s2 = cmd2.ExecuteScalar().ToString();
                l3.Text = s2.Split(new char[] { ' ' })[0];
                s1 = "select Blood_group from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd3 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd3.ExecuteScalar();
                l5.Text = s2;
                s1 = "select Admin_field from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd4 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd4.ExecuteScalar();
                l6.Text = s2;
                s1 = "select Admin_id from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd5 = new SqlCommand(s1, obj.con);
                s2 = cmd5.ExecuteScalar().ToString();
                l7.Text = s2;
                s1 = "select Contact_number from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd6 = new SqlCommand(s1, obj.con);
                s2 = cmd6.ExecuteScalar().ToString();
                l8.Text = s2;
                s1 = "select Emergency_contact from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd7 = new SqlCommand(s1, obj.con);
                s2 = cmd7.ExecuteScalar().ToString();
                l9.Text = s2.Split(new char[] { ' ' })[0];
                s1 = "select Residential_adress from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd8 = new SqlCommand(s1, obj.con);
                s2 = cmd8.ExecuteScalar().ToString();
                l10.Text = s2;
                s1 = "select gender from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
                SqlCommand cmd9 = new SqlCommand(s1, obj.con);
                s2 = cmd9.ExecuteScalar().ToString();
                l4.Text = s2;
                temp = 1;
                obj.con.Close();
            }
            t1.Visible = true;
            t2.Visible = true;
            t3.Visible = true;
            t4.Visible = true;
            t5.Visible = true;
            t6.Visible = true;
            t7.Visible = true;
            t8.Visible = true;
            t9.Visible = true;
            t10.Visible = true;
            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;
            l5.Visible = true;
            l6.Visible = true;
            l7.Visible = true;
            l8.Visible = true;
            l9.Visible = true;
            l10.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            bu1.Visible = false;
            b1.Visible = false;
            b2.Visible = false;
            t1.Visible = false;
            t2.Visible = false;
            t3.Visible = false;
            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            t7.Visible = false;
            t8.Visible = false;
            t9.Visible = false;
            t10.Visible = false; 
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            la7.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            b1.Visible = false;
            b2.Visible = false;
            bu1.Visible = false;
            t1.Visible = false;
            t2.Visible = false;
            t3.Visible = false;
            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            t7.Visible = false;
            t8.Visible = false;
            t9.Visible = false;
            t10.Visible = false;
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            la7.Visible = false;
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = true;
            r5.Visible = true;
            r6.Visible = true;
            r7.Visible = true;

            Class1 obj = new Class1();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            try
            {
                //MessageBox.Show("Hi");
                String s1 = "select avg(Points) from Task where emp_post = '" + l6.Text + "'";
                SqlCommand cmd = new SqlCommand(s1, obj.con);
                String s2 = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(s2);
                if (s2 != "" && s2 != null)
                {
                    r3.Text = s2;
                    s1 = "select empid from Task group by empid,emp_post having avg(Points) > select avg(Points) from Task group by empid,emp_post";
                    //where avg(Points) < '" + s2 + "'
                    SqlCommand cmd1 = new SqlCommand(s1, obj.con);
                    s2 = cmd1.ExecuteScalar().ToString();
                    if (s2 == "" || s2 == null)
                    {
                        MessageBox.Show("No employee holds top rank for now!");
                        r7.Text = "--";
                        r5.Text = "--";
                    }
                    else
                    {
                        r7.Text = s2;
                        s1 = "select Full_name from emp_info where Employee_ID = '" + s2 + "'";
                        //where avg(Points) < '" + s2 + "'
                        SqlCommand cmd3 = new SqlCommand(s1, obj.con);
                        s2 = cmd3.ExecuteScalar().ToString();
                        r5.Text = s2;
                    }

                }
                else
                {
                    MessageBox.Show("No employee is working in this section!");
                    r1.Visible = false;
                    r2.Visible = false;
                    r3.Visible = false;
                    r4.Visible = false;
                    r5.Visible = false;
                    r6.Visible = false;
                    r7.Visible = false;
                }

            }
            catch (Exception ex)
            { MessageBox.Show("Unable to get Rank!"); }
            obj.con.Close();
        
        }

        private void label3_Click(object sender, EventArgs e)
        {
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            t1.Visible = false;
            t2.Visible = false;
            t3.Visible = false;
            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            t7.Visible = false;
            t8.Visible = false;
            t9.Visible = false;
            t10.Visible = false;
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            la7.Visible = false;
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            b1.Visible = true;
            b2.Visible = true;
            bu1.Visible = true;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Class1 obj = new Class1();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            string s1 = "select Admin_field from admin_info where password = '" + Form3.instance.pass.Text + "' and Admin_id = '" + Form3.instance.email.Text + "'";
            SqlCommand cmd = new SqlCommand(s1, obj.con);
            string s2 = (string)cmd.ExecuteScalar();
            s1 = "select max(srno) from Tasks";
            SqlCommand cmd1 = new SqlCommand(s1, obj.con);
            string s3 = cmd1.ExecuteScalar().ToString();
            if (s3 == null || s3 == "")
            {
                s3 = "1";
            }
            else
            {
                int i = int.Parse(s3);
                i++;
                s3 = i.ToString();
            }
            string insertdata = "insert into Tasks values('" + b1.Text + "' , '" + b2.Text + "' , '" + s2 + "' , '" + "incomplete" + "' , '" + s3 + "')";
            obj.cmd.Connection = obj.con;
            obj.cmd.CommandText = insertdata;
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("Task assigned successfuly!");
            b1.Text = "";
            b2.Text = "";  
        }

        private void r3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
