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

        protected Producto()
        {
            idProducto = 1;
        }
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

        int IdAutomatico()
        {
            for(int i=0;i<=PetShop.Productos.Count;i++)
            {
                IdProducto = i+1;
            }

            return IdProducto;
        }

        public static bool operator ==(List<Producto> productos, Producto producto)
        {
            foreach (Producto auxProducto in PetShop.Productos)
            {
                if (producto == auxProducto)
                    return true;
            }
            return false;
        }

        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }

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
