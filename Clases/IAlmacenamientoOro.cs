using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Interfaz IAlmacenamientoOro que corresponde a la categoría de Edificios y hereda de la interfaz IAlmacenamiento.
    /// </summary>
    interface IAlmacenamientoOro : IAlmacenamiento
    {
        Int32 CantidadOro { get; }
    }
}
