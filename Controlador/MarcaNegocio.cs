using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class MarcaNegocio
    {
        public List<Marcas> listar()
        {
            List<Marcas> lista = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT id,Descripcion from marcas";
                datos.SetConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    lista.Add(new Marcas((int)datos.Lector["id"], (string)datos.Lector["descripcion"]));
                }
                return lista;

            }
            catch (Exception ex1)
            {
                throw ex1;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
