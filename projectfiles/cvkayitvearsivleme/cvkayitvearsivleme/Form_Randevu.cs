using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Form_Randevu : Form
    {


        public Form_Randevu()
        {
            InitializeComponent();
        }
        Database database = new Database();
        string selectedTC = "";

        private void decline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            database.verileriGoster(dataGridView1, "Select RANDEVULAR.TC, AD, SOYAD, TELEFON, EPOSTA, ADRES, EGITIM, RANDEVUTARIHI, RANDEVUSAATI, NOTS from BILGILER JOIN RANDEVULAR ON RANDEVULAR.TC=BILGILER.TC");

        }

        private void Form_Randevu_Load(object sender, EventArgs e)
        {
            database.verileriGoster(dataGridView1, "Select RANDEVULAR.TC, AD, SOYAD, TELEFON, EPOSTA,ADRES, EGITIM, RANDEVUTARIHI, RANDEVUSAATI, NOTS from BILGILER JOIN RANDEVULAR ON RANDEVULAR.TC=BILGILER.TC");

        }

        private void accept_Click(object sender, EventArgs e)
        {
            try
            {
                ///search in databese verileriGoster("SELECT * FROM BILGILER WHERE AD LIKE'" + textBox_Ad.Text + "%'");
                string sqlString = "Select RANDEVULAR.TC, AD, SOYAD, TELEFON, EPOSTA,ADRES, EGITIM, RANDEVUTARIHI, RANDEVUSAATI, NOTS from BILGILER JOIN RANDEVULAR ON RANDEVULAR.TC=BILGILER.TC WHERE";
                int control = 0;

                if (textBox_Tc.Text != "")
                {
                    control++;
                    sqlString += " RANDEVULAR.TC LIKE '" + textBox_Tc.Text + "%' AND";
                }
                if (textBox_Ad.Text != "")
                {
                    control++;
                    sqlString += " AD LIKE '" + textBox_Ad.Text + "%' AND";
                }
                if (textBox_Soyad.Text != "")
                {
                    control++;
                    sqlString += " SOYAD LIKE '" + textBox_Soyad.Text + "%' AND";
                }
                if (textBox_Tel.Text != "")
                {
                    control++;
                    sqlString += " TELEFON LIKE '" + textBox_Tel.Text + "%' AND";
                }
                if (textBox_Eposta.Text != "")
                {
                    control++;
                    sqlString += " EPOSTA LIKE '" + textBox_Eposta.Text + "%' AND";
                }


                if (control == 0) MessageBox.Show("Lütfen en az bir değer giriniz.");
                sqlString = sqlString.Remove(sqlString.Length - 3, 3); //AND SİLİNİYOR
                database.verileriGoster(dataGridView1, sqlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { database.connection.Close(); }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            ///delete from sql
            try
            {
                if (selectedTC != "")
                {
                    DialogResult dialogResult = MessageBox.Show($"Seçili Tc {selectedTC},\n kişinin randevusunu silmek istediğinize emin misiniz? Bu işlem geri alınamaz!", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM RANDEVULAR WHERE TC = '" + selectedTC + "'", database.connection);
                        command.ExecuteNonQuery();
                        database.connection.Close();
                        MessageBox.Show("Silme işlemi başarılı.");
                        database.verileriGoster(dataGridView1, "Select RANDEVULAR.TC, AD, SOYAD, TELEFON, EPOSTA,ADRES, EGITIM, RANDEVUTARIHI, RANDEVUSAATI, NOTS from BILGILER JOIN RANDEVULAR ON RANDEVULAR.TC=BILGILER.TC");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Silme işlemi iptal edildi.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kişiyi seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
            finally { database.connection.Close(); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            selectedTC = dataGridView1.Rows[e.RowIndex].Cells["TC"].FormattedValue.ToString();

        }


    }
}
