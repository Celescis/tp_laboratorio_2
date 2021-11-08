using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Jugador
    {
        #region ATRIBUTOS
        string nombre;
        Inventario inventario;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Jugador()
        {
            this.inventario = new Inventario();
        }
        public Jugador(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Jugador(string nombre, Inventario inventario):this(nombre)
        {
            this.inventario = inventario;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES  
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        public Inventario Inventario
        {
            set
            {
                this.inventario = value;
            }
            get
            {
                return this.inventario;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {this.Nombre}");
            sb.AppendLine($"INVENTARIO: \n{this.inventario}");

            return sb.ToString();
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Jugador j1, string nombre)
        {
            return (j1.Nombre==nombre);
        }
        public static bool operator !=(Jugador j1, string nombre)
        {
            return !(j1 == nombre);
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Nombre == j2.Nombre);
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion SOBRECARGA
    }
}
