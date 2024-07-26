using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public class InterfazVisual 
    {
        public static void AdministrarPrograma(){
            Console.WriteLine(@"
            ================================================
                        ¿QUE DESEAS HACER?
            ================================================
                        1.Agregar Estudiante.
                        2.Editar Estudiante.
                        3.Mostrar Estudiantes.
                        4.Agregar Profesor.
                        5.Editar Profesor.
                        6.Mostrar Profesor.
                        7.Eliminar Estudiante o profesor.
            ================================================
                        Ingresa una opcion:
            =================================================");

        }
    }
}