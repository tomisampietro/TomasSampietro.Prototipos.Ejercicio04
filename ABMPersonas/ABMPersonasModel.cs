using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomasSampietro.Prototipos.Ejercicio04.ABMPersonas
{
    internal class ABMPersonasModel
    {
        //Creo una lista de personas, y le meto valores de prueba.
        public List<Persona> Personas { get; private set; } = new List<Persona>
        {
            new Persona { DNI = 12345678, Nombre = "Juan", Apellido = "Perez", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 11 },
            new Persona { DNI = 87654321, Nombre = "María", Apellido = "Gómez", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 221 },
            new Persona { DNI = 11223344, Nombre = "Pedro", Apellido = "Martínez", TipoTelefono = TiposTelefono.Otro, CodigoPais = 1, CodigoArea = 212 },
            new Persona { DNI = 44332211, Nombre = "Lucía", Apellido = "Fernández", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 351 },
            new Persona { DNI = 55667788, Nombre = "Roberto", Apellido = "López", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 34, CodigoArea = 91 },
            new Persona { DNI = 88776655, Nombre = "Ana", Apellido = "Rodríguez", TipoTelefono = TiposTelefono.Otro, CodigoPais = 44, CodigoArea = 20 },
            new Persona { DNI = 33445566, Nombre = "Santiago", Apellido = "Méndez", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 11 },
            new Persona { DNI = 66554433, Nombre = "Carolina", Apellido = "Ramírez", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 341 },
            new Persona { DNI = 99887766, Nombre = "Federico", Apellido = "Alvarez", TipoTelefono = TiposTelefono.Otro, CodigoPais = 33, CodigoArea = 1 },
            new Persona { DNI = 11224466, Nombre = "Sofía", Apellido = "Silva", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 261 },
            new Persona { DNI = 77553322, Nombre = "Guillermo", Apellido = "Sosa", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 11 },
            new Persona { DNI = 22334455, Nombre = "Laura", Apellido = "Morales", TipoTelefono = TiposTelefono.Otro, CodigoPais = 55, CodigoArea = 11 },
            new Persona { DNI = 55443322, Nombre = "Diego", Apellido = "Herrera", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 264 },
            new Persona { DNI = 44331122, Nombre = "Valentina", Apellido = "Nuñez", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 34, CodigoArea = 93 },
            new Persona { DNI = 33225544, Nombre = "Lucas", Apellido = "Castro", TipoTelefono = TiposTelefono.Otro, CodigoPais = 1, CodigoArea = 305 },
            new Persona { DNI = 77668899, Nombre = "Florencia", Apellido = "Vega", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 342 },
            new Persona { DNI = 88996655, Nombre = "Nicolás", Apellido = "Cabrera", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 49, CodigoArea = 30 },
            new Persona { DNI = 99882255, Nombre = "Gabriela", Apellido = "Reyes", TipoTelefono = TiposTelefono.Otro, CodigoPais = 54, CodigoArea = 385 },
            new Persona { DNI = 44112233, Nombre = "Matías", Apellido = "Pereira", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 11 },
            new Persona { DNI = 55998877, Nombre = "Juliana", Apellido = "Ortiz", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 44, CodigoArea = 131 },
            new Persona { DNI = 66557788, Nombre = "Ignacio", Apellido = "Vargas", TipoTelefono = TiposTelefono.Otro, CodigoPais = 33, CodigoArea = 55 },
            new Persona { DNI = 88442211, Nombre = "Paula", Apellido = "Serrano", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 381 },
            new Persona { DNI = 99223344, Nombre = "Esteban", Apellido = "Molina", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 261 },
            new Persona { DNI = 11335566, Nombre = "Andrea", Apellido = "Aguirre", TipoTelefono = TiposTelefono.Otro, CodigoPais = 54, CodigoArea = 376 },
            new Persona { DNI = 22667788, Nombre = "Emiliano", Apellido = "Rojas", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 11 },
            new Persona { DNI = 33889977, Nombre = "Martina", Apellido = "Cáceres", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 221 },
            new Persona { DNI = 55664433, Nombre = "Franco", Apellido = "Salinas", TipoTelefono = TiposTelefono.Otro, CodigoPais = 54, CodigoArea = 343 },
            new Persona { DNI = 66778899, Nombre = "Victoria", Apellido = "Ibáñez", TipoTelefono = TiposTelefono.Casa, CodigoPais = 1, CodigoArea = 646 },
            new Persona { DNI = 77889966, Nombre = "Gonzalo", Apellido = "Luna", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 11 },
            new Persona { DNI = 88991122, Nombre = "Camila", Apellido = "Blanco", TipoTelefono = TiposTelefono.Otro, CodigoPais = 54, CodigoArea = 223 },
            new Persona { DNI = 11227788, Nombre = "Facundo", Apellido = "Benítez", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 381 },
            new Persona { DNI = 12334455, Nombre = "Milagros", Apellido = "Medina", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 264 },
            new Persona { DNI = 44332299, Nombre = "Joaquín", Apellido = "Escobar", TipoTelefono = TiposTelefono.Otro, CodigoPais = 34, CodigoArea = 91 },
            new Persona { DNI = 55443377, Nombre = "Agustina", Apellido = "Valdez", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 341 },
            new Persona { DNI = 77668844, Nombre = "Tomás", Apellido = "Quintero", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 11 },
            new Persona { DNI = 99881122, Nombre = "Malena", Apellido = "Pizarro", TipoTelefono = TiposTelefono.Otro, CodigoPais = 44, CodigoArea = 20 },
            new Persona { DNI = 11224455, Nombre = "Sebastián", Apellido = "Funes", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 223 },
            new Persona { DNI = 44332277, Nombre = "Isabel", Apellido = "Brito", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 376 },
            new Persona { DNI = 66554411, Nombre = "Ramiro", Apellido = "Zapata", TipoTelefono = TiposTelefono.Otro, CodigoPais = 54, CodigoArea = 261 },
            new Persona { DNI = 88776699, Nombre = "Elena", Apellido = "Domínguez", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 351 },
            new Persona { DNI = 33445599, Nombre = "Bruno", Apellido = "Leiva", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 11 },
            new Persona { DNI = 55667722, Nombre = "Lorena", Apellido = "García", TipoTelefono = TiposTelefono.Otro, CodigoPais = 54, CodigoArea = 221 },
            new Persona { DNI = 77668855, Nombre = "Germán", Apellido = "Correa", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 555 }
        };

        public string BorrarPersona(Persona persona)
        {
            //validaciones


            Personas.Remove(persona);
            return null; //ok. 
        }
    }
}
