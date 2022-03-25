using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conectar.ClasesBD
{
    public class Usuarios
    {
        public String CodigoUsuarios { get; set; }
        public String Nombre { get; set; }
        public String Clave { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(string codigoUsuarios, string nombre, string clave)
        {
            CodigoUsuarios = codigoUsuarios;
            Nombre = nombre;
            Clave = clave;
        }


    }
}
