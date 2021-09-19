using System;
using Iskol.Adviser.Api.Domain.Common;

namespace Iskol.Adviser.Api.Domain.Entities
{
    public class SectionSubject : AuditableBaseEntityBigTransactions
    {
        public Guid SectionId { get; set; }
        public int SubjectId { get; set; }
    }
}
