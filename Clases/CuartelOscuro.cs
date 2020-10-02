using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase CuartelOscuro que corresponde a la categoría de Edificios. Se encarga de generar tropas oscuras. Hereda de la clase ProduccionDeTropas.
    /// </summary>
    class CuartelOscuro : ProduccionDeTropas
    {
        /// <summary>
        /// Constructor de CuartelOscuro. 
        /// </summary>
        public CuartelOscuro()
        {
            Nombre = "Cuartel Oscuro";
            PrecioOro = 100;
            PrecioElixir = 100;
            PrecioElixirN = 200;
        }
    }
}
