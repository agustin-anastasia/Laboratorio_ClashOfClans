using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Aguila que corresponde a la categoria de Edificios y hereda de la clase Mixto.
    /// </summary>
    public class Aguila : Mixto
    {
        /// <summary>
        /// Constructor Aguila.
        /// </summary
        public Aguila()
        {
            Vida = 4000;
            Nombre = "Aguila de Artilleria";
            Daño = 200;
            PrecioOro = 100;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }
    }
}
