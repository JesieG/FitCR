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
        /// Crea el servicio y carga los usuarios y entrenadores desde sus archivos.
        /// </summary>
        /// <param name="usuarioDataHandler">Lector de datos de usuarios.</param>
        /// <param name="entrenadorDataHandler">Lector de datos de entrenadores.</param>
        public InformationService(IDataHandler<Usuario> usuarioDataHandler, IDataHandler<Entrenador> entrenadorDataHandler)
        {
            UsuarioDataHandler = usuarioDataHandler;
            EntrenadorDataHandler = entrenadorDataHandler;
            Usuarios = UsuarioDataHandler.LoadData(Configuracion.RutaUsuarios);
            Entrenadores = EntrenadorDataHandler.LoadData(Configuracion.RutaEntrenadores);
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
        /// Usuarios cargados del archivo.
        /// </summary>
        public List<Usuario> Usuarios { get; set; }

        /// <summary>
        /// Entrenadores cargados del archivo.
        /// </summary>
        public List<Entrenador> Entrenadores { get; set; }

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