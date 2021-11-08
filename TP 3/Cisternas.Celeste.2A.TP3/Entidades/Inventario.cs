using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Inventario
    {
        #region ATRIBUTOS
        List<Cubo> cubos;
        List<Herramienta> herramientas;
        int capacidad;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Inventario() : this(10)
        {
            this.cubos = new List<Cubo>();
            this.herramientas = new List<Herramienta>();
        }
        public Inventario(int capacidad)
        {
            this.capacidad = capacidad;
        }
        #endregion CONSTRUCTOR

        public int CantidadCubos
        {
            get
            {
                int cantidad = cubos.Count();
                return cantidad;
            }
        }

        public int CantidadHerramientas
        {
            get
            {
                int cantidad = herramientas.Count();
                return cantidad;
            }
        }

        public int Capacidad
        {
            get
            {
                return this.capacidad;
            }
            set
            {
                this.capacidad = value;
            }
        }

        public List<Cubo> ListaCubos
        {
            get
            {
                return this.cubos;
            }
            set
            {
                this.cubos = value;
            }
        }
        public List<Herramienta> ListaHerramienta
        {
            get
            {
                return this.herramientas;
            }
            set
            {
                this.herramientas = value;
            }
        }
        #region METODOS
       
        public bool ReturnMaterial(Inventario inventario, ETipoMaterial material)
        {
            bool isHere = false;
            foreach (Cubo item in inventario.cubos)
            {
                if (item.Tipo.Equals(material))
                {
                    isHere = true;
                }
            }
            return isHere;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad: {this.capacidad}");

            if (cubos.Count > 0)
            {
                sb.AppendLine($"...........CUBOS..........");
                sb.AppendLine("");
            }
            foreach (Cubo item in this.cubos)
            {
                sb.AppendLine(item.ToString());
            }

            if (herramientas.Count > 0)
            {
                sb.AppendLine($".......HERRAMIENTAS.......");
                sb.AppendLine("");
            }

            foreach (Herramienta item in this.herramientas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        //METODOS CUBOS
        public int CantidadMadera()
        {
            int cantidad = 0;
            foreach (Cubo item in cubos)
            {
                if (item.Tipo is ETipoMaterial.Madera)
                {
                    cantidad += 1;
                }
            }
            return cantidad;
        }

        public int CantidadDiamante()
        {
            int cantidad = 0;
            foreach (Cubo item in cubos)
            {
                if (item.Tipo is ETipoMaterial.Diamante)
                {
                    cantidad += 1;
                }
            }
            return cantidad;
        }

        public int CantidadPiedra()
        {
            int cantidad = 0;
            foreach (Cubo item in cubos)
            {
                if (item.Tipo is ETipoMaterial.Piedra)
                {
                    cantidad += 1;
                }
            }
            return cantidad;
        }

        int GetIndiceCubo(Cubo cubo)
        {
            int index = -1;

            foreach (Cubo item in this.cubos)
            {
                if (item.Equals(cubo))
                {
                    index = this.cubos.IndexOf(cubo);
                    break;
                }
            }

            return index;
        }

        public bool TieneCubo()
        {
            bool isOk = false;
            if (this.cubos.Count > 0)
            {
                isOk = true;
            }
            return isOk;
        }
        public bool AgregarCubo(Cubo cubo)
        {
            return this + cubo;
        }

        public bool RemoverCubo(Cubo cubo)
        {
            return this - cubo;
        }

        //METODOS HERRAMIENTAS

        int GetIndiceHerramienta(Herramienta herramienta)
        {
            int index = -1;

            foreach (Herramienta item in this.herramientas)
            {
                if (item.Equals(herramienta))
                {
                    index = this.herramientas.IndexOf(herramienta);
                    break;
                }
            }

            return index;
        }
        public bool AgregarHerramienta(Herramienta herramienta)
        {
            return this + herramienta;
        }
        public bool AgregarHerramientaSinBorrar(Herramienta herramienta)
        {
            return herramienta + this;
        }

        public bool RemoverHerramienta(Herramienta herramienta)
        {
            return this - herramienta;
        }
        #endregion METODOS

        #region SOBRECARGA

        //CUBOS
        public static bool operator +(Inventario i, Cubo cubo)
        {
            bool isOk = false;

            if (i.capacidad <= 10)
            {
                i.cubos.Add(cubo);
                i.capacidad--;
                isOk = true;
            }

            return isOk;
        }
        public static bool operator -(Inventario i, Cubo cubo)
        {
            bool isOk = false;
            int index = i.GetIndiceCubo(cubo);

            if (index != -1)
            {
                i.cubos.RemoveAt(index);
                i.capacidad++;
                isOk = true;
            }

            return isOk;
        }

        //HERRAMIENTAS
        public static bool operator +(Inventario i, Herramienta herramienta)
        {
            bool isOk = false;
            Cubo cubito = new Cubo(herramienta.Tipo);

            if (i.capacidad <= 10)
            {
                i.herramientas.Add(herramienta);
                i.capacidad--;
                i.RemoverCubo(cubito);
                isOk = true;
            }

            return isOk;
        }
        /// <summary>
        /// Sobrecarga + que no disminuye cubos del mismo tipo
        /// </summary>
        /// <param name="herramienta"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator +(Herramienta herramienta, Inventario i)
        {
            bool isOk = false;

            if (i.capacidad <= 10)
            {
                i.herramientas.Add(herramienta);
                i.capacidad--;
                isOk = true;
            }

            return isOk;
        }
        public static bool operator -(Inventario i, Herramienta herramienta)
        {
            bool isOk = false;
            int index = i.GetIndiceHerramienta(herramienta);

            if (index != -1)
            {
                i.herramientas.RemoveAt(index);
                i.capacidad++;
                isOk = true;
            }

            return isOk;
        }
        #endregion SOBRECARGA
    }
}
