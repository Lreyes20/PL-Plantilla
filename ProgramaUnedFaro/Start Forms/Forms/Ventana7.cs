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

namespace Start_Forms.Forms
{
    public partial class Ventana7 : Form
    {
        public Ventana7()
        {
            InitializeComponent();
        }

        private void Ventana7_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < DataBase.CONT_ORDENES; i++)
            {
                dataGridView1.Rows.Add(DataBase.ordenes[i].Id, DataBase.ordenes[i].Fecha, DataBase.ordenes[i].Vendedor_compra, DataBase.ordenes[i], DataBase.ordenes[i].TotalVendedor(), DataBase.ordenes[i].TotalFinal());
            }
        }
    }
}
