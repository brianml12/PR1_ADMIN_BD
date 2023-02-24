using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Libro
    {
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string TITULO { get; set; }
        public int NUMERO_EDICION { get; set; }
        public string ANO_PUBLICACION { get; set; }
        public string NOMBRE_AUTORES { get; set; }
        public string PAIS_PUBLICACION { get; set; }
        public string SINOPSIS { get; set; }
        public string CARRERA { get; set; }
        public string MATERIA { get; set; }
    }
}
