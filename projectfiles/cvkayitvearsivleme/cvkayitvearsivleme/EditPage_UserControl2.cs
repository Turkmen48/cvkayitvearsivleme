using System;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class EditPage_UserControl2 : UserControl
    {
        public EditPage_UserControl2()
        {
            InitializeComponent();
        }

        private void EditPage_UserControl2_Load(object sender, EventArgs e)
        {

        }


        public string Telefon { get { return telefon.Text; } set { telefon.Text = value; } }
        public string Eposta { get { return eposta.Text; } set { eposta.Text = value; } }
        public string Askerlik { get { return askerlik.Text; } set { askerlik.Text = value; } }
        public string Egitim { get { return egitim.Text; } set { egitim.Text = value; } }
        public string IsTecrubesi { get { return isTecrubesi.Text; } set { isTecrubesi.Text = value; } }
        public string CalismDurumu { get { return calismaDurumu.Text; } set { calismaDurumu.Text = value; } }
        public string Adres { get { return adres.Text; } set { adres.Text = value; } }
    }
}
