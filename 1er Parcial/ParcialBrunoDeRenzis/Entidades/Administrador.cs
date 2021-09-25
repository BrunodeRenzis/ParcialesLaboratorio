using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Usuario
    {
        
        public Administrador(string nombre,string apellido,string nombreUsuario,string passUsuario,EPerfil perfil):base(nombre,apellido,nombreUsuario,passUsuario,perfil)
        {
            
        }
    }
}
