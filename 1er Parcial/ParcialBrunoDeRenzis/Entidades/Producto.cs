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
                idProducto = i+1;
            }

            return idProducto;
        }
    }
}
