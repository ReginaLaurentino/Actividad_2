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
        public FormDetalle( )
        {
            InitializeComponent();
            
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {

            CargarGrilla();



        }
        private void CargarGrilla()
        {

            ConsultaPresentacion datos = new ConsultaPresentacion();

            try
            {

                listaArticulos = datos.Presentacion();
                D_data.DataSource = listaArticulos;

                D_data.Columns[0].Visible = true;
                D_data.Columns[1].Visible = true;
                D_data.Columns[2].Visible = true;
                D_data.Columns[3].Visible = true;
                D_data.Columns[4].Visible = true;
                D_data.Columns[5].Visible = true;
                D_data.Columns[6].Visible = true;
                D_data.Columns[7].Visible = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
                textBox.BackColor = Color.Red;
            else
           if (textBox.Text == "")
                textBox.BackColor = System.Drawing.SystemColors.Control;


            ConsultaPresentacion datos = new ConsultaPresentacion();

            try
            {

                listaArticulos = datos.Presentacion(comboBox.SelectedItem.ToString(), textBox.Text);
                D_data.DataSource = listaArticulos;
                RecargarImagen(listaArticulos[0].UrlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void B_vertodo_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
