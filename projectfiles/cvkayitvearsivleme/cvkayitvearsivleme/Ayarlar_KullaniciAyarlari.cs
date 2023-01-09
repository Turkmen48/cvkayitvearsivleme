using System;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Ayarlar_KullaniciAyarlari : UserControl
    {
        Database database = new Database();
        public Ayarlar_KullaniciAyarlari()
        {
            InitializeComponent();
        }

        private void Ayarlar_KullaniciAyarlari_Load(object sender, EventArgs e)
        {
            database.verileriGoster(dataGridView1, "select * from KULLANICILAR");

        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Kullanıcı giriş bilgilerini değiştirmek istediğinize emin misiniz? Bu işlemi yaparsanız bir sonraki girişinizde yeni giriş bilgilerinizi kullanmanız gerekecek!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    string username = textBox1.Text;
                    string password = textBox2.Text;
                    string email = textBox3.Text;
                    string sqlString = "UPDATE KULLANICILAR SET";
                    if (!String.IsNullOrEmpty(username))
                    {
                        sqlString += $" [USERNAME]='{username}' ,";
                    }
                    if (!String.IsNullOrEmpty(password))
                    {
                        sqlString += $" [PASSWORD]='{password}' ,";
                    }
                    if (!String.IsNullOrEmpty(email))
                    {

                        sqlString += $" [EMAIL]='{email}' ,";

                    }

                    sqlString = sqlString.Remove(sqlString.Length - 1, 1);
                    sqlString += " WHERE ID=1";

                    Console.WriteLine(sqlString);

                    database.oneLineRun(sqlString);
                    MessageBox.Show("Kullanıcı giriş bilgileri değiştirildi!");
                    database.verileriGoster(dataGridView1, "select * from KULLANICILAR");

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
