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


namespace Employee_Details;
public partial class Form8 : Form
{
    Form9 f1;
     
    public Form8(Form9 frm1)
    {
        InitializeComponent();
        this.f1 = frm1;
         
    }

    private void Form8_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_Click(object sender, EventArgs e)
    {
        if (Yna.Text == "Your name")
        {
            Yna.Text = "";
            Yna.ForeColor = Color.Black;
        }
    }

    private void textBox2_Click(object sender, EventArgs e)
    {
        if (Emi.Text == "Admin ID")
        {
            Emi.Text = "";
            Emi.ForeColor = Color.Black;
        }
    }

    private void textBox3_Click(object sender, EventArgs e)
    {
        if (pass.Text == "Password")
        {
            pass.Text = "";
            pass.ForeColor = Color.Black;
        }
    }

    private void textBox4_Click(object sender, EventArgs e)
    {
        if (pass2.Text == "Re-enter password")
        {
            pass2.Text = "";
            pass2.ForeColor = Color.Black;
        }
    }

    private void textBox1_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(Yna.Text) || Yna.Text == "Your name")
        {
            e.Cancel = true;
            Yna.Focus();
            errorProvider1.SetError(Yna, "Please enter your name.");
        }
    }

    private void textBox2_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(Emi.Text) || Emi.Text == "Admin ID")
        {
            e.Cancel = true;
            Emi.Focus();
            errorProvider2.SetError(Emi, "Please enter your Admin ID.");
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

    private void textBox4_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(pass2.Text) || pass2.Text == "Re-enter password")
        {
            e.Cancel = true;
            pass2.Focus();
            errorProvider4.SetError(pass2, "Re-enter the password.");
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
               if (pass.Text == pass2.Text)
                {
                    if (f1.t1.Text != null && f1.t2.Text != null)
                    {
                        if (f1.t3.Text != null && f1.t4.Text != null)
                        {
                            if (f1.t5.Text != null && f1.t6.Text != null)
                            {
                                if (f1.t7.Text != null && f1.t8.Text != null)
                                {
                                    if (f1.t9.Text != null)
                                    {
                                if (pass.Text != null)
                                {
                                    try
                                    {
                                        Class1 obj = new Class1();
                                        obj.con.ConnectionString = obj.locate;
                                        obj.con.Open();
                                        string insertdata = "insert into admin_info values('" + f1.t1.Text + "' ,'" + f1.t2.Text + "', '" + f1.t3.Text + "' , '" + f1.t4.Text + "' , '" + f1.t5.Text + "' , '" + f1.t6.Text + "' , '" + f1.t7.Text + "' , '" + f1.t8.Text + "' , '" + f1.t9.Text + "' , '" + pass.Text + "' , '" + f1.s1 + "')";
                                        obj.cmd.Connection = obj.con;
                                        obj.cmd.CommandText = insertdata;
                                        obj.cmd.ExecuteNonQuery();
                                        obj.con.Close();
                                        if (Yna.Text is not "" and not "Your name")
                                        {
                                            if (Emi.Text != "" && Emi.Text != "Email id")
                                            {
                                                if (pass.Text != "" && pass.Text != "Password")
                                                {
                                                    if (pass2.Text != "" && pass2.Text != "Re-enter password")
                                                    {
                                                        MessageBox.Show("Account created Successfully!");
                                                        Form3 frm3 = new Form3();
                                                        this.Visible = false;
                                                        frm3.ShowDialog();
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

               else
               {
                    MessageBox.Show("Please re-enter correct password.");
               }
            
        /*if (textBox1.Text is not "" and not "Your name")
        {
            if (textBox2.Text != "" && textBox2.Text != "Email id")
            {
                if (pass.Text != "" && pass.Text != "Password")
                {
                    if (textBox4.Text != "" && textBox4.Text != "Re-enter password")
                    {
                        Form6 frm6 = new Form6();
                        this.Visible = false;
                        frm6.ShowDialog();
                    }
                }
            }
        }*/
    }

    private void label12_Click(object sender, EventArgs e)
    {
        Form9 frm9 = new Form9();
        this.Visible = false;
        frm9.ShowDialog();
    }
}
