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
        int idPersona;

        public Persona()
        {
            this.IdPersona = IdAutomatico();
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
        }

        public Persona(string nombre, string apellido):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.AppendLine($"{this.Apellido}");
            return sb.ToString();
        }

        public virtual int IdAutomatico()
        {
            for (int i = 0; i <= 1; i++)
            {
                idPersona = i + 1;
            }

            return idPersona;
        }
    }
}
