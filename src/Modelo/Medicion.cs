using System;

namespace FitCR
{
    public class Medicion
    {
        public string Id { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public double Peso { get; set; }
        public double Grasa { get; set; }
        public double Musculatura { get; set; }
    }
}