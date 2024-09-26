using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomasSampietro.Prototipos.Ejercicio04.ABMPersonas
{
    //PERSONA, es un DTO (Data Transfer Object), es un objeto que lo unico que hace es transferir datos. 
    internal class Persona //---> Esta estructura representa los datos que tiene el MODELO. 
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public TiposTelefono TipoTelefono { get; set; } //TiposTelefono es una enumeracion. 

        public int CodigoPais { get; set; }
        public int CodigoArea { get; set; }
    }
}
