using System;
using System.Collections.Generic;
using System.Text;

namespace Iskol.Adviser.Api.Domain.Common
{
    public abstract class AuditableBaseEntityBigTransactions
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }

    }
}
