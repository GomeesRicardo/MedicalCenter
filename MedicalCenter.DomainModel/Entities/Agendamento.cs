using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.DomainModel.Entities
{
    public class Agendamento :  EntityBase<Guid>
    {
        public Guid IdClinica { get; set; }
        public Clinica Clinica { get; set; }

        public Guid IdPaciente { get; set; }
        public Paciente Paciente { get; set; }

        public virtual ICollection<Exame> Exames { get; set; }

        public DateTime Data { get; set; }

        public String Observacao { get; set; }

        public Agendamento()
        {
            Exames = new List<Exame>();
        }
    }
}
