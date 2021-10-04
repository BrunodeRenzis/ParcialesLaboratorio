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

        /// <summary>
        /// Constructor por defecto de la clase Cliente
        /// </summary>
        public Cliente():base()
        {
            this.idCliente = 0;
        }

        /// <summary>
        /// Constructor con parámetros de la clase Cliente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Cliente(string nombre,string apellido):base(nombre,apellido)
        {
            this.IdCliente = IdAutomatico();
        }

        
        public int IdCliente { get => idCliente; set => idCliente = value; }

        /// <summary>
        /// Sobrecarga del método Mostrar para la clase cliente.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del método IdAutomatico para la clase Cliente
        /// </summary>
        /// <returns></returns>
        public override int IdAutomatico()
        {
            for (int i = 0; i <= PetShop.Clientes.Count; i++)
            {
                 IdCliente = i + 1;
            }

            return IdCliente;
        }

        /// <summary>
        /// Sobrecarga del operador + para la clase Cliente, si un cliente no está en la lista devolverá la lista con el cliente agregado, caso contrario retornará la misma lista
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Sobrecarga del operador - para la clase Cliente, si un cliente está en la lista devolverá la lista con el cliente eliminado, caso contrario retornará la misma lista
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Sobrecarga del operador == para la clase Cliente, si un cliente está en la lista devolverá true caso contrario retornará false
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator ==(List<Cliente> clientes, Cliente cliente)
        {
            foreach (Cliente auxCliente in PetShop.Clientes)
            {
                if (cliente.Nombre == auxCliente.Nombre && cliente.Apellido == cliente.Apellido)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// /// Sobrecarga del operador != para la clase Cliente, si un cliente no está en la lista devolverá true caso contrario retornará false

        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator !=(List<Cliente> clientes, Cliente cliente)
        {
            return !(clientes == cliente);
        }


    }
}
