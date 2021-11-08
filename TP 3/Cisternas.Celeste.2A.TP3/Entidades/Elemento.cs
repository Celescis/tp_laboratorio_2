using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Cubo))]
    [XmlInclude(typeof(Herramienta))]
    public abstract class Elemento
    {
        #region ATRIBUTOS
        ETipoMaterial tipo;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Elemento()
        {

        }
        public Elemento(ETipoMaterial tipo)
        {
            this.tipo = tipo;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        public ETipoMaterial Tipo
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
        #endregion PROPIEDADES

        public virtual string Mostrar()
        {
            return ((string)this);
        }

        public static explicit operator string(Elemento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de material: {e.Tipo}");
            return sb.ToString();
        }
       
        public static bool operator ==(Elemento c1, Elemento c2)
        {
            return (c1.Tipo == c2.Tipo && Equals(c1.GetType(),c2.GetType()));
        }
        public static bool operator !=(Elemento c1, Elemento c2)
        {
            return !(c1 == c2);
        }
    }
}
