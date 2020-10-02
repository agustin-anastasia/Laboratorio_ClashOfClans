using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Cañones que corresponde a la categoria de Edificios defensivos que solamente pueden atacar tropas terrestres y hereda de la clase Terrestre.
    /// </summary>
    public class Cañones : Terrestre
    {
        /// <summary>
        /// Constructor de Cañones.
        /// </summary>
        
        public Cañones()
        {
            Vida = 470;
            Nombre = "Cañon";
            PrecioOro = 350;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }
    }
}
