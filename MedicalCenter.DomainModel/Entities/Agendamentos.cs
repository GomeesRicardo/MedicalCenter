using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MedicalCenter.DomainModel.Entities
{
     [Table("Agendamentos")]
    public class Agendamentos :  EntityBase<Guid>
    {
        public DateTime Data { get; set; }
        public String Observacao { get; set; }

        [ForeignKey("Clinicas")]
        [Column("IdClinica")]
        public Guid IdClinica { get; set; }

        [ForeignKey("Pacientes")]
        [Column("IdPaciente")]
        public Guid IdPaciente { get; set; }

        [ForeignKey("Exames")]
        [Column("IdExame")]
        public Guid IdExame { get; set; }

        public virtual Clinicas Clinicas { get; set; }
        public virtual Pacientes Pacientes { get; set; }
        public virtual Exames Exames { get; set; }
    }
}
