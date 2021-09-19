using Iskol.Adviser.Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iskol.Adviser.Api.Domain.Entities
{
    public class Student : AuditableBaseEntityBigTransactions
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string ExtensionName { get; set; }
        public string Email { get; set; }
        public string LRN { get; set; }
        public string Status { get; set; }
    }
}
