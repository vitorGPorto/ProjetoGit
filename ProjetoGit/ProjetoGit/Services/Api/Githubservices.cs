using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
        public async Task<List<Organization>> GetListOrganization(string token)
        {
            var uri = $"{BASE_URI}/user/orgs";
            try
            {
               
             return await _requestProvider.GetAsync<List<Organization>>(uri, token);
                
            }
            catch (Exception x)
            {
                return null;
            }
        }
        public async Task<User> GetRepositorio(string token)
        {
            var uri = $"{BASE_URI}/user/repos";

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

