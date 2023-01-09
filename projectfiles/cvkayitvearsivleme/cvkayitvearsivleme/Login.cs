using System;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Login : Form
    {
        Database database = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox2.Text;
                string password = textBox1.Text;
                if (database.login(username, password) == true)
                {
                    MessageBox.Show("Giriş Başarılı!");

                    this.DialogResult = DialogResult.OK;
                }
                else if (database.login(username, password) == false)
                {
                    MessageBox.Show("Böyle bir kullanıcı yok!");
                }

                else
                {
                    MessageBox.Show("Bilinmeyen bir hata oluştu!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sifremi_Unuttum sifremi_Unuttum = new Sifremi_Unuttum();
            if (Application.OpenForms["Sifremi_Unuttum"] == null)
            {
                sifremi_Unuttum.Show(); //open form
            }
        }
    }
}
