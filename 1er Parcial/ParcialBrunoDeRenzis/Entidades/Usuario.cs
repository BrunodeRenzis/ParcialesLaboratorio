using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        int idUsuario;
        string nombreUsuario;
        string passUsuario;
        EPerfil perfil;
        
        public Usuario()
        {
        }

        public Usuario(string nombreUsuario,string passUsuario,int idUsuario,EPerfil perfil)
        {
            this.nombreUsuario = nombreUsuario;
            this.passUsuario = passUsuario;
            this.idUsuario = idUsuario;
            this.perfil = perfil;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public EPerfil Perfil { get => perfil; set => perfil = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string PassUsuario { get => passUsuario; set => passUsuario = value; }

        /*public void HardcodeoUsuarios()
        {
            PetShop.Usuarios.Add(new Usuario("bderenzis", "bruno2021",1,EPerfil.Administrador));
            PetShop.Usuarios.Add(new Usuario("lrodriguez", "lucas2021",2,EPerfil.Empleado));
            PetShop.Usuarios.Add(new Usuario("eoggioni", "ezequiel2021",3,EPerfil.Empleado));
        }*/

        

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.IdUsuario}");
            sb.AppendLine($"{this.NombreUsuario}");
            sb.AppendLine($"{this.PassUsuario}");
            sb.AppendLine($"{this.Perfil.ToString()}");
            return sb.ToString();
        }


    }

    public enum EPerfil
    {
        Administrador,
        Empleado
    }
}
