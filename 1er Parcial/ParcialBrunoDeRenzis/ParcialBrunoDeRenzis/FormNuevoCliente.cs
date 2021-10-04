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
    public partial class FormNuevoCliente : Form
    {
        public void Limpiar()
        {
            this.tbNombre.Text = String.Empty;
            this.tbApellido.Text = String.Empty;
        }
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!Validaciones.NotEmptyString(this.tbNombre.Text, this.tbApellido.Text))
            {
                MessageBox.Show("Faltan campos que completar antes de agregar cliente");
                Limpiar();
            }
            else
            {
                    PetShop.Clientes.Add(new Cliente(this.tbNombre.Text, this.tbApellido.Text));
                    this.Close();
            }
        }
    }
}
