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
    public partial class FormNuevoEmpleado : Form
    {
        public FormNuevoEmpleado()
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
            PetShop.Empleados+=new Empleado(this.txtBoxNombre.Text,this.txtBoxApellido.Text,GenerarUsuario(),GenerarContraseña(),(EPerfil)this.cmbRol.SelectedValue);
            ActualizarListaEmpleados();
        }
    }
}
