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
    public partial class FormModificar : Form
    {
        private List<Articulo> listaArticulos;
        int ID;
        public FormModificar()
        {
            InitializeComponent();
        }

        private void B_aceptar_MOD_Click(object sender, EventArgs e)
        {
            if (Text_desple_mod.Text == "")
                Text_desple_mod.BackColor = Color.Red;
            else
            if (Text_desple_mod.Text == "")
                Text_desple_mod.BackColor = System.Drawing.SystemColors.Control;


            ConsultaPresentacion datos = new ConsultaPresentacion();

            try
            {

                listaArticulos = datos.BusquedaModificar(Desplegable_Modificar.SelectedItem.ToString(), Text_desple_mod.Text);
                DGV.DataSource = listaArticulos;
                DGV.Columns[0].Visible = true;
                DGV.Columns[1].Visible = true;
                DGV.Columns[2].Visible = true;
                DGV.Columns[3].Visible = true;
                DGV.Columns[4].Visible = true;
                DGV.Columns[5].Visible = true;
                DGV.Columns[6].Visible = true;
                DGV.Columns[7].Visible = false;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormModificar_Load(object sender, EventArgs e) {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                CargarGrilla();
                MOD_desplegable_marca.DataSource = marcaNegocio.listar();
                MOD_desplegable_categoria.DataSource = categoriaNegocio.listar();

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        private void CargarGrilla()
        {

            ConsultaPresentacion datos = new ConsultaPresentacion();

            try
            {

                listaArticulos = datos.ListadoenModificar();
                DGV.DataSource = listaArticulos;

                DGV.Columns[0].Visible = true;
                DGV.Columns[1].Visible = true;
                DGV.Columns[2].Visible = true;
                DGV.Columns[3].Visible = true;
                DGV.Columns[4].Visible = true;
                DGV.Columns[5].Visible = true;
                DGV.Columns[6].Visible = true;
                DGV.Columns[7].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewRow dvg = DGV.Rows[e.RowIndex];

            MOD_Text_codigo.Text = dvg.Cells[0].Value.ToString();
            MOD_Text_nombre.Text = dvg.Cells[1].Value.ToString();
            MOD_Text_descripcion.Text = dvg.Cells[2].Value.ToString();
            MOD_Text_imagen.Text = dvg.Cells[3].Value.ToString();
            MOD_desplegable_marca.Text = dvg.Cells[4].Value.ToString();
            MOD_desplegable_categoria.Text = dvg.Cells[5].Value.ToString();
            MOD_Text_precio.Text = dvg.Cells[6].Value.ToString();
            ID = (Int32)dvg.Cells[7].Value;






        }

        private void MOD_B_aceptar_Click(object sender, EventArgs e) {
            
            string consulta;
            int marca, categoria;
            ConsultaPresentacion buscar = new ConsultaPresentacion();

            try
            {
                marca = buscar.BuscarIDMarca(MOD_desplegable_marca.Text);
                categoria = buscar.BuscarIDCategoria(MOD_desplegable_categoria.Text);
                //update Articulos set Codigo = 'asd', Nombre = 'pepe', Descripcion = 'zarasa2', IdMarca = 1, IdCategoria =2, ImagenUrl ='holis', Precio = 5000 where Articulos.Id = '7'
                consulta = " update Articulos set Codigo =  '"+ MOD_Text_codigo.Text +"' , Nombre = '" + MOD_Text_nombre.Text + "', Descripcion = '" + MOD_Text_descripcion.Text + "', IdMarca = '"+marca+"', IdCategoria= '"+categoria+"', ImagenUrl =' " + MOD_Text_imagen.Text + "', Precio = '" + MOD_Text_precio.Text + "' where Articulos.Id = '" + ID + "'";

                buscar.Modificar(consulta);
                CargarGrilla();
            }
            catch (Exception ex )
            {

                throw ex;
            }
            

        }

        private void MOD_B_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
