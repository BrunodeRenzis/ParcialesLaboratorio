using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Método que corroborará si un string es empty o no y retornara true si no es empty y false si es empty.
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="cadenaN"></param>
        /// <returns></returns>
        public static bool NotEmptyString(string cadena, params string[] cadenaN)
        {
            if (cadena == String.Empty)
                return false;
            
            return true;
        }

        
        /// <summary>
        /// Corrobora que haya elementos en la lista, devolviendo true si los hay, false si no.
        /// </summary>
        /// <param name="objetosLista"></param>
        /// <returns></returns>
        public static bool ListaInicializada(int objetosLista)
        {
            if (objetosLista > 0)
                return true;

            return false;
        }

        /// <summary>
        /// Verifica que haya stock de un producto para la venta solicitada por parte del usuario.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static bool HayStock(Producto producto,double cantidad)
        {
            foreach (Producto productoLista in PetShop.Productos)
            {
                if (producto.IdProducto == productoLista.IdProducto && producto.Stock - cantidad >= 0)
                    return true;
            }

            return false;
        }

        
        /// <summary>
        /// Devuelve el valor de la caja total del día hasta el momento.
        /// </summary>
        /// <returns></returns>
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
