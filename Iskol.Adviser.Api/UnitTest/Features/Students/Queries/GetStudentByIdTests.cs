using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Iskol.Adviser.Api.Application.Features.Students.Queries.GetStudentById;
using Iskol.Adviser.Api.Application.Interfaces.Repositories;
using Iskol.Adviser.Api.Domain.Entities;
using static Iskol.Adviser.Api.Application.Features.Students.Queries.GetStudentById.GetStudentByIdQuery;
using Iskol.Adviser.Api.Application.Interfaces;

namespace UnitTest.Features.Students.Queries
{
    [TestClass]
    public class GetStudentByIdTests
    {
        [TestClass]
        public class GetProductByIdTests
        {
            [TestMethod]
            public async Task GetProductById_WhenProductNotExists_ReturnsException()
            {
                //arrange
                Mock<IUnitOfWork> mockUnitOfWork = new Mock<IUnitOfWork>();
                mockUnitOfWork.Setup(c => c.StudentRepositoryAsync.GetByGuidIdAsync(It.IsAny<Guid>())).Returns(Task.FromResult<Student>(null));
                var eventHandler = new GetStudentByIdQueryHandler(mockUnitOfWork.Object);
                try
                {
                    //act
                    var response = await eventHandler.Handle(new Mock<GetStudentByIdQuery>().Object, It.IsAny<CancellationToken>());
                }
                catch (Exception ex)
                {
                    //assert
                    mockUnitOfWork.Verify(c => c.StudentRepositoryAsync.GetByGuidIdAsync(It.IsAny<Guid>()), Times.Once);
                    Assert.AreEqual($"Student Not Found.", ex.Message);
                }
            }


            [TestMethod]
            public async Task GetProductById_WhenProductExists_ReturnsProductSuccess()
            {
                //arrange
                Mock<IUnitOfWork> mockUnitOfWork = new Mock<IUnitOfWork>();
                mockUnitOfWork.Setup(c => c.StudentRepositoryAsync.GetByGuidIdAsync(It.IsAny<Guid>())).Returns(Task.FromResult<Student>(new Student() { Id = It.IsAny<Guid>() }));
                var eventHandler = new GetStudentByIdQueryHandler(mockUnitOfWork.Object);

                //act
                var response = await eventHandler.Handle(new Mock<GetStudentByIdQuery>().Object, It.IsAny<CancellationToken>());

                //assert
                mockUnitOfWork.Verify(c => c.StudentRepositoryAsync.GetByGuidIdAsync(It.IsAny<Guid>()), Times.Once);
                Assert.IsTrue(response.Data != null);
                Assert.IsTrue(((Student)response.Data).Id == It.IsAny<Guid>());
            }
        }
    }
}