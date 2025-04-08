using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public string nombre;
        public int telefono;
        public string correo;

        public override string ToString()
        {
            return (nombre + " // " + telefono + " // " + correo);
        }
    }
}
