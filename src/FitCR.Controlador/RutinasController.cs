using System.Globalization;
using FitCR.Modelo;

namespace FitCR.Controlador
{
    /// <summary>
    /// Agrega, edita y elimina las rutinas del sistema.
    /// </summary>
    public class RutinasController
    {
        /// <summary>
        /// Crea el controlador con el servicio que tiene los datos.
        /// </summary>
        public RutinasController(InformationService informationService)
        {
            InformationService = informationService;
        }

        /// <summary>
        /// Servicio con la informacion del sistema.
        /// </summary>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Agrega una rutina nueva y se la asigna al usuario.
        /// </summary>
        /// <returns>True si se agrego, false si algun dato no es valido.</returns>
        public bool Agregar(string nombre, Usuario? usuario, DateTime vigencia)
        {
            if (usuario == null || !NombreValido(nombre) || vigencia.Date < DateTime.Today)
            {
                return false;
            }

            var nuevoId = CalcularNuevoId();
            var fechaVigencia = vigencia.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            var fechaAsignacion = DateTime.Today.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            var rutina = new Rutina(nuevoId.ToString(), nombre, usuario.Id, fechaVigencia, fechaAsignacion);

            InformationService.Rutinas.Add(rutina);
            usuario.Rutinas.Add(nuevoId);

            return GuardarRutinas() && GuardarUsuarios();
        }

        /// <summary>
        /// Cambia el nombre, el usuario y la vigencia de una rutina.
        /// </summary>
        /// <returns>True si se guardo, false si algun dato no es valido.</returns>
        public bool Editar(Rutina? rutina, string nombre, Usuario? usuario, DateTime vigencia)
        {
            if (rutina == null || usuario == null || !NombreValido(nombre))
            {
                return false;
            }

            rutina.Nombre = nombre;
            rutina.FechaVigencia = vigencia;

            if (rutina.IdUsuario != usuario.Id)
            {
                CambiarUsuario(rutina, usuario);
                return GuardarRutinas() && GuardarUsuarios();
            }

            return GuardarRutinas();
        }

        /// <summary>
        /// Elimina una rutina y la quita de la lista de los usuarios.
        /// </summary>
        /// <returns>True si se elimino, false si no hay rutina.</returns>
        public bool Eliminar(Rutina? rutina)
        {
            if (rutina == null)
            {
                return false;
            }

            InformationService.Rutinas.Remove(rutina);

            if (int.TryParse(rutina.Id, out int idRutina))
            {
                QuitarDeLosUsuarios(idRutina);
            }

            return GuardarRutinas() && GuardarUsuarios();
        }

        /// <summary>
        /// Busca una rutina por su identificador. Devuelve null si no existe.
        /// </summary>
        public Rutina? BuscarRutina(string idRutina)
        {
            foreach (var rutina in InformationService.Rutinas)
            {
                if (rutina.Id == idRutina)
                {
                    return rutina;
                }
            }

            return null;
        }

        /// <summary>
        /// Busca un usuario por su identificador. Devuelve null si no existe.
        /// </summary>
        public Usuario? BuscarUsuario(string idUsuario)
        {
            foreach (var usuario in InformationService.Usuarios)
            {
                if (usuario.Id == idUsuario)
                {
                    return usuario;
                }
            }

            return null;
        }

        /// <summary>
        /// Nombre del usuario dueno de una rutina, o un texto si ya no existe.
        /// </summary>
        public string ObtenerNombreUsuario(string idUsuario)
        {
            var usuario = BuscarUsuario(idUsuario);

            if (usuario == null)
            {
                return "Sin usuario";
            }

            return usuario.Nombre;
        }

        // La coma separa los datos en el CSV, por eso no se permite en el nombre.
        private static bool NombreValido(string nombre)
        {
            return !string.IsNullOrWhiteSpace(nombre) && !nombre.Contains(',');
        }

        // El nuevo id es el mayor que ya existe mas uno.
        private int CalcularNuevoId()
        {
            var mayor = -1;

            foreach (var rutina in InformationService.Rutinas)
            {
                if (int.TryParse(rutina.Id, out int id) && id > mayor)
                {
                    mayor = id;
                }
            }

            return mayor + 1;
        }

        // La rutina pasa a ser solo del nuevo usuario: se le quita a quien la tenga, se le da a el y se anota la fecha de hoy.
        private void CambiarUsuario(Rutina rutina, Usuario nuevoUsuario)
        {
            if (int.TryParse(rutina.Id, out int idRutina))
            {
                QuitarDeLosUsuarios(idRutina);
                nuevoUsuario.Rutinas.Add(idRutina);
            }

            rutina.IdUsuario = nuevoUsuario.Id;
            rutina.FechaAsignacion = DateTime.Today;
        }

        // Quita la rutina de la lista de todos los usuarios que la tengan.
        private void QuitarDeLosUsuarios(int idRutina)
        {
            foreach (var usuario in InformationService.Usuarios)
            {
                usuario.Rutinas.Remove(idRutina);
            }
        }

        private bool GuardarRutinas()
        {
            return InformationService.RutinaDataHandler.SaveData(Configuracion.RutaRutinas, InformationService.Rutinas);
        }

        private bool GuardarUsuarios()
        {
            return InformationService.UsuarioDataHandler.SaveData(Configuracion.RutaUsuarios, InformationService.Usuarios);
        }
    }
}