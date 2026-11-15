using FitCR.Modelo.Enums;

namespace FitCR.Modelo
{
    /// <summary>
    /// Entrenador del gimnasio o entrenador personal.
    /// </summary>
    public class Entrenador : Persona
    {
        /// <summary>
        /// Crea un entrenador a partir de los textos de una linea del CSV.
        /// </summary>
        public Entrenador(string id, string nombre, string usuario, string contrasena, string tipo)
        {
            Id = id;
            Nombre = nombre;
            NombreUsuario = usuario;
            Contrasena = contrasena;
            Tipo = tipo;
            Rol = Rol.Entrenador;
        }

        /// <summary>
        /// Nombre con el que el entrenador inicia sesion.
        /// </summary>
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Contrasena del entrenador.
        /// </summary>
        public string Contrasena { get; set; }

        /// <summary>
        /// Tipo de entrenador: "gimnasio" o "personal".
        /// </summary>
        public string Tipo { get; set; }
    }
}