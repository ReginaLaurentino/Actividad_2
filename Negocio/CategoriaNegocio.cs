using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select id, descripcion from Categorias");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new Categoria((int)datos.Lector["id"], (string)datos.Lector["descripcion"]));
                }

                return lista;
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
