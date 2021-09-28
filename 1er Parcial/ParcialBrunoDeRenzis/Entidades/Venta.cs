using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        Empleado empleado;
        Cliente cliente;
        static int idVenta=0;
        double monto;
        List<Producto> productos;

        public Venta()
        {
            productos = new List<Producto>();
            idVenta++;
        }

        public Venta(Empleado empleado, Cliente cliente, double monto, List<Producto> productos):this()
        {
            this.Empleado = empleado;
            this.Cliente = cliente;
            this.Monto = monto;
            this.Productos = productos;
        }

        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public double Monto { get => monto; set => monto = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
    }
}
