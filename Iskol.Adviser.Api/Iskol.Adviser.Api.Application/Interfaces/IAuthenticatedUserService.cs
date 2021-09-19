using System;
using System.Collections.Generic;
using System.Text;

namespace Iskol.Adviser.Api.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
