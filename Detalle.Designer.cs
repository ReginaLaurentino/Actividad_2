
namespace Actividad_2
{
    partial class FormDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalle));
            this.D_Imagen = new System.Windows.Forms.PictureBox();
            this.D_B_aceptar = new System.Windows.Forms.Button();
            this.D_label_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labeldescripcion = new System.Windows.Forms.Label();
            this.labelprecio = new System.Windows.Forms.Label();
            this.labelimagen = new System.Windows.Forms.Label();
            this.labelmarca = new System.Windows.Forms.Label();
            this.labelcategoria = new System.Windows.Forms.Label();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.texturlimagen = new System.Windows.Forms.TextBox();
            this.textmarca = new System.Windows.Forms.TextBox();
            this.textcategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.D_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // D_Imagen
            // 
            this.D_Imagen.BackColor = System.Drawing.Color.Transparent;
            this.D_Imagen.Location = new System.Drawing.Point(337, 35);
            this.D_Imagen.Name = "D_Imagen";
            this.D_Imagen.Size = new System.Drawing.Size(431, 345);
            this.D_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.D_Imagen.TabIndex = 1;
            this.D_Imagen.TabStop = false;
            // 
            // D_B_aceptar
            // 
            this.D_B_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("D_B_aceptar.BackgroundImage")));
            this.D_B_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D_B_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.D_B_aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.D_B_aceptar.Location = new System.Drawing.Point(592, 426);
            this.D_B_aceptar.Name = "D_B_aceptar";
            this.D_B_aceptar.Size = new System.Drawing.Size(75, 23);
            this.D_B_aceptar.TabIndex = 2;
            this.D_B_aceptar.Text = "Salir";
            this.D_B_aceptar.UseVisualStyleBackColor = true;
            this.D_B_aceptar.Click += new System.EventHandler(this.D_B_aceptar_Click);
            // 
            // D_label_text
            // 
            this.D_label_text.AutoSize = true;
            this.D_label_text.BackColor = System.Drawing.Color.Transparent;
            this.D_label_text.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.D_label_text.Location = new System.Drawing.Point(22, 5);
            this.D_label_text.Name = "D_label_text";
            this.D_label_text.Size = new System.Drawing.Size(118, 15);
            this.D_label_text.TabIndex = 3;
            this.D_label_text.Text = "Detalle de producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 83);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.comboBox.Location = new System.Drawing.Point(408, 6);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 6;
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(535, 6);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(149, 23);
            this.Text.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(693, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.BackColor = System.Drawing.Color.Transparent;
            this.labelcodigo.Location = new System.Drawing.Point(22, 44);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(46, 15);
            this.labelcodigo.TabIndex = 10;
            this.labelcodigo.Text = "Codigo";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BackColor = System.Drawing.Color.Transparent;
            this.labelnombre.Location = new System.Drawing.Point(22, 91);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(51, 15);
            this.labelnombre.TabIndex = 11;
            this.labelnombre.Text = "Nombre";
            // 
            // labeldescripcion
            // 
            this.labeldescripcion.AutoSize = true;
            this.labeldescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labeldescripcion.Location = new System.Drawing.Point(22, 148);
            this.labeldescripcion.Name = "labeldescripcion";
            this.labeldescripcion.Size = new System.Drawing.Size(69, 15);
            this.labeldescripcion.TabIndex = 12;
            this.labeldescripcion.Text = "Descripcion";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.BackColor = System.Drawing.Color.Transparent;
            this.labelprecio.Location = new System.Drawing.Point(22, 194);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(40, 15);
            this.labelprecio.TabIndex = 13;
            this.labelprecio.Text = "Precio";
            // 
            // labelimagen
            // 
            this.labelimagen.AutoSize = true;
            this.labelimagen.BackColor = System.Drawing.Color.Transparent;
            this.labelimagen.Location = new System.Drawing.Point(22, 242);
            this.labelimagen.Name = "labelimagen";
            this.labelimagen.Size = new System.Drawing.Size(65, 15);
            this.labelimagen.TabIndex = 14;
            this.labelimagen.Text = "Url Imagen";
            // 
            // labelmarca
            // 
            this.labelmarca.AutoSize = true;
            this.labelmarca.BackColor = System.Drawing.Color.Transparent;
            this.labelmarca.Location = new System.Drawing.Point(22, 292);
            this.labelmarca.Name = "labelmarca";
            this.labelmarca.Size = new System.Drawing.Size(40, 15);
            this.labelmarca.TabIndex = 15;
            this.labelmarca.Text = "Marca";
            // 
            // labelcategoria
            // 
            this.labelcategoria.AutoSize = true;
            this.labelcategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelcategoria.Location = new System.Drawing.Point(22, 339);
            this.labelcategoria.Name = "labelcategoria";
            this.labelcategoria.Size = new System.Drawing.Size(58, 15);
            this.labelcategoria.TabIndex = 16;
            this.labelcategoria.Text = "Categoria";
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(103, 41);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.ReadOnly = true;
            this.textcodigo.Size = new System.Drawing.Size(228, 23);
            this.textcodigo.TabIndex = 17;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(103, 83);
            this.textnombre.Name = "textnombre";
            this.textnombre.ReadOnly = true;
            this.textnombre.Size = new System.Drawing.Size(228, 23);
            this.textnombre.TabIndex = 18;
            // 
            // textdescripcion
            // 
            this.textdescripcion.Location = new System.Drawing.Point(103, 140);
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.ReadOnly = true;
            this.textdescripcion.Size = new System.Drawing.Size(228, 23);
            this.textdescripcion.TabIndex = 19;
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(103, 186);
            this.textprecio.Name = "textprecio";
            this.textprecio.ReadOnly = true;
            this.textprecio.Size = new System.Drawing.Size(228, 23);
            this.textprecio.TabIndex = 20;
            // 
            // texturlimagen
            // 
            this.texturlimagen.Location = new System.Drawing.Point(103, 234);
            this.texturlimagen.Name = "texturlimagen";
            this.texturlimagen.ReadOnly = true;
            this.texturlimagen.Size = new System.Drawing.Size(228, 23);
            this.texturlimagen.TabIndex = 21;
            // 
            // textmarca
            // 
            this.textmarca.Location = new System.Drawing.Point(103, 284);
            this.textmarca.Name = "textmarca";
            this.textmarca.ReadOnly = true;
            this.textmarca.Size = new System.Drawing.Size(228, 23);
            this.textmarca.TabIndex = 22;
            // 
            // textcategoria
            // 
            this.textcategoria.Location = new System.Drawing.Point(103, 331);
            this.textcategoria.Name = "textcategoria";
            this.textcategoria.ReadOnly = true;
            this.textcategoria.Size = new System.Drawing.Size(228, 23);
            this.textcategoria.TabIndex = 23;
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.textcategoria);
            this.Controls.Add(this.textmarca);
            this.Controls.Add(this.texturlimagen);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.textdescripcion);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.labelcategoria);
            this.Controls.Add(this.labelmarca);
            this.Controls.Add(this.labelimagen);
            this.Controls.Add(this.labelprecio);
            this.Controls.Add(this.labeldescripcion);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelcodigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.D_label_text);
            this.Controls.Add(this.D_B_aceptar);
            this.Controls.Add(this.D_Imagen);
            this.Name = "FormDetalle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetalle_FormClosing);
            this.Load += new System.EventHandler(this.FormDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.D_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox D_Imagen;
        private System.Windows.Forms.Button D_B_aceptar;
        private System.Windows.Forms.Label D_label_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labeldescripcion;
        private System.Windows.Forms.Label labelprecio;
        private System.Windows.Forms.Label labelimagen;
        private System.Windows.Forms.Label labelmarca;
        private System.Windows.Forms.Label labelcategoria;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textdescripcion;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.TextBox texturlimagen;
        private System.Windows.Forms.TextBox textmarca;
        private System.Windows.Forms.TextBox textcategoria;
    }
}