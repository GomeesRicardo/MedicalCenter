using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.DomainModel.Entities
{
    public class Exame : EntityBase<Guid>
    {
        public string codigo_exame { get; set; }
        public string nome { get; set; }
    }
}
