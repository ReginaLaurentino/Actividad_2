using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Actividad_2
{
    public partial class FormDetalle : Form
    {
        public List<Articulo> listaArticulos = new List<Articulo>();
        private Articulo art = null;
        int ID;
        

        public FormDetalle( )
        {
            InitializeComponent();
            
        }

        public FormDetalle(Articulo articulo)
        {
            InitializeComponent();
            art = articulo;
            Cargardatos();
                 
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            Cargardatos();
        }
              
        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaPresentacion datos = new ConsultaPresentacion();

            try
            {
                if (Text.Text == "")
                    Text.BackColor = Color.Red;
                else
                 
                if(comboBox.SelectedIndex >=0 && Text.Text.Length > 1)
                {
                    Text.BackColor = System.Drawing.SystemColors.Control;
                    listaArticulos = datos.Presentacion(comboBox.SelectedItem.ToString(), Text.Text);
                    textcodigo.Text = listaArticulos[0].Codigo.ToString();
                    textnombre.Text = listaArticulos[0].Nombre.ToString();
                    // textprecio.Text = String.Format("{0:f0}", listaArticulos[0].Precio.ToString());//listaArticulos[0].Precio.ToString();
                    textprecio.Text = listaArticulos[0].Precio.ToString("N0");
                    textdescripcion.Text = listaArticulos[0].Descripcion.ToString();
                    texturlimagen.Text = listaArticulos[0].UrlImagen.ToString();
                    textmarca.Text = listaArticulos[0].Marcas.Nombre.ToString();
                    textcategoria.Text = listaArticulos[0].Categorias.Nombre.ToString();

                    RecargarImagen(listaArticulos[0].UrlImagen);
                }

                

            }
            catch (Exception )
            {
                MessageBox.Show("Complete la busqueda o inserte un valor valido por favor");
            }
        }

        private void RecargarImagen(string img)
        {
            try
            {
                D_Imagen.Load(img);
            }
            catch (Exception)
            {

                D_Imagen.Load("https://www.meme-arsenal.com/memes/c9e6371faa3b57eaee1d35595ca8e910.jpg");
            }
           
        }
        private void D_B_aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult Dialog = MessageBox.Show("De verdad querés salir?", "Saliendo", MessageBoxButtons.YesNo);
                if (Dialog == DialogResult.Yes) return;
                else if (Dialog == DialogResult.No) e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargardatos()
        {
            try
            {
                if (art != null)
                {

                    textcodigo.Text = art.Codigo;
                    textnombre.Text = art.Nombre;
                    textdescripcion.Text = art.Descripcion;
                    texturlimagen.Text = art.UrlImagen;
                    textmarca.Text = art.Marcas.Nombre;
                    textcategoria.Text = art.Categorias.Nombre;
                    // textprecio.Text = String.Format("{0:f0}", art.Precio.ToString());//art.Precio.ToString();
                    textprecio.Text = art.Precio.ToString("N0");
                 // lblMonto.Text = monto.ToString("N2");
                    ID = art.ID;
                    D_Imagen.Load(art.UrlImagen);

                }

               


            }
            catch (Exception)
            {

                D_Imagen.Load("https://www.meme-arsenal.com/memes/c9e6371faa3b57eaee1d35595ca8e910.jpg");
            }



        }
            
    }
}
