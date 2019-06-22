﻿using MedicalCenter.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalCenter.DomainModel.Interfaces.Repositories
{
    public interface IClinicaRepository : IRepository<Clinica, Guid>
    {
    }
}
