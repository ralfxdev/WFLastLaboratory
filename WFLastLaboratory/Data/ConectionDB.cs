using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFLastLaboratory.Data
{
    internal class ConectionDB
    {
        private string connectionString = "Server=localhost;Database=db_university;Uid=root;Pwd=282001";

        public bool TestConnection()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try { conn.Open(); return true; } catch { return false; }
            }
        }

        public List<Models.Console> GetConsoles()
        {
            List<Models.Console> consoles = new List<Models.Console>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM catalogo_consolas";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idConsola = reader.GetInt32(0);
                    string nombreConsola = reader.GetString(1);
                    string compania = reader.GetString(2);
                    int anioLanzamiento = reader.GetInt32(3);
                    byte generacion = reader.GetByte(4);

                    Models.Console console = new Models.Console(idConsola, nombreConsola, compania, anioLanzamiento, generacion);
                    consoles.Add(console);
                }
            }

            return consoles;
        }

        public void InsertConsole(Models.Console console)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre_consola, @compania, @anio_lanzamiento, @generacion)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre_consola", console.NombreConsola);
                command.Parameters.AddWithValue("@compania", console.Compania);
                command.Parameters.AddWithValue("@anio_lanzamiento", console.AnioLanzamiento);
                command.Parameters.AddWithValue("@generacion", console.Generacion);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateConsole(Models.Console console)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE catalogo_consolas SET nombre_consola = @nombre_consola, compania = @compania, anio_lanzamiento = @anio_lanzamiento, generacion = @generacion WHERE id_consola = @id_consola";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre_consola", console.NombreConsola);
                command.Parameters.AddWithValue("@compania", console.Compania);
                command.Parameters.AddWithValue("@anio_lanzamiento", console.AnioLanzamiento);
                command.Parameters.AddWithValue("@generacion", console.Generacion);
                command.Parameters.AddWithValue("@id_consola", console.IdConsola);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteConsole(int idConsola)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM catalogo_consolas WHERE id_consola = @id_consola";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_consola", idConsola);

                command.ExecuteNonQuery();
            }
        }

        public Models.Console GetConsoleById(int idConsola)
        {
            Models.Console console = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM catalogo_consolas WHERE id_consola = @id_consola";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_consola", idConsola);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nombreConsola = reader.GetString(1);
                    string compania = reader.GetString(2);
                    int anioLanzamiento = reader.GetInt32(3);
                    byte generacion = reader.GetByte(4);

                    console = new Models.Console(idConsola, nombreConsola, compania, anioLanzamiento, generacion);
                }
            }

            return console;
        }

        public List<Models.Console> GetConsolesByCompany(string company)
        {
            List<Models.Console> consoles = new List<Models.Console>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM catalogo_consolas WHERE compania = @compania";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@compania", company);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idConsola = reader.GetInt32(0);
                    string nombreConsola = reader.GetString(1);
                    string compania = reader.GetString(2);
                    int anioLanzamiento = reader.GetInt32(3);
                    byte generacion = reader.GetByte(4);

                    Models.Console console = new Models.Console(idConsola, nombreConsola, compania, anioLanzamiento, generacion);
                    consoles.Add(console);
                }
            }

            return consoles;
        }
    }
}
