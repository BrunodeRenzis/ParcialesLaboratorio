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
        /// <summary>
        /// Constructor estático en el cual se instancia una lista por única vez
        /// </summary>
        static FormCliente()
        {
            PetShop.HardcodeoClientes();
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FormCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga lista de clientes al abrir el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = PetShop.Clientes;
        }

        /// <summary>
        /// Actualiza el datagrid ante un cambio en los datos.
        /// </summary>
        private void ActualizarDataGrid()
        {
            this.dgvClientes.DataSource=null;
            this.dgvClientes.DataSource = PetShop.Clientes;
        }

        /// <summary>
        /// Abre un nuevo formulario para agregar clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormNuevoCliente frm = new FormNuevoCliente();
            frm.ShowDialog();
            ActualizarDataGrid();
        }

        /// <summary>
        /// Método para filtrar resultados con lista alternativa según los criterios de búsqueda del cliente.
        /// </summary>
        /// <param name="clientesFiltrados"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Evento para escuchar cambios cada vez que se suelta una tecla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            List<Cliente> clientesFiltrados = new List<Cliente>();
            this.dgvClientes.DataSource = ClienteFiltrado(clientesFiltrados);
        }
    }
}
