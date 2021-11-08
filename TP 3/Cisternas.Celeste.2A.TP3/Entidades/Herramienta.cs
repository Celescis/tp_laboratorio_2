using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramienta : Elemento, IHerramienta
    {
        #region ATRIBUTOS
        ETipoHerramienta tipo;
        int durabilidad;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Herramienta()
        {

        }
        public Herramienta(ETipoMaterial tipoMaterial) : base(tipoMaterial)
        {

        }
        public Herramienta(ETipoHerramienta tipo, ETipoMaterial tipoMaterial) : this(tipoMaterial)
        {
            this.tipo = tipo;
        }
        public Herramienta(ETipoHerramienta tipo, int durabilidad, ETipoMaterial tipoMaterial) : this(tipo, tipoMaterial)
        {
            this.durabilidad = durabilidad;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        public ETipoHerramienta TipoHerramienta
        {
            set
            {
                this.tipo = value;
            }
            get
            {
                return this.tipo;
            }
        }
    
        /// <summary>
        /// Retorna la durabilidad de la herramienta segun el material
        /// </summary>
        public int Durabilidad
        {
            get
            {
                this.durabilidad= DurabilidadPorTipo(Tipo);
                return this.durabilidad;
            }
            set
            {
                this.durabilidad = value;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Herramienta: {this.TipoHerramienta}");
            sb.AppendLine(this.Uso(this.tipo));
            sb.AppendLine($"Durabilidad: {this.Durabilidad}");

            return sb.ToString(); ;
        }
        static public ETipoHerramienta DevuelveEnumH(string enu)
        {
            Enum.TryParse(enu, out ETipoHerramienta eTipoHerramienta);

            return eTipoHerramienta;

        }
        static public ETipoMaterial DevuelveEnumM(string enu)
        {
            Enum.TryParse(enu, out ETipoMaterial eTipoMaterial);

            return eTipoMaterial;

        }
        public override bool Equals(object obj)
        {
            Herramienta herramienta = obj as Herramienta;

            return herramienta is not null && herramienta == this;
        }
        public string Uso(ETipoHerramienta tipo)
        {
            string usos="Desconocido";

            switch(tipo)
            {
                case ETipoHerramienta.Pico:
                    usos = "Sirve para mineria";
                    break;
                case ETipoHerramienta.Hacha:
                    usos = "Sirve para cortar leña";
                    break;
                case ETipoHerramienta.Espada:
                    usos = "Sirve para luchar";
                    break;
            }

            return usos;
        }
        public int DurabilidadPorTipo(ETipoMaterial material)
        {
            int durabilidad=0;
            switch (material)
            {
                case ETipoMaterial.Madera:
                    durabilidad = 59;
                    break;
                case ETipoMaterial.Piedra:
                    durabilidad = 131;
                    break;
                case ETipoMaterial.Diamante:
                    durabilidad = 1561;
                    break;
            }
            return durabilidad;
        }
        #endregion METODOS
    }
}
