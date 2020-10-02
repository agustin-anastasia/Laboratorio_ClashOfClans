using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Muros correspondiente a la categoría de Edificios defensivos. Hereda de la clase Mixto.
    /// </summary>
    public class Muros : Mixto
    {
        /// <summary>
        /// Constructor de Muros.
        /// </summary>
        public Muros()
        {
            Vida = 300;
            Nombre = "Muro";

        }
    }
}
