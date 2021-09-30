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

        
    }
}
