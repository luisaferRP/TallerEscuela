using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace TallerEscuela.models
{
    public class Profesor
    {
        public string? Asignatura;
        public double Salario;
        public DateTime FechaContratacion;
        public List<string> Cursos;

        //Miembro metodos
        public int CalcularAntiguedad(){
            return 2;
        }

        public void ObtenerSalario(){

        }

    }
}