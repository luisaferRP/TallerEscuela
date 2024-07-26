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

        //miembro metodo
        public void MostrarDetalles(){
            
        }


    }
}