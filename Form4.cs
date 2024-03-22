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
     
    public partial class Form4 : Form
    {
        public string s1;   
        public Form4()
        {
            InitializeComponent();
                
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            s1 = "Female";
        }

         

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(this);
            /*if (fn.Text != null && em.Text !=null)
            {
                if (dt.Text != null && bg.Text != null)
                {
                    if (fw.Text != null && pe.Text != null)
                    {
                        if (ei.Text != null && jd.Text != null)
                        {
                            if (cn.Text != null && ecn.Text != null)
                            {
                                if (ra.Text != null)
                                {
                                    //try
                                    //{
                                    Class1 obj = new Class1();
                                    obj.con.ConnectionString = obj.locate;
                                    obj.con.Open();
                                    string insertdata = "insert into emp_info (Full name, Email id, Date of Birth, Blood group, Field of working, Post of employee, Employee ID, Joining date, Contact number, Emergency contact, Residential address, Password) values('" + fn.Text + "' ,'" + em.Text + "', '" + dt.Text + "' , '" + bg.Text + "' , '" + fw.Text + "' , '" + pe.Text + "' , '" + ei.Text + "' , '" + jd.Text + "' , '" + cn.Text + "' , '" + ecn.Text + "' , '" + ra.Text + "' , '" +frm5.pass.Text+ "')";
                                    obj.cmd.Connection = obj.con;
                                    obj.cmd.CommandText = insertdata;
                                    obj.cmd.ExecuteNonQuery();
                                    obj.con.Close();

                                    MessageBox.Show("Data inserted successfully!");

                                    
                                    // }
                                    // catch (Exception ex)
                                    // {
                                    //  MessageBox.Show(ex.Message);
                                    //}
                                }
                            }
                        }
                    }
                }
            }*/
            if (ei.Text.Length==10)
            {
                if (cn.Text.Length == 10)
                {
                    if (ecn.Text.Length == 10)
                    {
                        this.Visible = false;
                        frm5.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("Please enter valid emergency contact number (10 digit).");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid number. (10 digit).");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid Employee ID (10 digits)."); 
            }
        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Visible = false;
            frm2.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] category = new string[] { "jay" , "vir" , "sdgd"};
            //cmbCategory.DataSource = category;
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            //string[] category = new string[] { "jay", "vir", "sdgd" };
            //cmbCategory.DataSource = category;
        }

        private void jd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            s1 = "Male";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            s1 = "Other";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            s1 = "Male";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            s1 = "Female";
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            s1 = "Other";
        }
    }
}
