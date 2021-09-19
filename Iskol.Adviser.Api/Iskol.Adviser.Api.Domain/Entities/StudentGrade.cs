using System;
using Iskol.Adviser.Api.Domain.Common;
namespace Iskol.Adviser.Api.Domain.Entities
{
    public class StudentGrade : AuditableBaseEntityBigTransactions
    {
        public Guid StudentId { get; set; }
        public Guid Section { get; set; }
        public int SubjectId { get; set; }
        public int Q1 { get; set; }
        public int Q2 { get; set; }
        public int Q3 { get; set; }
        public int Q4 { get; set; }
        public decimal SubjectGrade { get; set; }
    }
}
