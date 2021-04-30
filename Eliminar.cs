using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Actividad_2
{
    public partial class FormEliminar : Form
    {
        private List<Articulo> listaArticulos;
        private Articulo Articulos = null;
        int ID;

        public FormEliminar()
        {
            InitializeComponent();
        }

       public FormEliminar(Articulo art)
        {
            InitializeComponent();
            Articulos = art;
        }



        private void FormEliminar_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (Articulos != null)
                {
                    tbCodigo.Text = Articulos.Codigo;
                    tbNombre.Text = Articulos.Nombre;
                    tbDescripcion.Text = Articulos.Descripcion;
                    tbPrecio.Text = Articulos.Precio.ToString();
                    tbImagen.Text = Articulos.UrlImagen;
                    tbMarca.Text = Articulos.Marcas.Nombre;
                    tbCategoria.Text = Articulos.Categorias.Nombre;
                    ID = Articulos.ID;
                    E_imagen.Load(Articulos.UrlImagen);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void E_B_Eliminar_Click(object sender, EventArgs e)
        {
            ConsultaPresentacion consulta = new ConsultaPresentacion();
            try
            {
                if (MessageBox.Show("De verdad lo vas a eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    consulta.eliminar(Articulos.ID);             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void E_B_cancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEliminar_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult Dialog = MessageBox.Show("De verad querés salir?", "Saliendo", MessageBoxButtons.YesNo);
                if (Dialog == DialogResult.Yes) return;
                else if (Dialog == DialogResult.No) e.Cancel = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

       
    }
}
