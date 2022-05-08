using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
   public class ArticuloNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

        
                datos.SetConsulta("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, ImagenUrl, a.precio, m.Descripcion Marca, c.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C WHERE a.IdMarca = m.Id and a.id = c.Id");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.id= (int)datos.Lector["ID"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                 
             

                    lista.Add(aux);
                  
                }
                

             
                return lista;
           

          
      
        }

        public void eliminar (int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                   datos.SetConsulta("delete from ARTICULOS where Id = @id");
                   datos.setearParametro("@id", id);
                   datos.EjecturarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }



}
