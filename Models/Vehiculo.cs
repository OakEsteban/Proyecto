using System;
using System.Collections.Generic;

namespace MudBlazorTemplates4.Models
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Diagnosticos = new HashSet<Diagnostico>();
        }

        public int IdVehiculo { get; set; }
        public string Placa { get; set; } = null!;
        public string TipoVehiculo { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public int Capacidad { get; set; }
        public int Cilindrada { get; set; }
        public string? Pais { get; set; }
        public string? Caracteristicas { get; set; }
        public string NombreMecanico { get; set; } = null!;
        public string TSoat { get; set; } = null!;
        public DateTime Csoat { get; set; }
        public DateTime Vsoat { get; set; }
        public int FkIdCliente { get; set; }

        public virtual Cliente FkIdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
    }
}
