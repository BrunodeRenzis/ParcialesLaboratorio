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
        /// <summary>
        /// Limpia los campos de texto del formulario
        /// </summary>
        public void Limpiar()
        {
            this.tbNombre.Text = String.Empty;
            this.tbApellido.Text = String.Empty;
        }
        /// <summary>
        /// Constructor por defecto de formCliente
        /// </summary>
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que agrega un cliente nuevo si este no existe y tiene todos los datos completos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!Validaciones.NotEmptyString(this.tbNombre.Text, this.tbApellido.Text))
            {
                MessageBox.Show("Faltan campos que completar antes de agregar cliente");
                Limpiar();
            }
            else
            {
                    PetShop.Clientes+=new Cliente(this.tbNombre.Text, this.tbApellido.Text);
                    this.Close();
            }
        }
    }
}
