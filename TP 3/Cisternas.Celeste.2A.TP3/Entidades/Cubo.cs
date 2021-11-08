using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cubo : Elemento, ICubo
    {
        #region ATRIBUTO
        int dureza;
        #endregion ATRIBUTO

        #region CONSTRUCTOR
        /// <summary>
        /// Sin parametros para serializacion
        /// </summary>
        public Cubo()
        {

        }
        public Cubo(ETipoMaterial tipoMaterial) : base(tipoMaterial)
        {

        }
        public Cubo(ETipoMaterial tipoMaterial, int dureza) : this(tipoMaterial)
        {
            this.dureza = dureza;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        public int DurezaPropiedad
        {
            get
            {
                this.dureza = Dureza();
                return this.dureza;
            }
            set
            {
                this.dureza = value;
            }
        }
        #endregion PROPIEDADES


        #region METODOS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cubo");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Dureza de bloque: {this.Dureza()}");

            return sb.ToString(); ;
        }
        public override bool Equals(object obj)
        {
            Cubo cubo = obj as Cubo;

            return cubo is not null && cubo == this;
        }

        static public ETipoMaterial DevuelveEnum(string enu)
        {
            Enum.TryParse(enu, out ETipoMaterial eTipoMaterial);
            
            return eTipoMaterial;

        }

        public int Dureza()
        {
            int numero = 0;

            switch (base.Tipo)
            {
                case ETipoMaterial.Madera:
                    numero = 2;
                    break;
                case ETipoMaterial.Piedra:
                    numero = 4;
                    break;
                case ETipoMaterial.Diamante:
                    numero = 10;
                    break;
            }

            return numero;
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Cubo c1, Cubo c2)
        {
            return (c1.Tipo == c2.Tipo && c1.dureza == c2.dureza);
        }
        public static bool operator !=(Cubo c1, Cubo c2)
        {
            return !(c1 == c2);
        }
        #endregion SOBRECARGA
    }
}
