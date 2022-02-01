using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ProjetoGit.Services
{
    public class SecureStorageService : ISecureStorageService
    {
        const string TOKEN_KEY = "secure_token";
        const string Login = "secure_login";
        const string AvatarUrl = "secure_AvatarUrl";
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

        public async Task<string> SaveUser(string login)
        {
            await SecureStorage.SetAsync(Login, login);
            return login;
        }

        public async Task<string> GetUser()
        {
            return await SecureStorage.GetAsync(Login);
        }
        public async Task<string> SaveAvatarUrl(string avatarUrl)
        {
            await SecureStorage.SetAsync(AvatarUrl, avatarUrl);
            return AvatarUrl;
        }

        public async Task<string> GetAvatarUrl()
        {
            return await SecureStorage.GetAsync(AvatarUrl);
        }
    }
}
