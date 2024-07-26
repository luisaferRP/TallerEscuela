using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace TallerEscuela.models
{
    public class Profesor : Persona
    {
        public string? Asignatura;
        public double Salario;
        public DateTime FechaContratacion;
        public List<string> Cursos;

        //Miembro constructor
        public Profesor(string nombre,string apellido,string tipoDocumento,string numeroDocumento,string email,string telefono,
        string asignatura,double salario,DateTime fechaContratacion): base(nombre,apellido,tipoDocumento,numeroDocumento,email,telefono){
            this.Asignatura = asignatura;
            this.Salario = salario;
            this.FechaContratacion = fechaContratacion;
        }

        //id
        public string IdProfesor(){
            return this.Id.ToString();
        }

        //Mostrar detalle de la clase base
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();

            Console.WriteLine(@$"
            Asignatura: {Asignatura,-10} °°° Salario :{Salario,-10} °°° Fecha de contratacion: {FechaContratacion: yyyy-mm-dd,-10} °°°");
        }

        //Miembro metodos
        public int CalcularAntiguedad(){
            return 2;
        }

        public void ObtenerSalario(){

        }

    }
}