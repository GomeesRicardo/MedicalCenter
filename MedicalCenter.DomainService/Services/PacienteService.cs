using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using MedicalCenter.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCenter.DomainService.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _PacienteRepository;

        public PacienteService(IPacienteRepository PacienteRepository)
        {
            _PacienteRepository = PacienteRepository;
        }

        public IEnumerable<Paciente> ReadAll()
        {
            return _PacienteRepository.ReadAll();
        }

        public void Create(Paciente Paciente)
        {
            _PacienteRepository.Create(Paciente);
        }

        public void Update(Paciente Paciente)
        {
            _PacienteRepository.Update(Paciente);
        }

        public Paciente Read(Guid id)
        {
            return _PacienteRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _PacienteRepository.Delete(id);
        }

        public void Complete()
        {
            _PacienteRepository.SaveChanges();
        }
    }
}

