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
