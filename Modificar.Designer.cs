
namespace Actividad_2
{
    partial class FormModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificar));
            this.Label_text_mod = new System.Windows.Forms.Label();
            this.label_buscar = new System.Windows.Forms.Label();
            this.Desplegable_Modificar = new System.Windows.Forms.ComboBox();
            this.Text_desple_mod = new System.Windows.Forms.TextBox();
            this.B_aceptar_MOD = new System.Windows.Forms.Button();
            this.Mod_label_codigo = new System.Windows.Forms.Label();
            this.MOD_label_nombre = new System.Windows.Forms.Label();
            this.MOD_label_descripcion = new System.Windows.Forms.Label();
            this.MOD_label_Precio = new System.Windows.Forms.Label();
            this.MOD_label_imagen = new System.Windows.Forms.Label();
            this.MOD_label_Marca = new System.Windows.Forms.Label();
            this.MOD_label_catego = new System.Windows.Forms.Label();
            this.MOD_B_aceptar = new System.Windows.Forms.Button();
            this.MOD_B_cancelar = new System.Windows.Forms.Button();
            this.MOD_Text_codigo = new System.Windows.Forms.TextBox();
            this.MOD_Text_nombre = new System.Windows.Forms.TextBox();
            this.MOD_Text_descripcion = new System.Windows.Forms.TextBox();
            this.MOD_Text_precio = new System.Windows.Forms.TextBox();
            this.MOD_Text_imagen = new System.Windows.Forms.TextBox();
            this.MOD_desplegable_marca = new System.Windows.Forms.ComboBox();
            this.MOD_desplegable_categoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_text_mod
            // 
            this.Label_text_mod.AutoSize = true;
            this.Label_text_mod.BackColor = System.Drawing.Color.Transparent;
            this.Label_text_mod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_text_mod.Location = new System.Drawing.Point(12, 9);
            this.Label_text_mod.Name = "Label_text_mod";
            this.Label_text_mod.Size = new System.Drawing.Size(168, 15);
            this.Label_text_mod.TabIndex = 0;
            this.Label_text_mod.Text = "Ingrese producto a modificar";
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.BackColor = System.Drawing.Color.Transparent;
            this.label_buscar.Location = new System.Drawing.Point(421, 9);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(42, 15);
            this.label_buscar.TabIndex = 1;
            this.label_buscar.Text = "Buscar";
            // 
            // Desplegable_Modificar
            // 
            this.Desplegable_Modificar.FormattingEnabled = true;
            this.Desplegable_Modificar.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.Desplegable_Modificar.Location = new System.Drawing.Point(469, 6);
            this.Desplegable_Modificar.Name = "Desplegable_Modificar";
            this.Desplegable_Modificar.Size = new System.Drawing.Size(121, 23);
            this.Desplegable_Modificar.TabIndex = 2;
            // 
            // Text_desple_mod
            // 
            this.Text_desple_mod.Location = new System.Drawing.Point(617, 6);
            this.Text_desple_mod.Name = "Text_desple_mod";
            this.Text_desple_mod.Size = new System.Drawing.Size(106, 23);
            this.Text_desple_mod.TabIndex = 3;
            // 
            // B_aceptar_MOD
            // 
            this.B_aceptar_MOD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_aceptar_MOD.Location = new System.Drawing.Point(762, 9);
            this.B_aceptar_MOD.Name = "B_aceptar_MOD";
            this.B_aceptar_MOD.Size = new System.Drawing.Size(75, 23);
            this.B_aceptar_MOD.TabIndex = 4;
            this.B_aceptar_MOD.Text = "Buscar";
            this.B_aceptar_MOD.UseVisualStyleBackColor = true;
            this.B_aceptar_MOD.Click += new System.EventHandler(this.B_aceptar_MOD_Click);
            // 
            // Mod_label_codigo
            // 
            this.Mod_label_codigo.AutoSize = true;
            this.Mod_label_codigo.BackColor = System.Drawing.Color.Transparent;
            this.Mod_label_codigo.Location = new System.Drawing.Point(18, 47);
            this.Mod_label_codigo.Name = "Mod_label_codigo";
            this.Mod_label_codigo.Size = new System.Drawing.Size(49, 15);
            this.Mod_label_codigo.TabIndex = 6;
            this.Mod_label_codigo.Text = "Codigo ";
            // 
            // MOD_label_nombre
            // 
            this.MOD_label_nombre.AutoSize = true;
            this.MOD_label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.MOD_label_nombre.Location = new System.Drawing.Point(338, 47);
            this.MOD_label_nombre.Name = "MOD_label_nombre";
            this.MOD_label_nombre.Size = new System.Drawing.Size(51, 15);
            this.MOD_label_nombre.TabIndex = 7;
            this.MOD_label_nombre.Text = "Nombre";
            // 
            // MOD_label_descripcion
            // 
            this.MOD_label_descripcion.AutoSize = true;
            this.MOD_label_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.MOD_label_descripcion.Location = new System.Drawing.Point(673, 47);
            this.MOD_label_descripcion.Name = "MOD_label_descripcion";
            this.MOD_label_descripcion.Size = new System.Drawing.Size(69, 15);
            this.MOD_label_descripcion.TabIndex = 8;
            this.MOD_label_descripcion.Text = "Descripcion";
            // 
            // MOD_label_Precio
            // 
            this.MOD_label_Precio.AutoSize = true;
            this.MOD_label_Precio.BackColor = System.Drawing.Color.Transparent;
            this.MOD_label_Precio.Location = new System.Drawing.Point(18, 101);
            this.MOD_label_Precio.Name = "MOD_label_Precio";
            this.MOD_label_Precio.Size = new System.Drawing.Size(40, 15);
            this.MOD_label_Precio.TabIndex = 9;
            this.MOD_label_Precio.Text = "Precio";
            // 
            // MOD_label_imagen
            // 
            this.MOD_label_imagen.AutoSize = true;
            this.MOD_label_imagen.BackColor = System.Drawing.Color.Transparent;
            this.MOD_label_imagen.Location = new System.Drawing.Point(338, 101);
            this.MOD_label_imagen.Name = "MOD_label_imagen";
            this.MOD_label_imagen.Size = new System.Drawing.Size(65, 15);
            this.MOD_label_imagen.TabIndex = 10;
            this.MOD_label_imagen.Text = "Url Imagen";
            // 
            // MOD_label_Marca
            // 
            this.MOD_label_Marca.AutoSize = true;
            this.MOD_label_Marca.BackColor = System.Drawing.Color.Transparent;
            this.MOD_label_Marca.Location = new System.Drawing.Point(338, 163);
            this.MOD_label_Marca.Name = "MOD_label_Marca";
            this.MOD_label_Marca.Size = new System.Drawing.Size(40, 15);
            this.MOD_label_Marca.TabIndex = 11;
            this.MOD_label_Marca.Text = "Marca";
            // 
            // MOD_label_catego
            // 
            this.MOD_label_catego.AutoSize = true;
            this.MOD_label_catego.BackColor = System.Drawing.Color.Transparent;
            this.MOD_label_catego.Location = new System.Drawing.Point(12, 163);
            this.MOD_label_catego.Name = "MOD_label_catego";
            this.MOD_label_catego.Size = new System.Drawing.Size(58, 15);
            this.MOD_label_catego.TabIndex = 12;
            this.MOD_label_catego.Text = "Categoria";
            // 
            // MOD_B_aceptar
            // 
            this.MOD_B_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MOD_B_aceptar.Location = new System.Drawing.Point(842, 100);
            this.MOD_B_aceptar.Name = "MOD_B_aceptar";
            this.MOD_B_aceptar.Size = new System.Drawing.Size(75, 23);
            this.MOD_B_aceptar.TabIndex = 13;
            this.MOD_B_aceptar.Text = "Modificar";
            this.MOD_B_aceptar.UseVisualStyleBackColor = true;
            this.MOD_B_aceptar.Click += new System.EventHandler(this.MOD_B_aceptar_Click);
            // 
            // MOD_B_cancelar
            // 
            this.MOD_B_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MOD_B_cancelar.Location = new System.Drawing.Point(842, 141);
            this.MOD_B_cancelar.Name = "MOD_B_cancelar";
            this.MOD_B_cancelar.Size = new System.Drawing.Size(75, 23);
            this.MOD_B_cancelar.TabIndex = 14;
            this.MOD_B_cancelar.Text = "Cancelar";
            this.MOD_B_cancelar.UseVisualStyleBackColor = true;
            this.MOD_B_cancelar.Click += new System.EventHandler(this.MOD_B_cancelar_Click);
            // 
            // MOD_Text_codigo
            // 
            this.MOD_Text_codigo.Location = new System.Drawing.Point(75, 44);
            this.MOD_Text_codigo.Name = "MOD_Text_codigo";
            this.MOD_Text_codigo.Size = new System.Drawing.Size(224, 23);
            this.MOD_Text_codigo.TabIndex = 16;
            // 
            // MOD_Text_nombre
            // 
            this.MOD_Text_nombre.Location = new System.Drawing.Point(408, 44);
            this.MOD_Text_nombre.Name = "MOD_Text_nombre";
            this.MOD_Text_nombre.Size = new System.Drawing.Size(224, 23);
            this.MOD_Text_nombre.TabIndex = 17;
            // 
            // MOD_Text_descripcion
            // 
            this.MOD_Text_descripcion.Location = new System.Drawing.Point(782, 47);
            this.MOD_Text_descripcion.Name = "MOD_Text_descripcion";
            this.MOD_Text_descripcion.Size = new System.Drawing.Size(224, 23);
            this.MOD_Text_descripcion.TabIndex = 18;
            // 
            // MOD_Text_precio
            // 
            this.MOD_Text_precio.Location = new System.Drawing.Point(75, 98);
            this.MOD_Text_precio.Name = "MOD_Text_precio";
            this.MOD_Text_precio.Size = new System.Drawing.Size(224, 23);
            this.MOD_Text_precio.TabIndex = 19;
            // 
            // MOD_Text_imagen
            // 
            this.MOD_Text_imagen.Location = new System.Drawing.Point(408, 101);
            this.MOD_Text_imagen.Name = "MOD_Text_imagen";
            this.MOD_Text_imagen.Size = new System.Drawing.Size(224, 23);
            this.MOD_Text_imagen.TabIndex = 21;
            // 
            // MOD_desplegable_marca
            // 
            this.MOD_desplegable_marca.FormattingEnabled = true;
            this.MOD_desplegable_marca.Location = new System.Drawing.Point(408, 155);
            this.MOD_desplegable_marca.Name = "MOD_desplegable_marca";
            this.MOD_desplegable_marca.Size = new System.Drawing.Size(224, 23);
            this.MOD_desplegable_marca.TabIndex = 22;
            // 
            // MOD_desplegable_categoria
            // 
            this.MOD_desplegable_categoria.FormattingEnabled = true;
            this.MOD_desplegable_categoria.Location = new System.Drawing.Point(76, 160);
            this.MOD_desplegable_categoria.Name = "MOD_desplegable_categoria";
            this.MOD_desplegable_categoria.Size = new System.Drawing.Size(224, 23);
            this.MOD_desplegable_categoria.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(986, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 83);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.Color.Gray;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 237);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 25;
            this.DGV.Size = new System.Drawing.Size(1046, 245);
            this.DGV.TabIndex = 25;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1070, 568);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MOD_desplegable_categoria);
            this.Controls.Add(this.MOD_desplegable_marca);
            this.Controls.Add(this.MOD_Text_imagen);
            this.Controls.Add(this.MOD_Text_precio);
            this.Controls.Add(this.MOD_Text_descripcion);
            this.Controls.Add(this.MOD_Text_nombre);
            this.Controls.Add(this.MOD_Text_codigo);
            this.Controls.Add(this.MOD_B_cancelar);
            this.Controls.Add(this.MOD_B_aceptar);
            this.Controls.Add(this.MOD_label_catego);
            this.Controls.Add(this.MOD_label_Marca);
            this.Controls.Add(this.MOD_label_imagen);
            this.Controls.Add(this.MOD_label_Precio);
            this.Controls.Add(this.MOD_label_descripcion);
            this.Controls.Add(this.MOD_label_nombre);
            this.Controls.Add(this.Mod_label_codigo);
            this.Controls.Add(this.B_aceptar_MOD);
            this.Controls.Add(this.Text_desple_mod);
            this.Controls.Add(this.Desplegable_Modificar);
            this.Controls.Add(this.label_buscar);
            this.Controls.Add(this.Label_text_mod);
            this.Name = "FormModificar";
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_text_mod;
        private System.Windows.Forms.Label label_buscar;
        private System.Windows.Forms.ComboBox Desplegable_Modificar;
        private System.Windows.Forms.TextBox Text_desple_mod;
        private System.Windows.Forms.Button B_aceptar_MOD;
        private System.Windows.Forms.Label Mod_label_codigo;
        private System.Windows.Forms.Label MOD_label_nombre;
        private System.Windows.Forms.Label MOD_label_descripcion;
        private System.Windows.Forms.Label MOD_label_Precio;
        private System.Windows.Forms.Label MOD_label_imagen;
        private System.Windows.Forms.Label MOD_label_Marca;
        private System.Windows.Forms.Label MOD_label_catego;
        private System.Windows.Forms.Button MOD_B_aceptar;
        private System.Windows.Forms.Button MOD_B_cancelar;
        private System.Windows.Forms.TextBox MOD_Text_codigo;
        private System.Windows.Forms.TextBox MOD_Text_nombre;
        private System.Windows.Forms.TextBox MOD_Text_descripcion;
        private System.Windows.Forms.TextBox MOD_Text_precio;
        private System.Windows.Forms.TextBox MOD_Text_imagen;
        private System.Windows.Forms.ComboBox MOD_desplegable_marca;
        private System.Windows.Forms.ComboBox MOD_desplegable_categoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGV;
    }
}