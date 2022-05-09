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
                datos.SetConsulta("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, ImagenUrl, a.precio, m.Descripcion Marca, c.Descripcion Categoria " +
                    "from ARTICULOS A " +
                    "Inner Join Marcas as m on A.IdMarca = M.Id " +
                    "Inner Join CATEGORIAS as c on A.IdCategoria = C.Id");
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
                   datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Articulos articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "insert into ARTICULOS values('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "'," + articulo.Marca.ID + "," +articulo.Categoria.ID + ",'" + articulo.ImagenUrl + "'," + articulo.Precio + ")";
                datos.SetConsulta(consulta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void modificar(Articulos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("update Articulos set Nombre = @nombre, Descripcion = @descripcion, imagenUrl = @urlImagen, Codigo = @codigo, idmarca = @idmarca, idcategoria=@idcategoria, precio=@precio Where Id = @id");
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@urlImagen", modificar.ImagenUrl);
                datos.setearParametro("@codigo", modificar.Codigo);   
                datos.setearParametro("@idmarca", modificar.Marca.ID);
                datos.setearParametro("@idcategoria", modificar.Categoria.ID);
                datos.setearParametro("@id", modificar.id);
                datos.setearParametro("@precio", modificar.Precio);

                datos.EjecutarAccion();

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
