using MedicalCenter.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.DomainService.Interfaces
{
    public interface IService<T, EntityId> where T : EntityBase<EntityId>
    {
        void Create(T entity);
        T Read(EntityId id);
        IEnumerable<T> ReadAll();
        void Update(T entity);
        void Delete(EntityId id);
        void SaveChanges();
    }
}
