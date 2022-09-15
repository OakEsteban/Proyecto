using System;
using System.Collections.Generic;

namespace MudBlazorTemplates4.Models
{
    public partial class Mecanico
    {
        public int IdMecanico { get; set; }
        public string NivelEducativo { get; set; } = null!;
        public int FkIdPersona { get; set; }

        public virtual Persona FkIdPersonaNavigation { get; set; } = null!;
    }
}
