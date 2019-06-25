using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Repositories
{
    public class ClinicaEntityFrameworkRepository : IClinicaRepository
    {
        private readonly MedicalCenterContext _db;

        public ClinicaEntityFrameworkRepository()
        {
            _db = new MedicalCenterContext();
        }

        public void Create(Clinicas entity)
        {
            _db.Clinicas.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Clinicas Read(Guid id)
        {
            return _db.Clinicas.Find(id);
        }

        public IEnumerable<Clinicas> ReadAll()
        {
            return _db.Clinicas;
        }

        public void Update(Clinicas entity)
        {
            _db.Clinicas.Update(entity);
            _db.SaveChanges();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
