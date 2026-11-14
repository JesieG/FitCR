using System;

namespace FitCR
{
    public class Rutina
    {
        public Rutina(string id, string nombre, string idUsuario, string fechaVigencia)
        {
            Id = id;
            Nombre = nombre;
            IdUsuario = idUsuario;
            FechaVigencia = DateTime.Parse(fechaVigencia);
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}