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
        bool usuarioLogueado = false;
        public Empleado GetEmpleado
        {
            get { return auxEmpleado; }
        }

        public bool UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        static FormLogin()
        {
            PetShop.HardcodeoUsuarios();
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            this.tbUser.Text = String.Empty;
            this.tbPass.Text = String.Empty;
        }

        

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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            foreach (Empleado empleado in PetShop.Empleados)
            {
                this.lsEmpleados.Items.Add(empleado.ToString());
            }
        }

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
