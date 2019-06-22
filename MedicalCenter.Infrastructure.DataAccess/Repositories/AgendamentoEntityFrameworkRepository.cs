using MedicalCenter.DomainModel.Entities;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Repositories
{
    public class AgendamentoEntityFrameworkRepository
    {
        private readonly MedicalCenterContext _db;

        public AgendamentoEntityFrameworkRepository(MedicalCenterContext db)
        {
            _db = db;
        }

        public void Create(Agendamento entity)
        {
            _db.Agendamentos.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Agendamento Read(Guid id)
        {
            return _db.Agendamentos.Find(id);
        }

        public IEnumerable<Agendamento> ReadAll()
        {
            return _db.Agendamentos;
        }

        public void Update(Agendamento entity)
        {
            _db.Agendamentos.Update(entity);
            _db.SaveChanges();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
