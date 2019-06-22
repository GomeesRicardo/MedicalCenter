using MedicalCenter.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.DomainModel.Entities
{
    public class Paciente : EntityBase<Guid>
    {
        public string cpf { get; set; }
        public string nome { get; set; }

        public Endereco Endereco { get; set; }

        public string telefone { get; set; }
        public string email { get; set; }
    }
}
