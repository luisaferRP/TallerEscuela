using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public static class AdministradorApp
    {
        public static List<Estudiante> Estudiante;
        public static List<Profesor> Profesor;

        static AdministradorApp(){
            
            Estudiante = new List<Estudiante>(){};
            Profesor = new List<Profesor>(){};
        }

        //Miembros metodos
        public static void AgregarEstudiante(Estudiante datoEstudiante){
            Estudiante.Add(datoEstudiante);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
            ****************************************
                ¡Estudiante agregado exitosamente!
            ****************************************");
            Console.ResetColor();
        }

        public static void AgregarProfesor(Profesor profesor){
            Profesor.Add(profesor);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
            ****************************************
                ¡Profesor agregado exitosamente!
            ****************************************");
            Console.ResetColor();

        }

        //Mostrar detalles
        public static void MostrarEstudiantes(){
            foreach (var item in Estudiante)
            {
                item.MostrarDetalles();
            }

        }

        public static void MostrarProfesores(){

            foreach (var item in Profesor)
            {
                item.MostrarDetalles();
            }

        }
    }
}