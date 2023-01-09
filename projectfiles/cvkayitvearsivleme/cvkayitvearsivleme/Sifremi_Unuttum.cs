using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Sifremi_Unuttum : Form
    {
        int index = 0;
        List<UserControl> panels = new List<UserControl>();
        Database database = new Database();

        SifremiUnuttum_Giris userControl1 = new SifremiUnuttum_Giris();
        SifremiUnuttum_Kurtar userControl2 = new SifremiUnuttum_Kurtar();
        public Sifremi_Unuttum()
        {
            InitializeComponent();
        }

        private void Sifremi_Unuttum_Load(object sender, EventArgs e)
        {
            panels.Add(userControl1);
            panels.Add(userControl2);

            panel1.Controls.Add(panels[index]);
        }



        private void login_button_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (database.check_Email(userControl1.email.Text) == true)
                {
                    index = 1; ///2. uc
                    panel1.Controls.Clear();
                    panel1.Controls.Add(panels[index]);
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı yok!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
