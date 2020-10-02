using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase TorreDeMagos que corresponde a la categoría de Edificios defensivos y hereda de la clase Mixto.
    /// </summary>
    public class TorreDeMagos : Mixto
    {
        /// <summary>
        /// Constructor de TorreDeMagos.
        /// </summary>
        public TorreDeMagos()
        {
            Vida = 620;
            Nombre = "Torre de Magos";
            PrecioOro = 350;
            PrecioElixir = 0;
            PrecioElixirN = 0;

        }
    }
}
