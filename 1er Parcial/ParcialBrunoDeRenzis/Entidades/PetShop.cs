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
            PetShop.Usuarios.Add(new Usuario("Bruno","de Renzis","bderenzis", "bruno2021",1,EPerfil.Administrador));
            PetShop.Usuarios.Add(new Usuario("Lucas","Rodriguez","lrodriguez", "lucas2021",2,EPerfil.Empleado));
            PetShop.Usuarios.Add(new Usuario("Ezequiel","Oggioni","eoggioni", "ezequiel2021",3,EPerfil.Empleado));
        }

        public static void HardcodeoClientes()
        {
            PetShop.Clientes.Add(new Cliente(1,"Cosme","Fulanito",50000));
            PetShop.Clientes.Add(new Cliente(2,"Petin","Partusa",30000));
            PetShop.Clientes.Add(new Cliente(3,"Romeo Rubén","Romero",30000));
            PetShop.Clientes.Add(new Cliente(4,"Mateo","Logía",50000));
            PetShop.Clientes.Add(new Cliente(5,"Elba","Tracio",40000));
            PetShop.Clientes.Add(new Cliente(6,"Susana","Door",40000));
        }
    }
}
