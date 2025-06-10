
using System;
using System.Data;
using System.Data.SqlClient;

namespace FormularzDanych
{
    public class DatabaseManager
    {
        private string connectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\FormularzDanych.mdf;Integrated Security=True";

        public void ZapiszDane(params string[] dane)
        {
            using (SqlConnection polaczenie = new SqlConnection(connectionString))
            {
                string zapytanie = "INSERT INTO Wnioski VALUES (" + string.Join(",", dane.Select((_, i) => "@p" + i)) + ")";

                SqlCommand polecenie = new SqlCommand(zapytanie, polaczenie);

                for (int i = 0; i < dane.Length; i++)
                {
                    polecenie.Parameters.AddWithValue("@p" + i, dane[i]);
                }

                try
                {
                    polaczenie.Open();
                    polecenie.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }

        public DataTable WczytajDane()
        {
            DataTable tabela = new DataTable();
            using (SqlConnection polaczenie = new SqlConnection(connectionString))
            {
                string zapytanie = "SELECT * FROM Wnioski";
                SqlCommand polecenie = new SqlCommand(zapytanie, polaczenie);
                try
                {
                    polaczenie.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(polecenie);
                    adapter.Fill(tabela);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Błąd: " + ex.Message);
                }
            }
            return tabela;
        }
    }
}
