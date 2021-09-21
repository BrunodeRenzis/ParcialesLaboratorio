using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario:Persona
    {
        int idUsuario;
        EPerfil perfil;
        List<Usuario> usuarios;


        
        public Usuario()
        {
            this.Usuarios = new List<Usuario>();
        }

        public Usuario(string nombre,string apellido,int id,EPerfil perfil):base(nombre,apellido)
        {
            this.perfil = perfil;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public EPerfil Perfil { get => perfil; set => perfil = value; }
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        public void HardcodeoUsuarios()
        {
            PetShop.Usuarios.Add(new Usuario("bderenzis", "bruno2021",1,EPerfil.Administrador));
            PetShop.Usuarios.Add(new Usuario("lrodriguez", "lucas2021",2,EPerfil.Empleado));
            PetShop.Usuarios.Add(new Usuario("eoggioni", "ezequiel2021",3,EPerfil.Empleado));
        }

        public static bool operator == (Usuario usuario,string nombre)
        {
            foreach (Usuario usuarioComparacion in PetShop.Usuarios)
            {
                if(usuario.Nombre == usuarioComparacion.Nombre)
                {
                    return true;
                }
            }
            PetShop.Usuarios.Add(usuario);
            return false;
        }

        public static bool operator !=(Usuario usuario, string nombre)
        {
            return !(usuario!=nombre);
        }




    }

    public enum EPerfil
    {
        Administrador,
        Empleado
    }
}
