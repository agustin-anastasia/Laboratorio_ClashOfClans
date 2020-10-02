using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Interface IProduccionRecursos que hereda de la interfaz IEdificio.
    /// </summary>
    public interface IProduccionRecursos: IEdificio
    {
        Int32 Produccion { get; }
    }
}
