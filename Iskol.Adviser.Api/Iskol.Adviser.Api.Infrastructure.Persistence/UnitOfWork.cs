using System;
using Iskol.Adviser.Api.Application.Interfaces;
using Iskol.Adviser.Api.Application.Interfaces.Repositories;
using Iskol.Adviser.Api.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace Iskol.Adviser.Api.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        public IStudentRepositoryAsync StudentRepositoryAsync { get; }
        private bool _beginDatabaseTransaction;
        IDbContextTransaction _dbContextTransaction;

        public UnitOfWork(IStudentRepositoryAsync studentRepositoryAsync,
            ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            StudentRepositoryAsync = studentRepositoryAsync;
        }

        public void BeginTransaction(bool beginDatabaseTransaction)
        {
            _beginDatabaseTransaction = beginDatabaseTransaction;
            if (_beginDatabaseTransaction)
                _dbContextTransaction = _applicationDbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _applicationDbContext.SaveChanges();
            if (_beginDatabaseTransaction && _dbContextTransaction != null)
                _dbContextTransaction.Commit();
        }

        public void Rollback()
        {
            if (_beginDatabaseTransaction && _dbContextTransaction != null)
            {
                _dbContextTransaction.Rollback();
            }
        }

    }
}
