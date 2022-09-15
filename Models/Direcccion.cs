using System;
using System.Collections.Generic;

namespace MudBlazorTemplates4.Models
{
    public partial class Direcccion
    {
        public int IdDireccion { get; set; }
        public string Zona { get; set; } = null!;
        public string TipoCalle { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Num1 { get; set; } = null!;
        public string Num2 { get; set; } = null!;
        public string Num3 { get; set; } = null!;
        public int FkIdPersona { get; set; }

        public virtual Persona FkIdPersonaNavigation { get; set; } = null!;
    }
}
