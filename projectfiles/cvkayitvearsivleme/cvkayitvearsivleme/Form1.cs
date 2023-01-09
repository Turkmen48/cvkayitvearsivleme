using System;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
            label5.Text = database.get_Appointments().ToString();

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            datelabel.Text = DateTime.Now.ToShortDateString();
            timelabel.Text = DateTime.Now.ToLongTimeString();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form_CvOlustur form_CvOlustur = new Form_CvOlustur();

            //If the form has been opened, do not open it again.
            if (Application.OpenForms["Form_CvOlustur"] == null)
            {
                form_CvOlustur.Show(); //open form
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_CvAra form_CvAra = new Form_CvAra();
            if (Application.OpenForms["Form_CvAra"] == null)
            {
                form_CvAra.Show(); //open form
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Ayarlar form_Ayarlar = new Form_Ayarlar();
            if (Application.OpenForms["Form_Ayarlar"] == null)
            {
                form_Ayarlar.Show(); //open form
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_RandevuVer form_RandevuVer = new Form_RandevuVer();
            if (Application.OpenForms["Form_RandevuVer"] == null)
            {
                form_RandevuVer.Show(); //open form
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_Randevu form_Randevu = new Form_Randevu();
            if (Application.OpenForms["Form_Randevu"] == null)
            {
                form_Randevu.Show(); //open form
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
