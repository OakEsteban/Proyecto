using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MudBlazorTemplates4.Models
{
    public partial class DbTalMContext : DbContext
    {
        public DbTalMContext()
        {
        }

        public DbTalMContext(DbContextOptions<DbTalMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrativo> Administrativos { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Diagnostico> Diagnosticos { get; set; } = null!;
        public virtual DbSet<Direcccion> Direcccions { get; set; } = null!;
        public virtual DbSet<Mecanico> Mecanicos { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Vehiculo> Vehiculos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
  //              optionsBuilder.UseSqlServer("Server=LocalHost;Database=DbTalM; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrativo>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("PK__Administ__B2C3ADE5503EA2C4");

                entity.ToTable("Administrativo");

                entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");

                entity.Property(e => e.FkIdPersona).HasColumnName("fk_idPersona");

                entity.Property(e => e.NivelEducativo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativo");

                entity.HasOne(d => d.FkIdPersonaNavigation)
                    .WithMany(p => p.Administrativos)
                    .HasForeignKey(d => d.FkIdPersona)
                    .HasConstraintName("FK_Administrativo_Persona");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__885457EE1F6E9359");

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Correo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.FkIdPersona).HasColumnName("fk_idPersona");

                entity.HasOne(d => d.FkIdPersonaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.FkIdPersona)
                    .HasConstraintName("FK_Cliente_Persona");
            });

            modelBuilder.Entity<Diagnostico>(entity =>
            {
                entity.HasKey(e => e.IdDig)
                    .HasName("PK__Diagnost__3E41658DF261C9F1");

                entity.ToTable("Diagnostico");

                entity.Property(e => e.IdDig).HasColumnName("idDig");

                entity.Property(e => e.DAceite)
                    .HasColumnType("date")
                    .HasColumnName("dAceite");

                entity.Property(e => e.DDireccion)
                    .HasColumnType("date")
                    .HasColumnName("dDireccion");

                entity.Property(e => e.DFrenos)
                    .HasColumnType("date")
                    .HasColumnName("dFrenos");

                entity.Property(e => e.DRefrigerante)
                    .HasColumnType("date")
                    .HasColumnName("dRefrigerante");

                entity.Property(e => e.FkIdVehiculo).HasColumnName("fk_idVehiculo");

                entity.Property(e => e.NAceite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nAceite");

                entity.Property(e => e.NDirecion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nDirecion");

                entity.Property(e => e.NFrenos)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nFrenos");

                entity.Property(e => e.NRefrigerante)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nRefrigerante");

                entity.Property(e => e.Repuesto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("repuesto");

                entity.HasOne(d => d.FkIdVehiculoNavigation)
                    .WithMany(p => p.Diagnosticos)
                    .HasForeignKey(d => d.FkIdVehiculo)
                    .HasConstraintName("FK_Diagnostico_Vehiculo");
            });

            modelBuilder.Entity<Direcccion>(entity =>
            {
                entity.HasKey(e => e.IdDireccion)
                    .HasName("PK__Direccci__B49878C9A2C1D97E");

                entity.ToTable("Direcccion");

                entity.Property(e => e.IdDireccion).HasColumnName("idDireccion");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.FkIdPersona).HasColumnName("fk_idPersona");

                entity.Property(e => e.Num1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("num1");

                entity.Property(e => e.Num2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("num2");

                entity.Property(e => e.Num3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("num3");

                entity.Property(e => e.TipoCalle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoCalle");

                entity.Property(e => e.Zona)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zona");

                entity.HasOne(d => d.FkIdPersonaNavigation)
                    .WithMany(p => p.Direcccions)
                    .HasForeignKey(d => d.FkIdPersona)
                    .HasConstraintName("FK_Direccion_Persona");
            });

            modelBuilder.Entity<Mecanico>(entity =>
            {
                entity.HasKey(e => e.IdMecanico)
                    .HasName("PK__Mecanico__4BBE2FDE35258FAF");

                entity.ToTable("Mecanico");

                entity.Property(e => e.IdMecanico).HasColumnName("idMecanico");

                entity.Property(e => e.FkIdPersona).HasColumnName("fk_idPersona");

                entity.Property(e => e.NivelEducativo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nivelEducativo");

                entity.HasOne(d => d.FkIdPersonaNavigation)
                    .WithMany(p => p.Mecanicos)
                    .HasForeignKey(d => d.FkIdPersona)
                    .HasConstraintName("FK_Mecanico_Persona");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Persona__A478814137E28C36");

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Nacimiento)
                    .HasColumnType("date")
                    .HasColumnName("nacimiento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo)
                    .HasName("PK__Vehiculo__486829700403DB0C");

                entity.ToTable("Vehiculo");

                entity.Property(e => e.IdVehiculo).HasColumnName("idVehiculo");

                entity.Property(e => e.Capacidad).HasColumnName("capacidad");

                entity.Property(e => e.Caracteristicas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("caracteristicas");

                entity.Property(e => e.Cilindrada).HasColumnName("cilindrada");

                entity.Property(e => e.Csoat)
                    .HasColumnType("date")
                    .HasColumnName("csoat");

                entity.Property(e => e.FkIdCliente).HasColumnName("fk_idCliente");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modelo");

                entity.Property(e => e.NombreMecanico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreMecanico");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Placa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("placa");

                entity.Property(e => e.TSoat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tSoat");

                entity.Property(e => e.TipoVehiculo)
                    .HasMaxLength(50)
                    .HasColumnName("tipoVehiculo");

                entity.Property(e => e.Vsoat)
                    .HasColumnType("date")
                    .HasColumnName("vsoat");

                entity.HasOne(d => d.FkIdClienteNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.FkIdCliente)
                    .HasConstraintName("FK_Vehiculo_Cliente");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
