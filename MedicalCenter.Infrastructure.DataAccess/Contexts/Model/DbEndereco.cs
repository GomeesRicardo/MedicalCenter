using MedicalCenter.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.Infrastructure.DataAccess.Contexts.Model
{
    public class DbEndereco
    {
        public Guid Id { get; set; }

        public Endereco Endereco { get; set; }
    }
}
