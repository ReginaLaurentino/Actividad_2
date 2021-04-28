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
    public partial class FormPresentacion : Form    {

        private List<Articulo> listaArticulos;
        public FormPresentacion()
        {
            InitializeComponent();
        }
         private void Label_Buscador_Click(object sender, EventArgs e)
        {

        }

        private void FormPresentacion_Load(object sender, EventArgs e) {
            CargarGrilla();
        }

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.ShowDialog();
            CargarGrilla();
        }
        private void CargarGrilla()
        {

            ConsultaPresentacion datos = new ConsultaPresentacion();

            try
            {
                listaArticulos = datos.Presentacion();
                Show_data.DataSource = listaArticulos;

                //Show_data.Columns["ImagenUrl"].Visible = false;
                Show_data.Columns[0].Visible = false;
                Show_data.Columns[3].Visible = false;
                Show_data.Columns[4].Visible = false;
                Show_data.Columns[5].Visible = false;
                Show_data.Columns[6].Visible = false;
                
                RecargarImagen(listaArticulos[0].UrlImagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void RecargarImagen(string img)
        {
            ImagenProducto.Load(img);
        }

        private void Show_data_MouseClick(object sender, MouseEventArgs e) {
            Articulo seleccionado = (Articulo)Show_data.CurrentRow.DataBoundItem;
            RecargarImagen(seleccionado.UrlImagen);

        }


    }
}
