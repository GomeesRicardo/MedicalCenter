using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MedicalCenter.DomainModel.Entities
{
    [Table("Exames")]
    public class Exames : EntityBase<Guid>
    {
        [Column("codigo_exame")]
        public string codigo_exame { get; set; }

        [Column("nome")]
        public string nome { get; set; }
    }
}
