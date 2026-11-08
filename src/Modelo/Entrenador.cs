namespace FitCR
{
    public class Entrenador : Persona
    {
        public Entrenador(string id, string nombre, string usuario, string tipo)
        {
            Id = id;
            Nombre = nombre;
            NombreUsuario = usuario;
            Tipo = tipo;
        }

        public string NombreUsuario { get; set; }
        public string Tipo { get; set; }
    }
}