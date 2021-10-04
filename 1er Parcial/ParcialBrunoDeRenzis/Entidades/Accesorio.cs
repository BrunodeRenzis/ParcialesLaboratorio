using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Accesorio : Producto
    {
        ETipoAccesorio tipoAccesorio;
        /// <summary>
        /// Constructor con parámetros de la clase Accesorio.
        /// </summary>
        /// <param name="nombreProducto"></param>
        /// <param name="marcaProducto"></param>
        /// <param name="precioProducto"></param>
        /// <param name="stock"></param>
        /// <param name="tipo"></param>
        /// <param name="tipoAccesorio"></param>
        public Accesorio(string nombreProducto, string marcaProducto, double precioProducto,double stock, ETipo tipo,ETipoAccesorio tipoAccesorio) : base(nombreProducto, marcaProducto, precioProducto, stock, tipo)
        {
            this.TipoAccesorio = tipoAccesorio;
        }

        public ETipoAccesorio TipoAccesorio { get => tipoAccesorio; set => tipoAccesorio = value; }

        public enum ETipoAccesorio
        {
            Juguete,
            Piedritas,
            Rascador
        }

        /// <summary>
        /// Sobreescritura del método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto accesorio in PetShop.Productos)
            {
                sb.AppendLine($"{base.ToString()}");
                sb.AppendLine($"{this.TipoAccesorio}");
            }
            return sb.ToString();
        }
    }
}
