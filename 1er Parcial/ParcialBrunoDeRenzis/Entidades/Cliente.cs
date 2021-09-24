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

        public Cliente(int id,string nombre,string apellido,double saldo):base(nombre,apellido)
        {
            this.Saldo = saldo;
        }

        public double Saldo { get => saldo; set => saldo = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.Saldo}");
            return base.ToString();
        }
    }
}
