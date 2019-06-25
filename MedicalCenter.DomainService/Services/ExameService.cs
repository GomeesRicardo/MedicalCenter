using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using MedicalCenter.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCenter.DomainService.Services
{
    public class ExameService : IExameService
    {
        private readonly IExameRepository _ExameRepository;

        public ExameService(IExameRepository ExameRepository)
        {
            _ExameRepository = ExameRepository;
        }

        public IEnumerable<Exames> ReadAll()
        {
            return _ExameRepository.ReadAll();
        }

        public void Create(Exames Exame)
        {
            _ExameRepository.Create(Exame);
        }

        public void Update(Exames Exame)
        {
            _ExameRepository.Update(Exame);
        }

        public Exames Read(Guid id)
        {
            return _ExameRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _ExameRepository.Delete(id);
        }

        public void SaveChanges()
        {
            _ExameRepository.SaveChanges();
        }
    }
}

