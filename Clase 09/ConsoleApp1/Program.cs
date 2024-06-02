using System.Data.SqlClient;


namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //En SQLServer para la coneccion es Server=. ---> con un . alcanza
            string connectionString = "Server=. ; Database=SistemaGestion1 ; Trusted_Connection=true";
            //SQL Express
            //SqlConnection connectionString = @"Server=localhost\SQLEXPRESS ; Database=SistemaGestion2 ; Trusted_Connection=true";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Ususario";
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var dato = dataReader.GetString(1);
                                Console.WriteLine(dato);
                            }
                        }

                    }                 
                                        
                }
                connection.Close();

                //DataAdapter
                //SqlAdapter adapter = new SqlAdapter(query, connection);
                //connection.Open();
                //DataSet resultados = new DataSet();
                //adapter.Fill(resultado);
                //connection.Close();
            }
        }
    }
}