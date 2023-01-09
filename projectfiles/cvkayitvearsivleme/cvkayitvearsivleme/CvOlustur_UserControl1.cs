using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    public partial class CvOlustur_UserControl1 : UserControl

    {
        Database database = new Database();
        public CvOlustur_UserControl1()
        {
            InitializeComponent();
        }

        private void CvOlustur_UserControl1_Load(object sender, EventArgs e)
        {
            ///get dogumYerıId from database and set to dogumyerı text box
            database.connection.Open();
            DataTable dt = new DataTable();
            string Sql = "select * from DOGUMYERIID";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Sql, database.connection);
            sqlDataAdapter.Fill(dt);
            dogumYeri.ValueMember = "ID";
            dogumYeri.DisplayMember = "SEHIR_ADI";
            dogumYeri.DataSource = dt;
        }

        //get tc with tc textbox 
        public string Tc
        { ///tc kontrol get set
            get
            {
                if (!TcDogrulaV2(tc.Text))
                {

                    throw new Exception("Tc kimlik no hatalı");
                }
                else return tc.Text;
            }
            set { tc.Text = value; }

        }


        public string Ad { get { return ad.Text; } set { ad.Text = value; } }
        public string Soyad { get { return soyad.Text; } set { soyad.Text = value; } }
        public string Cinsiyet { get { return cinsiyet.Text; } set { cinsiyet.Text = value; } }
        public DateTime DogumTarihi { get { return dogumTarihi.Value; } set { dogumTarihi.Value = value; } }
        public string DogumYeriId { get { return dogumYeri.SelectedValue.ToString(); } set { dogumYeri.SelectedValue = value; } }
        public string MedeniHal { get { return medeniHal.Text; } set { medeniHal.Text = value; } }
        public static bool TcDogrulaV2(string tcKimlikNo)
        {
            bool returnvalue = false;
            if (tcKimlikNo.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;
                TcNo = Int64.Parse(tcKimlikNo);
                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;
                C1 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C2 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C3 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C4 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C5 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C6 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C7 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C8 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C9 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);
                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }

            return returnvalue;
        }






    }


}

