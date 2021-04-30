
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
            this.D_data = new System.Windows.Forms.DataGridView();
            this.D_Imagen = new System.Windows.Forms.PictureBox();
            this.D_B_aceptar = new System.Windows.Forms.Button();
            this.D_label_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.B_vertodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.D_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // D_data
            // 
            this.D_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_data.Location = new System.Drawing.Point(22, 44);
            this.D_data.Name = "D_data";
            this.D_data.RowTemplate.Height = 25;
            this.D_data.Size = new System.Drawing.Size(454, 345);
            this.D_data.TabIndex = 0;
            // 
            // D_Imagen
            // 
            this.D_Imagen.BackColor = System.Drawing.Color.Transparent;
            this.D_Imagen.Location = new System.Drawing.Point(509, 44);
            this.D_Imagen.Name = "D_Imagen";
            this.D_Imagen.Size = new System.Drawing.Size(259, 345);
            this.D_Imagen.TabIndex = 1;
            this.D_Imagen.TabStop = false;
            // 
            // D_B_aceptar
            // 
            this.D_B_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("D_B_aceptar.BackgroundImage")));
            this.D_B_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.D_B_aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.D_B_aceptar.Location = new System.Drawing.Point(390, 420);
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
            this.D_label_text.Location = new System.Drawing.Point(22, 9);
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
            "Nombre",
            "Descripcion",
            "Marca",
            "Categoria",
            "Precio"});
            this.comboBox.Location = new System.Drawing.Point(408, 6);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 6;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(535, 6);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(149, 23);
            this.textBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(693, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_vertodo
            // 
            this.B_vertodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_vertodo.BackgroundImage")));
            this.B_vertodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_vertodo.Location = new System.Drawing.Point(128, 420);
            this.B_vertodo.Name = "B_vertodo";
            this.B_vertodo.Size = new System.Drawing.Size(75, 23);
            this.B_vertodo.TabIndex = 9;
            this.B_vertodo.Text = "Ver todo";
            this.B_vertodo.UseVisualStyleBackColor = true;
            this.B_vertodo.Click += new System.EventHandler(this.B_vertodo_Click);
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.B_vertodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.D_label_text);
            this.Controls.Add(this.D_B_aceptar);
            this.Controls.Add(this.D_Imagen);
            this.Controls.Add(this.D_data);
            this.Name = "FormDetalle";
            this.Text = "Detalle de producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetalle_FormClosing);
            this.Load += new System.EventHandler(this.FormDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.D_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView D_data;
        private System.Windows.Forms.PictureBox D_Imagen;
        private System.Windows.Forms.Button D_B_aceptar;
        private System.Windows.Forms.Label D_label_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button B_vertodo;
    }
}