using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Terrestre correspondiente a la categoría de Edificios defensivos. Hereda de la clase Defensivo.
    /// Pueden atacar solamente a tropas terrestres.
    /// </summary>
    public class Terrestre: Defensivo
    {
        /// <summary>
        /// Constructor de Terrestre.
        /// </summary>
        public Terrestre()
        {
            Nivel = 1;
        }
    }
}
