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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            PetShop.HardcodeoClientes();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            foreach (Cliente cliente in PetShop.Clientes)
            {
                this.lsClientes.Items.Add(cliente.ToString());
            }
        }
    }
}
