using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoGit.Services
{
    public class NavigationService : INavigationService
    {
     
        public async Task GoTo(Page page)
        {
          
            await Application.Current.MainPage.Navigation.PushAsync(page);

        }
    }

        
}
