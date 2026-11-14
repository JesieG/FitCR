using System.Collections.Generic;

namespace FitCR
{
    // Registra un nuevo usuario en el sistema.
    public class RegistroController
    {
        public RegistroController(InformationService informationService)
        {
            InformationService = informationService;
        }

        public InformationService InformationService { get; set; }

        public bool Registrar(string nombre, string usuario, string contrasena, string edad, string peso, string estatura)
        {
            // Revisa que no vengan campos vacios.
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return false;
            }

            // Revisa que el nombre de usuario no exista ya.
            foreach (var u in InformationService.Usuarios)
            {
                if (u.NombreUsuario == usuario)
                {
                    return false;
                }
            }

            // Calcula el nuevo id (la cantidad de usuarios que ya hay).
            var nuevoId = InformationService.Usuarios.Count.ToString();

            // Crea el usuario nuevo (sin rutinas al inicio, por eso las llaves vacias).
            var nuevo = new Usuario(nuevoId, nombre, usuario, contrasena, edad, peso, estatura, "{}");

            // Lo agrega a la lista.
            InformationService.Usuarios.Add(nuevo);

            return true;
        }
    }
}