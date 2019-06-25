using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Repositories
{
    public class ExameEntityFrameworkRepository : IExameRepository
    {
        private readonly MedicalCenterContext _db;

        public ExameEntityFrameworkRepository()
        {
            _db = new MedicalCenterContext();
        }

        public void Create(Exames entity)
        {
            _db.Exames.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Exames Read(Guid id)
        {
            return _db.Exames.Find(id);
        }

        public IEnumerable<Exames> ReadAll()
        {
            return _db.Exames;
        }

        public void Update(Exames entity)
        {
            _db.Exames.Update(entity);
            _db.SaveChanges();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
