using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace ParcialBrunoDeRenzis
{
    public partial class FormVenta : Form
    {
        List<Producto> listaCompra;
        Cliente unCliente;
        SoundPlayer sonidoVenta;
        string locacion = Directory.GetCurrentDirectory();
        static FormVenta()
        {
            if(!Validaciones.ListaInicializada(PetShop.Productos.Count))
                PetShop.HardcodearProductos();

            if (!Validaciones.ListaInicializada(PetShop.Clientes.Count))
                PetShop.HardcodeoClientes();
        }

        public FormVenta()
        {
            InitializeComponent();
            listaCompra = new List<Producto>();
            unCliente = new Cliente();
            sonidoVenta = new SoundPlayer();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = PetShop.Productos;
            this.dgvClientes.DataSource = PetShop.Clientes;
            sonidoVenta.SoundLocation = String.Concat(locacion, "/compra.wav");
        }
        void ActualizarDataGridProductos()
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = PetShop.Productos;
        }

        void ActualizarDataGridClientes()
        {
            this.dgvClientes.DataSource = null;
            this.dgvClientes.DataSource = PetShop.Clientes;
        }

        private void btnAgregarAVenta_Click(object sender, EventArgs e)
        {
            bool hayStock = false;
            if (Validaciones.NotEmptyString(this.txtBoxCantidad.Text))
            {
                foreach (Producto item in PetShop.Productos)
                {
                    if (item.IdProducto == (int)this.dgvProductos.CurrentRow.Cells["idProducto"].Value)
                    {

                        if (Validaciones.HayStock(item, double.Parse(this.txtBoxCantidad.Text)))
                        {
                            item.Stock -= double.Parse(this.txtBoxCantidad.Text);
                            listaCompra.Add(item);
                            hayStock = true;
                            ActualizarDataGridProductos();
                        }

                        if (!hayStock)
                            MessageBox.Show("No hay stock suficiente para la venta");
                    }
                }
            }

            else
                MessageBox.Show("No se ha ingresado cantidad de producto alguno");

            

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (listaCompra.Count >= 1)
            {
                unCliente.Nombre = this.dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                unCliente.Apellido = this.dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                Venta unaVenta = new Venta(PetShop.Empleado, unCliente, listaCompra);
                unaVenta.Monto = unaVenta.CalcularMonto(int.Parse(this.txtBoxCantidad.Text));
                unCliente.Saldo -= unaVenta.CalcularMonto(int.Parse(this.txtBoxCantidad.Text));
                PetShop.Ventas.Add(unaVenta);
                ActualizarDataGridClientes();
                sonidoVenta.Play();
            }

            else
                MessageBox.Show("No se ha efectuado la venta por que no hay productos en ella");

        }

       
    }
}