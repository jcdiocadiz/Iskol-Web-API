using Iskol.Adviser.Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iskol.Adviser.Api.Domain.Entities
{
    public class Subject : AuditableBaseEntity
    {
        public string SubjectName { get; set; }
    }
}
