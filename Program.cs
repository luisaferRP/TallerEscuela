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

                Console.WriteLine("Ingesa el apellido del estudiante: ");
                string? apellido = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el tipo de documento del estudiante: ");
                string? tipoDocumento = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el numero de documento del estudiante: ");
                string? numeroDocumento = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el email del estudiante: ");
                string? email = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el telefono del estudiante: ");
                string? telefono = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el nombre del acudiente del estudiante: ");
                string? nombreAcudiente = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el curso actual del estudiante: ");
                string? cursoActual = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa la fecha de nacimiento del estudiante: YYYY/MM/DD ");
                string? fecha = Console.ReadLine().Trim();

                if (DateOnly.TryParse(fecha, out DateOnly fechaNacimiento));

                if (string.IsNullOrWhiteSpace(nombre) &&  string.IsNullOrWhiteSpace(apellido) &&  string.IsNullOrWhiteSpace(numeroDocumento) && 
                    string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(telefono) &&  string.IsNullOrWhiteSpace(nombreAcudiente) &&  string.IsNullOrWhiteSpace(cursoActual) ){

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Ey! Alguno de los datos ingresados no son validos !");
                        Console.ResetColor();
                }else{
                    Estudiante newEstudiante = new Estudiante(nombre,apellido,tipoDocumento,numeroDocumento,email,telefono,nombreAcudiente,cursoActual,fechaNacimiento);
                    newEstudiante.AgregarCalificacion();
                    AdministradorApp.AgregarEstudiante(newEstudiante);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"******************************************* ¡Estudiante agregado exitosamente!*******************************************");
                Console.ResetColor();
                Volver();
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
                
                Volver();
                break;
            case 3:
            //Mostrar eestudiante
                Console.WriteLine(@"
            ======================================================================================================
                                                     Lista de estudiantes
            ====================================================================================================== ");
                AdministradorApp.MostrarEstudiantes();
                Volver();
                break;
            case 4:
            //Agregar profesor
                Console.WriteLine(@"**************************************** Creación de un nuevo profesor ****************************************");
                
                 Console.WriteLine(@"**************************************** Creación de un nuevo estudiante ****************************************");

                Console.WriteLine("Ingresa el nombre del profesor: ");
                 string? nombreP = Console.ReadLine().Trim();

                Console.WriteLine("Ingresa el apellido del profesor: ");
                string? apellidoP = Console.ReadLine().Trim();

                Console.WriteLine("Ingresa el tipo de documento del profesor: ");
                string? tipoDocumentoP = Console.ReadLine().Trim();

                Console.WriteLine("Ingresa el numero de documento del profesor: ");
                string? numeroDocumentoP = Console.ReadLine().Trim();

                Console.WriteLine("Ingresa el email del profesor: ");
                string? emailP = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el telefono del estudiante: ");
                string? telefonoP = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el nombre del acudiente del estudiante: ");
                string? asignatura = Console.ReadLine().Trim();

                Console.WriteLine("Ingesa el curso actual del estudiante: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingesa la fecha de nacimiento del estudiante: YYYY/MM/DD ");
                string? fechaContratacion = Console.ReadLine();

                if (DateTime.TryParse(fechaContratacion, out DateTime fechaC));

                if (string.IsNullOrWhiteSpace(nombreP) &&  string.IsNullOrWhiteSpace(apellidoP) &&  string.IsNullOrWhiteSpace(numeroDocumentoP) && 
                    string.IsNullOrWhiteSpace(emailP) && string.IsNullOrWhiteSpace(telefonoP) &&  string.IsNullOrWhiteSpace(asignatura) ){

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Ey! Alguno de los datos ingresados no son validos !");
                        Console.ResetColor();
                }else{
                    Profesor primeroProfesor = new Profesor(nombreP,apellidoP,tipoDocumentoP,numeroDocumentoP,emailP,telefonoP,asignatura,salario,fechaC);
                    AdministradorApp.AgregarProfesor(primeroProfesor);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"**************************************** ¡Profesor agregado exitosamente! ****************************************");
                Console.ResetColor();
                Volver();
                break;

            case 5:
                 //editar profesor
                Console.WriteLine("Por favor ingrese el id del profesor que desea editar:");
                string? idP = Console.ReadLine();
                var encontradoP = AdministradorApp.Profesor.FirstOrDefault(item => item.IdProfesor() == idP );

                if (encontradoP == null)
                {
                    Console.WriteLine("Lo sentimos, el profesor que quieres editar no se encuentra en nuestra lista");
                }else
                {
                    encontradoP.editar(idP);
                }

                Volver();
              
                break;
            case 6:
                Console.WriteLine(@"
            ======================================================================================================
                                                     Lista de profesores
            ====================================================================================================== ");
                AdministradorApp.MostrarProfesores();
                Volver();
                break;
            case 7:
            //Eliminar 
                AdministradorApp.Eliminar();
                Volver();
                break;
            default:
                // Console.ForegroundColor = ConsoleColor.Red;
                // Console.WriteLine("El dato ingresado no es correcto...");
                // Console.ResetColor();
                // Volver();
                break;
           }

        } while (true);

    }

    static void Volver(){
        Console.WriteLine("Ingrese cualquier letra para volver al menu :");
        Console.Read();
        Console.Clear();
    }

}

