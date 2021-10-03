using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class PetShop
    {
        static List<Cliente> clientes;
        static List<Producto> productos;
        static List<Empleado> empleados;
        static List<Venta> ventas;

        static PetShop()
        {
            Productos = new List<Producto>();
            Clientes = new List<Cliente>();
            Empleados = new List<Empleado>();
            Ventas = new List<Venta>();
        }

        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public static List<Empleado> Empleados { get => empleados; set => empleados = value; }
        public static List<Venta> Ventas { get => ventas; set => ventas = value; }
        public static List<Producto> Productos { get => productos; set => productos = value; }

        public static void HardcodeoUsuarios()
        {
            PetShop.Empleados+=new Empleado("Bruno","de Renzis","bderenzis", "bruno2021",EPerfil.Administrador);
            PetShop.Empleados+=new Empleado("Lucas","Rodriguez","lrodriguez", "lucas2021",EPerfil.Empleado);
            PetShop.Empleados+=new Empleado("Ezequiel","Oggioni","eoggioni", "ezequiel2021",EPerfil.Empleado);
        }

        public static void HardcodeoClientes()
        {
            PetShop.Clientes+=new Cliente("Cosme","Fulanito",50000);
            PetShop.Clientes+=new Cliente("Petin","Partusa",30000);
            PetShop.Clientes+=new Cliente("Romeo Rubén","Romero",30000);
            PetShop.Clientes+=new Cliente("Mateo","Logía",50000);
            PetShop.Clientes+=new Cliente("Elba","Rack Obama",20000);
            PetShop.Clientes+=new Cliente("Esther","Píscore",50000);
            PetShop.Clientes+=new Cliente("Elba","Tracio",40000);
            PetShop.Clientes+=new Cliente("Susana","Door",40000);
        }

        public static void HardcodearProductos()
        {
            PetShop.Productos+=new Alimento("Power Balance", "Dog Chow", 4000, Producto.ETipo.Alimento, 7,20);
            PetShop.Productos+=new Alimento("Power Ultra", "Pedigree", 3000, Producto.ETipo.Alimento, 7,20);
            PetShop.Productos+=new Alimento("Plus Ultra", "Purina", 5000, Producto.ETipo.Alimento, 7,20);
            PetShop.Productos+=new Alimento("Sabrosito", "Sabrositos", 2000, Producto.ETipo.Alimento, 2,30);
            PetShop.Productos+=new Alimento("Kitten", "Royal Cannin", 7000, Producto.ETipo.Alimento, 7,15);
            PetShop.Productos+=new Accesorio("Huesito", "Happy Dog", 500,10, Producto.ETipo.Accesorio, Accesorio.ETipoAccesorio.Juguete);
            PetShop.Productos+=new Accesorio("Huesito Premium", "Happy Dog Chetardo", 1500,15, Producto.ETipo.Accesorio, Accesorio.ETipoAccesorio.Juguete);
            PetShop.Productos+=new Accesorio("Ratón", "Happy Cat", 500,20, Producto.ETipo.Accesorio, Accesorio.ETipoAccesorio.Juguete);
            PetShop.Productos+=new Accesorio("Piedritas absorbentes perfumadas", "Smelly Cat", 800,30, Producto.ETipo.Accesorio, Accesorio.ETipoAccesorio.Piedritas);
            PetShop.Productos+=new Accesorio("Rascador chico", "Happy Cat", 2500,14, Producto.ETipo.Accesorio, Accesorio.ETipoAccesorio.Rascador);
            PetShop.Productos+=new Accesorio("Rascador grande", "Happy Cat", 4500,15, Producto.ETipo.Accesorio, Accesorio.ETipoAccesorio.Rascador);
        }

        public static void HardcodearVentas()
        {
            Producto prod1 = new Alimento("Power Balance", "Dog Chow", 4000, Producto.ETipo.Alimento, 7, 20);
            
            PetShop.Ventas += new Venta(new Empleado("Bruno", "de Renzis", "bderenzis", "bruno2021", EPerfil.Administrador), new Cliente("Cosme", "Fulanito", 50000),2500, new List<Producto> {prod1});
            PetShop.Ventas += new Venta(new Empleado("Bruno", "de Renzis", "bderenzis", "bruno2021", EPerfil.Administrador), new Cliente("Susana", "Horia", 10000), 5000, new List<Producto> { prod1 });
            PetShop.Ventas += new Venta(new Empleado("Bruno", "de Renzis", "bderenzis", "bruno2021", EPerfil.Administrador), new Cliente("Pepper", "Clemens", 20000), 10000, new List<Producto> { prod1 });
        }



    }
}
