using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Form_Ayarlar : Form
    {
        int index = 0;
        List<UserControl> panels = new List<UserControl>();

        public Form_Ayarlar()
        {
            InitializeComponent();
        }

        private void Form_Ayarlar_Load(object sender, EventArgs e)
        {
            panels.Add(new Ayarlar_KullaniciAyarlari());
            panels.Add(new Ayarlar_Logs());
            panel1.Controls.Add(panels[index]);
        }

        private void kullaniciAyarlari_Click(object sender, EventArgs e)
        {
            index = 0; ///1. uc
            panel1.Controls.Clear();
            panel1.Controls.Add(panels[index]);
        }

        private void sabitleriDuzenle_Click(object sender, EventArgs e)
        {
            index = 1; ///1. uc
            panel1.Controls.Clear();
            panel1.Controls.Add(panels[index]);
        }
    }
}
