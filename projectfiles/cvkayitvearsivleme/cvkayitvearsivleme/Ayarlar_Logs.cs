using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Ayarlar_Logs : UserControl
    {
        Database database = new Database();
        public Ayarlar_Logs()
        {
            InitializeComponent();
        }

        private void Ayarlar_Logs_Load(object sender, EventArgs e)
        {
            database.verileriGoster(dataGridView1, "SELECT ISLEMADI AS [İŞLEM ADI], ISLEMTARIHI AS [İŞLEM TARİHİ] FROM LOGS");
            dataGridView1.AutoResizeColumns();
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Tüm log kayıtlarını silmek istediğinize emin misiniz? Bu işlem geri alınamaz!", "Silme İşlemi", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    database.connection.Open();
                    SqlCommand command = new SqlCommand("TRUNCATE TABLE LOGS", database.connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show($"İşlem başarılı. Tüm kayıtlar silindi!");
                    database.verileriGoster(dataGridView1, "SELECT ISLEMADI AS [İŞLEM ADI], ISLEMTARIHI AS [İŞLEM TARİHİ] FROM LOGS");
                    dataGridView1.AutoResizeColumns();




                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { database.connection.Close(); }
        }
    }
}
