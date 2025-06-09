using HelpApp.Domain.Account;
using Microsoft.AspNetCore.Identity;

namespace HelpApp.Infra.Data.Identity
{
    public class AuthenticationService : IAuthenticate
    {
        public Task<bool> Authenticate(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Logout()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
