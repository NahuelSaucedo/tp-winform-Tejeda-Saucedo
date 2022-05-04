using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    class Articulos
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marcas IdMarca { get; set; }
        public Categorias IdCategoria { get; set; }
        public string ImageUrl { get; set; }
        public float Precio { get; set; }

    }
}
