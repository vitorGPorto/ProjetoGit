using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ProjetoGit.Services
{
    public class SecureStorageService : ISecureStorageService
    {
        const string TOKEN_KEY = "secure_token";

        public SecureStorageService()
        {
        }

        public async Task<string> SaveToken(string token)
        {
            await SecureStorage.SetAsync(TOKEN_KEY, token);
            return token;
        }

        public async Task<string> GetToken()
        {
            return await SecureStorage.GetAsync(TOKEN_KEY);
        }

        public Task<bool> DeleteToken()
        {
            try
            {
                SecureStorage.Remove(TOKEN_KEY);
                return Task.Run(() => true);
            }
            catch 
            {
                return Task.Run(() => false);
            }
        }
    }
}
