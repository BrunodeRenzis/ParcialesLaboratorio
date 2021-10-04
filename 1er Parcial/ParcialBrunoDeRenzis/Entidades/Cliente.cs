using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        int idCliente;
        double saldo;
        bool clienteActual;

        public Cliente():base()
        {
            this.idCliente = 0;
            this.saldo = 0;
            this.clienteActual = false;
        }

        public Cliente(string nombre,string apellido,double saldo):base(nombre,apellido)
        {
            this.Saldo = saldo;
            this.ClienteActual = Validaciones.EsCliente();
            this.IdCliente = IdAutomatico();
        }

        
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public bool ClienteActual { get => clienteActual; set => clienteActual = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.Saldo}");
            return sb.ToString();
        }

        public override int IdAutomatico()
        {
            for (int i = 0; i <= PetShop.Clientes.Count; i++)
            {
                 IdCliente = i + 1;
            }

            return IdCliente;
        }

        public static List<Cliente> operator +(List<Cliente> clientes, Cliente cliente)
        {
            if (clientes != cliente)
            {
                PetShop.Clientes.Add(cliente);
                return PetShop.Clientes;
            }
            else
                return PetShop.Clientes;
        }

        public static List<Cliente> operator -(List<Cliente> clientes, Cliente cliente)
        {

            if (clientes == cliente)
            {
                PetShop.Clientes.Remove(cliente);
                return PetShop.Clientes;
            }
            else
                return PetShop.Clientes;
        }

        public static bool operator ==(List<Cliente> clientes, Cliente cliente)
        {
            foreach (Cliente auxCliente in PetShop.Clientes)
            {
                if (cliente == auxCliente)
                    return true;
            }

            return false;
        }

        public static bool operator !=(List<Cliente> clientes, Cliente cliente)
        {
            return !(clientes == cliente);
        }


    }
}
