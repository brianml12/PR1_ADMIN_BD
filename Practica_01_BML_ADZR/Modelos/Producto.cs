using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string NombreCorto { get; set; }
        public string Descripcion { get; set; }
        public string Serie { get; set; }
        public string Color { get; set; }
        public string FechaAdquision { get; set; }
        public string TipoAdquision { get; set; }
        public string Observaciones { get; set; }
        public string NombreArea { get; set; }
        public string Ubicacion { get; set; }

        public int AREAS_id { get; set; }
        public Producto(){}


    }
}
