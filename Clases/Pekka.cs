using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Pekka correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Pekka : TropaNormal
    {
        /// <summary>
        /// Constructor Pekka.
        /// </summary>
        public Pekka()
        {
            Velocidad = 16;
            Vida = 2800;
            Daño = 240;
            Nivel = 1;
            Nombre = "Pekka";
            PrecioElixir = 28000;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 5;
        }
    }
}
