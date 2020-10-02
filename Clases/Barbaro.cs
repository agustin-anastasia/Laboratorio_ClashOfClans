using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Barbaro correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    
    class Barbaro : TropaNormal
    {
        /// <summary>
        /// Constructor de Barbaro.
        /// </summary>
       
        public Barbaro()
        {          
            Velocidad = 20;
            Vida = 45;
            Daño = 8;
            Nivel = 1;
            Nombre = "Barbaro";
            PrecioElixir = 25;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 40;
        }
    }
}

