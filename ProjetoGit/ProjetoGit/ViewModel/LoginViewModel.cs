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
        private IDialogService _dialogService;

        public LoginViewModel(ISecureStorageService secureStorageService, IGithubService githubService, IDialogService dialogService)
        {
            _secureStorageService = secureStorageService;
            _githubService = githubService;
            _dialogService = dialogService;

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
                await _dialogService.ShowAlertAsync("Your token is valid!", "Sucess", "OK");

                // TODO: redirect to new page
            }
            else
            {
                await _dialogService.ShowAlertAsync("Your token is invalid!", "Attention", "OK");
            }

            IsBusy = false;
        }
    }
}
