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
        
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        

        

        private void Login()
        {
            FormLogin frm = new FormLogin();
            this.empleadosToolStripMenuItem.Enabled = false;
            this.verVentasToolStripMenuItem.Enabled = false;
            if (frm.ShowDialog() == DialogResult.Yes)

            {
                if (frm.GetEmpleado.Perfil == EPerfil.Administrador)
                {
                    this.empleadosToolStripMenuItem.Enabled = true;
                    this.verVentasToolStripMenuItem.Enabled = true;
                }
            }

            else
                this.Close();
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Login();
        }


        
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frmCli = new FormCliente();
            frmCli.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenta frm = new FormVenta();
            frm.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void altaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoEmpleado formEmp = new FormNuevoEmpleado();
            formEmp.ShowDialog();
        }    

        private void menuPpal_MouseHover(object sender, EventArgs e)
        {
            menúToolStripMenuItem.ShowDropDown();
            this.timerMenú.Enabled = false;
            
            if(MousePosition.X>490 || MousePosition.Y>590)
            {
                menúToolStripMenuItem.HideDropDown();
            }
        }

        private void menúToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.timerMenú.Enabled = true;
            this.timerMenú.Interval = 1500;
            this.timerMenú.Start();
        }
    }
}
