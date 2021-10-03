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
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbRol.DataSource = Enum.GetValues(typeof(EPerfil));
            foreach (Empleado empleado in PetShop.Empleados)
            {
                this.lsEmpleados.Items.Add(empleado.ToString());
            }
        }

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

        private void ActualizarListaEmpleados()
        {
            this.lsEmpleados.DataSource = null;
            this.lsEmpleados.DataSource = PetShop.Empleados;
        }

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
