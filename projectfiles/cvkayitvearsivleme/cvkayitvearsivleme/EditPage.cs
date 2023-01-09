using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class EditPage : Form
    {
        int index = 0;
        List<UserControl> panels = new List<UserControl>();
        Database database = new Database();
        Services services = new Services();
        string selectedTc = "";

        EditPage_UserControl1 userControl1 = new EditPage_UserControl1();
        EditPage_UserControl2 userControl2 = new EditPage_UserControl2();



        public EditPage(string tc, string ad, string soyad, string cinsiyet, string dogumTarihi, string dogumYeriId, string medeniHal, string telefon, string eposta, string askerlik, string egitim, string isTecrubesi, string calismaDurumu, string adres)
        {
            InitializeComponent();
            userControl1.Tc = tc;
            selectedTc = tc;
            userControl1.Ad = ad;
            userControl1.Soyad = soyad;
            userControl1.Cinsiyet = cinsiyet;
            userControl1.DogumTarihi = DateTime.Parse(dogumTarihi);

            userControl1.DogumYeriId = dogumYeriId;
            userControl1.setDogumYeri(dogumYeriId);
            userControl1.MedeniHal = medeniHal;
            userControl2.Telefon = telefon;
            userControl2.Eposta = eposta;
            userControl2.Askerlik = askerlik;
            userControl2.Egitim = egitim;
            userControl2.IsTecrubesi = isTecrubesi;
            userControl2.CalismDurumu = calismaDurumu;
            userControl2.Adres = adres;




        }

        private void EditPage_Load(object sender, EventArgs e)
        {


            panels.Add(userControl1);
            panels.Add(userControl2);

            panel1.Controls.Add(panels[index]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 0; ///1. uc
            panel1.Controls.Clear();
            panel1.Controls.Add(panels[index]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 1; ///2. uc
            panel1.Controls.Clear();
            panel1.Controls.Add(panels[index]);
        }

        private void decline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {


            try
            {
                database.connection.Open();
                string sql = "UPDATE BILGILER SET  AD=@ad, SOYAD=@soyad, CINSIYET=@cinsiyet, DOGUMTARIHI=@dogumTarihi, DOGUMYERIID=@dogumYeriId, MEDENIHAL=@medeniHal, TELEFON=@telefon, EPOSTA=@eposta, ASKERLİK=@askerlik, EGITIM=@egitim, ISTECRUBESI=@isTecrubesi, CALISIYORMU=@calismaDurumu, ADRES=@adres WHERE TC=@tc";
                string changeTc = "UPDATE CVTCLISTESI SET TC=@tcChange WHERE TC=@tc";

                SqlCommand sqlCommand = new SqlCommand(sql, database.connection);
                SqlCommand sqlCommandChangeTc = new SqlCommand(changeTc, database.connection);
                sqlCommandChangeTc.Parameters.AddWithValue("@tcChange", userControl1.Tc);
                sqlCommandChangeTc.Parameters.AddWithValue("@tc", selectedTc);


                sqlCommand.Parameters.AddWithValue("@tc", selectedTc);

                sqlCommand.Parameters.AddWithValue("@ad", userControl1.Ad);
                sqlCommand.Parameters.AddWithValue("@soyad", userControl1.Soyad);
                sqlCommand.Parameters.AddWithValue("@cinsiyet", userControl1.Cinsiyet);
                sqlCommand.Parameters.AddWithValue("@dogumTarihi", userControl1.DogumTarihi);
                sqlCommand.Parameters.AddWithValue("@dogumYeriId", userControl1.DogumYeriId);
                sqlCommand.Parameters.AddWithValue("@medeniHal", userControl1.MedeniHal);
                sqlCommand.Parameters.AddWithValue("@telefon", userControl2.Telefon);
                sqlCommand.Parameters.AddWithValue("@eposta", userControl2.Eposta);
                sqlCommand.Parameters.AddWithValue("@askerlik", userControl2.Askerlik);
                sqlCommand.Parameters.AddWithValue("@egitim", userControl2.Egitim);
                sqlCommand.Parameters.AddWithValue("@isTecrubesi", userControl2.IsTecrubesi);
                sqlCommand.Parameters.AddWithValue("@calismaDurumu", userControl2.CalismDurumu);
                sqlCommand.Parameters.AddWithValue("@adres", userControl2.Adres);
                sqlCommand.ExecuteNonQuery();
                sqlCommandChangeTc.ExecuteNonQuery();
                MessageBox.Show("Düzenleme İşlemi Başarıyla Yapıldı! ");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
            finally
            {
                database.connection.Close();
            }

        }
    }
}
