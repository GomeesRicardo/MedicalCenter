using MedicalCenter.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MedicalCenter.DomainModel.Entities
{
    [Table("Pacientes")]
    public class Pacientes : EntityBase<Guid>
    {

        public string cpf { get; set; }
        public string nome { get; set; }
        public Endereco endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public virtual ICollection<Agendamentos> Agendamentos { get; set; }

        public Pacientes()
        {
            Agendamentos = new List<Agendamentos>();
        }
    }
}
