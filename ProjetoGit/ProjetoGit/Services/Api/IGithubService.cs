using ProjetoGit.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoGit.Services.Api
{
    public interface IGithubService
    {
        Task<User> GetAuthenticatedUser(string token);

        Task<List<Organization>> GetListOrganization(string token);

    }
}
