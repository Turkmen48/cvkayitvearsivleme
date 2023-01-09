using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class RandevuVer_RandevuKayıt_Uc : UserControl
    {
        public string selectedTC { get { return textBox_Tc.Text; } set { textBox_Tc.Text = value; } } // dışardan gelen text değeri bizim valuemiz

        public RandevuVer_RandevuKayıt_Uc()
        {
            InitializeComponent();



        }
        Database database = new Database();



        private void randevuVer_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show($"{selectedTC} TC numaralı kişiye {tarih.Text} ve {saat.Text} saatinde randevu verilsin mi?", "Randevu Ver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    //if TC is exist in database then update else add
                    if (database.isExist("SELECT * FROM RANDEVULAR WHERE TC = @TC", new SqlParameter("@TC", selectedTC)))
                    {
                        database.connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE RANDEVULAR SET RANDEVUTARIHI = @randevutarihi, RANDEVUSAATI = @randevusaati, NOTS=@nots WHERE TC = @tc", database.connection);
                        command.Parameters.Add("@tc", selectedTC);
                        command.Parameters.Add("@randevutarihi", tarih.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.Add("@randevusaati", saat.Text);
                        command.Parameters.Add("@nots", nots.Text);
                        command.ExecuteNonQuery();
                        database.connection.Close();
                        MessageBox.Show("Randevu Güncellendi");
                    }
                    else
                    {
                        database.connection.Open();
                        SqlCommand command = new SqlCommand("insert into RANDEVULAR (TC,RANDEVUTARIHI,RANDEVUSAATI,NOTS) values (@tc,@randevutarihi,@randevusaati,@nots)", database.connection);
                        command.Parameters.Add("@tc", selectedTC);
                        command.Parameters.Add("@randevutarihi", tarih.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.Add("@randevusaati", saat.Text);
                        command.Parameters.Add("@nots", nots.Text);
                        command.ExecuteNonQuery();

                        database.connection.Close();
                        MessageBox.Show("Randevu verildi");

                    }


                }
                else
                {
                    MessageBox.Show("Randevu verilmedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { database.connection.Close(); }
        }

        private void RandevuVer_RandevuKayıt_Uc_Load(object sender, System.EventArgs e)
        {

            string st = DateTime.Now.ToString("HH:mm");
            saat.EditValue = st;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
