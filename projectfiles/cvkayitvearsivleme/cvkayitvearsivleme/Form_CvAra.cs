using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Form_CvAra : Form
    {
        public Form_CvAra()
        {
            InitializeComponent();
        }

        ///connection string
        Database database = new Database();

        string selectedTC = "";
        string ad, soyad, cinsiyet, dogumTarihi, dogumYeriId, medeniHal, telefon, eposta, askerlik, egitim, isTecrubesi, calismaDurumu, adres;

        private void refresh_Click(object sender, EventArgs e)
        {
            database.verileriGoster(dataGridView1, "SELECT p.TC,p.AD,p.SOYAD,p.TELEFON,p.EPOSTA,p.DOGUMTARIHI,p.EGITIM,d.SEHIR_ADI,p.ADRES,p.ISTECRUBESI,p.CINSIYET,p.ASKERLİK,p.MEDENIHAL,p.CALISIYORMU FROM BILGILER p, DOGUMYERIID d  WHERE p.DOGUMYERIID= d.ID");



        }

        private void decline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_CvAra_Load(object sender, EventArgs e)
        {

            database.verileriGoster(dataGridView1, "SELECT p.TC,p.AD,p.SOYAD,p.TELEFON,p.EPOSTA,p.DOGUMTARIHI,p.EGITIM,d.SEHIR_ADI,p.ADRES,p.ISTECRUBESI,p.CINSIYET,p.ASKERLİK,p.MEDENIHAL,p.CALISIYORMU FROM BILGILER p, DOGUMYERIID d  WHERE p.DOGUMYERIID= d.ID");


        }

        private void accept_Click(object sender, EventArgs e)
        {
            ///search in databese verileriGoster("SELECT * FROM BILGILER WHERE AD LIKE'" + textBox_Ad.Text + "%'");
            string sqlString = "SELECT p.TC,p.AD,p.SOYAD,p.TELEFON,p.EPOSTA,p.DOGUMTARIHI,p.EGITIM,d.SEHIR_ADI,p.ADRES,p.ISTECRUBESI,p.CINSIYET,p.ASKERLİK,p.MEDENIHAL,p.CALISIYORMU FROM BILGILER p, DOGUMYERIID d  WHERE p.DOGUMYERIID= d.ID AND";
            int control = 0;

            if (textBox_Tc.Text != "")
            {
                control++;
                sqlString += " TC LIKE '" + textBox_Tc.Text + "%' AND";
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
            if (comboBox_Cinsiyet.Text != "")
            {

                control++;
                sqlString += " CINSIYET LIKE '" + comboBox_Cinsiyet.Text + "%' AND";
            }

            if (control == 0) MessageBox.Show("Lütfen en az bir değer giriniz.");
            sqlString = sqlString.Remove(sqlString.Length - 3, 3);
            database.verileriGoster(dataGridView1, sqlString);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            selectedTC = dataGridView1.Rows[e.RowIndex].Cells["TC"].FormattedValue.ToString();
            ad = dataGridView1.Rows[e.RowIndex].Cells["AD"].FormattedValue.ToString();
            soyad = dataGridView1.Rows[e.RowIndex].Cells["SOYAD"].FormattedValue.ToString();
            telefon = dataGridView1.Rows[e.RowIndex].Cells["TELEFON"].FormattedValue.ToString();
            eposta = dataGridView1.Rows[e.RowIndex].Cells["EPOSTA"].FormattedValue.ToString();
            dogumTarihi = dataGridView1.Rows[e.RowIndex].Cells["DOGUMTARIHI"].FormattedValue.ToString();
            egitim = dataGridView1.Rows[e.RowIndex].Cells["EGITIM"].FormattedValue.ToString();
            dogumYeriId = getValue(dataGridView1.Rows[e.RowIndex].Cells["SEHIR_ADI"].FormattedValue.ToString());
            adres = dataGridView1.Rows[e.RowIndex].Cells["ADRES"].FormattedValue.ToString();
            isTecrubesi = dataGridView1.Rows[e.RowIndex].Cells["ISTECRUBESI"].FormattedValue.ToString();
            cinsiyet = dataGridView1.Rows[e.RowIndex].Cells["CINSIYET"].FormattedValue.ToString();
            askerlik = dataGridView1.Rows[e.RowIndex].Cells["ASKERLİK"].FormattedValue.ToString();
            medeniHal = dataGridView1.Rows[e.RowIndex].Cells["MEDENIHAL"].FormattedValue.ToString();
            calismaDurumu = dataGridView1.Rows[e.RowIndex].Cells["CALISIYORMU"].FormattedValue.ToString();
            MessageBox.Show($"Seçtiğiniz Kişinin Tc Numarası: {selectedTC} Adı: {ad} Soyadı: {soyad}");


        }
        private string getValue(string sehirAdi)
        {
            try
            {
                database.connection.Open();
                string sql = $"Select * from DOGUMYERIID WHERE SEHIR_ADI='{sehirAdi}'";
                SqlCommand sqlCommand = new SqlCommand(sql, database.connection);

                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    return read["ID"].ToString();
                }
                return "Hata.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                return "Hata";
            }
            finally
            {
                database.connection.Close();
            }
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            ///delete from sql
            try
            {
                if (selectedTC != "")
                {
                    DialogResult dialogResult = MessageBox.Show($"Seçili Tc {selectedTC},\nSilmek istediğinize emin misiniz? Bu işlem geri alınamaz!", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM CVTCLISTESI WHERE TC = '" + selectedTC + "'", database.connection);
                        command.ExecuteNonQuery();
                        database.connection.Close();
                        MessageBox.Show("Silme işlemi başarılı.");
                        database.verileriGoster(dataGridView1, "SELECT p.TC,p.AD,p.SOYAD,p.TELEFON,p.EPOSTA,p.DOGUMTARIHI,p.EGITIM,d.SEHIR_ADI,p.ADRES,p.ISTECRUBESI,p.CINSIYET,p.ASKERLİK,p.MEDENIHAL,p.CALISIYORMU FROM BILGILER p, DOGUMYERIID d  WHERE p.DOGUMYERIID= d.ID");
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
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {

            try
            {
                if (selectedTC != "")
                {



                    EditPage form_EditPage = new EditPage(tc: selectedTC, ad: ad, soyad: soyad, cinsiyet: cinsiyet, dogumTarihi: dogumTarihi, dogumYeriId: dogumYeriId, medeniHal: medeniHal, telefon: telefon, eposta: eposta, askerlik: askerlik, egitim: egitim, isTecrubesi: isTecrubesi, calismaDurumu: calismaDurumu, adres: adres);
                    if (Application.OpenForms["EditPage"] == null)
                    {
                        form_EditPage.Show(); //open form
                    }
                }
                else
                {
                    throw new Exception("Lütfen düzenlemek istediğiniz kişiye çift tıklayınız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
    }
}

