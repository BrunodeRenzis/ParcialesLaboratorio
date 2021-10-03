using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace ParcialBrunoDeRenzis
{
    public partial class FormVenta : Form
    {
        static FormVenta()
        {
            PetShop.HardcodearProductos();
        }
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = PetShop.Productos;
        }
    }
}
