using System.Globalization;
using FitCR.Modelo.Enums;

namespace FitCR.Modelo
{
    /// <summary>
    /// Usuario que utiliza la aplicacion del gimnasio.
    /// </summary>
    public class Usuario : Persona
    {
        /// <summary>
        /// Crea un usuario a partir de los textos de una linea del CSV.
        /// </summary>
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
            Rol = Rol.Usuario;
        }

        /// <summary>
        /// Nombre con el que el usuario inicia sesion.
        /// </summary>
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Contrasena del usuario.
        /// </summary>
        public string Contrasena { get; set; }

        /// <summary>
        /// Edad en anos.
        /// </summary>
        public int Edad { get; set; }

        /// <summary>
        /// Peso en kilogramos.
        /// </summary>
        public double Peso { get; set; }

        /// <summary>
        /// Estatura en metros.
        /// </summary>
        public double Estatura { get; set; }

        /// <summary>
        /// Identificadores de las rutinas del usuario.
        /// </summary>
        public List<int> Rutinas { get; set; }

        /// <summary>
        /// Indice de masa corporal: peso entre estatura al cuadrado. Devuelve 0 si no hay estatura.
        /// </summary>
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

        /// <summary>
        /// Convierte el usuario en una linea del CSV.
        /// </summary>
        public override string ToString()
        {
            var rutinas = "{" + string.Join(";", Rutinas) + "}";
            return Id + "," + Nombre + "," + NombreUsuario + "," + Contrasena + "," + Edad + "," +
                   Peso.ToString(CultureInfo.InvariantCulture) + "," +
                   Estatura.ToString(CultureInfo.InvariantCulture) + "," + rutinas;
        }

        // Convierte el texto "{1;2;3}" en una lista de numeros.
        private static List<int> LeerRutinas(string rutinas)
        {
            var lista = new List<int>();
            if (string.IsNullOrWhiteSpace(rutinas) || rutinas.Length < 2)
            {
                return lista;
            }

            var limpio = rutinas.Substring(1, rutinas.Length - 2);
            foreach (var parte in limpio.Split(';'))
            {
                if (int.TryParse(parte, out int numero))
                {
                    lista.Add(numero);
                }
            }
            return lista;
        }
    }
}