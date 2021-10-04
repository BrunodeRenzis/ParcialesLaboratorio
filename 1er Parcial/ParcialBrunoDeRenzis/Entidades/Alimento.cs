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

        /// <summary>
        /// Constructor con parámetros de la clase Alimento
        /// </summary>
        /// <param name="nombreProducto"></param>
        /// <param name="marcaProducto"></param>
        /// <param name="precioProducto"></param>
        /// <param name="tipo"></param>
        /// <param name="peso"></param>
        /// <param name="stock"></param>
        public Alimento(string nombreProducto,string marcaProducto, double precioProducto, ETipo tipo, double peso, double stock) : base(nombreProducto,marcaProducto, precioProducto, stock, tipo)
        {
            this.Peso = peso;
        }

        public double Peso { get => peso; set => peso = value; }

        /// <summary>
        /// Sobreescritura del método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto alimento in PetShop.Productos)
            {
                sb.AppendLine($"{base.ToString()}");
                sb.AppendLine($"{this.Peso}");
            }
            return sb.ToString();
        }
    }
}
