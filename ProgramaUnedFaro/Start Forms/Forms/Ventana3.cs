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
using Business.Utilites;

namespace Start_Forms.Forms
{
    public partial class Ventana3 : Form
    {
        public Ventana3()
        {
            InitializeComponent();
        }

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("¿Está realmente seguro que desea regresar?", "Regresar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            validar();
        }

        public void validar()
        {
            try
            {

                int id;
                DateTime fecha;
                Vendedor vendedor_compra;

                id = (int)numericUpDown2.Value;
                fecha = DateTime.Now;
                vendedor_compra = (Vendedor)comboBox1.SelectedItem;

                if (vendedor_compra == null || orden_compra.Orden_compra_detalle_cantidad == 0)
                {
                    MessageBox.Show("ERROR: Todos los datos son obligatorios");
                }
                else
                {
                    if (DataBase.MAXIMO == DataBase.CONT_ORDENES)
                    {
                        MessageBox.Show("ERROR: La memoria se encuentra llena");
                    }
                    else
                    {
                        if (DataBase.ordenes.Take(DataBase.CONT_ORDENES).FirstOrDefault(x => x.Id == id) != null)
                        {
                            MessageBox.Show("ERROR: El identificador se encuentra repetido");
                        }
                        else
                        {
                            orden_compra.Id = id;
                            orden_compra.Fecha = fecha;
                            orden_compra.Vendedor_compra = vendedor_compra;

                            for (int i = 0; i < orden_compra.Orden_compra_detalle_cantidad; i++)
                            {
                                orden_compra.Orden_compra_detalle[i].Articulo_detalle.Cantidad_Disponible
                                    -= orden_compra.Orden_compra_detalle[i].Cantidad;
                            }

                            DataBase.ordenes[DataBase.CONT_ORDENES] = orden_compra;
                            DataBase.CONT_ORDENES += 1;

                            MessageBox.Show("CORRECTO");
                            this.Dispose();
                            Form ventana = new Ventana3();
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
       

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        
        {
            agregar();
        }

        public void agregar()
        {
            try
            {
                Articulo articulo;
                int cantidad;
                articulo = (Articulo)comboBox2.SelectedItem;
                cantidad = (int)numericUpDown1.Value;

                if (articulo == null)
                {
                    MessageBox.Show("ERROR: Todos los datos son obligatorios");
                }
                else
                {
                    if (cantidad > articulo.Cantidad_Disponible)
                    {
                        MessageBox.Show("ERROR: No contamos con esa cantidad de artículos");
                        return;
                    }


                    if (orden_compra.Orden_compra_detalle.Take(orden_compra.Orden_compra_detalle_cantidad).FirstOrDefault(x => x.Articulo_detalle.Id == articulo.Id) != null)
                    {
                        orden_compra.Orden_compra_detalle.Take(orden_compra.Orden_compra_detalle_cantidad).FirstOrDefault(x => x.Articulo_detalle.Id == articulo.Id).Cantidad = cantidad;
                    }
                    else
                    {
                        orden_compra.Orden_compra_detalle[orden_compra.Orden_compra_detalle_cantidad] = new OrdenCompraDetalle();
                        orden_compra.Orden_compra_detalle[orden_compra.Orden_compra_detalle_cantidad].Articulo_detalle = articulo;
                        orden_compra.Orden_compra_detalle[orden_compra.Orden_compra_detalle_cantidad].Cantidad = cantidad;
                        orden_compra.Orden_compra_detalle_cantidad += 1;
                    }


                    decimal pv = 0;
                    decimal pf = 0;
                    dataGridView1.Rows.Clear();

                    for (int i = 0; i < orden_compra.Orden_compra_detalle_cantidad; i++)
                    {
                        dataGridView1.Rows.Add(
                            orden_compra.Orden_compra_detalle[i].Articulo_detalle.Descripcion,
                            orden_compra.Orden_compra_detalle[i].Cantidad,
                            orden_compra.Orden_compra_detalle[i].Articulo_detalle.Precio_vendedor,
                            orden_compra.Orden_compra_detalle[i].PV(),
                            orden_compra.Orden_compra_detalle[i].Articulo_detalle.Precio_Final,
                            orden_compra.Orden_compra_detalle[i].PF());

                        pf += orden_compra.Orden_compra_detalle[i].PF();
                        pv += orden_compra.Orden_compra_detalle[i].PV();
                    }

                    dataGridView2.Rows[0].Cells[0].Value = pv;
                    dataGridView2.Rows[0].Cells[1].Value = pf;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Los datos ingresados no son válidos");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void Ventana3_Load_1(object sender, EventArgs e)
        {
            comboBox1.DataSource = DataBase.vendedores.Take(DataBase.CONT_VENDEDORES).ToArray();
            comboBox2.DataSource = DataBase.articulos.Take(DataBase.CONT_ARTICULOS).ToArray();
            dataGridView2.Rows.Add(0.0, 0.0);
        }
    }
}


