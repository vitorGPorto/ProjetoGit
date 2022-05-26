using System;
using System.Threading.Tasks;

namespace ProjetoGit.Services
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
    }
}
