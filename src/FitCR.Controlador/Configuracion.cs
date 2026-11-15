namespace FitCR.Controlador
{
    /// <summary>
    /// Guarda las rutas de los archivos en un solo lugar.
    /// </summary>
    public static class Configuracion
    {
        /// <summary>
        /// Ruta del archivo de usuarios.
        /// </summary>
        public static string RutaUsuarios => Path.Combine(CarpetaFiles, "usuarios.csv");

        /// <summary>
        /// Ruta del archivo de entrenadores.
        /// </summary>
        public static string RutaEntrenadores => Path.Combine(CarpetaFiles, "entrenadores.csv");

        /// <summary>
        /// Ruta del archivo de rutinas.
        /// </summary>
        public static string RutaRutinas => Path.Combine(CarpetaFiles, "rutinas.csv");

        // Busca la carpeta Files subiendo desde donde corre el programa.
        private static string CarpetaFiles
        {
            get
            {
                var carpeta = new DirectoryInfo(AppContext.BaseDirectory);
                while (carpeta != null)
                {
                    var candidata = Path.Combine(carpeta.FullName, "Files");
                    if (Directory.Exists(candidata))
                    {
                        return candidata;
                    }
                    carpeta = carpeta.Parent;
                }
                return "Files";
            }
        }
    }
}