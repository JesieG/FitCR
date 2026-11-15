using FitCR.Modelo.Enums;

namespace FitCR.Modelo
{
    /// <summary>
    /// Abstraccion de una persona, base para el usuario y el entrenador.
    /// </summary>
    public abstract class Persona
    {
        /// <summary>
        /// Identificador de la persona.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Nombre completo de la persona.
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Rol de la persona dentro de la aplicacion.
        /// </summary>
        public Rol Rol { get; set; }
    }
}