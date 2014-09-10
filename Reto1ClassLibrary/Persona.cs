using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1ClassLibrary
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public override bool Equals(object obj)
        {
            Persona auxPersona = obj as Persona;

            return this.Nombre == auxPersona.Nombre && this.Edad == auxPersona.Edad;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
