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

        public Persona()
        {
            this.Id = IdAutomatico();
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
        protected int Id { get => id; set => id = value; }

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
                id = i + 1;
            }

            return id;
        }
    }
}
