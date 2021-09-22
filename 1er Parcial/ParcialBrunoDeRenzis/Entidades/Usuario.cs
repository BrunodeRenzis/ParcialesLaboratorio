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
        string nombreUsuario;
        string passUsuario;
        EPerfil perfil;
        
        public Usuario()
        {
        }

        public Usuario(string nombre, string apellido,string nombreUsuario,string passUsuario,int idUsuario,EPerfil perfil):base(nombre,apellido)
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

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.AppendLine($"{this.Apellido}");
            sb.AppendLine($"--{this.Perfil}");
            return sb.ToString();
        }


    }

    public enum EPerfil
    {
        Administrador,
        Empleado
    }
}
