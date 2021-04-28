
namespace Actividad_2
{
    partial class FormPresentacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPresentacion));
            this.Label_Buscador = new System.Windows.Forms.Label();
            this.Desplegable = new System.Windows.Forms.ComboBox();
            this.Text_Buscador = new System.Windows.Forms.TextBox();
            this.B_Aceptar_Buscador = new System.Windows.Forms.Button();
            this.Show_data = new System.Windows.Forms.DataGridView();
            this.ImagenProducto = new System.Windows.Forms.PictureBox();
            this.B_Agregar = new System.Windows.Forms.Button();
            this.B_Modificar = new System.Windows.Forms.Button();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Detalle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Show_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Buscador
            // 
            this.Label_Buscador.AutoSize = true;
            this.Label_Buscador.BackColor = System.Drawing.Color.Transparent;
            this.Label_Buscador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Buscador.Location = new System.Drawing.Point(12, 18);
            this.Label_Buscador.Name = "Label_Buscador";
            this.Label_Buscador.Size = new System.Drawing.Size(53, 19);
            this.Label_Buscador.TabIndex = 0;
            this.Label_Buscador.Text = "Buscar";
            this.Label_Buscador.Click += new System.EventHandler(this.Label_Buscador_Click);
            // 
            // Desplegable
            // 
            this.Desplegable.FormattingEnabled = true;
            this.Desplegable.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Descripcion",
            "Marca",
            "Categoria",
            "Precio"});
            this.Desplegable.Location = new System.Drawing.Point(71, 18);
            this.Desplegable.Name = "Desplegable";
            this.Desplegable.Size = new System.Drawing.Size(121, 23);
            this.Desplegable.TabIndex = 1;
            // 
            // Text_Buscador
            // 
            this.Text_Buscador.Location = new System.Drawing.Point(198, 18);
            this.Text_Buscador.Name = "Text_Buscador";
            this.Text_Buscador.Size = new System.Drawing.Size(234, 23);
            this.Text_Buscador.TabIndex = 2;
            this.Text_Buscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Buscador_KeyPress);
            // 
            // B_Aceptar_Buscador
            // 
            this.B_Aceptar_Buscador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Aceptar_Buscador.BackgroundImage")));
            this.B_Aceptar_Buscador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_Aceptar_Buscador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_Aceptar_Buscador.Location = new System.Drawing.Point(449, 18);
            this.B_Aceptar_Buscador.Name = "B_Aceptar_Buscador";
            this.B_Aceptar_Buscador.Size = new System.Drawing.Size(75, 23);
            this.B_Aceptar_Buscador.TabIndex = 3;
            this.B_Aceptar_Buscador.Text = "Aceptar";
            this.B_Aceptar_Buscador.UseVisualStyleBackColor = true;
            this.B_Aceptar_Buscador.Click += new System.EventHandler(this.B_Aceptar_Buscador_Click);
            // 
            // Show_data
            // 
            this.Show_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_data.Location = new System.Drawing.Point(23, 63);
            this.Show_data.Name = "Show_data";
            this.Show_data.RowTemplate.Height = 25;
            this.Show_data.Size = new System.Drawing.Size(294, 565);
            this.Show_data.TabIndex = 4;
            this.Show_data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Show_data_MouseClick);
            // 
            // ImagenProducto
            // 
            this.ImagenProducto.BackColor = System.Drawing.Color.Transparent;
            this.ImagenProducto.Location = new System.Drawing.Point(323, 47);
            this.ImagenProducto.Name = "ImagenProducto";
            this.ImagenProducto.Size = new System.Drawing.Size(685, 581);
            this.ImagenProducto.TabIndex = 5;
            this.ImagenProducto.TabStop = false;
            // 
            // B_Agregar
            // 
            this.B_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Agregar.BackgroundImage")));
            this.B_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.B_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_Agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_Agregar.Location = new System.Drawing.Point(34, 643);
            this.B_Agregar.Name = "B_Agregar";
            this.B_Agregar.Size = new System.Drawing.Size(75, 23);
            this.B_Agregar.TabIndex = 6;
            this.B_Agregar.Text = "Agregar";
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
            // 
            // B_Modificar
            // 
            this.B_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Modificar.BackgroundImage")));
            this.B_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_Modificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_Modificar.Location = new System.Drawing.Point(128, 643);
            this.B_Modificar.Name = "B_Modificar";
            this.B_Modificar.Size = new System.Drawing.Size(75, 23);
            this.B_Modificar.TabIndex = 7;
            this.B_Modificar.Text = "Modificar";
            this.B_Modificar.UseVisualStyleBackColor = true;
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Eliminar.BackgroundImage")));
            this.B_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_Eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_Eliminar.Location = new System.Drawing.Point(221, 643);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.B_Eliminar.TabIndex = 8;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            // 
            // B_Detalle
            // 
            this.B_Detalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Detalle.BackgroundImage")));
            this.B_Detalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_Detalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_Detalle.Location = new System.Drawing.Point(323, 643);
            this.B_Detalle.Name = "B_Detalle";
            this.B_Detalle.Size = new System.Drawing.Size(75, 23);
            this.B_Detalle.TabIndex = 9;
            this.B_Detalle.Text = "Detalle";
            this.B_Detalle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(938, 613);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 694);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_Detalle);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.B_Modificar);
            this.Controls.Add(this.B_Agregar);
            this.Controls.Add(this.ImagenProducto);
            this.Controls.Add(this.Show_data);
            this.Controls.Add(this.B_Aceptar_Buscador);
            this.Controls.Add(this.Text_Buscador);
            this.Controls.Add(this.Desplegable);
            this.Controls.Add(this.Label_Buscador);
            this.Name = "FormPresentacion";
            this.Text = "StockAdministrator";
            this.Load += new System.EventHandler(this.FormPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Buscador;
        private System.Windows.Forms.ComboBox Desplegable;
        private System.Windows.Forms.TextBox Text_Buscador;
        private System.Windows.Forms.Button B_Aceptar_Buscador;
        private System.Windows.Forms.DataGridView Show_data;
        private System.Windows.Forms.PictureBox ImagenProducto;
        private System.Windows.Forms.Button B_Agregar;
        private System.Windows.Forms.Button B_Modificar;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Detalle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

