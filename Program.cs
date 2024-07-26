using System;
using System.ComponentModel;
using TallerEscuela.models;

public class Program
{
    public static void Main(){
        do
        {
           InterfazVisual.AdministrarPrograma();
            var opcion = Console.ReadLine();
            int op = 0;

           try
           {
                bool convetir = int.TryParse(opcion,out op);
           }
           catch (Exception)
           {    
                Console.WriteLine("Ey! Ingresaste un dato invalido");
           }

           switch (op)
           {
            case 1:
                Console.WriteLine(@"
                =======================================
                    Creación de un nuevo estudiante
                =======================================");

                // Console.WriteLine("Ingesa el nombre del estudiante: ");
                // string? nombre = Console.ReadLine();

                // Console.WriteLine("Ingesa el apellido del estudiante: ");
                // string? apellido = Console.ReadLine();

                // Console.WriteLine("Ingesa el tipo de documento del estudiante: ");
                // string? tipoDocumento = Console.ReadLine();

                // Console.WriteLine("Ingesa el numero de documento del estudiante: ");
                // string? numeroDocumento = Console.ReadLine();

                // Console.WriteLine("Ingesa el email del estudiante: ");
                // string? email = Console.ReadLine();

                // Console.WriteLine("Ingesa el telefono del estudiante: ");
                // string? telefono = Console.ReadLine();

                // Console.WriteLine("Ingesa el nombre del acudiente del estudiante: ");
                // string? nombreAcudiente = Console.ReadLine();

                // Console.WriteLine("Ingesa el curso actual del estudiante: ");
                // string? cursoActual = Console.ReadLine();

                // Console.WriteLine("Ingesa la fecha de nacimiento del estudiante: ");
                // string? fecha = Console.ReadLine();

                // if (DateOnly.TryParse(fecha, out DateOnly fechaNacimiento));

                // Estudiante newEstudiante = new Estudiante(nombre,apellido,tipoDocumento,numeroDocumento,email,telefono,nombreAcudiente,cursoActual,fechaNacimiento);
                Estudiante primerEstudiante = new Estudiante("luisa","ramirez","C.C","10029303","luisa@gmail.com","222334","Ivan","11°",new DateOnly(2024,02,12));
                primerEstudiante.AgregarCalificacion(2.5);
                Estudiante segundoEstudiante = new Estudiante("maria","gomez","C.C","1048390","mariasa@gmail.com","56323","socorro","8°",new DateOnly(2024,02,12));

                AdministradorApp.AgregarEstudiante(primerEstudiante);
                AdministradorApp.AgregarEstudiante(segundoEstudiante);
                break;
            case 2:
                break;
            case 3:

                Console.WriteLine(@"
            ======================================================================================================
                                                     Lista de estudiantes
            ====================================================================================================== ");
                AdministradorApp.MostrarEstudiantes();
                break;
            case 4:
                Console.WriteLine("Escribe el id del estudiante que deseas eliminar: ");
                string? id = Console.ReadLine();

                

                
                break;
            case 5:
                Console.WriteLine("Vamos a agregar un profesor");
                Profesor primeroProfesor = new Profesor("Javier","Combita","C.c","436257303","Javi@gmail.com","31348277","Matematicas",1300.000,new DateTime(2002/02/06));
                AdministradorApp.AgregarProfesor(primeroProfesor);
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;

            
            default:
                break;
           }




           
            
        } while (true);

    }

}
