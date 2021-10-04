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
        int nroVenta;
        double monto;
        List<Producto> productos;

        public Venta()
        {
            productos = new List<Producto>();
            idVenta++;
        }

        /// <summary>
        /// Constructor para hardcodear una venta, solo con fines de muestra
        /// </summary>
        /// <param name="empleado"></param>
        /// <param name="cliente"></param>
        /// <param name="monto"></param>
        /// <param name="productos"></param>
        public Venta(Empleado empleado, Cliente cliente, double monto, List<Producto> productos) :this()
        {
            this.NroVenta = idVenta;
            this.Empleado = empleado;
            this.Cliente = cliente;
            this.Productos = productos;
            this.Monto = monto;
        }

        /// <summary>
        /// Constructor para generar una venta en el sistema. Calcula el monto total a partir de los productos.
        /// </summary>
        /// <param name="empleado"></param>
        /// <param name="cliente"></param>
        /// <param name="productos"></param>
        public Venta(Empleado empleado, Cliente cliente, List<Producto> productos) : this()
        {
            this.NroVenta = idVenta;
            this.Empleado = empleado;
            this.Cliente = cliente;
            this.Productos = productos;
        }

        public int NroVenta { get => nroVenta; set => nroVenta = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public double Monto { get => monto; set => monto = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }

        

        public double CalcularMonto(int cantidad)
        {
            double monto = 0;
            for (int i = 0; i < Productos.Count; i++)
            {
                monto += Productos[i].PrecioProducto*cantidad;
            }
            return monto;
        }

        

        public static bool operator ==(List<Venta> productos, Venta producto)
        {
            foreach (Venta auxProducto in PetShop.Ventas)
            {
                if (producto == auxProducto)
                    return true;
            }
            return false;
        }

        public static bool operator !=(List<Venta> productos, Venta producto)
        {
            return !(productos == producto);
        }
        public static List<Venta> operator + (List<Venta> ventas, Venta venta)
        {
            
                if (ventas!=venta)
                {
                    PetShop.Ventas.Add(venta);
                    return PetShop.Ventas;
                }

            
               return PetShop.Ventas;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Venta {NroVenta}    ");
            sb.AppendLine($"Empleado {Empleado.Nombre} {Empleado.Apellido}    ");
            sb.AppendLine($"Cliente {Cliente.Nombre} {Cliente.Apellido}    ");
            sb.AppendLine("Productos: ");
            foreach (Producto producto in Productos)
            {
                sb.AppendLine($"{producto.NombreProducto}    ");
            }
            sb.AppendLine($"Valor total: {Monto}\n");
            return sb.ToString();
        }
    }
}
