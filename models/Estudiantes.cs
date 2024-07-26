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
            Nombre del acudiente : {NombreAcudiente,-10} , Curso: {CursoActual,-10} , Fecha de Nacimiento: {FechaNacimiento:yyyy-MM-dd,-10} ,Calificaciones: {calificacionesDetalles} °°°°");
        }



        //Miembros metodos
        public void AgregarCalificacion(double nota){
            Calificaciones.Add(nota);
        }

        public void CalcularPromedio(){

        }

        public int CalcularEdad(){
            return 2;
        }

    }
}