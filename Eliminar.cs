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
                {
                    consulta.eliminar(Articulos.ID);
                    MessageBox.Show("Eliminado con exito");
                    BlanquearTextbox();
                  

                }
                               
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

        private void BlanquearTextbox()
        {
            try
            {
                tbCodigo.Text = null;
                tbNombre.Text = null;
                tbDescripcion.Text = null;
                tbPrecio.Text = null;
                tbImagen.Text = null;
                tbMarca.Text = null;
                tbCategoria.Text = null;
                ID = 0;
                E_imagen.Load("https://www.meme-arsenal.com/memes/c9e6371faa3b57eaee1d35595ca8e910.jpg");
                
            }
            catch (Exception ex )
            {

                throw ex;
            }
            


        }

        private void E_B_Aceptar_Click(object sender, EventArgs e)
        {

            


            ConsultaPresentacion datos = new ConsultaPresentacion();

            try
            {
                if (E_Text_buscador.Text == "" && E_desplegable.SelectedIndex == -1)
                    E_Text_buscador.BackColor = Color.Red;
                else
                 if (E_Text_buscador.Text == "" && E_desplegable.SelectedIndex == -1)
                    E_Text_buscador.BackColor = System.Drawing.SystemColors.Control;

                if (E_desplegable.SelectedIndex >= 0 && E_Text_buscador.Text.Length > 1)
                {
                    E_Text_buscador.BackColor = System.Drawing.SystemColors.Control;

                    listaArticulos = datos.Presentacion(E_desplegable.SelectedItem.ToString(), E_Text_buscador.Text);
                    tbCodigo.Text = listaArticulos[0].Codigo.ToString();
                    tbNombre.Text = listaArticulos[0].Nombre.ToString();
                    tbPrecio.Text = listaArticulos[0].Precio.ToString();
                    tbDescripcion.Text = listaArticulos[0].Descripcion.ToString();
                    tbImagen.Text = listaArticulos[0].UrlImagen.ToString();
                    tbMarca.Text = listaArticulos[0].Marcas.Nombre.ToString();
                    tbCategoria.Text = listaArticulos[0].Categorias.Nombre.ToString();
                    ID = listaArticulos[0].ID;
                    E_imagen.Load(listaArticulos[0].UrlImagen.ToString());
                }

            }
            catch (Exception )
            {
                E_imagen.Load("https://www.meme-arsenal.com/memes/c9e6371faa3b57eaee1d35595ca8e910.jpg");
            }
        }
    }
}
