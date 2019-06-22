using MedicalCenter.DomainModel.Entities;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Repositories
{
    public class ExameEntityFrameworkRepository
    {
        private readonly MedicalCenterContext _db;

        public ExameEntityFrameworkRepository(MedicalCenterContext db)
        {
            _db = db;
        }

        public void Create(Exame entity)
        {
            _db.Exames.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Exame Read(Guid id)
        {
            return _db.Exames.Find(id);
        }

        public IEnumerable<Exame> ReadAll()
        {
            return _db.Exames;
        }

        public void Update(Exame entity)
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
