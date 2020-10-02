using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Reina correspondiente a la categoría de Héroes. Hereda de la clase Héroe.
    /// Los héroes son tropas especiales ya que no consumen ningún recurso y tienen un poder especial que incrementa su poder.
    /// </summary>
    class Reina : Heroe
    {
        /// <summary>
        /// Constructor de Reina.
        /// </summary>
        public Reina()
        {
            Nombre = "Reina";
            Daño = 160;
            Vida = 725;
            Nivel = 1;
            Velocidad = 24;
            PrecioElixir = 0;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 1;
        }
    }
}
   
