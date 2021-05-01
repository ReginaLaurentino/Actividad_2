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

            



        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (Text.Text == "")
                Text.BackColor = Color.Red;
            else
           if (Text.Text == "")
                Text.BackColor = System.Drawing.SystemColors.Control;


            ConsultaPresentacion datos = new ConsultaPresentacion();

            try
            {

                listaArticulos = datos.BusquedaModificar(comboBox.SelectedItem.ToString(), Text.Text);
                textcodigo.Text = listaArticulos[0].Codigo.ToString();
                textnombre.Text = listaArticulos[0].Nombre.ToString();
                textprecio.Text = listaArticulos[0].Precio.ToString();
                textdescripcion.Text = listaArticulos[0].Descripcion.ToString();
                texturlimagen.Text = listaArticulos[0].UrlImagen.ToString();
                textmarca.Text = listaArticulos[0].Marcas.Nombre.ToString();
                textcategoria.Text = listaArticulos[0].Categorias.Nombre.ToString();
                
                //ID = (Int32)listaArticulos[7].Codigo;

                RecargarImagen(listaArticulos[0].UrlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RecargarImagen(string img)
        {
            D_Imagen.Load(img);
        }
        private void D_B_aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDetalle_FormClosing(object sender, FormClosingEventArgs e)
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
                    textprecio.Text = art.Precio.ToString();
                    ID = art.ID;
                    D_Imagen.Load(art.UrlImagen);

                }

               


            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

    }
}
