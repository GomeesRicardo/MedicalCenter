using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.ValueObjects;
//using MedicalCenter.Infrastructure.DataAccess.Contexts.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Contexts
{
    public class MedicalCenterContext : DbContext
    {
        public DbSet<Clinicas> Clinicas { get; set; }
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Exames> Exames { get; set; }
        public DbSet<Agendamentos> Agendamentos { get; set; }

        public MedicalCenterContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(Properties.Resources.
                ResourceManager.GetString("DbConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.RemovePluralizingTableNameConvention();

            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Pacientes>()
                .Property(paciente => paciente.endereco)
                .HasConversion(
                    endereco => endereco.ToString(),
                    endereco => Endereco.Parse(endereco))
                .HasColumnName("endereco");

            modelBuilder
                .Entity<Clinicas>()
                .Property(clinica => clinica.endereco)
                .HasConversion(
                    endereco => endereco.ToString(),
                    endereco => Endereco.Parse(endereco))
                .HasColumnName("endereco");


            //modelBuilder.Entity<Agendamentos>()
            //   .HasOne(p => p.Exames)
            //   .WithMany(b => b.Agendamentos)
            //   .HasForeignKey(p => p.IdExame);
        }
    }
}

public static class ModelBuilderExtensions
{
    public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
    {
        foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
        {
            entity.Relational().TableName = entity.DisplayName();
        }
    }
}