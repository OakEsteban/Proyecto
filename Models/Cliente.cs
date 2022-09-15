using System;
using System.Collections.Generic;

namespace MudBlazorTemplates4.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdCliente { get; set; }
        public string Correo { get; set; } = null!;
        public int FkIdPersona { get; set; }
        

        public virtual Persona FkIdPersonaNavigation { get; set; } = null!;
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
