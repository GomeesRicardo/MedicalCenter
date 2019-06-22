using MedicalCenter.DomainModel.Entities;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Repositories
{
    public class ClinicaEntityFrameworkRepository
    {
        private readonly MedicalCenterContext _db;

        public ClinicaEntityFrameworkRepository(MedicalCenterContext db)
        {
            _db = db;
        }

        public void Create(Clinica entity)
        {
            _db.Clinicas.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Clinica Read(Guid id)
        {
            return _db.Clinicas.Find(id);
        }

        public IEnumerable<Clinica> ReadAll()
        {
            return _db.Clinicas;
        }

        public void Update(Clinica entity)
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
