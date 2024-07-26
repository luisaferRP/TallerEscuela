using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public class Persona
    {
        protected Guid Id;
        protected string? Nombre;
        protected string? Apellido;
        protected string? TipoDocumento;
        protected string? NumeroDocumento;
        protected string? Email;
        protected string? Telefono;

        public Persona(string nombre,string apellido,string tipoDocumento,string numeroDocumento,string email,string telefono){
            this.Id= Guid.NewGuid();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Email = email;
            this.Telefono = telefono;
        }

        // Miembro método virtual,permitir que las clases derivadas lo sobreescriban
        public virtual void MostrarDetalles()
        {
            Console.WriteLine(@$"
        ____________________________________________________________________________________________________________________
        Id: {Id,-10} ,
        Nombre :{Nombre,-10} , Apellido: {Apellido,-10}
        Tipo Documento: {TipoDocumento,-10} , Numero Documento : {NumeroDocumento,-10}
        Email: {Email,-10} ,Telefono : {Telefono,-10} ");

        }
    }
}