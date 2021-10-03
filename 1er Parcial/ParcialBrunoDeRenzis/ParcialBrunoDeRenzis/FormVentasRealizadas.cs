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
    public partial class FormVentasRealizadas : Form
    {
        static FormVentasRealizadas()
        {
            PetShop.HardcodearVentas();
        }
        public FormVentasRealizadas()
        {
            InitializeComponent();
        }

        private void FormVentasRealizadas_Load(object sender, EventArgs e)
        {
            foreach (Venta venta in PetShop.Ventas)
            {
                this.lsVentas.Items.Add(venta.ToString());
            }
        }
    }
}
