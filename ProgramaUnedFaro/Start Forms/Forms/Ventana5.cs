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
    public partial class Ventana5 : Form
    {
        public Ventana5()
        {
            InitializeComponent();
        }

        private void Ventana5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.articulos.Take(DataBase.CONT_ARTICULOS).ToArray();
        }
    }
}
