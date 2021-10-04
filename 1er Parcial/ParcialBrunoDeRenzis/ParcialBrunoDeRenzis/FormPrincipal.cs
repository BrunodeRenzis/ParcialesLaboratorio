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
    public partial class FormPrincipal : Form
    {
        Empleado empleadoLogueado;

        public Empleado EmpleadoLogueado { get => empleadoLogueado; set => empleadoLogueado = value; }
        /// <summary>
        /// Constructor por defecto del formulario principal inicializando componentes
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Método que valida el resultado del login y según el tipo de usuario valida las funciones disponibles y el color de fondo
        /// </summary>
        private void Login()
        {
            FormLogin frm = new FormLogin();
            this.empleadosToolStripMenuItem.Enabled = false;
            this.verVentasToolStripMenuItem.Enabled = false;
            this.BackColor = Color.DarkTurquoise;
            if (frm.ShowDialog() == DialogResult.Yes && FormLogin.UsuarioLogueado)
            {
                PetShop.Empleado = frm.GetEmpleado;
                if (frm.GetEmpleado.Perfil == EPerfil.Administrador)
                {
                    this.empleadosToolStripMenuItem.Enabled = true;
                    this.verVentasToolStripMenuItem.Enabled = true;
                    this.BackColor = Color.Goldenrod;
                }
            }

            else
                this.Close();
        }

        /// <summary>
        /// Evento previo al cierre, pregunta si está seguro de que desea salir, si no desea salir, se cancela el evento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// Carga del formulario principal y se asegura de que las listas de productos estén previamente inicializadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Login();
            if (!Validaciones.ListaInicializada(PetShop.Productos.Count))
                PetShop.HardcodearProductos();
        }


        /// <summary>
        /// Abre el menú de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frmCli = new FormCliente();
            frmCli.ShowDialog();
        }

        /// <summary>
        /// Abre el menú de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.ShowDialog();
        }

        /// <summary>
        /// Abre el menú de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenta frm = new FormVenta();
            frm.ShowDialog();
        }

       /// <summary>
       /// Despliega el menú si se pasa por encima del toolstrip, si se sale del elemento se oculta el menú.
       /// </summary>
       /// <paam name="sender"></param>
       /// <param name="e"></param>
        private void menuPpal_MouseHover(object sender, EventArgs e)
        {
            menúToolStripMenuItem.ShowDropDown();
            this.timerMenú.Enabled = false;
            
            if(MousePosition.X>490 || MousePosition.Y>590)
            {
                menúToolStripMenuItem.HideDropDown();
            }
        }

        /// <summary>
        /// Se oculta el menú al no estar sobre el.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menúToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.timerMenú.Enabled = true;
            this.timerMenú.Interval = 100;
            this.timerMenú.Start();
        }

        /// <summary>
        /// Despliega el menú de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleado formEmp = new FormEmpleado();
            formEmp.ShowDialog();
        }

        /// <summary>
        /// Despliega el menú de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentasRealizadas frmVentasRealizadas = new FormVentasRealizadas();
            frmVentasRealizadas.ShowDialog();
        }
    }
}
