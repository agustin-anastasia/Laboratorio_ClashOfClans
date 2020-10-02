using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    class Aldea
    {
        /// <summary>
        /// Clase madre Aldea
        /// </summary>

        private static Aldea instancia;

        /// <summary>
        /// Metodo singleton que se asegura que siempre exista una instancia de Aldea en cualquier parte del programa
        /// </summary>
        /// <returns>Retorna una instancia de Aldea</returns>

        public static Aldea GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Aldea();
            }
            return instancia;
        }

        public String Nombre { get; set; }

        /// <summary>
        /// Variables que definen los máximos de cada edificio.   
        /// </summary>

        const Int32 MaxCuartel = 4;
        const Int32 MaxCuartelOscuro = 2;
        const Int32 MaxCampamento = 4;
        const Int32 MaxAlmacenOro = 4;
        const Int32 MaxAlmacenElixir = 4;
        const Int32 MaxAlmacenElixirN = 1;
        const Int32 MaxMinaOro = 6;
        const Int32 MaxRecolectoraElixir = 6;
        const Int32 MaxRecolectoraElixirN = 3;

        /// <summary>
        /// Listas que contienen la cantidad de edificios existentes.
        /// </summary>

        List<IEdificio> ListaCuarteles = new List<IEdificio>();
        List<IEdificio> ListaCuartelesO = new List<IEdificio>();
        List<IEdificio> ListaCampamentos = new List<IEdificio>();
        List<IEdificio> ListaAlmacenesOro = new List<IEdificio>();
        List<IEdificio> ListaAlmacenesElixir = new List<IEdificio>();
        List<IEdificio> ListaAlmacenesElixirN = new List<IEdificio>();
        List<IEdificio> ListaMinasOro = new List<IEdificio>();
        List<IEdificio> ListaRecolectorasElixir = new List<IEdificio>();
        List<IEdificio> ListaRecolectorasElixirN = new List<IEdificio>();

        /// <summary>
        /// Listas de todos los edificios existentes en la aldea
        /// </summary>

        public List<IEdificio> listaEdificiosAldea;
        /// <summary>
        /// Lista de todas las tropas exitentes en la aldea
        /// </summary>
        public List<Tropa> listaTropasAldea;

        /// <summary>
        /// Propiedades que contienen la cantidad de los recursos Oro, Elixir rojo y Elixir negro.
        /// </summary>

        public Int32 CantidadOro { get; set; }
        public Int32 CantidadElixir { get; set; }
        public Int32 CantidadElixirN { get; set; }
        public Int32 CantidadTropas { get; set; }

        /// <summary>
        /// Propiedades que contienen la capacidad de los Recursos Oro, Elixir rojo y Elixir negro.
        /// </summary>

        public Int32 CapacidadOro { get; set; }
        public Int32 CapacidadElixir { get; set; }
        public Int32 CapacidadElixirN { get; set; }
        public Int32 CapacidadTropas { get; set; }

        /// <summary>
        /// Validadores de existencia de edificios
        /// </summary>

        public Boolean HayCastillo { get; set; }
        public Boolean HayCuartel { get; set; }
        public Boolean HayCuartelOscuro { get; set; }
        public Boolean HayRecolectorOro { get; set; }
        public Boolean HayRecolectorElixir { get; set; }
        public Boolean HayRecolectorElixirN { get; set; }

        /// <summary>
        /// Constructor Aldea con atributos fijos definidos desde el inicio del juego.
        /// </summary>

        private Aldea()
        {
            CantidadOro = 1000;
            CantidadElixir = 1000;
            CantidadElixir = 1000;
            CapacidadOro = 1000;
            CapacidadElixir = 1000;
            CapacidadElixirN = 1000;
            CapacidadTropas = 50;
            listaEdificiosAldea = new List<IEdificio>();
            listaTropasAldea = new List<Tropa>();
            HayCastillo = false;
            HayCuartel = false;
            HayCuartelOscuro = false;
            HayRecolectorElixir = false;
            HayRecolectorElixirN = false;
            HayRecolectorOro = false;
        }

        /// <summary>
        /// Metodo Constructor que crea edificios pasados por parámetro. El Ayuntamiento solo es posible crearlo desde el comienzo.
        /// </summary>
        /// <param name="e"></param>
        /// <returns>"Has comprado" con el nombre del edificio nuevo adquirido.</returns>

        public String Constructor(IEdificio e)
        {
            String frase;
            // Solo es posible crearlo desde el comienzo.
            if (e is Ayuntamiento)
            {
                listaEdificiosAldea.Add(e);
            }
            // Si los recursos NO son suficientes.
            if (e.PrecioOro > this.CantidadOro || e.PrecioElixir > this.CantidadElixir || e.PrecioElixirN > this.CantidadElixirN)
            {
                return "No es posible comprar el edificio. Recursos insuficientes";
            }
            // Si los recursos SON suficientes.
            else
            {
                // Si la aldea no llegó al límite máximo de edificios de ese tipo, se compra.
                if (e is Cuartel && ListaCuarteles.Count() < MaxCuartel)
                {
                    ListaCuarteles.Add(e);
                    HayCuartel = true;
                }
                else if (e is CuartelOscuro && ListaCuartelesO.Count() < MaxCuartelOscuro)
                {
                    ListaCuartelesO.Add(e);
                }
                else if (e is Campamento && ListaCampamentos.Count() < MaxCampamento)
                {
                    ListaCampamentos.Add(e);
                }
                else if (e is AlmacenOro && ListaAlmacenesOro.Count() < MaxAlmacenOro)
                {
                    ListaAlmacenesOro.Add(e);
                }
                else if (e is AlmacenElixir && ListaAlmacenesElixir.Count() < MaxAlmacenElixir)
                {
                    ListaAlmacenesElixir.Add(e);
                }
                else if (e is AlmacenElixirN && ListaAlmacenesElixirN.Count() < MaxAlmacenElixirN)
                {
                    ListaAlmacenesElixirN.Add(e);
                }
                else if (e is MinaOro && ListaMinasOro.Count() < MaxMinaOro)
                {
                    ListaMinasOro.Add(e);
                    HayRecolectorOro = true;
                }
                else if (e is RecolectoraElixir && ListaRecolectorasElixir.Count() < MaxRecolectoraElixir)
                {
                    ListaRecolectorasElixir.Add(e);
                    HayRecolectorElixir = true;
                }
                else if (e is RecolectoraElixirN && ListaRecolectorasElixirN.Count() < MaxRecolectoraElixirN)
                {
                    ListaRecolectorasElixirN.Add(e);
                    HayRecolectorElixirN = true;
                }
                // Siempre y cuando no sea un castillo y ya haya uno creado.
                else if (e is Castillo && HayCastillo == false)
                {
                    HayCastillo = true;
                }
                else if (e is Castillo && HayCastillo == true)
                {
                    return "Ya existe un castillo";
                }
                // Edificos Defensivos no tienen límites.
                else if (e is Defensivo)
                {
                }
                // El edificio NO se compró o porque era un Castillo, o porque .
                else
                {
                    return frase = "No puedes comprar más edificios del tipo: " + e.Nombre;
                }
                this.CantidadOro -= e.PrecioOro;
                this.CantidadElixir -= e.PrecioElixir;
                this.CantidadElixirN -= e.PrecioElixirN;
                listaEdificiosAldea.Add(e);
            }
            return "Has comprado " + e.Nombre;
        }

        /// <summary>
        /// Metodo constructor de Tropas que agrega a la lista TropasAldea cuando se compra una tropa.
        /// Para poder comprar cualquier tipo de Tropa debe existir un cuartel.
        /// </summary>
        /// <param name="t"></param>

        public String Constructor2(Tropa t)
        {
            if (!HayCuartel)
            {
                return "No es posible comprar tropas sin cuartel";
            }
            if (t.PrecioOro > this.CantidadOro || t.PrecioElixir > this.CantidadElixir || t.PrecioElixirN > this.CantidadElixirN)
            {
                return "No es posible comprar la Tropa. Recursos insuficientes";
            }
            if (CantidadTropas + t.Poblacion > CapacidadTropas)
            {
                return "No es posible comprar tropas, espacio lleno";
            }
            else
            {
                this.CantidadOro -= t.PrecioOro;
                this.CantidadElixir -= t.PrecioElixir;
                this.CantidadElixirN -= t.PrecioElixirN;
                this.CantidadTropas += t.Poblacion;
                listaTropasAldea.Add(t);
                return t.Nombre + " comprado exitosamente.";
            }
        }

        /// <summary>
        /// Metodo ActualizarTopesRecursos que actualiza los recursos por cada almacen y los agrega a la cantidad de cada recurso.
        /// </summary>
        public void ActualizarTopesRecursos()
        {
            this.CapacidadOro = 1000;
            this.CapacidadElixir = 1000;
            this.CapacidadElixirN = 1000;
            this.CapacidadTropas = 50;

            foreach (IEdificio a in listaEdificiosAldea)
                if (a is IAlmacenamientoOro)
                {
                    IAlmacenamientoOro o = (IAlmacenamientoOro)a;
                    this.CapacidadOro += o.CantidadOro;
                }
                else if (a is IAlmacenamientoElixir)
                {
                    IAlmacenamientoElixir e = (IAlmacenamientoElixir)a;
                    this.CapacidadElixir += e.CantidadElixir;
                }
                else if (a is IAlmacenamientoElixirN)
                {
                    IAlmacenamientoElixirN eN = (IAlmacenamientoElixirN)a;
                    this.CapacidadElixirN += eN.CantidadElixirN;
                }
                else if (a is IAlmacenamientoTropa)
                {
                    IAlmacenamientoTropa t = (IAlmacenamientoTropa)a;
                    this.CapacidadTropas += t.CantidadTropas;
                }
        }

        /// <summary>
        /// Método ActualizarCantRecursos que actualiza los recursos generados en los edificios de producción.
        /// </summary>

        public void ActualizarCantRecursos()
            {
                Int32 Oro = 0;
                Int32 Elixir = 0;
            Int32 ElixirN = 0;
            Int32 Tropas = 0;

            foreach (IEdificio a in listaEdificiosAldea)
            {
                if (a is MinaOro)
                {
                    MinaOro o = (MinaOro)a;
                    Oro += o.Produccion;
                }
                if(a is RecolectoraElixir)
                {
                    RecolectoraElixir r = (RecolectoraElixir)a;
                    Elixir += r.Produccion;
                }
                if (a is RecolectoraElixirN)
                {
                    RecolectoraElixirN rN = (RecolectoraElixirN)a;
                    ElixirN += rN.Produccion;
                }
            }
            foreach (Tropa t in listaTropasAldea)
            {
                Tropas += 1;
                Tropas += t.Poblacion;
            }
            this.CantidadTropas = Tropas;
            this.CantidadOro = Oro;
            this.CantidadElixir = Elixir;
            this.CantidadElixirN = ElixirN;
        }
        
    }
}