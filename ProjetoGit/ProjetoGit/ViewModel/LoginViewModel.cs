using ProjetoGit.Services;
using ProjetoGit.Services.Api;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoGit.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public string Token { get; set; }

        public ICommand LoginCommand { get; set; }

        private ISecureStorageService _secureStorageService;
        private IGithubService _githubService;

        public LoginViewModel(ISecureStorageService secureStorageService, IGithubService githubService)
        {
            _secureStorageService = secureStorageService;
            _githubService = githubService;

            LoginCommand =  new Command(async ()=> await LoginCommandAction());
        }

        private async Task LoginCommandAction()
        {
            // TODO: implement loader on page using this property
            IsBusy = true;

            // validar
            // request api
            var authenticatedUser = await _githubService.GetAuthenticatedUser(Token);
            if (authenticatedUser != null)
            {
                await _secureStorageService.SaveToken(Token);
                // success message
                // redirect to new page
            }
            else
            {
                // fail message;
            }

            IsBusy = false;
        }
    }
}
