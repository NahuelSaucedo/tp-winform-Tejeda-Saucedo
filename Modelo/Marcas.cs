using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Marcas
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
        public Marcas(int id, string descripcion)
        {
            this.ID = id;
            this.Descripcion = descripcion;
        }
        public Marcas() { }
    }
}
