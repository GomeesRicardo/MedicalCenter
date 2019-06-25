using MedicalCenter.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MedicalCenter.DomainModel.Entities
{
    [Table("Clinicas")]
    public class Clinicas : EntityBase<Guid>
    {
        public string cnpj { get; set; }
        public string nome { get; set; }
        public Endereco endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
