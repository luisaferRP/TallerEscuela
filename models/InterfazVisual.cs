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
                        4.Eliminar Estudiante.
                        5.Agregar Profesor.
                        6.Editar Profesor.
                        7.Mostrar Profesor.
                        8.Eliminar Profesor.
            ================================================
                    Ingresa una opcion:
            =================================================");

        }
    }
}