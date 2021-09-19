using Iskol.Adviser.Api.Domain.Common;

namespace Iskol.Adviser.Api.Domain.Entities
{
    public class Section : AuditableBaseEntityBigTransactions
    {
        public int SchoolYearId { get; set; }
        public int SchoolDays { get; set; }
        public int UserId { get; set; }
        public string SectionName { get; set; }
        public int GradeLevelId { get; set; }
    }
}
