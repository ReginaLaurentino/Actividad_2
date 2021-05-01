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
        private Articulo Articulos= null;
        int ID;
        public FormModificar() {
            InitializeComponent();
        }

        public FormModificar(Articulo art) {
            InitializeComponent();
            Articulos = art;
        }

        private void B_aceptar_MOD_Click(object sender, EventArgs e)  {
           

            ConsultaPresentacion datos = new ConsultaPresentacion();

            try {
                if (Text_desple_mod.Text == "" && Desplegable_Modificar.SelectedIndex == -1)
                    Text_desple_mod.BackColor = Color.Red;
                else
                 if (Text_desple_mod.Text == "" && Desplegable_Modificar.SelectedIndex == -1)
                    Text_desple_mod.BackColor = System.Drawing.SystemColors.Control;

                if (Desplegable_Modificar.SelectedIndex >= 0 && Text_desple_mod.Text.Length > 1)
                {
                    Text_desple_mod.BackColor = System.Drawing.SystemColors.Control;


                    listaArticulos = datos.Presentacion(Desplegable_Modificar.SelectedItem.ToString(), Text_desple_mod.Text);
                    DGV.DataSource = listaArticulos;
                    Articulos = (Articulo)DGV.CurrentRow.DataBoundItem;
                    CargarTextBox(Articulos);

                    RecargarImagen(listaArticulos[0].UrlImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormModificar_Load(object sender, EventArgs e) {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try {
                CargarGrilla();
                if (Articulos != null) {
                    CargarTextBox(Articulos);
                }

                MOD_desplegable_marca.DataSource = marcaNegocio.listar();
                MOD_desplegable_categoria.DataSource = categoriaNegocio.listar();

            }
            catch (Exception ex) {

                throw ex;
            }
        }

        private void CargarGrilla() {

            ConsultaPresentacion datos = new ConsultaPresentacion();

            try {
                listaArticulos = datos.Presentacion();
                DGV.DataSource = listaArticulos;

                DGV.Columns[0].Visible = true;
                DGV.Columns[1].Visible = true;
                DGV.Columns[2].Visible = true;
                DGV.Columns[3].Visible = true;
                DGV.Columns[4].Visible = true;
                DGV.Columns[5].Visible = true;
                DGV.Columns[6].Visible = true;
                DGV.Columns[7].Visible = false;
                RecargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }

        private void RecargarImagen(string img)
        {
            try {
                picture.Load(img);
            }
            catch (Exception) {

                picture.Load("https://www.meme-arsenal.com/memes/c9e6371faa3b57eaee1d35595ca8e910.jpg");
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

            try  {
                marca = buscar.BuscarIDMarca(MOD_desplegable_marca.Text);
                categoria = buscar.BuscarIDCategoria(MOD_desplegable_categoria.Text);
                consulta = " update Articulos set Codigo =  '"+ MOD_Text_codigo.Text +"' , Nombre = '" + MOD_Text_nombre.Text + "', Descripcion = '" + MOD_Text_descripcion.Text + "', IdMarca = '"+marca+"', IdCategoria= '"+categoria+"', ImagenUrl =' " + MOD_Text_imagen.Text + "', Precio = '" + MOD_Text_precio.Text + "' where Articulos.Id = '" + ID + "'";

                buscar.Modificar(consulta);
                MessageBox.Show("Modificado con exito");
                CargarGrilla();

            }
            catch (Exception ex ) {
                throw ex;
            }
            

        }

        private void MOD_B_cancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void FormModificar_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                DialogResult Dialog = MessageBox.Show("De verad querés salir? Perderás los datos", "Saliendo", MessageBoxButtons.YesNo);
                if (Dialog == DialogResult.Yes) return;
                else if (Dialog == DialogResult.No) e.Cancel = true;
            }
            catch (Exception ex) {
                throw ex;
            }

        }

        private void CargarTextBox(Articulo Articulos)
        {
            MOD_Text_codigo.Text = Articulos.Codigo;
            MOD_Text_nombre.Text = Articulos.Nombre;
            MOD_Text_descripcion.Text = Articulos.Descripcion;
            MOD_Text_imagen.Text = Articulos.UrlImagen;
            MOD_desplegable_marca.Text = Articulos.Marcas.Nombre;
            MOD_desplegable_categoria.Text = Articulos.Categorias.Nombre;
            MOD_Text_precio.Text = Articulos.Precio.ToString();
            ID = Articulos.ID;
        }

        private void B_vertodo_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
