using System;
using System.Collections.Generic;

namespace MudBlazorTemplates4.Models
{
    public partial class Diagnostico
    {
        public int IdDig { get; set; }
        public string? NAceite { get; set; }
        public DateTime? DAceite { get; set; }
        public string? NRefrigerante { get; set; }
        public DateTime? DRefrigerante { get; set; }
        public string? NFrenos { get; set; }
        public DateTime? DFrenos { get; set; }
        public string? NDirecion { get; set; }
        public DateTime? DDireccion { get; set; }
        public string? Repuesto { get; set; }
        public int FkIdVehiculo { get; set; }

        public virtual Vehiculo FkIdVehiculoNavigation { get; set; } = null!;
    }
}
