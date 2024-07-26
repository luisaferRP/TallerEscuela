using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public class InterfazVisual 
    {
        public static void AdministrarPrograma(){
            Console.WriteLine(@"
            ================================================
                        ¿QUE DESEAS HACER?
            ================================================
                        1.Agregar.
                        2.Editar.
                        3.liminar.
                        4.Realizar Consultas.
            =================================================
            ");

        }
    }
}