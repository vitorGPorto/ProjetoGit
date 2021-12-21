using ProjetoGit.Services;
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

        public LoginViewModel()
        {
            LoginCommand =  new Command(async ()=> await LoginCommandAction());
        }

        private async Task LoginCommandAction()
        {
            var apiService = new Githubservices();
            await apiService.GetGithubProfile("aismaniotto");
        }
    }
}
