using MedicalCenter.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.DomainService.Interfaces
{
    public interface IPacienteService
    {
        IEnumerable<Paciente> ReadAll();
        void Create(Paciente Paciente);
        void Update(Paciente Paciente);
        Paciente Read(Guid id);
        void Delete(Guid id);
        void Complete();

    }
}
