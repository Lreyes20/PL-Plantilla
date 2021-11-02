
namespace Start_Forms.Forms
{
    partial class VentanaInicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConVende = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAArticulo = new System.Windows.Forms.Button();
            this.btnRVenta = new System.Windows.Forms.Button();
            this.btnRVenderores = new System.Windows.Forms.Button();
            this.btnRArticulo = new System.Windows.Forms.Button();
            this.btnConVenta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnConVenta);
            this.panel1.Controls.Add(this.btnConVende);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnAArticulo);
            this.panel1.Controls.Add(this.btnRVenta);
            this.panel1.Controls.Add(this.btnRVenderores);
            this.panel1.Controls.Add(this.btnRArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnConVende
            // 
            this.btnConVende.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConVende.Location = new System.Drawing.Point(12, 261);
            this.btnConVende.Name = "btnConVende";
            this.btnConVende.Size = new System.Drawing.Size(211, 34);
            this.btnConVende.TabIndex = 5;
            this.btnConVende.Text = "Consultar Vendedor";
            this.btnConVende.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConVende.UseVisualStyleBackColor = true;
            this.btnConVende.Click += new System.EventHandler(this.btnConVende_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 221);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(211, 34);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar Articulo";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAArticulo
            // 
            this.btnAArticulo.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAArticulo.Location = new System.Drawing.Point(12, 181);
            this.btnAArticulo.Name = "btnAArticulo";
            this.btnAArticulo.Size = new System.Drawing.Size(211, 34);
            this.btnAArticulo.TabIndex = 3;
            this.btnAArticulo.Text = "Actualizar Articulo";
            this.btnAArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAArticulo.UseVisualStyleBackColor = true;
            this.btnAArticulo.Click += new System.EventHandler(this.btnAArticulo_Click);
            // 
            // btnRVenta
            // 
            this.btnRVenta.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRVenta.Location = new System.Drawing.Point(12, 141);
            this.btnRVenta.Name = "btnRVenta";
            this.btnRVenta.Size = new System.Drawing.Size(211, 34);
            this.btnRVenta.TabIndex = 2;
            this.btnRVenta.Text = "Registrar Venta";
            this.btnRVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRVenta.UseVisualStyleBackColor = true;
            this.btnRVenta.Click += new System.EventHandler(this.btnRVenta_Click);
            // 
            // btnRVenderores
            // 
            this.btnRVenderores.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRVenderores.Location = new System.Drawing.Point(12, 101);
            this.btnRVenderores.Name = "btnRVenderores";
            this.btnRVenderores.Size = new System.Drawing.Size(211, 34);
            this.btnRVenderores.TabIndex = 1;
            this.btnRVenderores.Text = "Registrar Vendedores";
            this.btnRVenderores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRVenderores.UseVisualStyleBackColor = true;
            this.btnRVenderores.Click += new System.EventHandler(this.btnRVenderores_Click);
            // 
            // btnRArticulo
            // 
            this.btnRArticulo.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRArticulo.Location = new System.Drawing.Point(12, 61);
            this.btnRArticulo.Name = "btnRArticulo";
            this.btnRArticulo.Size = new System.Drawing.Size(211, 34);
            this.btnRArticulo.TabIndex = 0;
            this.btnRArticulo.Text = "Registrar Articulos";
            this.btnRArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRArticulo.UseVisualStyleBackColor = true;
            this.btnRArticulo.Click += new System.EventHandler(this.btnRArticulo_Click);
            // 
            // btnConVenta
            // 
            this.btnConVenta.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConVenta.Location = new System.Drawing.Point(12, 301);
            this.btnConVenta.Name = "btnConVenta";
            this.btnConVenta.Size = new System.Drawing.Size(211, 34);
            this.btnConVenta.TabIndex = 6;
            this.btnConVenta.Text = "Consultar Venta";
            this.btnConVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConVenta.UseVisualStyleBackColor = true;
            this.btnConVenta.Click += new System.EventHandler(this.btnConVenta_Click);
            // 
            // VentanaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaInicial";
            this.Text = "VentanaInicial";
            this.Load += new System.EventHandler(this.VentanaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRArticulo;
        private System.Windows.Forms.Button btnRVenderores;
        private System.Windows.Forms.Button btnRVenta;
        private System.Windows.Forms.Button btnAArticulo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConVende;
        private System.Windows.Forms.Button btnConVenta;
    }
}