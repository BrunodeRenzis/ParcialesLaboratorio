using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int id;

        /// <summary>
        /// Constructor por defecto de la clase Persona
        /// </summary>
        public Persona()
        {
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
        }

        /// <summary>
        /// Constructor con parámetros de la clase persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(string nombre, string apellido):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        protected int Id { get => id; set => id = value; }

        /// <summary>
        /// Creación del método virtual Mostrar, mostrará datos básicos de cualquier persona para que luego se complete la descripción con las diferencias entre cliente o empleado.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.AppendLine($"{this.Apellido}");
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Creación del método abstracto IdAutomático.
        /// </summary>
        /// <returns></returns>
        public abstract int IdAutomatico();


    }
}
