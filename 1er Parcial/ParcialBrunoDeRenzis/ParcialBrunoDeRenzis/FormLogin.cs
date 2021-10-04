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
    public partial class FormLogin : Form
    {
        Empleado auxEmpleado;
        static bool usuarioLogueado = false;
        public Empleado GetEmpleado
        {
            get { return auxEmpleado; }
        }

        public static bool UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        /// <summary>
        /// Constructor estático en el cual se instancia una lista por única vez
        /// </summary>
        static FormLogin()
        {
            PetShop.HardcodeoUsuarios();
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpia los campos de usuario y contraseña del formulario
        /// </summary>
        void Limpiar()
        {
            this.tbUser.Text = String.Empty;
            this.tbPass.Text = String.Empty;
        }

        

        /// <summary>
        /// Valida los datos ingresados con los correspondientes a la lista de usuarios y permite el acceso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            foreach (Empleado empleado in PetShop.Empleados)
            {
                if(empleado.NombreUsuario==tbUser.Text && empleado.PassUsuario == tbPass.Text)
                {
                    UsuarioLogueado = true;
                    auxEmpleado = empleado;
                    DialogResult=DialogResult.Yes;
                    this.Close();
                }
            }
            
            if (!UsuarioLogueado)
            {
                MessageBox.Show("Usuario invalido");
                Limpiar();
            }
        }

        /// <summary>
        /// Carga la lista de empleados para su visualización
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            foreach (Empleado empleado in PetShop.Empleados)
            {
                this.lsEmpleados.Items.Add(empleado.ToString());
            }
        }

        /// <summary>
        /// Autocompleta los datos de nombre de usuario y contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Empleado empleado in PetShop.Empleados)
            {
                if (lsEmpleados.SelectedItem.ToString().Contains(empleado.Nombre))
                {
                    this.tbUser.Text = empleado.NombreUsuario;
                    this.tbPass.Text = empleado.PassUsuario;
                }
            }
        }
    }
}
