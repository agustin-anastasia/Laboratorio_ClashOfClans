using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Aereo que corresponde a la categoria de Edificios y hereda de la clase Defensivo
    /// </summary>
    public class Aereo: Defensivo
    {
        /// <summary>
        /// Constructor de Aereo.
        /// </summary>
        public Aereo()
        {
            Nivel = 1;
        }
    }
}
