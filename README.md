#Fit.CR
Sistema de gestion fitness Proyecto 1 del curso de Tecnicas de Programacion (3Q 2026), Universidad Politecnica Internacional.

Estudiante: Jesie Gomez Guzman

## Que hace

Permite a los usuarios de un gimnasio llevar el control de su rutina de ejercicios, y a los entrenadores administrar rutinas y mediciones. Los datos se cargan desde archivos CSV.

## Tecnologias

- C# con Windows Forms
- .NET 10
- Patron MVC, con un proyecto por capa

## Estructura del repositorio

- `Files`: archivos CSV con los datos de ejemplo (todos con mas de 40 registros).
- `src/FitCR.Modelo`: las clases del sistema (usuarios, entrenadores, rutinas, mediciones, etc.).
- `src/FitCR.Controlador`: la logica y la lectura y escritura de los archivos.
- `src/FitCR.Vista`: las ventanas.
- `FitCR.sln`: la solucion de Visual Studio.

## Como ejecutarlo

1. Instalar el SDK de .NET 10 y un Visual Studio que lo soporte, con la carga de trabajo de desarrollo de escritorio de .NET.
2. Abrir `FitCR.sln`.
3. Dejar `FitCR.Vista` como proyecto de inicio.
4. Ejecutar con F5.

La carpeta `Files` debe quedar junto a la carpeta `src`. El programa la busca solo.

## Usuarios de prueba

Los usuarios de ejemplo tienen como contrasena su nombre de usuario seguido de `123`.

- Usuario: `ana0`, contrasena `ana0123`
- Entrenador: `ent0`, contrasena `ent0123`

## Funciones

Para todos:
- Inicio de sesion y registro de usuarios nuevos.

Usuario:
- Perfil con su IMC.
- Historial: visitas, ultimas 5 rutinas, mediciones y control de aumentos de peso.
- Estadisticas por rango de fechas: top 10 de visitantes y de ausentes, aumento de pesos y mejoras en los objetivos.
- Insignias de logro y de la verguenza.
- Clases del gimnasio.
- Notificaciones.

Entrenador:
- Rutinas: agregar, editar y eliminar.
- Registro de mediciones.
- Notificaciones: rutinas por vencer y mediciones cercanas.
- Registro de visitas desde la aplicacion.

