using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Antiaereos que corresponde a la categoria de Edificios defensivos que solamente pueden atacar tropas aéreas y hereda de la clase Aereo.
    /// </summary>
    public class Antiaereos : Aereo
    {
        /// <summary>
        /// Constructor de la clase Antiaereo.
        /// </summary>
        
        public Antiaereos()
        {
            Nombre = "Antiaéreos";
            Vida = 800;
            Daño = 400;
            PrecioOro = 100;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }
    }
}
