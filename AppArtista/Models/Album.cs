using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArtista.Models
{
    // Clase que representa el modelo de datos para un álbum musical
    public class Album
    {
        public string Nombre { get; set; }
        public string Anio { get; set; }
        public string Portada { get; set; }
        public string Descripcion { get; set; }
    }
}
