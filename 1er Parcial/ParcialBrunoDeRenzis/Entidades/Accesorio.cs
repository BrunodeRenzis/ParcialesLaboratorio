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
