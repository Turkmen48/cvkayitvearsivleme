using System;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class RandevuVer_CvGetirUc : UserControl
    {
        public RandevuVer_CvGetirUc()
        {
            InitializeComponent();
            database.verileriGoster(dataGridView1, "SELECT p.TC,p.AD,p.SOYAD,p.TELEFON,p.EPOSTA,p.DOGUMTARIHI,p.EGITIM,d.SEHIR_ADI,p.ADRES,p.ISTECRUBESI,p.CINSIYET,p.ASKERLİK,p.MEDENIHAL,p.CALISIYORMU FROM BILGILER p, DOGUMYERIID d  WHERE p.DOGUMYERIID= d.ID");

        }
        Database database = new Database();
        string seciliTc = "";
        private void accept_Click(object sender, EventArgs e)
        {
            ///search in databese verileriGoster("SELECT * FROM BILGILER WHERE AD LIKE'" + textBox_Ad.Text + "%'");
            string sqlString = "SELECT p.TC,p.AD,p.SOYAD,p.TELEFON,p.EPOSTA,p.DOGUMTARIHI,p.EGITIM,d.SEHIR_ADI,p.ADRES,p.CINSIYET,p.ASKERLİK,p.MEDENIHAL,p.CALISIYORMU FROM BILGILER p, DOGUMYERIID d  WHERE p.DOGUMYERIID= d.ID AND";
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
            string seciliTcTemp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult sonuc = MessageBox.Show($"{seciliTcTemp} TC numaralı kişiye randevu vermek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {

                //send secili tc to form

                seciliTc = seciliTcTemp;
                MessageBox.Show($"{seciliTc} TC numaralı kişi başarıyla seçildi. Lütfen Randevu Kayıt butonuna basınız!");











            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        public string selectedTc
        {
            get { return seciliTc; }
            set { seciliTc = value; }
        }

        private void RandevuVer_CvGetirUc_Load(object sender, EventArgs e)
        {

        }
    }
}
