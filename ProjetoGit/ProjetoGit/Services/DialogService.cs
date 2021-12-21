using System;
using System.Threading.Tasks;

namespace ProjetoGit.Services
{
    public class DialogService :  IDialogService
    {
        public async Task ShowAlertAsync(string message, string title, string buttonLabel)
        {
            await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(title, message, buttonLabel);
        }
    }
}
