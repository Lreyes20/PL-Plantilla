using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccess.Data;
using Entites.Models;

namespace Start_Forms.Forms
{
    public partial class Ventana4 : Form
    {
        public Ventana4()
        {
            InitializeComponent();
        }

        private void btnActualizarArticulo_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("¿Está realmente seguro que desea regresar?", "Regresar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
        }

        private void Ventana4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.articulos.Take(DataBase.CONT_ARTICULOS).ToArray();
            comboBox1.DataSource = DataBase.articulos.Take(DataBase.CONT_ARTICULOS).ToArray();
        }
        public void validar()
        {
            try
            {
                Articulo articulo;
                int cantidad_disponible;
                articulo = (Articulo)comboBox1.SelectedItem;
                cantidad_disponible = (int)numericUpDown1.Value;

                if (articulo == null)
                {
                    MessageBox.Show("ERROR: Todos los datos son obligatorios");
                }
                else
                {
                    articulo.Cantidad_Disponible = cantidad_disponible;
                    MessageBox.Show("CORRECTO");
                    this.Dispose();
                    Form ventana = new Ventana4();
                    ventana.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Los datos ingresados no son válidos");
            }
        }
    }
}

