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
        static FormCliente()
        {
            PetShop.HardcodeoClientes();
        }
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = PetShop.Clientes;
        }

        private void ActualizarDataGrid()
        {
            this.dgvClientes.DataSource=null;
            this.dgvClientes.DataSource = PetShop.Clientes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormNuevoCliente frm = new FormNuevoCliente();
            frm.ShowDialog();
            ActualizarDataGrid();
        }

        List<Cliente> ClienteFiltrado(List<Cliente> clientesFiltrados)
        {
            foreach (Cliente cliente in PetShop.Clientes)
            {
                if (cliente.Nombre.Contains(tbCliente.Text, StringComparison.OrdinalIgnoreCase) || cliente.Apellido.Contains(tbCliente.Text, StringComparison.OrdinalIgnoreCase))
                {
                    clientesFiltrados.Add(cliente);
                }
            }
            return clientesFiltrados;
        }

        private void tbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            List<Cliente> clientesFiltrados = new List<Cliente>();
            this.dgvClientes.DataSource = ClienteFiltrado(clientesFiltrados);
        }
    }
}
