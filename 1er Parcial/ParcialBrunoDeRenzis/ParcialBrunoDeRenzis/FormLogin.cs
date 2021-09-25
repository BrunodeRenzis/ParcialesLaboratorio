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
            FormPrincipal frmPpal = new FormPrincipal();
            bool usuarioEncontrado = false;
            foreach (Empleado empleado in PetShop.Empleados)
            {
                if(empleado.NombreUsuario==tbUser.Text && empleado.PassUsuario == tbPass.Text)
                {
                    this.Hide();
                    frmPpal.ShowDialog();
                    usuarioEncontrado = true;
                    this.Close();
                }
            }
            
            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuario invalido");
                Limpiar();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            foreach (Empleado empleado in PetShop.Empleados)
            {
                this.lsUsuarios.Items.Add(empleado.ToString());
            }
        }

        
    }
}
