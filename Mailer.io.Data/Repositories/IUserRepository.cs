using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mailer.io.Api.Models;
using Mailer.io.Models;
using Microsoft.AspNet.Identity;

namespace Mailer.io.Data.Repositories
{
    public interface IUserRepository:IDisposable
    {
        Task<IdentityResult> RegisterUser(RegisterViewModel viewModel);
        Task<ApplicationUser> FindUser(string userName, string password);
        Task<List<ApplicationUser>> GetUsers();
        ApplicationUser GetUser(string username);
    }
}