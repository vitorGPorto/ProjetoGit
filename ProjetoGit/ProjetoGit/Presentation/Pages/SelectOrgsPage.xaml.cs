using ProjetoGit.Services;
using ProjetoGit.Services.Api;
using ProjetoGit.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoGit.Presentation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectOrgsPage : ContentPage
    {

       
        public SelectOrgsPage()
        {
            InitializeComponent();

            // TODO: add some dependency injection tool
            BindingContext = new OrgsViewModel(
                new SecureStorageService(),
                new DialogService(),
                new NavigationService(),
                new Githubservices(new RequestProvider())
                );
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {

        }

        private void Items_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
          

           
        }
    }
}