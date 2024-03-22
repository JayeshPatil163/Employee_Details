using System.Data.SqlClient;
using Twilio.TwiML.Voice;

namespace Employee_Details
{
    public partial class Form1 : Form
    {
        static void main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Application.Run(form1);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Visible = false;
            frm3.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Visible = false;
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                           
        }
    }
}