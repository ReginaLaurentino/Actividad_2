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

namespace Presentacion
{
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Text.Text == "")
                    Text.BackColor = Color.Red;
                else
               if (Text.Text == "")
                    Text.BackColor = System.Drawing.SystemColors.Control;

                if (Text.Text.Length > 1)
                {
                    ConsultaPresentacion Nuevacategora = new ConsultaPresentacion();
                    Nuevacategora.AgregarCategoria(Text.Text);
                    MessageBox.Show("agregado sin problema");
                    Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
