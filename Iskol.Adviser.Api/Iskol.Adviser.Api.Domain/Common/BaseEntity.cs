using System;
using System.Collections.Generic;
using System.Text;

namespace Iskol.Adviser.Api.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
    }
}
