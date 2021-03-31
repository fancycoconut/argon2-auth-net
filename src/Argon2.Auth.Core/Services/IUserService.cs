using Argon2.Auth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argon2.Auth.Core.Services
{
    public interface IUserService
    {
        Task<bool> SignIn();
        Task Register(User user);
    }
}
