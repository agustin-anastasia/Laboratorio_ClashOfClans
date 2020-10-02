using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Interfaz IAlmacenamientoTropa que corresponde a la categoría de Edificios y hereda de la interfaz IAlmacenamiento.
    /// </summary>
    interface IAlmacenamientoTropa : IAlmacenamiento
    {
        Int32 CantidadTropas { get; }
    }
}
