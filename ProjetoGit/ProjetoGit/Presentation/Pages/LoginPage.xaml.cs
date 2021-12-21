using ProjetoGit.ViewModel;
using Xamarin.Forms;

namespace ProjetoGit.Presentation.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
