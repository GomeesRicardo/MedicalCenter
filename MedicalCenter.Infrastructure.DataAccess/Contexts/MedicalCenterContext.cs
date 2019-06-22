using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.ValueObjects;
//using MedicalCenter.Infrastructure.DataAccess.Contexts.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Contexts
{
    public class MedicalCenterContext : DbContext
    {
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }

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
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Paciente>()
                .Property(paciente => paciente.Endereco)
                .HasConversion(
                    endereco => endereco.ToString(),
                    endereco => Endereco.Parse(endereco))
                .HasColumnName("endereco");

            modelBuilder
                .Entity<Clinica>()
                .Property(clinica => clinica.Endereco)
                .HasConversion(
                    endereco => endereco.ToString(),
                    endereco => Endereco.Parse(endereco))
                .HasColumnName("endereco");
        }
    }
}
