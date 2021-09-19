using Iskol.Adviser.Api.Application.Exceptions;
using Iskol.Adviser.Api.Application.Interfaces;
using Iskol.Adviser.Api.Application.Interfaces.Repositories;
using Iskol.Adviser.Api.Application.Wrappers;
using Iskol.Adviser.Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Iskol.Adviser.Api.Application.Features.Students.Queries.GetStudentById
{
    public class GetStudentByIdQuery : IRequest<Response<Student>>
    {
        public Guid Id { get; set; }
        public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, Response<Student>>
        {
            //private readonly IStudentRepositoryAsync _studentRepositoryAsync;
            private readonly IUnitOfWork _unitOfWork;
            public GetStudentByIdQueryHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;

            }
            public async Task<Response<Student>> Handle(GetStudentByIdQuery query, CancellationToken cancellationToken)
            {
                var student = await _unitOfWork.StudentRepositoryAsync.GetByGuidIdAsync(query.Id);
                if (student == null) throw new ApiException($"Student Not Found.");
                return new Response<Student>(student);
            }
        }
    }
}
