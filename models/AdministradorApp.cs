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

        //metodo eliminar
        public static void Eliminar(){
            Console.WriteLine("¿Qué deseas eliminar?  1.Estudiante ,  2.Profesor");
            string? leer = Console.ReadLine();
            int opcion = 0;
            try
            {
                bool conf = int.TryParse(leer,out opcion);

                switch (opcion)
                {
                    case 1:
                       Console.WriteLine("Escribe el id del estudiante que deseas eliminar: ");
                        string? idE = Console.ReadLine();

                        var encontradoE = Estudiante.FirstOrDefault(item => item.IdEstudiantes() == idE );

                        if (encontradoE != null )
                        {
                            Estudiante.Remove(encontradoE);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("¡ Dato eliminado de forma exitosa !");
                            Console.ResetColor();
                        }else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Ey! El dato no ha sido eliminado !");
                            Console.ResetColor();
                        }
                        break;

                    case 2: 
                        Console.WriteLine("Escribe el id del profesor que deseas eliminar: ");
                        string? idP = Console.ReadLine();

                        var encontradoP = Profesor.FirstOrDefault(item => item.IdProfesor() == idP );

                        if (encontradoP != null )
                        {
                            Profesor.Remove(encontradoP);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("¡ Dato eliminado de forma exitosa !");
                            Console.ResetColor();
                        }else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Ey! El dato no ha sido eliminado !");
                            Console.ResetColor();
                        }
                        break;
                    
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Ey! El dato ingresado no es valido !");
                        Console.ResetColor();

                        break;
                }
                
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Ey! El dato ingresado no es valido !");
                Console.ResetColor();
            }
         

        }
    }
}