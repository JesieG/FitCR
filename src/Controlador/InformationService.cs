using System.Collections.Generic;

namespace FitCR
{
    // Carga la informacion del sistema y la guarda para usarla en las pantallas.
    public class InformationService
    {
        public InformationService()
        {
            var lectorUsuarios = new FileHandler<Usuario>();
            Usuarios = lectorUsuarios.LoadData(Configuracion.RutaUsuarios);

            var lectorEntrenadores = new FileHandler<Entrenador>();
            Entrenadores = lectorEntrenadores.LoadData(Configuracion.RutaEntrenadores);
        }

        public List<Usuario> Usuarios { get; set; }
        public List<Entrenador> Entrenadores { get; set; }

        // Aqui se guarda quien inicio sesion, segun su rol.
        public Usuario UsuarioActual { get; set; }
        public Entrenador EntrenadorActual { get; set; }
    }
}