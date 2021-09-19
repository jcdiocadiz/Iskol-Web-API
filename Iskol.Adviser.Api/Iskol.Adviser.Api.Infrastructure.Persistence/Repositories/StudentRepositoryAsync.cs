using Iskol.Adviser.Api.Application.Interfaces.Repositories;
using Iskol.Adviser.Api.Domain.Entities;
using Iskol.Adviser.Api.Infrastructure.Persistence.Contexts;
using Iskol.Adviser.Api.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Iskol.Adviser.Api.Infrastructure.Persistence.Repositories
{
    public class StudentRepositoryAsync : GenericRepositoryAsync<Student>, IStudentRepositoryAsync
    {
        private readonly DbSet<Student> _students;
        public StudentRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _students = dbContext.Set<Student>();
        }

        public Task<bool> IsLRMUnique(string lrn)
        {
            return _students.AllAsync(s => s.LRN != lrn);
        }
    }
}
