using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        double saldo;
        int idCliente;
        public Cliente(int idCliente,string nombre,string apellido,double saldo):base(nombre,apellido)
        {
            this.Saldo = saldo;
            this.IdCliente = IdAutomatico();
        }

        public double Saldo { get => saldo; set => saldo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public override string ToString()
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
    }
}
