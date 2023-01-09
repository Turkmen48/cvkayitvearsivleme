using System.Collections.Generic;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Form_RandevuVer : Form
    {
        public Form_RandevuVer()
        {
            InitializeComponent();

        }
        Database database = new Database();

        int index = 0;
        List<UserControl> panels = new List<UserControl>();
        RandevuVer_CvGetirUc userControlAra = new RandevuVer_CvGetirUc(); //uc
        RandevuVer_RandevuKayıt_Uc userControlKayit = new RandevuVer_RandevuKayıt_Uc(); //uc



        private void Form_RandevuVer_Load(object sender, System.EventArgs e)
        {
            panels.Add(userControlAra);
            panels.Add(userControlKayit);

            panel1.Controls.Add(panels[1]);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            index = 0;
            panel1.Controls.Clear();
            panel1.Controls.Add(panels[index]);
        }

        private void randevuKayit_Click(object sender, System.EventArgs e)
        {
            index = 1;
            panel1.Controls.Clear();
            panel1.Controls.Add(panels[index]);
            if (!string.IsNullOrEmpty(userControlAra.selectedTc))
            {
                userControlKayit.selectedTC = userControlAra.selectedTc;
            }
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(userControlAra.selectedTc);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
