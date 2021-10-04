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
        /// <summary>
        /// Constructor estático en el cual se instancia una lista por única vez.
        /// </summary>
        static FormVentasRealizadas()
        {
            PetShop.HardcodearVentas();
        }
        public FormVentasRealizadas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga las ventas realizadas cada vez que se abre el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVentasRealizadas_Load(object sender, EventArgs e)
        {
            foreach (Venta venta in PetShop.Ventas)
            {
                this.lsVentas.Items.Add(venta.ToString());
                lblFacturacion.Text = $"Facturación total: {Validaciones.CajaTotal()}";
            }
        }

        
    }
}
