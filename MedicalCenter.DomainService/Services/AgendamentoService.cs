using MedicalCenter.DomainModel.Entities;
using MedicalCenter.DomainModel.Interfaces.Repositories;
using MedicalCenter.DomainService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCenter.DomainService.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _AgendamentoRepository;

        public AgendamentoService(IAgendamentoRepository AgendamentoRepository)
        {
            _AgendamentoRepository = AgendamentoRepository;
        }

        public IEnumerable<Agendamentos> ReadAll()
        {
            return _AgendamentoRepository.ReadAll();
        }

        public void Create(Agendamentos Agendamento)
        {
            if (!VerificarDataHoraAproximadaNaClinica(Agendamento))
            {
                _AgendamentoRepository.Create(Agendamento);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Já existe um Exame marcado nesta Data/Hora para esta Clinica");
            }
        }

        public void Update(Agendamentos Agendamento)
        {
            if (!VerificarDataHoraAproximadaNaClinica(Agendamento))
            {
                _AgendamentoRepository.Update(Agendamento);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Já existe um Exame marcado nesta Data/Hora para esta Clinica");
            }
        }

        public Agendamentos Read(Guid id)
        {
            return _AgendamentoRepository.Read(id);
        }

        public void Delete(Guid id)
        {
            _AgendamentoRepository.Delete(id);
        }

        public void SaveChanges()
        {
            _AgendamentoRepository.SaveChanges();
        }

        public bool VerificarDataHoraAproximadaNaClinica(Agendamentos Agendamento)
        {
            bool existeAgendamento = false;

            var outrosAgendamentos = ReadAll().Where(x => x.Id != Agendamento.Id);
            existeAgendamento = outrosAgendamentos.Any(y => y.IdClinica == Agendamento.IdClinica && y.Data == Agendamento.Data);

            return existeAgendamento;
        }
    }
}

