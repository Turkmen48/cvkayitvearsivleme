using System;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class SifremiUnuttum_Kurtar : UserControl
    {
        Database database = new Database();
        public SifremiUnuttum_Kurtar()
        {
            InitializeComponent();
        }

        private void recovery_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Kullanıcı giriş bilgilerini değiştirmek istediğinize emin misiniz? Bu işlemi yaparsanız bir sonraki girişinizde yeni giriş bilgilerinizi kullanmanız gerekecek!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    string username = textBox2.Text;
                    string password = textBox1.Text;

                    database.oneLineRun($"UPDATE KULLANICILAR SET USERNAME='{username}', PASSWORD='{password}' WHERE ID=1");

                    MessageBox.Show("Kullanıcı giriş bilgileri değiştirildi!");





                }
                else
                {
                    MessageBox.Show("Kullanıcı giriş bilgileri değiştirilmedi!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.connection.Close();

            }
        }
    }
}
