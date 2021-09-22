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
        ETipo tipo;

        protected Producto(int idProducto, string nombreProducto,string marcaProducto, double precioProducto, ETipo tipo)
        {
            this.IdProducto = idProducto;
            this.NombreProducto = nombreProducto;
            this.MarcaProducto = marcaProducto;
            this.PrecioProducto = precioProducto;
            this.Tipo = tipo;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public string MarcaProducto { get => marcaProducto; set => marcaProducto = value; }

        public enum ETipo
        {
            Alimento,
            Accesorio
        }
    }
}
