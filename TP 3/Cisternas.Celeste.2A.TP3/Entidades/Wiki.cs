using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Jugador))]
    public class Wiki
    {
        #region ATRIBUTOS
        List<Jugador> jugadores;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Wiki()
        {
            this.jugadores = new List<Jugador>();
        }
        public Wiki(List<Jugador> lista) : this()
        {
            this.jugadores = lista;
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        public List<Jugador> Jugadores
        {
            get
            {
                return this.jugadores;
            }
            set
            {
                this.jugadores = value;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        public Jugador GetJugador(string nombre)
        {
            Jugador aux = null;
            bool isOk = false;
            nombre = nombre.ToLower();

            foreach (Jugador item in this.jugadores)
            {
                if (item == nombre)
                {
                    aux = item;
                    isOk = true;
                    break;
                }
            }
            if (!isOk)
            {
                aux = new Jugador(nombre);
            }

            return aux;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jugador item in jugadores)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public static Wiki JugadoresConMasCubos(Wiki wiki)
        {
            Wiki filtro = new Wiki();

            foreach (Jugador item in wiki.Jugadores)
            {
                if (item.Inventario.CantidadCubos > 3)
                {
                    filtro.Jugadores.Add(item);
                }
            }
            return filtro;
        }

        public static Wiki JugadoresConMasHerramientas(Wiki wiki)
        {
            Wiki filtro = new Wiki();

            foreach (Jugador item in wiki.Jugadores)
            {
                if (item.Inventario.CantidadHerramientas > 3)
                {
                    filtro.Jugadores.Add(item);
                }
            }
            return filtro;
        }

        #endregion METODOS

        #region SOBRECARGA
        /// <summary>
        /// Sobrecarga igualdad, analiza si el jugador se encuentra en la lista
        /// </summary>
        /// <param name="w"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Wiki w, Jugador j)
        {
            bool isOk = false;

            if (w.jugadores.Count > 0)
            {
                foreach (Jugador item in w.jugadores)
                {
                    if (item == j)
                    {
                        isOk = true;
                    }
                }
            }
            return isOk;
        }
        /// <summary>
        /// Sobrecarga distinto, analiza si el jugador no esta en la lista
        /// </summary>
        /// <param name="w"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Wiki w, Jugador j)
        {
            return !(w == j);
        }
        /// <summary>
        /// Sobrecarga operador +, agrega un jugador a la lista
        /// </summary>
        /// <param name="w"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static Wiki operator +(Wiki w, Jugador j)
        {
            Wiki aux = new Wiki();
            aux = w;
            if (w != j)
            {
                aux.jugadores.Add(j);
            }
            return aux;
        }
        #endregion SOBRECARGA
    }
}
