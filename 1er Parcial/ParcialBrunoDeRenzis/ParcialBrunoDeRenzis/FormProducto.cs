using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialBrunoDeRenzis
{
    public partial class FormProducto : Form
    {
        static FormProducto()
        {
            PetShop.HardcodearProductos();
        }
        public FormProducto()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = PetShop.Productos;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = PetShop.Productos;
        }

    }
}
