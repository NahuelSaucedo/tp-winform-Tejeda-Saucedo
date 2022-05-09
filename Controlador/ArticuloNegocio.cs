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

        public List<Articulos> filtrar(string campo, string criterio, string filtro)
        {

            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, ImagenUrl, a.precio, m.Descripcion Marca, c.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C WHERE a.IdMarca = m.Id and a.id = c.Id and  ";
                switch (campo)
                {

                    case "Codigo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Codigo like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "Codigo like '%" + filtro + "'";
                                break;
                            case "Igual a":
                                consulta += "Codigo like '%" + filtro + "%'";
                                break;
                            default:
                                break;
                        }

                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Nombre like '"+ filtro + "%'" ;
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            case "Igual a":
                                consulta += "Nombre like '%" + filtro + "%'";
                                break;
                            default:
                                break;
                        }

                        break;
                    case "Precio":
                        switch (criterio)
                        {
                            case "Menor a":
                                consulta += "Precio <" + filtro;
                                break;

                            case "Mayor a":
                                consulta += "Precio >" + filtro;

                                break;
                            case "Igual a:":
                                consulta += "Precio =" + filtro;
                                break;
                            default:
                                consulta += "Numero =" + filtro;
                                break;
                        }
                        break;
             
                        
                    default:
                        break;
                }
                datos.SetConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.id = (int)datos.Lector["ID"];
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
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }



}
