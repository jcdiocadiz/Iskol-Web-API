using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iskol.Adviser.Api.Application.Features.Students.Queries.GetStudentById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Iskol.Adviser.Api.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class StudentController : BaseApiController
    {
        // GET: api/Student
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await Mediator.Send(new GetStudentByIdQuery { Id = id }));
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
