using System;
using Iskol.Adviser.Api.Application.Interfaces.Repositories;

namespace Iskol.Adviser.Api.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IStudentRepositoryAsync StudentRepositoryAsync { get; }
        void BeginTransaction(bool beginDatabaseTransaction);
        void Commit();
        void Rollback();
    }
}
