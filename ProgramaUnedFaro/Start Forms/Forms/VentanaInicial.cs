using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_Forms.Forms
{
    public partial class VentanaInicial : Form
    {
        public VentanaInicial()
        {
            InitializeComponent();
        }

        private void VentanaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnRArticulo_Click(object sender, EventArgs e)
        {

            Form ventana = new Ventana1();
            ventana.ShowDialog();
        }

        private void btnRVenderores_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventana2();
            ventana.ShowDialog();
        }

        private void btnRVenta_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventana3();
            ventana.ShowDialog();
        }

        private void btnAArticulo_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventana4();
            ventana.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventana5();
            ventana.ShowDialog();
        }

        private void btnConVende_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventana6();
            ventana.ShowDialog();
        }

        private void btnConVenta_Click(object sender, EventArgs e)
        {
            Form ventana = new Ventana7();
            ventana.ShowDialog();
        }
    }
}
