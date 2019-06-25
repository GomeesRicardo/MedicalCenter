using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Repositories
{
    public class AgendamentoEntityFrameworkRepository : IAgendamentoRepository
    {
        private readonly MedicalCenterContext _db;

        public AgendamentoEntityFrameworkRepository()
        {
            _db = new MedicalCenterContext();
        }

        public void Create(Agendamentos entity)
        {
            _db.Agendamentos.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Agendamentos Read(Guid id)
        {
            //return _db.Agendamentos.Find(id);

            var lst = _db.Agendamentos.AsNoTracking();
            lst = lst.Include("Pacientes");
            lst = lst.Include("Exames");
            lst = lst.Include("Clinicas");
            return lst.First(x => x.Id == id);
        }

        public IEnumerable<Agendamentos> ReadAll()
        {
            var lst = _db.Agendamentos.AsNoTracking();
            lst = lst.Include("Pacientes");
            lst = lst.Include("Exames");
            lst = lst.Include("Clinicas");
            return lst;
        }

        public void Update(Agendamentos entity)
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
