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
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public IEnumerable<Pacientes> ReadAll()
        {
            return _pacienteRepository.ReadAll();
        }

        public void Create(Pacientes Paciente)
        {
            _pacienteRepository.Create(Paciente);
        }

        public void Update(Pacientes Paciente)
        {
            _pacienteRepository.Update(Paciente);
        }

        public Pacientes Read(Guid id)
        {
            return _pacienteRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _pacienteRepository.Delete(id);
        }

        public void SaveChanges()
        {
            _pacienteRepository.SaveChanges();
        }
    }
}

