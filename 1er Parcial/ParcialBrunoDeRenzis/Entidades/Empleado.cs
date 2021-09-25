using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Usuario
    {
        int idEmpleado;

        public Empleado():base()
        {

        }

        public Empleado(string nombre,string apellido,string nombreUsuario,string passUsuario,EPerfil perfil):base(nombre,apellido,nombreUsuario,passUsuario,perfil)
        {
            IdEmpleado = IdAutomatico();
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        public override int IdAutomatico()
        {
            for (int i = 0; i <= PetShop.Empleados.Count; i++)
            {
                IdEmpleado = i + 1;
            }

            return IdEmpleado;
        }
    }
}
