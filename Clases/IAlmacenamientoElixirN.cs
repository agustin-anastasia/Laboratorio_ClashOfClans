using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Interfaz IAlmacenamientoElixirN que corresponde a la categoría de Edificios y hereda de la interfaz IAlmacenamiento.
    /// </summary>
    interface IAlmacenamientoElixirN : IAlmacenamiento
    {
        Int32 CantidadElixirN { get; }
    }
}
