using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reto1ClassLibrary
{
    public class Reto1
    {
        //METODO PARA ORDENAR LA LISTA  (Linq)
        //RECIBE UNA LIST<Persona>
        //DEVUELVE UNA LIST<Persona>
       public static List<Persona> OrdenarLista(List<Persona> personas){

           if (personas != null)
           {
               return personas.OrderByDescending(x => x.Edad).ThenBy(x => x.Nombre).ToList();
           }
           else
           {
               return null;
           }

       }  
    }
}
