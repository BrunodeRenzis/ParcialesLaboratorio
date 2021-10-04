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

        /// <summary>
        /// Constructor por defecto de empleado heredado de Persona.
        /// </summary>
        public Empleado():base()
        {
        }

        /// <summary>
        /// Constructor con parámetros utilizado para obtener solo nombre y apellido de un empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Empleado(string nombre,string apellido):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        /// <summary>
        /// Constructor con parámetros para obtener un empleado completo.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="passUsuario"></param>
        /// <param name="perfil"></param>
        public Empleado(string nombre,string apellido,string nombreUsuario,string passUsuario,EPerfil perfil):base(nombre,apellido,nombreUsuario,passUsuario,perfil)
        {
            IdEmpleado = IdAutomatico();
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        /// <summary>
        /// Sobrecarga del método IdAutomático para recorrer todos los empleados y asignarles un Id.
        /// </summary>
        /// <returns></returns>
        public override int IdAutomatico()
        {
            for (int i = 0; i <= PetShop.Empleados.Count; i++)
            {
                IdEmpleado = i + 1;
            }

            return IdEmpleado;
        }

        /// <summary>
        /// Sobrecarga del operador +, si un empleado no se encuentra en la lista, lo agrega y devuelve esa lista. Caso contrario devuelve la misma lista.
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static List<Empleado> operator + (List<Empleado> empleados,Empleado empleado)
        {
                if (empleados != empleado)
                {
                    PetShop.Empleados.Add(empleado);
                    return PetShop.Empleados;
                }
                else
                    return PetShop.Empleados;
        }

        /// <summary>
        /// Sobrecarga del operador -, si un empleado se encuentra en la lista, lo elimina y devuelve esa lista. Caso contrario devuelve la misma lista.
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static List<Empleado> operator -(List<Empleado> empleados, Empleado empleado)
        {
            
                if (empleados == empleado)
                {
                    PetShop.Empleados.Remove(empleado);
                    return PetShop.Empleados;
                }
                else
                    return PetShop.Empleados;
        }

        /// <summary>
        /// Sobrecarga del operador ==, si un empleado no se encuentra en la lista, devuelve false. Caso contrario devuelve true.
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static bool operator == (List<Empleado> empleados, Empleado empleado)
        {
            foreach (Empleado auxEmpleado in PetShop.Empleados)
            {
                if (empleado == auxEmpleado)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=, si un empleado no se encuentra en la lista, devuelve true. Caso contrario devuelve false.
        /// </summary>
        /// <param name="empleados"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static bool operator !=(List<Empleado> empleados, Empleado empleado)
        {
            return !(empleados==empleado);
        }
        
        /// <summary>
        /// Sobreescritura del método Mostrar de la clase Persona
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{IdEmpleado}, ");
            sb.Append(base.Mostrar());

            return sb.ToString();
        }
    }
}
