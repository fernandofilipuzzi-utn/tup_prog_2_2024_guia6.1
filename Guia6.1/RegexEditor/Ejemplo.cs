using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexEditor
{
    public class Ejemplo
    {
        public string Patron { get; set; }
        public string Contenido { get; set; }
        public bool EsGrupo { get; set; }

        public Ejemplo(string patron, string contenido, bool grupo)
        {
            Patron = patron;
            Contenido = contenido;
            EsGrupo = grupo;
        }

        override public string ToString()
        {
            return Contenido.Length < 15 ? Contenido : Contenido.Substring(0, 15);
        }
    }
}
