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

        //editar profesor
        public void editar(string id)
        {
            int op = 0;
            Console.WriteLine(@$"
            ************************
            Que deseas editar? :
            1. Asignatura.
            2. Salario.
            *************************");
            op = Convert.ToInt16(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine($"Ingresa el nuevo nombre de la asignatura: ");
                    string? asignatura = Console.ReadLine();
                    this.Asignatura = asignatura;
                    break;
                case 2:
                    Console.WriteLine($"Ingresa el nuevo salario: ");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    this.Salario = salario;
                    break;
                  
                default:
                    Console.WriteLine("Ingresa una opcion valida");
                    break;
            }
        }

        //Miembro metodos
        public int CalcularAntiguedad(){
            return 2;
        }

        public void ObtenerSalario(){

        }

    }
}