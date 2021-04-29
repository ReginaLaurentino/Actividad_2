
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
            this.D_B_aceptar.Location = new System.Drawing.Point(386, 415);
            this.D_B_aceptar.Name = "D_B_aceptar";
            this.D_B_aceptar.Size = new System.Drawing.Size(75, 23);
            this.D_B_aceptar.TabIndex = 2;
            this.D_B_aceptar.Text = "Aceptar";
            this.D_B_aceptar.UseVisualStyleBackColor = true;
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
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.D_label_text);
            this.Controls.Add(this.D_B_aceptar);
            this.Controls.Add(this.D_Imagen);
            this.Controls.Add(this.D_data);
            this.Name = "FormDetalle";
            this.Text = "Detalle de producto";
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
    }
}