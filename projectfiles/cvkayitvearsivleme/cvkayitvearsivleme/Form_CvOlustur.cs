using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class Form_CvOlustur : Form
    {
        /// Not: Bu formdaki accept ve decline dışındaki butonlar button 1 button 2 şeklinde default kalsın.

        int index = 0;
        List<UserControl> panels = new List<UserControl>();
        Database database = new Database();
        Services services = new Services();
        CvOlustur_UserControl1 userControl1 = new CvOlustur_UserControl1();
        CvOlustur_UserControl2 userControl2 = new CvOlustur_UserControl2();
        public Form_CvOlustur()
        {

            InitializeComponent();


        }

        private void Form_CvOlustur_Load(object sender, EventArgs e)
        {
            panels.Add(userControl1);
            panels.Add(userControl2);

            panel1.Controls.Add(panels[index]);

        }

        private void decline_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void accept_Click(object sender, EventArgs e)
        {
            ///add data
            try
            {
                string[] items = { userControl1.Tc, userControl1.Ad, userControl1.DogumYeriId, userControl1.MedeniHal, userControl1.Cinsiyet, userControl2.Telefon, userControl2.Eposta, userControl2.Askerlik, userControl2.Egitim, userControl2.CalismDurumu, userControl2.Adres, userControl2.IsTecrubesi };
                //add all datas to database

                database.connection.Open();
                SqlCommand commandPrimary = new SqlCommand("insert into CVTCLISTESI (TC) values (@tcprimary)", database.connection);

                SqlCommand command = new SqlCommand("insert into BILGILER (TC,AD,SOYAD,DOGUMYERIID,DOGUMTARIHI,MEDENIHAL,TELEFON,EPOSTA,ASKERLİK,EGITIM,CALISIYORMU,ADRES,CINSIYET,ISTECRUBESI) values (@tc,@ad,@soyad,@dogumyeriid,@dogumtarihi,@medenihal,@telefon,@eposta,@askerlik,@egitim,@calisiyormu,@adres,@cinsiyet,@istecrubesi)", database.connection);
                //if all text boxes are not null

                if (services.isNotNull(items))
                {
                    commandPrimary.Parameters.Add("@tcprimary", userControl1.Tc);

                    command.Parameters.Add("@tc", userControl1.Tc);
                    command.Parameters.Add("@ad", userControl1.Ad);
                    command.Parameters.Add("@soyad", userControl1.Soyad);
                    command.Parameters.Add("@dogumyeriid", userControl1.DogumYeriId);
                    command.Parameters.Add("@dogumtarihi", userControl1.DogumTarihi.ToString("yyyy-MM-dd"));
                    command.Parameters.Add("@medenihal", userControl1.MedeniHal);
                    command.Parameters.Add("@telefon", userControl2.Telefon);
                    command.Parameters.Add("@eposta", userControl2.Eposta);
                    command.Parameters.Add("@askerlik", userControl2.Askerlik);
                    command.Parameters.Add("@egitim", userControl2.Egitim);
                    command.Parameters.Add("@calisiyormu", userControl2.CalismDurumu);
                    command.Parameters.Add("@adres", userControl2.Adres);
                    command.Parameters.Add("@cinsiyet", userControl1.Cinsiyet);
                    command.Parameters.Add("@istecrubesi", userControl2.IsTecrubesi);
                    commandPrimary.ExecuteNonQuery();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz");
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate"))
                    MessageBox.Show("Bu TC kimlik numarası ile daha önce kayıt yapılmış!", ex.GetType().Name);
                else
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
                }
            }

            finally
            {
                database.connection.Close();
            }
        }
    }
}
