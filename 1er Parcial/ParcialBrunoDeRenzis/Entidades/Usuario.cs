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

        /// <summary>
        /// Constructor por defecto de Usuario heredado de persona.
        /// </summary>
        public Usuario():base()
        {

        }

        /// <summary>
        /// Constructor de Usuario con parámetros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="passUsuario"></param>
        /// <param name="perfil"></param>
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

        /// <summary>
        /// Sobreescritura del método Mostrar de la clase Persona. Muestra el nombre y apellido del empleado y su rol.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} {this.Apellido} -- {this.Perfil}");
            return sb.ToString();
        }


        /// <summary>
        /// Sobreescritura del método IdAutomático recorre la lista de usuarios y les asigna un id.
        /// </summary>
        /// <returns></returns>
        public override int IdAutomatico()
        {
            for (int i = 0; i <= PetShop.Clientes.Count; i++)
            {
                IdUsuario = i + 1;
            }

            return IdUsuario;
        }


    }

    public enum EPerfil
    {
        Empleado,
        Administrador
    }
}
