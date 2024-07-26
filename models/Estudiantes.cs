using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Timers;

namespace TallerEscuela.models
{
    public class Estudiante : Persona
    {
        public string? NombreAcudiente;
        public string? CursoActual;
        public DateOnly FechaNacimiento;
        public List<double> Calificaciones;

        //Constructor
        public Estudiante(string nombre,string apellido,string tipoDocumento,string numeroDocumento,
        string email,string telefono,string nombreAcudiente,string cursoActual,DateOnly fechaNacimiento): base(nombre,apellido,tipoDocumento,numeroDocumento,email,telefono)
        {
            this.NombreAcudiente = nombreAcudiente;
            this.CursoActual = cursoActual;
            this.FechaNacimiento = fechaNacimiento;

            Calificaciones = new List<double>(){};
        }

        //id
        public string IdEstudiantes(){
            return this.Id.ToString();
        }

        //Mostrar detalle de la clase base
        public override void MostrarDetalles()
        {
            //mostramos el detalle de la clase base
            base.MostrarDetalles();

            string calificacionesDetalles = string.Join(", ", Calificaciones.Select(item => item.ToString()));

            // Mostramos los detalles específicos de Estudiante
            Console.WriteLine(@$"
            Nombre del acudiente : {NombreAcudiente,-10} , Curso: {CursoActual,-10} , Fecha de Nacimiento: {FechaNacimiento:yyyy-MM-dd,-10} ,Calificaciones: {calificacionesDetalles}");
        }


        public void editar(string id)
        {
            int op = 0;
            Console.WriteLine(@$"
            ************************
            Que deseas editar? :
            1. Nombre.
            2. Apellido.
            3. Las calificaciones.
            *************************");
            op = Convert.ToInt16(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine($"Ingresa el nuevo nombre del estudiante: ");
                    string? nombre = Console.ReadLine();
                    this.Nombre = nombre;
                    break;
                case 2:
                    Console.WriteLine($"Ingresa el nuevo apellido del estudiante: ");
                    string? apellido = Console.ReadLine();
                    this.Apellido = apellido;
                    break;
                case 3:
                    Console.WriteLine("Notas actuales: ");
                    Console.Write("[");
                    Calificaciones.ForEach(cali => Console.Write(" " + cali + " "));
                    Console.WriteLine("]");
                    Calificaciones.Clear();
                    AgregarCalificacion();
                    break;
                default:
                    Console.WriteLine("Ingresa una opcion valida");
                    break;
            }
        }



        //Miembros metodos
        public void AgregarCalificacion(){
            Console.WriteLine("¿Cuantas calificaciones desea agregar?");
            int total = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Calificacion {0}: ",i);
                double notas = Convert.ToDouble(Console.ReadLine());
                Calificaciones.Add(notas);
            }
        }

        public void CalcularPromedio(){

        }

        public int CalcularEdad(){
            return 2;
        }

    }
}