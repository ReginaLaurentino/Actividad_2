
namespace Presentacion
{
    partial class AgregarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCategoria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.TextBox();
            this.b_agregar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nueva categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria";
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(133, 49);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(159, 23);
            this.Text.TabIndex = 2;
            // 
            // b_agregar
            // 
            this.b_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_agregar.BackgroundImage")));
            this.b_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_agregar.Location = new System.Drawing.Point(105, 87);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(75, 23);
            this.b_agregar.TabIndex = 3;
            this.b_agregar.Text = "Agregar";
            this.b_agregar.UseVisualStyleBackColor = true;
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_cancelar.BackgroundImage")));
            this.b_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_cancelar.Location = new System.Drawing.Point(217, 87);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_cancelar.TabIndex = 4;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(397, 138);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_agregar);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.Button b_cancelar;
    }
}