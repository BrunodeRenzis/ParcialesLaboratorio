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
        public Accesorio(int idProducto, string nombreProducto, string marcaProducto, double precioProducto, ETipo tipo,ETipoAccesorio tipoAccesorio) : base(idProducto, nombreProducto, marcaProducto, precioProducto, tipo)
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
    }
}
