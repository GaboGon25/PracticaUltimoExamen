using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUltimoExamen
{
    public class Libros: Publicaciones
    {
        public string Autor {  get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}
