using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details;
public partial class Form9 : Form
{
    public string s1;
     
    public Form9()
    {
        InitializeComponent();
         
    }

    private void Form9_Load(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        s1 = "Male";
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        s1 = "Female";
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
        s1 = "other";
    }
    private void button1_Click(object sender, EventArgs e)
    {
        if (t6.Text.Length == 5)
        {
            if (t7.Text.Length == 10)
            {
                if (t8.Text.Length == 10)
                {
                    Form8 frm8 = new Form8(this);
                    this.Visible = false;
                    frm8.ShowDialog();
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
            MessageBox.Show("Please enter valid Admin ID (5 digits)");
        }
    }

    private void label12_Click(object sender, EventArgs e)
    {
        Form3 frm3 = new Form3();
        this.Visible = false;
        frm3.ShowDialog();
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
