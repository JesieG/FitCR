namespace FitCR
{
    // Entrenador. Puede ser del gimnasio o personal.
    public class Entrenador : Persona
    {
        public Entrenador(string id, string nombre, string usuario, string contrasena, string tipo)
        {
            Id = id;
            Nombre = nombre;
            NombreUsuario = usuario;
            Contrasena = contrasena;
            Tipo = tipo;
        }

        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Tipo { get; set; }
    }
}