using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        int idProducto;
        string nombreProducto;
        string marcaProducto;
        double precioProducto;
        double stock;
        ETipo tipo;

        /// <summary>
        /// Constructor por defecto de la clase producto
        /// </summary>
        protected Producto()
        {
            idProducto = 1;
        }

        /// <summary>
        /// Constructor de producto con parámetros
        /// </summary>
        /// <param name="nombreProducto"></param>
        /// <param name="marcaProducto"></param>
        /// <param name="precioProducto"></param>
        /// <param name="stock"></param>
        /// <param name="tipo"></param>
        protected Producto(string nombreProducto,string marcaProducto, double precioProducto,double stock, ETipo tipo):this()
        {
            this.IdProducto = IdAutomatico();
            this.NombreProducto = nombreProducto;
            this.MarcaProducto = marcaProducto;
            this.PrecioProducto = precioProducto;
            this.Tipo = tipo;
            this.Stock = stock;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public string MarcaProducto { get => marcaProducto; set => marcaProducto = value; }
        public double Stock { get => stock; set => stock = value; }

        public enum ETipo
        {
            Alimento,
            Accesorio
        }
        /// <summary>
        /// Genera un id automático a partir de los elementos de la lista.
        /// </summary>
        /// <returns></returns>
        int IdAutomatico()
        {
            for(int i=0;i<=PetShop.Productos.Count;i++)
            {
                IdProducto = i+1;
            }

            return IdProducto;
        }

        /// <summary>
        /// Sobrecarga del operador == , devuelve true si los productos son iguales
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(List<Producto> productos, Producto producto)
        {
            foreach (Producto auxProducto in PetShop.Productos)
            {
                if (producto == auxProducto)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador != , devuelve true si los productos son distintos
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }

        /// <summary>
        /// Sobrecarga del operador + , devuelve una lista con un elemento agregado si los productos son distintos
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static List<Producto> operator +(List<Producto> productos, Producto producto)
        {
            if (productos != producto)
            {
                PetShop.Productos.Add(producto);
                return PetShop.Productos;
            }

            else
                return PetShop.Productos;
        }

        /// <summary>
        /// Sobrecarga del operador - , devuelve una lista con un elemento quitado si los productos son iguales
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static List<Producto> operator -(List<Producto> productos, Producto producto)
        {
            if (productos == producto)
            {
                PetShop.Productos.Remove(producto);
                return PetShop.Productos;
            }
            else
                return PetShop.Productos;
        }

        /// <summary>
        /// Sobrecarga del método tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in PetShop.Productos)
            {
                sb.AppendLine($"{NombreProducto}  ");
                sb.AppendLine($"{MarcaProducto}   ");
                sb.AppendLine($"{PrecioProducto}   ");
            }
            return sb.ToString();
        }
    }
}
