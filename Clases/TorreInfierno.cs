using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase TorreInfierno que corresponde a la categoría de Edificios defensivos y hereda de la clase Mixto.
    /// </summary>
    public class TorreInfierno : Mixto
    {
        /// <summary>
        /// Constructor de TorreInfierno.
        /// </summary>
        public TorreInfierno()
        {
            Vida = 1500;
            Nombre = "Torre Infierno";
            PrecioOro = 350;
            PrecioElixir = 0;
            PrecioElixirN = 0;

        }
    }
}
