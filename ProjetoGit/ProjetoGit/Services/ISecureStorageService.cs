using System;
using System.Threading.Tasks;

namespace ProjetoGit.Services
{
    public interface ISecureStorageService
    {
        Task<string> SaveToken(string token);
        Task<string> GetToken();
        Task<bool> DeleteToken();

        Task<string> SaveUser(string login);
        Task<string> GetUser();

        Task<string> SaveAvatarUrl(string avatarUrl);
        Task<string> GetAvatarUrl();
    }
}
