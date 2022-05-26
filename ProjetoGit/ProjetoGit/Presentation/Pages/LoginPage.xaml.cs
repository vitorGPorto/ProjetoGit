using ProjetoGit.Services;
using ProjetoGit.Services.Api;
using ProjetoGit.ViewModel;
using Xamarin.Forms;

namespace ProjetoGit.Presentation.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            // TODO: add some dependency injection tool
            BindingContext = new LoginViewModel(
                new SecureStorageService(),
                new Githubservices(new RequestProvider()),
                new DialogService(),
                new NavigationService()
                );

        }
        public async void teste()
        {
            await Navigation.PushAsync(new SelectRepoPage());
        }
    }
}
