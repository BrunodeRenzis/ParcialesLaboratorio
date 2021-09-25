using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimento : Producto
    {
        double peso;

        public Alimento(string nombreProducto,string marcaProducto, double precioProducto, ETipo tipo, double peso, double stock) : base(nombreProducto,marcaProducto, precioProducto, stock, tipo)
        {
            this.Peso = peso;
        }

        public double Peso { get => peso; set => peso = value; }
    }
}
