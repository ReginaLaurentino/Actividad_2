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
                datos.SetearConsulta("select Codigo , Nombre, ARTICULOS.Descripcion , MARCAS.Descripcion as 'marcas', CATEGORIAS.Descripcion as 'cate' ,ImagenUrl, Precio, ARTICULOS.Id from ARTICULOS inner join MARCAS on MARCAS.Id = ARTICULOS.IdMarca INNER JOIN CATEGORIAS ON CATEGORIAS.Id = ARTICULOS.IdCategoria");
                datos.EjecutarLectura();

                while (datos.Lector.Read()) {
                    Articulo aux = new Articulo();
                    aux.Marcas = new Marca();
                    aux.Categorias = new Categoria();


                    aux.Codigo = (string)datos.Lector[0];
                    aux.Nombre = (string)datos.Lector[1];
                    aux.Descripcion = (string)datos.Lector[2];
                    aux.Marcas.Nombre = (string)datos.Lector["marcas"];
                    aux.Categorias.Nombre = (string)datos.Lector["cate"];
                    aux.UrlImagen = (string)datos.Lector[5];
                    aux.Precio = (Decimal)datos.Lector[6];
                    aux.ID = (Int32)datos.Lector[7];


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

            try {
                string valores = "values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " + nuevo.Marcas.ID + ", " + nuevo.Categorias.ID + ", '" + nuevo.UrlImagen + "', " + nuevo.Precio + ")";
                datos.SetearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " + valores);
                datos.EjectutarAccion();
            }
            catch (Exception ex) {
                throw ex;
            }

            finally {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> Presentacion(string columna, string texto)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            string valores;
            int IDMarca, IDMCategoria;
            

            try {
                
                if( columna == "Marca") {
                    IDMarca = BuscarIDMarca(texto);
                    //aca lloramos una hora hasta q vimos que le mandabamos Marca y no IdMarca
                    valores = " IdMarca = '" + IDMarca + "' ";

                } else if (columna == "Categoria")
                {
                     IDMCategoria= BuscarIDCategoria(texto);
                     valores = " IdCategoria = '" + IDMCategoria + "' ";

                } else
                {
                    valores = " " + columna + " = '" + texto + "' ";
                }
                               

                datos.SetearConsulta("select Codigo , Nombre, ARTICULOS.Descripcion , MARCAS.Descripcion as 'marcas', CATEGORIAS.Descripcion as 'cate' ,ImagenUrl, Precio, ARTICULOS.Id from ARTICULOS inner join MARCAS on MARCAS.Id = ARTICULOS.IdMarca INNER JOIN CATEGORIAS ON CATEGORIAS.Id = ARTICULOS.IdCategoria Where " + valores);
                datos.EjecutarLectura();
                while (datos.Lector.Read()) {
                    Articulo aux = new Articulo();
                    aux.Marcas = new Marca();
                    aux.Categorias = new Categoria();


                    aux.Codigo = (string)datos.Lector[0];
                    aux.Nombre = (string)datos.Lector[1];
                    aux.Descripcion = (string)datos.Lector[2];
                    aux.Marcas.Nombre = (string)datos.Lector["marcas"];
                    aux.Categorias.Nombre = (string)datos.Lector["cate"];
                    aux.UrlImagen = (string)datos.Lector[5];
                    aux.Precio = (Decimal)datos.Lector[6];
                    aux.ID = (Int32)datos.Lector[7];

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


        public int BuscarIDMarca (string marca) {
            int ID=0;
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.SetearConsulta(string.Format("select Id from MARCAS where Descripcion like '%{0}%'", marca));
                datos.EjecutarLectura();

                while (datos.Lector.Read()){
                    ID = (Int32)datos.Lector["Id"];
                }  


            }
            catch (Exception ex ) {

                throw ex;
            }
            finally  {
                datos.cerrarConexion();
            }
            return ID;
        }

        public int BuscarIDCategoria (string categoria) {
            int ID = 0;
            AccesoDatos datos = new AccesoDatos();

            try {
                
                datos.SetearConsulta(string.Format("select Id from CATEGORIAS where Descripcion like '%{0}%'", categoria));
                datos.EjecutarLectura();

                while (datos.Lector.Read()) {
                    ID = (Int32)datos.Lector["Id"];
                }
            }
            catch (Exception ex)  {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
            return ID;
        }
               

        public void Modificar(string consulta) {
            AccesoDatos datos = new AccesoDatos();

            try {
                
                datos.SetearConsulta(consulta);
                datos.EjectutarAccion();
            }
            catch (Exception ex) {
                throw ex;
            }

            finally {
                datos.cerrarConexion();
            }



        }

        public void eliminar(int id) {
            AccesoDatos datos = new AccesoDatos();
            try {
                datos.SetearConsulta("Delete from ARTICULOS where Id = " + id);
                datos.EjectutarAccion();
            }
            catch ( Exception ex) {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
        }

        public void AgregarMarca (string marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.SetearConsulta("insert into MARCAS values('" + marca + "')");
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

        public void AgregarCategoria(string categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
               
                datos.SetearConsulta("insert into Categorias values('" + categoria + "')");
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


    }
}
