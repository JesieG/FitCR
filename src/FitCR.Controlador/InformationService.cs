using FitCR.Controlador.Abstracciones;
using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Carga la informacion del sistema y la guarda para usarla en las pantallas.
    /// </summary>
    public class InformationService
    {
        /// <summary>
        /// Crea el servicio y carga todos los datos desde sus archivos.
        /// </summary>
        /// <param name="usuarioDataHandler">Lector de datos de usuarios.</param>
        /// <param name="entrenadorDataHandler">Lector de datos de entrenadores.</param>
        /// <param name="rutinaDataHandler">Lector de datos de rutinas.</param>
        /// <param name="visitaDataHandler">Lector de datos de visitas.</param>
        /// <param name="medicionDataHandler">Lector de datos de mediciones.</param>
        /// <param name="claseDataHandler">Lector de datos de clases.</param>
        public InformationService(
            IDataHandler<Usuario> usuarioDataHandler,
            IDataHandler<Entrenador> entrenadorDataHandler,
            IDataHandler<Rutina> rutinaDataHandler,
            IDataHandler<Visita> visitaDataHandler,
            IDataHandler<Medicion> medicionDataHandler,
            IDataHandler<Clase> claseDataHandler)
        {
            UsuarioDataHandler = usuarioDataHandler;
            EntrenadorDataHandler = entrenadorDataHandler;
            RutinaDataHandler = rutinaDataHandler;
            VisitaDataHandler = visitaDataHandler;
            MedicionDataHandler = medicionDataHandler;
            ClaseDataHandler = claseDataHandler;

            Usuarios = UsuarioDataHandler.LoadData(Configuracion.RutaUsuarios);
            Entrenadores = EntrenadorDataHandler.LoadData(Configuracion.RutaEntrenadores);
            Rutinas = RutinaDataHandler.LoadData(Configuracion.RutaRutinas);
            Visitas = VisitaDataHandler.LoadData(Configuracion.RutaVisitas);
            Mediciones = MedicionDataHandler.LoadData(Configuracion.RutaMediciones);
            Clases = ClaseDataHandler.LoadData(Configuracion.RutaClases);
        }

        /// <summary>
        /// Lector y guardador de datos de usuarios.
        /// </summary>
        public IDataHandler<Usuario> UsuarioDataHandler { get; set; }

        /// <summary>
        /// Lector y guardador de datos de entrenadores.
        /// </summary>
        public IDataHandler<Entrenador> EntrenadorDataHandler { get; set; }

        /// <summary>
        /// Lector y guardador de datos de rutinas.
        /// </summary>
        public IDataHandler<Rutina> RutinaDataHandler { get; set; }

        /// <summary>
        /// Lector y guardador de datos de visitas.
        /// </summary>
        public IDataHandler<Visita> VisitaDataHandler { get; set; }

        /// <summary>
        /// Lector y guardador de datos de mediciones.
        /// </summary>
        public IDataHandler<Medicion> MedicionDataHandler { get; set; }

        /// <summary>
        /// Lector y guardador de datos de clases.
        /// </summary>
        public IDataHandler<Clase> ClaseDataHandler { get; set; }

        /// <summary>
        /// Usuarios cargados del archivo.
        /// </summary>
        public List<Usuario> Usuarios { get; set; }

        /// <summary>
        /// Entrenadores cargados del archivo.
        /// </summary>
        public List<Entrenador> Entrenadores { get; set; }

        /// <summary>
        /// Rutinas cargadas del archivo.
        /// </summary>
        public List<Rutina> Rutinas { get; set; }

        /// <summary>
        /// Visitas al gimnasio cargadas del archivo.
        /// </summary>
        public List<Visita> Visitas { get; set; }

        /// <summary>
        /// Mediciones cargadas del archivo.
        /// </summary>
        public List<Medicion> Mediciones { get; set; }

        /// <summary>
        /// Clases del gimnasio cargadas del archivo.
        /// </summary>
        public List<Clase> Clases { get; set; }

        /// <summary>
        /// Persona que inicio sesion. Si no hay nadie, es null.
        /// </summary>
        public Persona? PersonaActual { get; set; }

        /// <summary>
        /// La persona actual como usuario. Es null si quien entro no es un usuario.
        /// </summary>
        public Usuario? UsuarioActual => PersonaActual as Usuario;

        /// <summary>
        /// La persona actual como entrenador. Es null si quien entro no es un entrenador.
        /// </summary>
        public Entrenador? EntrenadorActual => PersonaActual as Entrenador;
    }
}