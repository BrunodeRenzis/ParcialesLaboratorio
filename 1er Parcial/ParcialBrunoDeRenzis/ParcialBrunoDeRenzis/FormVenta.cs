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
        /// <summary>
        /// Constructor estático en el cual se instancia una lista por única vez con previa validación a que no hayan sido anteriormente instanciadas
        /// </summary>
        static FormVenta()
        {
            if(!Validaciones.ListaInicializada(PetShop.Productos.Count))
                PetShop.HardcodearProductos();

            if (!Validaciones.ListaInicializada(PetShop.Clientes.Count))
                PetShop.HardcodeoClientes();
        }

        /// <summary>
        /// Constructor por defecto del formulario de ventas
        /// </summary>
        public FormVenta()
        {
            InitializeComponent();
            listaCompra = new List<Producto>();
            unCliente = new Cliente();
            sonidoVenta = new SoundPlayer();
        }

        /// <summary>
        /// Evento de carga de formulario donde se cargan las listas que se necesitan para la venta y el sonido al finalizar la venta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVenta_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = PetShop.Productos;
            this.dgvClientes.DataSource = PetShop.Clientes;
            sonidoVenta.SoundLocation = String.Concat(locacion, "/compra.wav");
        }
        
        /// <summary>
        /// Actualización de lista de productos en el datagrid
        /// </summary>
        void ActualizarDataGridProductos()
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = PetShop.Productos;
        }

        /// <summary>
        /// Actualización de datos en lista de clientes en el datagrid
        /// </summary>
        void ActualizarDataGridClientes()
        {
            this.dgvClientes.DataSource = null;
            this.dgvClientes.DataSource = PetShop.Clientes;
        }

        /// <summary>
        /// Actualización de lista de venta en el listbox
        /// </summary>
        void ActualizarListaVenta()
        {
            this.lsProductosVenta.DataSource = null;
            this.lsProductosVenta.DataSource = listaCompra;
        }

        /// <summary>
        /// Limpia la lista de productos de la venta
        /// </summary>
        void LimpiarListaProductos()
        {
            this.lsProductosVenta.DataSource = null;
        }

        /// <summary>
        /// Agrega un elemento a la venta validando la disponibilidad de stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            ActualizarListaVenta();
                        }

                        if (!hayStock)
                            MessageBox.Show("No hay stock suficiente para la venta");
                    }
                }
            }

            else
                MessageBox.Show("No se ha ingresado cantidad de producto alguno");

            

        }

        /// <summary>
        /// Confirma la venta y la crea generandola con los datos de productos y clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (listaCompra.Count >= 1)
            {
                unCliente.Nombre = this.dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                unCliente.Apellido = this.dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                Venta unaVenta = new Venta(PetShop.Empleado, unCliente, listaCompra);
                unaVenta.Monto = unaVenta.CalcularMonto(int.Parse(this.txtBoxCantidad.Text));
                PetShop.Ventas.Add(unaVenta);
                ActualizarDataGridClientes();
                LimpiarListaProductos();
                sonidoVenta.Play();
                listaCompra = new List<Producto>();
                unaVenta = new Venta(); 
            }

            else
            {
                MessageBox.Show("No se ha efectuado la venta por que no hay productos en ella");
                LimpiarListaProductos();
                listaCompra = new List<Producto>();
            }

        }

        /// <summary>
        /// Método encargado de filtrar según busqueda la lista de productos
        /// </summary>
        /// <param name="productosFiltrados"></param>
        /// <returns></returns>
        List<Producto> ProductoFiltrado(List<Producto> productosFiltrados)
        {
            foreach (Producto producto in PetShop.Productos)
            {
                if (producto.NombreProducto.Contains(tbProducto.Text, StringComparison.OrdinalIgnoreCase))
                {
                    productosFiltrados.Add(producto);
                }
            }

            return productosFiltrados;
        }

        /// <summary>
        /// Evento que va actualizando la lista de productos al soltar una tecla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbProducto_KeyUp(object sender, KeyEventArgs e)
        {
            List<Producto> productosFiltrados = new List<Producto>();
            this.dgvProductos.DataSource = ProductoFiltrado(productosFiltrados);
        }
    }
}