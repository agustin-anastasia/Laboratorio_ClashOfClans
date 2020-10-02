using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase DragonBebe correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class DragonBebe :TropaNormal
    {
        /// <summary>
        /// Constructor de DragonBebe.
        /// </summary>
        public DragonBebe()
        {
            Velocidad = 16;
            Vida = 1900;
            Daño = 75;
            Nivel = 1;
            Nombre = "Bebé Dragon";
            PrecioElixir = 15000;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 5;
        }
    }
}
