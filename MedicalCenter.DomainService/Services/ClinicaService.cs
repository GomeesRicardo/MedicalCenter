using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using MedicalCenter.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCenter.DomainService.Services
{
    public class ClinicaService : IClinicaService
    {
        private readonly IClinicaRepository _ClinicaRepository;

        public ClinicaService(IClinicaRepository ClinicaRepository)
        {
            _ClinicaRepository = ClinicaRepository;
        }

        public IEnumerable<Clinicas> ReadAll()
        {
            return _ClinicaRepository.ReadAll();
        }

        public void Create(Clinicas Clinica)
        {
            _ClinicaRepository.Create(Clinica);
        }

        public void Update(Clinicas Clinica)
        {
            _ClinicaRepository.Update(Clinica);
        }

        public Clinicas Read(Guid id)
        {
            return _ClinicaRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _ClinicaRepository.Delete(id);
        }

        public void SaveChanges()
        {
            _ClinicaRepository.SaveChanges();
        }
    }
}

