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
                   
                    Articulos.Codigo = listaArticulos[0].Codigo.ToString();
                    Articulos.ID = listaArticulos[0].ID;
                    Articulos.Nombre= listaArticulos[0].Nombre.ToString();
                    Articulos.Descripcion = listaArticulos[0].Descripcion.ToString();
                    Articulos.UrlImagen = listaArticulos[0].UrlImagen.ToString();
                    Articulos.Marcas.Nombre = listaArticulos[0].Marcas.Nombre.ToString();
                    Articulos.Categorias.Nombre = listaArticulos[0].Categorias.Nombre.ToString();
                    Articulos.Precio = listaArticulos[0].Precio;
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
                
                        if (Articulos != null) {
                         CargarTextBox(Articulos);
                    RecargarImagen(Articulos.UrlImagen);
                        }

                        MOD_desplegable_marca.DataSource = marcaNegocio.listar();
                        MOD_desplegable_categoria.DataSource = categoriaNegocio.listar();

                    }
                    catch (Exception ex) {

                     throw ex;
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
                    CargarTextBox(Articulos);



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
                     RecargarImagen(Articulos.UrlImagen);

        }

               
    }
}
