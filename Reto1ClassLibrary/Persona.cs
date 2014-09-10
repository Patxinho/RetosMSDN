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
            if (obj == null)
            {
                return false;
            }
            Persona auxPersona = obj as Persona;
            if (auxPersona == null)
            {
                return false;
            }
            return this.Nombre == auxPersona.Nombre && this.Edad == auxPersona.Edad;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Nombre,this.Edad).GetHashCode();
        }
    }
}
