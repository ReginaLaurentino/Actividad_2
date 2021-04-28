using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio {
    class ConsultaPresentacion  {

        public List<Articulo> Presentacion()  {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.SetearConsulta("select Codigo , Nombre, ImagenUrl, Descripcion from ARTICULOS");
                datos.EjecutarLectura();

                while(datos.Lector.Read()) {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex ) {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }

            



        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string valores = "values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " + nuevo.Marcas.ID + ", " + nuevo.Categorias.ID + ", '" + nuevo.UrlImagen + "', " + nuevo.Precio + ")";
                datos.SetearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " + valores);

                datos.EjectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> Presentacion(string columna, string texto)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            //ver como pasarle los indices de Categoria y Marcas

            try {
                string valores = " "+columna+" = '"+texto+"' ";
                datos.SetearConsulta("select Codigo , Nombre, ImagenUrl from ARTICULOS Where" + valores);
                datos.EjecutarLectura();
                while (datos.Lector.Read()) {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }

                return lista;



            }

            catch (Exception ex ) {

                throw ex;
            }

            finally {
                datos.cerrarConexion();
            }

        }



    }
}
