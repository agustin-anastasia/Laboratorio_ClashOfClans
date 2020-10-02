using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Mixto correspondiente a la categoría de Edificios defensivos. 
    /// Son todos los edificios capaces de atacar cualquier tipo de tropa.
    /// Hereda de la clase Defensivo.
    /// </summary>
    public class Mixto: Defensivo
    {
        /// <summary>
        /// Constructor de Mixto.
        /// </summary>
        public Mixto()
        {
            Nivel = 1;
        }
    }
}
