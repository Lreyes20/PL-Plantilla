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
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        private void btnRegrear1_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("¿Está realmente seguro que desea regresar?", "Regresar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
           
        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            validar();
        }

        public void validar()
        {
            try
            {
                int id;
                string descripcion;
                bool activo;
                decimal precio_vendedor;
                decimal precio_Final;
                int cantidad_disponible;

                id = (int)numericUpDown1.Value;
                descripcion = textBox1.Text;
                activo = checkBox1.Checked;
                precio_vendedor = numericUpDown2.Value;
                precio_Final = numericUpDown3.Value;
                cantidad_disponible = (int)numericUpDown4.Value;

                if (descripcion == "")
                {
                    MessageBox.Show("ERROR: Todos los datos son obligatorios");
                }
                else
                {
                    if (DataBase.MAXIMO == DataBase.CONT_ARTICULOS)
                    {
                        MessageBox.Show("ERROR: La memoria se encuentra llena");
                    }
                    else
                    {
                        if (DataBase.articulos.Take(DataBase.CONT_ARTICULOS).FirstOrDefault(x => x.Id == id) != null)
                        {
                            MessageBox.Show("ERROR: El identificador se encuentra repetido");
                        }
                        else
                        {
                            Articulo articulo = new Articulo(id, descripcion, activo, precio_vendedor, precio_Final, cantidad_disponible);
                            DataBase.articulos[DataBase.CONT_ARTICULOS] = articulo;
                            DataBase.CONT_ARTICULOS += 1;
                            MessageBox.Show("CORRECTO");
                            this.Dispose();
                            Form ventana = new Ventana1();
                            ventana.ShowDialog();
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Los datos ingresados no son válidos");
            }
        }
    }
}




