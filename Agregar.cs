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
using Presentacion;

namespace Actividad_2
{
    public partial class FormAgregar : Form
    {
        public FormAgregar() {
            InitializeComponent();
        }


        private void B_Aceptar_Click(object sender, EventArgs e) {
                Articulo nuevo = new Articulo();
                ConsultaPresentacion NuevoArticulo = new ConsultaPresentacion();
                try  {
                    nuevo.Codigo = Text_Codigo.Text;
                    nuevo.Nombre = Text_Nombre.Text;
                    nuevo.Descripcion = Text_Descripcion.Text;
                    nuevo.Precio = Convert.ToDecimal(Text_Precio.Text);
                    nuevo.UrlImagen = Text_Imagen.Text;
                    nuevo.Marcas = (Marca)Desplegable_Marca.SelectedItem;
                    nuevo.Categorias = (Categoria)Desplegable_Categoria.SelectedItem;

                    NuevoArticulo.agregar(nuevo);
                    MessageBox.Show("agregado sin problema");
                    Close();
                }
                catch (Exception ex)  {
                    MessageBox.Show(ex.ToString());
                }
                       

        }

        private void Text_Precio_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void FormAgregar_Load(object sender, EventArgs e)  {
            Cargar_Desplegables();
        }

        private void B_Cancelar_Click(object sender, EventArgs e) {
            Close();
               
        }

        private void FormAgregar_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                DialogResult Dialog = MessageBox.Show("De verad querés salir? Perderás los datos", "Saliendo", MessageBoxButtons.YesNo);
                if (Dialog == DialogResult.Yes) return;
                else if (Dialog == DialogResult.No) e.Cancel = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        private void Agregarmarca_Click(object sender, EventArgs e)
        {
            FormMarca agregarmarca = new FormMarca();
            agregarmarca.ShowDialog();
            Cargar_Desplegables();

        }

        private void Cargar_Desplegables()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                Desplegable_Marca.DataSource = marcaNegocio.listar();
                Desplegable_Categoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void b_categoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria agregarcat = new AgregarCategoria();
            agregarcat.ShowDialog();
            Cargar_Desplegables();
        }
    }
}
