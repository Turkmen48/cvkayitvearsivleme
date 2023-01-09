using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    internal class Database
    {
        // public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4JD2R8F\\;Initial Catalog=cvkayitvearsivleme;Integrated Security=True");

        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\cvkayitvearsivleme.mdf;Integrated Security=True");
        public void verileriGoster(DataGridView dataGridView1, string sqlString)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlString, connection); //data adapter sqlden veri çekmeye güncellemeye yarar
                DataSet dataSet = new DataSet(); //tablo doldurmaya yarar
                dataAdapter.Fill(dataSet); // dataadapter ve dataset ilişkilendirildi
                dataGridView1.DataSource = dataSet.Tables[0]; //datasetteki tablolardan 0. indexten itibaren doldur 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public int get_Appointments()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select Count(*) From RANDEVULAR Where RANDEVUTARIHI= CAST(GETDATE() as Date)", connection); //data adapter sqlden veri çekmeye güncellemeye yarar
                int values = (int)command.ExecuteScalar();
                return values;
            }


            catch (Exception ex) { MessageBox.Show(ex.Message); return 0; }
            finally { connection.Close(); }
        }

        public bool login(string username, string password)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"EXEC LOGINTO '{username}', '{password}' ", connection);
                SqlDataReader reader = command.ExecuteReader();
                bool result = reader.HasRows;
                return result;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
            finally { connection.Close(); }
        }
        public bool check_Email(string email)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"EXEC CHECKEMAIL '{email}' ", connection);
                SqlDataReader reader = command.ExecuteReader();
                bool result = reader.HasRows;
                return result;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
            finally { connection.Close(); }
        }


        public bool isExist(string sqlString, SqlParameter sqlParameter) //databasede tc var mı yok mu
        {
            SqlCommand command = new SqlCommand(sqlString, connection);
            command.Parameters.Add(sqlParameter);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool result = reader.HasRows;
            connection.Close();
            return result;
        }

        public void editUser(string sqlString, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand(sqlString, connection);
            command.Parameters.AddRange(sqlParameters);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void oneLineRun(string commands)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commands, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { connection.Close(); }
        }


    }
}
