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
        /// <summary>
        /// Constructor estático en el cual se instancia una lista por única vez con previa validación a que no hayan sido anteriormente instanciadas
        /// </summary>
        static FormProducto()
        {
            if (!Validaciones.ListaInicializada(PetShop.Productos.Count))
                PetShop.HardcodearProductos();
        }

        /// <summary>
        /// Constructor por defecto del formproducto
        /// </summary>
        public FormProducto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Actualiza la lista de productos y sus propiedades
        /// </summary>
        private void ActualizarDataGrid()
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = PetShop.Productos;
        }

        /// <summary>
        /// Método que devuelve lista de productos filtrados para realizar una búsqueda en nuestra lista de productos.
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
        /// Carga de lista de productos actual al iniciar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProducto_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = PetShop.Productos;
            
        }

        
        /// <summary>
        /// Evento que se ejecuta cada vez que se suelta una tecla
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
