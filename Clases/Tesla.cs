using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Tesla que corresponde a la categoría de Edificios defensivos y hereda de la clase Mixto.
    /// </summary>
    public class Tesla : Mixto
    {
        /// <summary>
        /// Constructor de Tesla.
        /// </summary>
        public Tesla()
        {
            Vida = 600;
            Nombre = "Torre Tesla";
            PrecioOro = 350;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }
    }
}
