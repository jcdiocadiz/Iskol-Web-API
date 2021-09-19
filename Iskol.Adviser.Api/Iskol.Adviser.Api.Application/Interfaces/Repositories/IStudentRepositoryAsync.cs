using Iskol.Adviser.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Iskol.Adviser.Api.Application.Interfaces.Repositories
{
    public interface IStudentRepositoryAsync : IGenericRepositoryAsync<Student>
    {
        Task<bool> IsLRMUnique(string lrn);
    }
}
