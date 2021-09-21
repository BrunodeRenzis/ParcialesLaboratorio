using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class PetShop
    {
        static List<Producto> productos;
        static List<Cliente> clientes;
        static List<Usuario> usuarios;
        static List<Venta> ventas;

        static PetShop()
        {
            Productos = new List<Producto>();
            Clientes = new List<Cliente>();
            Usuarios = new List<Usuario>();
            Ventas = new List<Venta>();
        }

        public static List<Producto> Productos { get => productos; set => productos = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public static List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public static List<Venta> Ventas { get => ventas; set => ventas = value; }
    }
}
