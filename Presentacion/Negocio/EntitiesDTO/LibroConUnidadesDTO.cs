using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class LibroConUnidadesDTO
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public Nullable<int> numOcurrencias { get; set; }
    }
}
