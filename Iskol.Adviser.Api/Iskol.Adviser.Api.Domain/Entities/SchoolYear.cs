using Iskol.Adviser.Api.Domain.Common;
namespace Iskol.Adviser.Api.Domain.Entities
{
    public class SchoolYear : AuditableBaseEntity
    {
        public int MonthFrom { get; set; }
        public int YearFrom { get; set; }
        public int MonthTo { get; set; }
        public int YearTo { get; set; }
    }
}
