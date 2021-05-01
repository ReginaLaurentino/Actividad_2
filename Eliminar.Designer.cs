
namespace Actividad_2
{
    partial class FormEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminar));
            this.E_label_texto = new System.Windows.Forms.Label();
            this.E_label_buscar = new System.Windows.Forms.Label();
            this.E_desplegable = new System.Windows.Forms.ComboBox();
            this.E_Text_buscador = new System.Windows.Forms.TextBox();
            this.E_B_Aceptar = new System.Windows.Forms.Button();
            this.E_imagen = new System.Windows.Forms.PictureBox();
            this.E_B_Eliminar = new System.Windows.Forms.Button();
            this.E_B_cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbImagen = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.E_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // E_label_texto
            // 
            this.E_label_texto.AutoSize = true;
            this.E_label_texto.BackColor = System.Drawing.Color.Transparent;
            this.E_label_texto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.E_label_texto.Location = new System.Drawing.Point(12, 9);
            this.E_label_texto.Name = "E_label_texto";
            this.E_label_texto.Size = new System.Drawing.Size(160, 15);
            this.E_label_texto.TabIndex = 0;
            this.E_label_texto.Text = "Ingrese producto a eliminar";
            // 
            // E_label_buscar
            // 
            this.E_label_buscar.AutoSize = true;
            this.E_label_buscar.BackColor = System.Drawing.Color.Transparent;
            this.E_label_buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.E_label_buscar.Location = new System.Drawing.Point(12, 39);
            this.E_label_buscar.Name = "E_label_buscar";
            this.E_label_buscar.Size = new System.Drawing.Size(44, 15);
            this.E_label_buscar.TabIndex = 1;
            this.E_label_buscar.Text = "Buscar";
            // 
            // E_desplegable
            // 
            this.E_desplegable.FormattingEnabled = true;
            this.E_desplegable.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.E_desplegable.Location = new System.Drawing.Point(60, 36);
            this.E_desplegable.Name = "E_desplegable";
            this.E_desplegable.Size = new System.Drawing.Size(121, 23);
            this.E_desplegable.TabIndex = 2;
            // 
            // E_Text_buscador
            // 
            this.E_Text_buscador.Location = new System.Drawing.Point(200, 36);
            this.E_Text_buscador.Name = "E_Text_buscador";
            this.E_Text_buscador.Size = new System.Drawing.Size(125, 23);
            this.E_Text_buscador.TabIndex = 3;
            // 
            // E_B_Aceptar
            // 
            this.E_B_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("E_B_Aceptar.BackgroundImage")));
            this.E_B_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E_B_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.E_B_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.E_B_Aceptar.Location = new System.Drawing.Point(351, 36);
            this.E_B_Aceptar.Name = "E_B_Aceptar";
            this.E_B_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.E_B_Aceptar.TabIndex = 4;
            this.E_B_Aceptar.Text = "Aceptar";
            this.E_B_Aceptar.UseVisualStyleBackColor = true;
            this.E_B_Aceptar.Click += new System.EventHandler(this.E_B_Aceptar_Click);
            // 
            // E_imagen
            // 
            this.E_imagen.BackColor = System.Drawing.Color.Transparent;
            this.E_imagen.Location = new System.Drawing.Point(339, 65);
            this.E_imagen.Name = "E_imagen";
            this.E_imagen.Size = new System.Drawing.Size(301, 248);
            this.E_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.E_imagen.TabIndex = 6;
            this.E_imagen.TabStop = false;
            // 
            // E_B_Eliminar
            // 
            this.E_B_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("E_B_Eliminar.BackgroundImage")));
            this.E_B_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E_B_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.E_B_Eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.E_B_Eliminar.Location = new System.Drawing.Point(200, 335);
            this.E_B_Eliminar.Name = "E_B_Eliminar";
            this.E_B_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.E_B_Eliminar.TabIndex = 7;
            this.E_B_Eliminar.Text = "Eliminar";
            this.E_B_Eliminar.UseVisualStyleBackColor = true;
            this.E_B_Eliminar.Click += new System.EventHandler(this.E_B_Eliminar_Click);
            // 
            // E_B_cancelar
            // 
            this.E_B_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("E_B_cancelar.BackgroundImage")));
            this.E_B_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E_B_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.E_B_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.E_B_cancelar.Location = new System.Drawing.Point(312, 335);
            this.E_B_cancelar.Name = "E_B_cancelar";
            this.E_B_cancelar.Size = new System.Drawing.Size(75, 23);
            this.E_B_cancelar.TabIndex = 8;
            this.E_B_cancelar.Text = "Cancelar";
            this.E_B_cancelar.UseVisualStyleBackColor = true;
            this.E_B_cancelar.Click += new System.EventHandler(this.E_B_cancelar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(558, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 77);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.Location = new System.Drawing.Point(29, 91);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(45, 15);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(29, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(29, 158);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(29, 190);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblImagen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImagen.Location = new System.Drawing.Point(29, 222);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(69, 15);
            this.lblImagen.TabIndex = 14;
            this.lblImagen.Text = "Url Imagen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(29, 252);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(41, 15);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.Location = new System.Drawing.Point(29, 288);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(60, 15);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoria";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(107, 88);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(218, 23);
            this.tbCodigo.TabIndex = 17;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(107, 122);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(218, 23);
            this.tbNombre.TabIndex = 18;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(107, 155);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(218, 23);
            this.tbDescripcion.TabIndex = 19;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(107, 187);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(218, 23);
            this.tbPrecio.TabIndex = 20;
            // 
            // tbImagen
            // 
            this.tbImagen.Location = new System.Drawing.Point(107, 216);
            this.tbImagen.Name = "tbImagen";
            this.tbImagen.ReadOnly = true;
            this.tbImagen.Size = new System.Drawing.Size(218, 23);
            this.tbImagen.TabIndex = 21;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(107, 249);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.ReadOnly = true;
            this.tbMarca.Size = new System.Drawing.Size(218, 23);
            this.tbMarca.TabIndex = 22;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(107, 285);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.ReadOnly = true;
            this.tbCategoria.Size = new System.Drawing.Size(218, 23);
            this.tbCategoria.TabIndex = 23;
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 393);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbImagen);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.E_B_cancelar);
            this.Controls.Add(this.E_B_Eliminar);
            this.Controls.Add(this.E_imagen);
            this.Controls.Add(this.E_B_Aceptar);
            this.Controls.Add(this.E_Text_buscador);
            this.Controls.Add(this.E_desplegable);
            this.Controls.Add(this.E_label_buscar);
            this.Controls.Add(this.E_label_texto);
            this.Name = "FormEliminar";
            this.Text = "Eliminar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEliminar_FormClosing_1);
            this.Load += new System.EventHandler(this.FormEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.E_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label E_label_texto;
        private System.Windows.Forms.Label E_label_buscar;
        private System.Windows.Forms.ComboBox E_desplegable;
        private System.Windows.Forms.TextBox E_Text_buscador;
        private System.Windows.Forms.Button E_B_Aceptar;
        private System.Windows.Forms.PictureBox E_imagen;
        private System.Windows.Forms.Button E_B_Eliminar;
        private System.Windows.Forms.Button E_B_cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbImagen;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbCategoria;
    }
}