using System;
using System.Collections.Generic;

namespace MudBlazorTemplates4.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Administrativos = new HashSet<Administrativo>();
            Clientes = new HashSet<Cliente>();
            Direcccions = new HashSet<Direcccion>();
            Mecanicos = new HashSet<Mecanico>();
        }

        public int IdPersona { get; set; }
        [required]
        public string Nombre { get; set; } = null!;
        [required]
        public string Apellido { get; set; } = null!;
        [required]
        public int Telefono { get; set; }
        public DateTime? Nacimiento { get; set; }
       
        public Cliente Cliente { get; set; }
        public virtual ICollection<Administrativo> Administrativos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Direcccion> Direcccions { get; set; }
        public virtual ICollection<Mecanico> Mecanicos { get; set; }
    }
}
