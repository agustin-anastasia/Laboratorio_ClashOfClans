using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Valkiria correspondiente a la categoría de Tropas y hereda de la clase TropaOscura.
    /// </summary>
    class Valkiria : TropaOscura
    {
        /// <summary>
        /// Constructor de Valkiria.
        /// </summary>
        public Valkiria()
        {
            Vida = 750;
            Nombre = "Valkiria";
            Daño = 94;
            PrecioElixirN = 70;
            PrecioElixir = 0;
            PrecioOro = 0;
            Nivel = 1;
            Velocidad = 24;
            Poblacion = 2;
        }
    }
}
