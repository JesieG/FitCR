using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Entrega el control de aumentos de peso de los ejercicios de un usuario.
    /// </summary>
    public class AumentosController
    {
        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public AumentosController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Registros de peso del usuario, del mas reciente al mas antiguo.
        /// </summary>
        public List<AumentoPeso> ObtenerAumentos(Usuario usuario)
        {
            var resultado = new List<AumentoPeso>();

            // El archivo guarda los registros de la fecha mas antigua a la mas reciente, por eso se recorre al reves.
            for (var i = InformationService.Aumentos.Count - 1; i >= 0; i--)
            {
                var registro = InformationService.Aumentos[i];
                if (registro.IdUsuario == usuario.Id)
                {
                    resultado.Add(registro);
                }
            }

            return resultado;
        }

        /// <summary>
        /// Cuanto subio el peso respecto al registro anterior del mismo ejercicio. Es null si es el primero.
        /// </summary>
        public double? CalcularAumento(AumentoPeso registro)
        {
            AumentoPeso? anterior = null;

            foreach (var otro in InformationService.Aumentos)
            {
                var esDelMismoEjercicio = otro.IdUsuario == registro.IdUsuario && otro.Ejercicio == registro.Ejercicio;

                if (esDelMismoEjercicio && otro.Fecha < registro.Fecha && (anterior == null || otro.Fecha > anterior.Fecha))
                {
                    anterior = otro;
                }
            }

            if (anterior == null)
            {
                return null;
            }

            return registro.Peso - anterior.Peso;
        }

        /// <summary>
        /// Por cada ejercicio del usuario, el primer y el ultimo peso dentro del rango de fechas.
        /// </summary>
        public List<AumentoPorEjercicio> ObtenerAumentosPorEjercicio(Usuario usuario, DateTime desde, DateTime hasta)
        {
            var resultado = new List<AumentoPorEjercicio>();

            // El archivo viene de la fecha mas antigua a la mas reciente: el primero que aparece es el inicial y el ultimo es el final.
            foreach (var registro in InformationService.Aumentos)
            {
                if (registro.IdUsuario != usuario.Id || registro.Fecha.Date < desde.Date || registro.Fecha.Date > hasta.Date)
                {
                    continue;
                }

                var resumen = BuscarResumen(resultado, registro.Ejercicio);

                if (resumen == null)
                {
                    resultado.Add(new AumentoPorEjercicio(registro.Ejercicio, registro.Peso, registro.Peso));
                }
                else
                {
                    resumen.PesoFinal = registro.Peso;
                }
            }

            return resultado;
        }

        // Busca el resumen de un ejercicio en la lista. Devuelve null si todavia no esta.
        private static AumentoPorEjercicio? BuscarResumen(List<AumentoPorEjercicio> resumenes, string ejercicio)
        {
            foreach (var resumen in resumenes)
            {
                if (resumen.Ejercicio == ejercicio)
                {
                    return resumen;
                }
            }

            return null;
        }
    }
}