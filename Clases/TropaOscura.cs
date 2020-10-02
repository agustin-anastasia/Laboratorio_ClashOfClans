using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase TropaOscura que hereda de la clase Tropa.
    /// Las​ ​tropas​ ​oscuras​ ​son:​ ​esbirros,​ ​montapuercos,​ ​valkirias,​ ​golem,​ ​brujas,​ ​lavas​ ​y​ ​lanzarocas.​ 
    /// </summary>
    public class TropaOscura: Tropa
    {
        /// <summary>
        /// Propiedad de las Tropas oscuras.
        /// </summary>
        public Int32 ConsumoOscuro { get; set; }
    }
}
