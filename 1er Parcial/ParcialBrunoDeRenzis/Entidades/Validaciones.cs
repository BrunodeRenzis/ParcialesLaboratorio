using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        public static bool NotEmptyString(string cadena, params string[] cadenaN)
        {
            if (cadena == String.Empty)
                return false;
            
            return true;
        }

        public static bool EsCliente()
        {
            bool esCliente = true;
            foreach(Cliente cliente in PetShop.Clientes)
            {
                if (PetShop.Clientes!=cliente)
                    esCliente = false;
            }
            return esCliente;
        }

        public static bool ListaInicializada(int objetosLista)
        {
            if (objetosLista > 0)
                return true;

            return false;
        }

        public static bool HayStock(Producto producto,double cantidad)
        {
            foreach (Producto productoLista in PetShop.Productos)
            {
                if (producto.IdProducto == productoLista.IdProducto && producto.Stock - cantidad >= 0)
                    return true;
            }

            return false;
        }

        public static Cliente SaldoDisponible(double montoVenta, Cliente cliente)
        {
            foreach (Cliente auxCliente in PetShop.Clientes)
            {
                if(cliente.IdCliente == auxCliente.IdCliente && cliente.Saldo-montoVenta>0)
                {
                    cliente.Saldo -= montoVenta;
                }
            }
            return cliente;
        }

        public static double CajaTotal()
        {
            double montoTotal = 0;
            foreach (Venta venta in PetShop.Ventas)
            {
                montoTotal += venta.Monto;
            }

            return montoTotal;
        }



        
    }
}
