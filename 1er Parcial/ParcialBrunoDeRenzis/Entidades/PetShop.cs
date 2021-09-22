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

        public static void HardcodeoUsuarios()
        {
            PetShop.Usuarios.Add(new Usuario("bderenzis", "bruno2021",1,EPerfil.Administrador));
            PetShop.Usuarios.Add(new Usuario("lrodriguez", "lucas2021",2,EPerfil.Empleado));
            PetShop.Usuarios.Add(new Usuario("eoggioni", "ezequiel2021",3,EPerfil.Empleado));
        }
    }
}
