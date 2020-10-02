using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Cuartel que corresponde a la categoría de Edificios. Se encarga de generar tropas no oscuras. Hereda de la clase ProduccionDeTropas.
    /// </summary>
    
    class Cuartel : ProduccionDeTropas
    {
        /// <summary>
        /// Constructor de Cuartel. 
        /// </summary>
        public Cuartel()
        {
            Nombre = "Cuartel";
            PrecioOro = 100;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }
    }
}
