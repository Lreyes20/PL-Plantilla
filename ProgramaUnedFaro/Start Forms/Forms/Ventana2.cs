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
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("¿Está realmente seguro que desea regresar?", "Regresar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
        }

        private void btnGuardarVendedor_Click(object sender, EventArgs e)
        {
            {
                validar();
            }


        }

        private void validar()
        {
            try
            {
                string identificacion;
                string nombre;
                string primer_apellido;
                string segundo_apellido;
                DateTime fecha_nacimiento;
                char genero;
                DateTime fecha_ingreso;


                identificacion = textBox1.Text;
                nombre = textBox2.Text;
                primer_apellido = textBox3.Text;
                segundo_apellido = textBox4.Text;
                fecha_nacimiento = dateTimePicker1.Value;
                genero = Char.Parse(comboBox1.Text);
                fecha_ingreso = dateTimePicker2.Value;


                if (identificacion == "" || nombre == "" || primer_apellido == "" || segundo_apellido == "")
                {
                    MessageBox.Show("ERROR: Todos los datos son obligatorios");
                }
                else
                {
                    if (DataBase.MAXIMO == DataBase.CONT_VENDEDORES)
                    {
                        MessageBox.Show("ERROR: La memoria se encuentra llena");
                    }
                    else
                    {
                        if (DataBase.vendedores.Take(DataBase.CONT_VENDEDORES).FirstOrDefault(x => x.Identificacion == identificacion) != null)
                        {
                            MessageBox.Show("ERROR: El identificador se encuentra repetido");
                        }
                        else
                        {
                            Vendedor vendedor = new Vendedor(identificacion, nombre, primer_apellido, segundo_apellido, fecha_nacimiento, genero, fecha_ingreso);
                            DataBase.vendedores[DataBase.CONT_VENDEDORES] = vendedor;
                            DataBase.CONT_VENDEDORES += 1;
                            MessageBox.Show("CORRECTO");
                            this.Dispose();
                            Form ventana = new Ventana2();
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

        private void Ventana2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
