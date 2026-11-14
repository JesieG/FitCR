using System.Collections.Generic;
using System.Globalization;

namespace FitCR
{
    public class Usuario : Persona
    {
        public Usuario(string id, string nombre, string usuario, string contrasena, string edad, string peso, string estatura, string rutinas)
        {
            Id = id;
            Nombre = nombre;
            NombreUsuario = usuario;
            Contrasena = contrasena;
            Edad = int.Parse(edad);
            Peso = double.Parse(peso, CultureInfo.InvariantCulture);
            Estatura = double.Parse(estatura, CultureInfo.InvariantCulture);
            Rutinas = LeerRutinas(rutinas);
        }

        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public double Estatura { get; set; }
        public List<int> Rutinas { get; set; }

        public double Imc
        {
            get
            {
                if (Estatura > 0)
                {
                    return Peso / (Estatura * Estatura);
                }
                return 0;
            }
        }

        private List<int> LeerRutinas(string rutinas)
        {
            var lista = new List<int>();
            if (string.IsNullOrWhiteSpace(rutinas) || rutinas.Length < 2)
            {
                return lista;
            }

            var limpio = rutinas.Substring(1, rutinas.Length - 2);
            var partes = limpio.Split(';');
            foreach (var parte in partes)
            {
                int numero;
                if (int.TryParse(parte, out numero))
                {
                    lista.Add(numero);
                }
            }
            return lista;
        }

        // Convierte el usuario en una linea del CSV.
        public override string ToString()
        {
            var rutinas = "{" + string.Join(";", Rutinas) + "}";
            return Id + "," + Nombre + "," + NombreUsuario + "," + Contrasena + "," + Edad + "," +
                   Peso.ToString(CultureInfo.InvariantCulture) + "," +
                   Estatura.ToString(CultureInfo.InvariantCulture) + "," + rutinas;
        }
    }
}