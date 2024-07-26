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
                Console.WriteLine(@"**************************************** Creación de un nuevo estudiante ****************************************");

                Console.WriteLine("Ingesa el nombre del estudiante: ");
                 string? nombre = Console.ReadLine().Trim();

                // Console.WriteLine("Ingesa el apellido del estudiante: ");
                // string? apellido = Console.ReadLine().Trim();

                // Console.WriteLine("Ingesa el tipo de documento del estudiante: ");
                // string? tipoDocumento = Console.ReadLine().Trim();

                // Console.WriteLine("Ingesa el numero de documento del estudiante: ");
                // string? numeroDocumento = Console.ReadLine().Trim();

                // Console.WriteLine("Ingesa el email del estudiante: ");
                // string? email = Console.ReadLine().Trim();

                // Console.WriteLine("Ingesa el telefono del estudiante: ");
                // string? telefono = Console.ReadLine().Trim();

                // Console.WriteLine("Ingesa el nombre del acudiente del estudiante: ");
                // string? nombreAcudiente = Console.ReadLine().Trim();

                // Console.WriteLine("Ingesa el curso actual del estudiante: ");
                // string? cursoActual = Console.ReadLine().Trim();

                // Console.WriteLine("Ingesa la fecha de nacimiento del estudiante: YYYY/MM/DD ");
                // string? fecha = Console.ReadLine().Trim();

                // if (DateOnly.TryParse(fecha, out DateOnly fechaNacimiento));

                // Console.WriteLine("Agrega una calificacion:");
                // double nota = Convert.ToDouble(Console.ReadLine()).Trim();
                // primerEstudiante.AgregarCalificacion();
                if (string.IsNullOrWhiteSpace(nombre) &&  string.IsNullOrWhiteSpace(apellido) &&  string.IsNullOrWhiteSpace(numeroDocumento) && 
                    string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(telefono) &&  string.IsNullOrWhiteSpace(nombreAcudiente) &&  string.IsNullOrWhiteSpace(cursoActual) ){

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Ey! Alguno de los datos ingresados no son validos !");
                        Console.ResetColor();
                }else{
                    // Estudiante newEstudiante = new Estudiante(nombre,apellido,tipoDocumento,numeroDocumento,email,telefono,nombreAcudiente,cursoActual,fechaNacimiento);
                }

                Estudiante primerEstudiante = new Estudiante("luisa","ramirez","C.C","10029303","luisa@gmail.com","222334","Ivan","11°",new DateOnly(2024,02,12));
                primerEstudiante.AgregarCalificacion(2.5);
                Estudiante segundoEstudiante = new Estudiante("maria","gomez","C.C","1048390","mariasa@gmail.com","56323","socorro","8°",new DateOnly(2024,02,12));

                AdministradorApp.AgregarEstudiante(primerEstudiante);
                AdministradorApp.AgregarEstudiante(segundoEstudiante);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"******************************************* ¡Estudiante agregado exitosamente!*******************************************");
                Console.WriteLine("Ingrese cualquier letra para volver al menu :");
                Console.Read();
            Console.ResetColor();
                break;
            case 2:
            //editar estudiante
            Console.WriteLine("Por favor ingrese el id del estudiante que desea editar:");
            string? id = Console.ReadLine();
             var encontradoE = AdministradorApp.Estudiante.FirstOrDefault(item => item.IdEstudiantes() == id );

            if (encontradoE == null)
            {
                Console.WriteLine("Lo sentimos, el estudiante que quieres editar no se encuentra en nuestra lista");
            }else
            {
                encontradoE.editar(id);
            }
                break;
            case 3:
            //Mostrar eestudiante
                Console.WriteLine(@"
            ======================================================================================================
                                                     Lista de estudiantes
            ====================================================================================================== ");
                AdministradorApp.MostrarEstudiantes();
                Console.WriteLine("Ingrese cualquier letra para volver al menu :");
                Console.Read();
                break;
            case 4:
            //Agregar profesor
                 Console.WriteLine(@"**************************************** Creación de un nuevo profesor ****************************************");
                Profesor primeroProfesor = new Profesor("Javier","Combita","C.c","436257303","Javi@gmail.com","31348277","Matematicas",1300.000,new DateTime(2002/02/06));
                AdministradorApp.AgregarProfesor(primeroProfesor);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"**************************************** ¡Profesor agregado exitosamente! ****************************************");
                Console.ResetColor();
                Console.WriteLine("Ingrese cualquier letra para volver al menu :");
                Console.Read();
                break;
            case 5:
              
                break;
            case 6:
                Console.WriteLine(@"
            ======================================================================================================
                                                     Lista de profesores
            ====================================================================================================== ");
                AdministradorApp.MostrarProfesores();
                Console.WriteLine("Ingrese cualquier letra para volver al menu :");
                Console.Read();
                break;
            case 7:
            //Eliminar 
                AdministradorApp.Eliminar();
                Console.WriteLine("Ingrese cualquier letra para volver al menu :");
                Console.Read();
                break;

            
            default:
                break;
           }




           
            
        } while (true);

    }

}
