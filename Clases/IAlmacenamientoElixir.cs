using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Interfaz IAlmacenamientoElixir que corresponde a la categoría de Edificios y hereda de la interfaz IAlmacenamiento.
    /// </summary>
    interface IAlmacenamientoElixir : IAlmacenamiento
    {
        Int32 CantidadElixir { get; }
    }
}
