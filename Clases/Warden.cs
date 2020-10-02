using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Warden correspondiente a la categoría de Héroes. Hereda de la clase Héroe.
    /// Los héroes son tropas especiales ya que no consumen ningún recurso y tienen un poder especial que incrementa su poder.
    /// </summary>
    class Warden : Heroe
    {
        /// <summary>
        /// Constructo de Warden.
        /// </summary>
        public Warden()
        {
            Nombre = "Warden";
            Daño = 50;
            Vida = 1000;
            Nivel = 1;
            Velocidad = 16;
            PrecioElixir = 0;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 5;
        }
    }
}
