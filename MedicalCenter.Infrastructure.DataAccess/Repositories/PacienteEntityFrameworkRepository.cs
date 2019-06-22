using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using MedicalCenter.Infrastructure.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Repositories
{
    public class PacienteEntityFrameworkRepository : IPacienteRepository
    {
        private readonly MedicalCenterContext _db;

        public PacienteEntityFrameworkRepository(MedicalCenterContext db)
        {
            _db = db;
        }

        public void Create(Paciente entity)
        {
            _db.Pacientes.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Paciente Read(Guid id)
        {
            return _db.Pacientes.Find(id);
        }

        public IEnumerable<Paciente> ReadAll()
        {
            return _db.Pacientes;
        }

        public void Update(Paciente entity)
        {
            _db.Pacientes.Update(entity);
            _db.SaveChanges();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
