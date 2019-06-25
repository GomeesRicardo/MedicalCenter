using MedicalCenter.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.DomainService.Interfaces
{
    public interface IAgendamentoService : IService<Agendamentos, Guid>
    {
        bool VerificarDataHoraAproximadaNaClinica(Agendamentos Agendamento);
    }
}
