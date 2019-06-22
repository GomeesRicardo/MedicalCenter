using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MedicalCenter.DomainService.Interfaces;

namespace MedicalCenter.DomainService
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _vendorRepository;

        public PacienteService(IPacienteRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public IEnumerable<Paciente> ReadAll()
        {
            return _vendorRepository.ReadAll();
        }

        public void Create(Paciente vendor)
        {
            _vendorRepository.Create(vendor);
        }

        public void Update(Paciente vendor)
        {
            _vendorRepository.Update(vendor);
        }

        public Paciente Read(Guid id)
        {
            return _vendorRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _vendorRepository.Delete(id);
        }

        public void Complete()
        {
            _vendorRepository.SaveChanges();
        }
    }
}
