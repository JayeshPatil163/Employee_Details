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
    
    public partial class Form7 : Form
    {
        int temp = 0;
        int[] arr = new int[100];
        static int z = 1, i = 0;
        public static Form7 insta;
        
        public Form7()
        {
            InitializeComponent();
            insta = this; 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {
            o1.Visible = false;
            o2.Visible = false;
            o3.Visible = false;
            o4.Visible = false;
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            d1.Visible = false;
            d2.Visible = false;
            d3.Visible = false;
            d4.Visible = false;
            task.Visible = false;
            f.Visible = false;
            emi.Visible = false;
            db.Visible = false;
            g.Visible = false;
            bg.Visible = false;
            fw.Visible = false;
            pe.Visible = false;
            ei.Visible = false;
            jd.Visible = false;
            cn.Visible = false;
            ec.Visible = false;
            rs.Visible = false;
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
            l11.Visible = false;
            l12.Visible = false;
            label7.Visible = false; 
            pic.Visible = false;
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            
            
            Class1 obj = new Class1();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            try
            {
                //MessageBox.Show("Hi");
                String s1 = "select avg(Points) from Task where emp_post = '" + l6.Text + "' and empid = '" + l8.Text + "'";
                SqlCommand cmd = new SqlCommand(s1, obj.con);
                String s2 = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(s2);
                if (s2 != "" && s2 != null)
                {
                    pb1.Visible = true;
                    this.timer1.Start();
                    r3.Text = s2;
                    try
                    {
                        s1 = "select count(*) from Task group by empid,emp_post having select avg(Points) from Task group by empid,emp_post < '" + s2 + "'";
                        //where avg(Points) < '" + s2 + "'
                        SqlCommand cmd1 = new SqlCommand(s1, obj.con);
                        s2 = cmd1.ExecuteScalar().ToString();
                        if (s2 == "" || s2 == null)
                            s2 = "0";
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Wait!"); }
                    // MessageBox.Show(s2);
                    string s10 = "select count(*) from Task group by empid,emp_post having select avg(Points) from Task group by empid,emp_post > '" + s2 + "'";
                    SqlCommand cmd2 = new SqlCommand(s10, obj.con);
                    string s11 = cmd2.ExecuteScalar().ToString();
                    // MessageBox.Show(s11);
                    if (s2 == "" || s2 == null)
                    {
                        if (s11 == "" || s11 == null)
                            s2 = "First";
                        else
                            s2 = "Last";
                    }
                    else
                    {
                        if (s11 == "" || s11 == null)
                            s2 = "First";
                    }
                    r5.Text = s2;
                }
                else 
                {
                    r1.Visible = false;
                    r2.Visible = false;
                    r3.Visible = false;
                    r4.Visible = false;
                    r5.Visible = false;
                    MessageBox.Show("Not enough employee data!");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Unable to get Rank!"); }
            obj.con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            /*Class1 obj = new Class1();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            String s1 = "select Full_name from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
            SqlCommand cmd = new SqlCommand(s1, obj.con);
            String s2 = (String)cmd.ExecuteScalar();
            label7.Text = s2;
            obj.con.Close();*/
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            pb1.Visible = false;
            o1.Visible = false;
            o2.Visible = false;
            o3.Visible = false;
            o4.Visible = false;
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            d1.Visible = false;
            d2.Visible = false;
            d3.Visible = false;
            d4.Visible = false;
            task.Visible = false;
            f.Visible = false;
            emi.Visible = false;
            db.Visible = false;
            g.Visible = false;
            bg.Visible = false;
            fw.Visible = false;
            pe.Visible = false;
            ei.Visible = false;
            jd.Visible = false;
            cn.Visible = false;
            ec.Visible = false;
            rs.Visible = false;
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
            l11.Visible = false;
            l12.Visible = false;
            label7.Visible = true;
            pic.Visible = true;
            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
             
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            o1.Visible = false;
            o2.Visible = false;
            o3.Visible = false;
            o4.Visible = false;
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            d1.Visible = false;
            d2.Visible = false;
            d3.Visible = false;
            d4.Visible = false;
            task.Visible = false;
            label7.Visible = false;
            pic.Visible = false;
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            pb1.Visible = false;
            if (temp == 0)
            {
                Class1 obj = new Class1();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                String s1 = "select Full_name from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd = new SqlCommand(s1, obj.con);
                String s2 = (String)cmd.ExecuteScalar();
                l1.Text = s2;
                s1 = "select mail_id from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd1 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd1.ExecuteScalar();
                l2.Text = s2;
                s1 = "select Date_of_Birth from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd2 = new SqlCommand(s1, obj.con);
                s2 = cmd2.ExecuteScalar().ToString();
                l3.Text = s2.Split(new char[] { ' ' })[0];
                s1 = "select Blood_group from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd3 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd3.ExecuteScalar();
                l5.Text = s2;
                s1 = "select Field_of_working from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd4 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd4.ExecuteScalar();
                l6.Text = s2;
                s1 = "select Post_of_employee from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd5 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd5.ExecuteScalar();
                l7.Text = s2;
                s1 = "select Employee_ID from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd6 = new SqlCommand(s1, obj.con);
                s2 = cmd6.ExecuteScalar().ToString();
                l8.Text = s2;
                s1 = "select joining_date from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd7 = new SqlCommand(s1, obj.con);
                s2 = cmd7.ExecuteScalar().ToString();
                l9.Text = s2.Split(new char[] { ' ' })[0];
                s1 = "select Contact_number from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd8 = new SqlCommand(s1, obj.con);
                s2 = cmd8.ExecuteScalar().ToString();
                l10.Text = s2;
                s1 = "select Emergency_Contact from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd9 = new SqlCommand(s1, obj.con);
                s2 = cmd9.ExecuteScalar().ToString();
                l11.Text = s2;
                s1 = "select Residential_address from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd10 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd10.ExecuteScalar();
                l12.Text = s2;
                s1 = "select gender from emp_info where password = '" + Form2.instance.pass.Text + "' and Employee_ID = '" + Form2.instance.email.Text + "'";
                SqlCommand cmd11 = new SqlCommand(s1, obj.con);
                s2 = (String)cmd11.ExecuteScalar();
                l4.Text = s2;
                temp = 1;
                obj.con.Close();
            }
            f.Visible = true;
            emi.Visible =true;
            db.Visible = true;
            g.Visible = true;
            bg.Visible = true;
            fw.Visible = true;
            pe.Visible = true;
            ei.Visible = true;
            jd.Visible = true;
            cn.Visible = true;
            ec.Visible = true;
            rs.Visible = true;
            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;
            l5.Visible = true;
            l6.Visible = true;
            l7.Visible = true;
            l8.Visible = true;
            l9.Visible = true;
            l10.Visible =true;
            l11.Visible =true;
            l12.Visible =true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            f.Visible = false;
            emi.Visible = false;
            db.Visible = false;
            g.Visible = false;
            bg.Visible = false;
            fw.Visible = false;
            pe.Visible = false;
            ei.Visible = false;
            jd.Visible = false;
            cn.Visible = false;
            ec.Visible = false;
            rs.Visible = false;
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
            l11.Visible = false;
            l12.Visible = false;
            label7.Visible = false;
            pic.Visible = false;
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            pb1.Visible = false;
            Class1 obj = new Class1();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            Form2 Form = new Form2();
            //string s9 = "select Field_of_working from emp_info where password = '" + Form2.instance.pass.Text + "'";
            //SqlCommand cmd4 = new SqlCommand(s9, obj.con);
            //string s10 = cmd4.ExecuteScalar().ToString();
            string s9 = "select max(srno) from Task where emp_post = '" + l6.Text + "' and empid = '" + l8.Text + "'";
            SqlCommand cmd4 = new SqlCommand(s9, obj.con);
            string s6 = cmd4.ExecuteScalar().ToString();
            if (s6 == null || s6 == "")
                s6 = "0";
            // MessageBox.Show(s6);
            string s5 = "select min(srno) from Tasks where emp_post = '" + l6.Text + "' and srno > '" + s6 + "' and srno > '" + arr[i] + "'";
            SqlCommand cmd3 = new SqlCommand(s5, obj.con);
            s6 = cmd3.ExecuteScalar().ToString();
            // MessageBox.Show(s6);
            //String s5 = "select min(srno) from Tasks where trim(emp_post) = '" + l6.Text + "'";
            //SqlCommand cmd2 = new SqlCommand(s5, obj.con);
            //String s6 = cmd2.ExecuteScalar().ToString();
            //MessageBox.Show(s6);
            if (b1.Text.Trim() == "1" && b2.Text.Trim() == "2" && b3.Text.Trim() == "3" && b4.Text.Trim() == "4" && (s6 == "" || s6 == null))
            {
              //  MessageBox.Show("this is if block");
                o1.Visible = false;
                o2.Visible = false;
                o3.Visible = false;
                o4.Visible = false;
                b1.Visible = false;
                b2.Visible = false;
                b3.Visible = false;
                b4.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                d1.Visible = false;
                d2.Visible = false;
                d3.Visible = false;
                d4.Visible = false;
                task.Visible = true;
            }
            else
            {
                task.Visible = false;
                o1.Visible = true;
                o2.Visible = true;
                o3.Visible = true;
                o4.Visible = true;
                b1.Visible = true;
                b2.Visible = true;
                b3.Visible = true;
                b4.Visible = true;
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = true;
                p4.Visible = true;
                d1.Visible = true;
                d2.Visible = true;
                d3.Visible = true;
                d4.Visible = true;
                     
                while (b1.Text.Trim() == "1" || b2.Text.Trim() == "2" || b3.Text.Trim() == "3" || b4.Text.Trim() == "4")
                {
                    s9 = "select max(srno) from Task where emp_post = '" + l6.Text + "' and empid = '" +l8.Text+ "'";
                    SqlCommand cmd5 = new SqlCommand(s9, obj.con);
                    s6 = cmd5.ExecuteScalar().ToString();
                    if (s6 == null || s6 == "")
                        s6 = "0";
                   // MessageBox.Show(s6);
                    s5 = "select min(srno) from Tasks where emp_post = '" + l6.Text + "' and srno > '" + s6 + "' and srno > '" +arr[i]+ "'";
                    SqlCommand cmd8 = new SqlCommand(s5, obj.con);
                    s6 = cmd8.ExecuteScalar().ToString();
                   // MessageBox.Show(s6);

                    if (s6 == null || s6 == "")
                        break;
                    i++;
                    arr[i] = int.Parse(s6);
                    
                    String s1 = "select task from Tasks where srno = '" + s6 + "'";
                    SqlCommand cmd = new SqlCommand(s1, obj.con);
                    String s2 = (String)cmd.ExecuteScalar();
                   // MessageBox.Show(s2);
                    String s3 = "select Points from Tasks where srno = '" + s6 + "'";
                    SqlCommand cmd1 = new SqlCommand(s3, obj.con);
                    String s4 = cmd1.ExecuteScalar().ToString();
                   // MessageBox.Show(s4);
                    if (b1.Text.Trim() == "1" || b1.Text == null)
                    {
                        b1.Text = s2;
                        p1.Text = s4;
                    }
                    else if (b2.Text.Trim() == "2" || b2.Text == null)
                    {
                        b2.Text = s2;
                        p2.Text = s4;
                    }
                    else if (b3.Text.Trim() == "3" || b3.Text == null)
                    {
                        b3.Text = s2;
                        p3.Text = s4;
                    }
                    else if (b4.Text.Trim() == "4" || b4.Text == null)
                    {
                        b4.Text = s2;
                        p4.Text = s4;
                    }
                }
                
                if (b1.Text.Trim() == "1" || b1.Text == null)
                {
                    o1.Visible = false;
                    b1.Visible = false;
                    p1.Visible = false;
                    d1.Visible = false;
                }
                if (b2.Text.Trim() == "2" || b2.Text == null)
                {
                    o2.Visible = false;
                    b2.Visible = false;
                    p2.Visible = false;
                    d2.Visible = false;
                }
                if (b3.Text.Trim() == "3" || b3.Text == null)
                {
                    o3.Visible = false;
                    b3.Visible = false;
                    p3.Visible = false;
                    d3.Visible = false;
                }
                if (b4.Text.Trim() == "4" || b4.Text == null)
                {
                    o4.Visible = false;
                    b4.Visible = false;
                    p4.Visible = false;
                    d4.Visible = false;
                }
            }
            obj.con.Close();
            
        }

        private void b_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_3(object sender, EventArgs e)
        {
            
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Visible = false;
            frm2.ShowDialog();
        }

        private void ra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void fn_TextChanged(object sender, EventArgs e)
        {

        }

        private void cn_TextChanged(object sender, EventArgs e)
        {

        }

        private void pe_TextChanged(object sender, EventArgs e)
        {

        }

        private void ecn_TextChanged(object sender, EventArgs e)
        {

        }

        private void em_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void bg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void jd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ei_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Start");
                Class1 obj = new Class1();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                //MessageBox.Show("Start");
                 
                string s2 = "select emp_post from Tasks where srno = '" + arr[z] + "'";
                SqlCommand cmd1 = new SqlCommand(s2, obj.con);
                String s4 = (String)cmd1.ExecuteScalar();
                //MessageBox.Show(s4);
                string insertdata = "insert into Task values('" +b1.Text+ "','" +p1.Text+ "','" +s4+ "','" +"complete"+ "','" +arr[z]+ "','" +l8.Text+ "')";
                z++;
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = insertdata;
                obj.cmd.ExecuteNonQuery();
                //MessageBox.Show(s4);
                b1.Text = "1"; 
                o1.Visible = false;
                b1.Visible = false;
                p1.Visible = false;
                d1.BackColor = Color.Green;
                d1.Visible = false;
                //string s6 = "delete * from Tasks where srno = '" + s3 + "'";
                //SqlCommand cmd6 = new SqlCommand(s6, obj.con);
                //cmd6.ExecuteScalar();
                obj.con.Close();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 obj = new Class1();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                 
                string s2 = "select emp_post from Tasks where srno = '" + arr[z] + "'";
                SqlCommand cmd1 = new SqlCommand(s2, obj.con);
                String s4 = (String)cmd1.ExecuteScalar();
                string insertdata = "insert into Task values('" + b2.Text + "','" + p2.Text + "','" + s4 + "','" + "complete" + "','" + arr[z] + "','" + l8.Text + "')";
                z++;
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = insertdata;
                obj.cmd.ExecuteNonQuery();
                b2.Text = "2";
                o2.Visible = false;
                b2.Visible = false;
                p2.Visible = false;
                d2.Visible = false;
                obj.con.Close();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            d2.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 obj = new Class1();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                 
                string s2 = "select emp_post from Tasks where srno = '" + arr[z] + "'";
                SqlCommand cmd1 = new SqlCommand(s2, obj.con);
                String s4 = (String)cmd1.ExecuteScalar();
                string insertdata = "insert into Task values('" + b3.Text + "','" + p3.Text + "','" + s4 + "','" + "complete" + "','" + arr[z] + "','" + l8.Text + "')";
                z++;
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = insertdata;
                obj.cmd.ExecuteNonQuery();
                b3.Text = "3";
                o3.Visible = false;
                b3.Visible = false;
                p3.Visible = false;
                d3.Visible = false;
                obj.con.Close();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            d3.BackColor = Color.Green;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Class1 obj = new Class1();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                 
                string s2 = "select emp_post from Tasks where srno = '" + arr[z] + "'";
                SqlCommand cmd1 = new SqlCommand(s2, obj.con);
                String s4 = (String)cmd1.ExecuteScalar();
                string insertdata = "insert into Task values('" + b4.Text + "','" + p4.Text + "','" + s4 + "','" + "complete" + "','" + arr[z] + "','" + l8.Text + "')";
                z++;
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = insertdata;
                obj.cmd.ExecuteNonQuery();
                b4.Text = "4";
                o4.Visible = false;
                b4.Visible = false;
                p4.Visible = false;
                d4.Visible = false;
                obj.con.Close();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            d4.BackColor = Color.Green;
        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int s = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s += 1; 
            pb1.Value = s;
            pb1.Text = "Loading ..." + s + "%";
            if(pb1.Value == 100)
            {
                pb1.Value = 0;
                timer1.Stop();
                pb1.Hide();
                r1.Visible = true;
                r2.Visible = true;
                r3.Visible = true;
                r4.Visible = true;
                r5.Visible = true;
            }
        }

        private void b1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void r1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
