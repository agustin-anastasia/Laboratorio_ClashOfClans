using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Ballestas que corresponde a la categoría de Edificios defensivos y hereda de la clase Mixto.
    /// </summary>
    public class Ballestas : Mixto
    {
        /// <summary>
        /// Constructor de Ballestas.
        /// </summary>
        
        public Ballestas()
        {
            Vida = 1500;
            Nombre = "Ballesta";
            Daño = 100;
            PrecioOro = 100;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }
    }
}
