using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CantidadInsuficienteCubosException : Exception
    {
        public CantidadInsuficienteCubosException(): base("No tiene cubos para crear una herramienta")
        {
        }
        public CantidadInsuficienteCubosException(string mensaje) : this(mensaje, null)
        {

        }
        public CantidadInsuficienteCubosException(Exception e): base("No tiene cubos para crear una herramienta", e)
        {

        }
        public CantidadInsuficienteCubosException(string mensaje, Exception e): base("No tiene cubos para crear una herramienta" + mensaje, e)
        {

        }
    }
}
