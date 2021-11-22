using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class JugadorAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static JugadorAccesoDatos()
        {
            connectionString = @"Data Source=DESKTOP-Q90H3PF;Database=WikiCrafteo;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static Wiki Leer()
        {
            Wiki lista = new Wiki();

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = "SELECT * FROM Jugadores";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    
                    lista.Jugadores.Add(new Jugador(int.Parse(dataReader["ID_JUGADOR"].ToString()), dataReader["USUARIO"].ToString()));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return lista;
        }

        public static void Editar(Jugador jugadorEdit)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = "UPDATE Jugadores SET USUARIO = @USUARIO WHERE ID_JUGADOR = @ID";
                command.Parameters.AddWithValue("@USUARIO", jugadorEdit.Usuario);
                command.Parameters.AddWithValue("@ID", jugadorEdit.Id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Metodo que borra un jugador de la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public static void Eliminar(Jugador jugador)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = $"DELETE FROM Jugadores WHERE ID_JUGADOR = @ID AND USUARIO = @USUARIO";
                command.Parameters.AddWithValue("@ID", jugador.Id);
                command.Parameters.AddWithValue("@USUARIO", jugador.Usuario);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Metodo que guarda un jugador en la base de datos
        /// </summary>
        /// <param name="jugador"></param>
        public static void Guardar(Jugador jugador)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = $"INSERT INTO Jugadores (USUARIO) VALUES (@USUARIO)";
                command.Parameters.AddWithValue("@USUARIO", jugador.Usuario);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
