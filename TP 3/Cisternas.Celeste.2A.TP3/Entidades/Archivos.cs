using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Entidades
{
    public class Archivos
    {
        /// <summary>
        /// Guarda la lista de jugadores con su inventario en un archivo txt  
        /// </summary>
        /// <param name="archivo">archivo a guardar</param>
        /// <param name="dato">datos a guardar</param>
        /// <returns>true si se guardo sino false</returns>
        static public bool GuardarTxt(string archivo, Wiki jugadores)
        {
            bool isOk = false;
            List<Jugador> lista = jugadores.Jugadores;
            StringBuilder sb = new StringBuilder();

            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    foreach (Jugador item in lista)
                    {
                        sb.Clear();

                        foreach (Cubo cubitos in item.Inventario.ListaCubos)
                        {
                            sb.Append($"/C/{cubitos.Tipo},{cubitos.Dureza()};");
                        }

                        foreach (Herramienta herramientas in item.Inventario.ListaHerramienta)
                        {
                            sb.Append($"/H/{herramientas.Tipo},{herramientas.TipoHerramienta},{herramientas.Durabilidad};");
                        }

                        sb.Append($"/J/{item.Nombre}\n");
                        writer.WriteLine(sb.ToString());
                    }

                    isOk = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isOk;
        }
        /// <summary>
        /// Lee un archivo txt y guarda los datos en una lista de jugadores
        /// </summary>
        /// <param name="archivo">archivo a gleer</param>
        /// <param name="texto">datos a guardar</param>
        /// <returns>true si se leyo sino false</returns>
        static public bool LeerTxt(string archivo, out Wiki jugadores)
        {
            bool isOk = false;
            jugadores = new Wiki();
            List<Jugador> lista = new List<Jugador>();
            Cubo cubo;
            Herramienta tool;
            List<Inventario> listaInv = new List<Inventario>();
            Inventario inv = new Inventario();
            string linea;
            string[] datos;
            string[] array;
            string borrar;

            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    linea = reader.ReadLine();
                    array = linea.Split(';');

                    foreach (string item in array)
                    {
                        if (item.Contains("/C/"))
                        {
                            borrar = item.Remove(0, 3);
                            datos = borrar.Split(',');
                            int.TryParse(datos[1], out int num);
                            cubo = new Cubo(Cubo.DevuelveEnum(datos[0]), num);
                            inv.AgregarCubo(cubo);
                            listaInv.Add(inv);
                        }

                        if (item.Contains("/H/"))
                        {
                            borrar = item.Remove(0, 3);
                            datos = borrar.Split(',');
                            int.TryParse(datos[2], out int num);
                            tool = new(Herramienta.DevuelveEnumH(datos[1]), num, Herramienta.DevuelveEnumM(datos[0]));
                            inv.AgregarHerramienta(tool);
                            listaInv.Add(inv);
                        }

                        if (item.Contains("/J/"))
                        {
                            borrar = item.Remove(0, 3);
                            datos = borrar.Split('\n');
                            lista.Add(new Jugador(datos[0]));
                        }
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        lista[i].Inventario = listaInv[i];
                    }
                    jugadores.Jugadores = lista;
                    isOk = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isOk;
        }

        public static bool GuardarXml(string archivo, Wiki wiki)
        {
            bool isOk = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Wiki));

                    serializer.Serialize(writer, wiki);
                    isOk = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return isOk;
        }

        public static Wiki LeerXml(string archivo)
        {
            Wiki lista;
            try
            {
                using (XmlTextReader writer = new XmlTextReader(archivo))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Wiki));

                    lista = (Wiki)deserializer.Deserialize(writer);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }


}

