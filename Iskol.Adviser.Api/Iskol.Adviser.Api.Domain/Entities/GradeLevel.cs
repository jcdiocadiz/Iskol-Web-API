using Iskol.Adviser.Api.Domain.Common;

namespace Iskol.Adviser.Api.Domain.Entities
{
    public class GradeLevel : AuditableBaseEntity
    {
        public int GradelevelNo { get; set; }
        public string GradeName { get; set; }
    }
}
