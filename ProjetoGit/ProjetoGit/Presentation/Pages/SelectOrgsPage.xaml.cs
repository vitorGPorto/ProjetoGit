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
            List<String> itens = new List<String>()
            {
                "Palmeiras", "Flamengo", "Atlético", "Santos", "Fluminense"
            };
            organizacao.ItemsSource = itens;
        }

        private void organizacao_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Item selecionado ", e.SelectedItem.ToString(), "OK");
        }
    }
}