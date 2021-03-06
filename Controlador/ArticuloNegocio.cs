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
                    aux.Precio = decimal.Round((decimal)datos.Lector["Precio"],2); // Para que el precio se vea con dos decimales
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
                datos.SetConsulta("Insert into articulos values(@codigo,@nombre,@descripcion,@idmarca,@idcategoria,@urlimagen,@precio)");
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@idmarca", articulo.Marca.ID);
                datos.setearParametro("@idcategoria", articulo.Categoria.ID);
                datos.setearParametro("@urlimagen", articulo.ImagenUrl);
                datos.setearParametro("@precio", articulo.Precio);
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
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, ImagenUrl, a.precio, m.Descripcion Marca, c.Descripcion Categoria " +
                    "from ARTICULOS A " +
                    "Inner Join Marcas as m on A.IdMarca = M.Id " +
                    "Inner Join CATEGORIAS as c on A.IdCategoria = C.Id " +
                    "WHERE ";
                switch (campo)
                {

                    case "Codigo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Codigo like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "a.Codigo like '%" + filtro + "'";
                                break;
                            case "Igual a":
                                consulta += "a.Codigo like '%" + filtro + "%'";
                                break;
                            default:
                                break;
                        }

                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "a.Nombre like '"+ filtro + "%'" ;
                                break;
                            case "Termina con":
                                consulta += "a.Nombre like '%" + filtro + "'";
                                break;
                            case "Igual a":
                                consulta += "a.Nombre like '%" + filtro + "%'";
                                break;
                            default:
                                break;
                        }

                        break;
                    case "Precio":
                        switch (criterio)
                        {
                            case "Menor a":
                                consulta += "a.Precio <" + filtro;
                                break;

                            case "Mayor a":
                                consulta += "a.Precio >" + filtro;

                                break;
                            case "Igual a:":
                                consulta += "a.Precio =" + filtro;
                                break;
                            default:
                                consulta += "a.precio =" + filtro;
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
