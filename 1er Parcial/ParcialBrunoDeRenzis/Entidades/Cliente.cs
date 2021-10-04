﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        int idCliente;

        public Cliente():base()
        {
            this.idCliente = 0;
        }

        public Cliente(string nombre,string apellido):base(nombre,apellido)
        {
            this.IdCliente = IdAutomatico();
        }

        
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
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
