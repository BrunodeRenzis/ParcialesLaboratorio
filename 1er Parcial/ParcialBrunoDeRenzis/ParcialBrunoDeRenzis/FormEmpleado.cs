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
    public partial class FormEmpleado : Form
    {
        /// <summary>
        /// Constructor por defecto del formulario
        /// </summary>
        public FormEmpleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga de empleados al iniciar el formEmpleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbRol.DataSource = Enum.GetValues(typeof(EPerfil));
            foreach (Empleado empleado in PetShop.Empleados)
            {
                this.lsEmpleados.Items.Add(empleado.ToString());
            }
        }

        /// <summary>
        /// Genera un nuevo nombre de usuario al agregar un empleado tomando su primer letra de nombre y su apellido.
        /// </summary>
        /// <returns></returns>
        private string GenerarUsuario()
        {
            string nombreUsuario = String.Empty;
            nombreUsuario += this.txtBoxNombre.Text[0];
            for (int i = 0; i < this.txtBoxApellido.Text.Length; i++)
            {
                nombreUsuario += this.txtBoxApellido.Text[i];
            }

            return nombreUsuario;
        }

        /// <summary>
        /// Genera una nueva password al agregar un empleado tomando su apellido completo y el año actual.
        /// </summary>
        /// <returns></returns>
        private string GenerarContraseña()
        {
            string passUsuario = String.Empty;
            for (int i = 0; i < this.txtBoxNombre.Text.Length; i++)
            {
                passUsuario += this.txtBoxNombre.Text[i];
            }
            passUsuario += DateTime.Now.Year.ToString();
            return passUsuario;
        }

        /// <summary>
        /// Actualización de la lista de empleados en el data grid.
        /// </summary>
        private void ActualizarListaEmpleados()
        {
            this.lsEmpleados.DataSource = null;
            this.lsEmpleados.DataSource = PetShop.Empleados;
        }

        /// <summary>
        /// Evento que valida el registro de un nuevo empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            

            if(!Validaciones.NotEmptyString(this.txtBoxNombre.Text,this.txtBoxApellido.Text,this.cmbRol.SelectedValue.ToString()))
            {
                MessageBox.Show("Complete los campos antes de registrar al empleado", "Error");
            }
            else
            {
                PetShop.Empleados += new Empleado(this.txtBoxNombre.Text, this.txtBoxApellido.Text, GenerarUsuario(), GenerarContraseña(), (EPerfil)this.cmbRol.SelectedValue);
                ActualizarListaEmpleados();
            }

        }

        /// <summary>
        /// Evento que valida la eliminación de un empleado existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.NotEmptyString(this.txtBoxNombre.Text, this.txtBoxApellido.Text, this.cmbRol.SelectedItem.ToString()))
            {
                MessageBox.Show("Se deben completar los campos antes de realizar una acción");
            }

            else
            {   
                PetShop.Empleados-=(Empleado)this.lsEmpleados.SelectedValue;
                ActualizarListaEmpleados();
            }


        }

        /// <summary>
        /// Evento que autocompleta los textbox con campos de empleado para una más rápida gestión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Empleado empleado in PetShop.Empleados)
            {
                if (lsEmpleados.SelectedItem.ToString().Contains(empleado.Nombre))
                {
                    this.txtBoxNombre.Text = empleado.Nombre;
                    this.txtBoxApellido.Text = empleado.Apellido;
                    this.cmbRol.Text = empleado.Perfil.ToString();
                }
            }
        }

        /// <summary>
        /// Evento que modifica los datos de un Empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool empleadoModificado = false;
            bool esAdministrador = true;
            foreach (Empleado empleado in PetShop.Empleados)
            {
                if (lsEmpleados.SelectedItem.ToString().Contains(empleado.Nombre) && lsEmpleados.SelectedItem.ToString().Contains(empleado.Apellido) && empleado.Perfil != EPerfil.Administrador)
                {
                    empleado.Nombre = this.txtBoxNombre.Text;
                    empleado.Apellido = this.txtBoxApellido.Text;
                    empleado.Perfil = (EPerfil)this.cmbRol.SelectedValue;
                    empleadoModificado = true;
                    esAdministrador = false;
                    ActualizarListaEmpleados();
                }
            }

            if(!empleadoModificado && !esAdministrador)
                MessageBox.Show("Ha habido un error al intentar modificar el empleado");

            if (esAdministrador && !empleadoModificado)
                MessageBox.Show("No se puede modificar datos de un administrador");
        }
    }
}
