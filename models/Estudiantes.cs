using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public class Estudiantes : Persona
    {
        public string? NombreAcudiente;
        public string? CursoActual;
        public DateOnly FechaNacimiento;
        public List<double> Calificaciones;

        //Constructor
        


        //Miembros metodos
        public void AgregarCalificacio(){

        }

        public void CalcularPromedio(){

        }

        public int CalcularEdad(){
            return 2;
        }

    }
}