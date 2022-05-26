using System.Threading.Tasks;
using ProjetoGit.Model;
using ProjetoGit.Services.Api;

namespace ProjetoGit.Services
{
    public class Githubservices : IGithubService
    {
        // TODO: consume from some shared preference service
        const string BASE_URI = "https://api.github.com";

        private IRequestProvider _requestProvider;

        public Githubservices(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }

        public async Task<User> GetAuthenticatedUser(string token)
        {
            var uri = $"{BASE_URI}/user";
            try
            {
                return await _requestProvider.GetAsync<User>(uri, token);
            }
            catch 
            {
                return null;
            }
        }
    }
}

