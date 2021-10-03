using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        public static bool NotEmptyString(string cadena, params string[] cadenaN)
        {
            if (cadena == String.Empty)
                return false;
            
            return true;
        }

        public static bool EsCliente()
        {
            bool esCliente = true;
            foreach(Cliente cliente in PetShop.Clientes)
            {
                if (PetShop.Clientes!=cliente)
                    esCliente = false;
            }
            return esCliente;
        }


        
    }
}
