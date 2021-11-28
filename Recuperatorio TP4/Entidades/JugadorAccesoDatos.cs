using System;
using System.Collections.Generic;
using System.Data;
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
            command.CommandType = CommandType.Text;
        }
        public static DataTable LeerConsulta()
        {
            DataTable dt = new DataTable();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_AllJugadores", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);

                cmd.ExecuteReader();

                return dt;
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

        //public static List<Inventario> LeerCubosConsulta()
        //{
        //    List<Inventario> lista = new List<Inventario>();
        //    List<Cubo> cubos = new List<Cubo>();
        //    try
        //    {
        //        command.Parameters.Clear();

        //        if (connection.State != ConnectionState.Open)
        //        {
        //            connection.Open();
        //        }
        //        command.CommandText = "SELECT i.ID_INVENTARIO, i.CAPACIDAD, c.CANTIDAD, c.MATERIAL FROM Inventarios i LEFT JOIN Cubos c ON i.ID_INVENTARIO = c.ID_INVENTARIO";

        //        SqlDataReader dataReader = command.ExecuteReader();

        //        while (dataReader.Read())
        //        {
        //            lista.Add(new Inventario(int.Parse(dataReader["i.ID_INVENTARIO"].ToString()), int.Parse(dataReader["i.CAPACIDAD"].ToString())));
        //            cubos.Add(new Cubo((ETipoMaterial)Enum.Parse(typeof(ETipoMaterial), dataReader["c.MATERIAL"].ToString()), int.Parse(dataReader["c.CANTIDAD"].ToString())));
        //        }

        //        for (int i = 0; i < lista.Count; i++)
        //        {
        //            if(lista[i].ID==i)
        //            lista[i].ListaElementos.Add(cubos[i]);
        //        }
                
        //        return lista;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

        public static void BorrarConsulta(Jugador player)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_BorrarJugador", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_JUGADOR", player.Id);
                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);

                cmd.ExecuteNonQuery();
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

        public static void GuardarJugadorConsulta(Jugador player)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_GuardarJugador", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_JUGADOR", player.Id);
                cmd.Parameters.AddWithValue("USUARIO", player.Usuario);
                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);
                cmd.Parameters.AddWithValue("CAPACIDAD", player.Inventario.Capacidad);

                cmd.ExecuteNonQuery();
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

        public static void GuardarCuboConsulta(Jugador player, Cubo cubo)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_GuardarCubo", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);
                cmd.Parameters.AddWithValue("CAPACIDAD", player.Inventario.Capacidad);
                cmd.Parameters.AddWithValue("C_CANTIDAD", cubo.Cantidad);
                cmd.Parameters.AddWithValue("C_MATERIAL", cubo.Tipo.ToString());

                cmd.ExecuteNonQuery();
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

        public static void GuardarHerramientaConsulta(Jugador player, Herramienta tool)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_GuardarHerramienta", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);
                cmd.Parameters.AddWithValue("CAPACIDAD", player.Inventario.Capacidad);
                cmd.Parameters.AddWithValue("C_CANTIDAD", tool.Cantidad);
                cmd.Parameters.AddWithValue("H_CANTIDAD", tool.Cantidad);
                cmd.Parameters.AddWithValue("H_MATERIAL", tool.Tipo.ToString());
                cmd.Parameters.AddWithValue("HERRAMIENTA", tool.TipoHerramienta.ToString());

                cmd.ExecuteNonQuery();
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
        public static void EditarInventarioConsulta(Jugador player)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_EditarInventario", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);
                cmd.Parameters.AddWithValue("CAPACIDAD", player.Inventario.Capacidad);

                cmd.ExecuteNonQuery(); 
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

        public static void EditarJugador(Jugador jugadorEdit)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
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

        public static void LimpiarInventarioConsulta(int id,int capacidad)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_LimpiarInventario", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_INVENTARIO", id);
                cmd.Parameters.AddWithValue("CAPACIDAD", capacidad);

                cmd.ExecuteNonQuery();
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
