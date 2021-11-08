using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException(): base("El nombre ingresado no es correcto")
        {
        }
        public NombreInvalidoException(string mensaje) : this(mensaje, null)
        {

        }
        public NombreInvalidoException(Exception e): base("El nombre ingresado no es correcto", e)
        {

        }
        public NombreInvalidoException(string mensaje, Exception e): base("El nombre ingresado no es correcto: " + mensaje, e)
        {

        }
    }
}
