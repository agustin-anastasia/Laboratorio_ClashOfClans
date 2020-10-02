using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Heroe que hereda de la clase Tropa.
    /// Los héroes son el Rey, la Reina y el Warden.
    /// </summary>
    class Heroe : Tropa
    {
        /// <summary>
        /// Metodo PoderEspecial que aplica únicamente a todos los héroes y consiste en incrementar su poder.
        /// </summary>
        public void PoderEspecial()
        {
            PrecioElixirN = 0;
            PrecioElixir = 0;
            PrecioOro = 0;
            Daño += 100;
            Vida += 50;
            Velocidad += 30;
        }
    }
}
