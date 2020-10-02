using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Interfaz IEdificio que tiene las propiedades generales que debe tener cualquier Edificio. 
    /// </summary>
    public interface IEdificio
    {                   
        String Nombre { get; }
        Int32 Vida { get; }
        Int32 Nivel { get; }
        Int32 PrecioOro { get; }
        Int32 PrecioElixir { get; }
        Int32 PrecioElixirN { get; }
    }
}
