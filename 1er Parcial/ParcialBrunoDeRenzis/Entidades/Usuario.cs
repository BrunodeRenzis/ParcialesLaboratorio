using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario:Persona
    {
        int idUsuario;
        string nombreUsuario;
        string passUsuario;
        EPerfil perfil;

        public Usuario():base()
        {

        }

        public Usuario(string nombre, string apellido,string nombreUsuario,string passUsuario,EPerfil perfil):base(nombre,apellido)
        {
            this.nombreUsuario = nombreUsuario;
            this.passUsuario = passUsuario;
            this.idUsuario = IdAutomatico();
            this.perfil = perfil;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public EPerfil Perfil { get => perfil; set => perfil = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string PassUsuario { get => passUsuario; set => passUsuario = value; }     

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} {this.Apellido} --{this.Perfil}");
            return sb.ToString();
        }

        public override int IdAutomatico()
        {
            return base.IdAutomatico();
        }


    }

    public enum EPerfil
    {
        Administrador,
        Empleado
    }
}
