using Acr.UserDialogs;
using ProjetoGit.Model;
using ProjetoGit.Presentation.Pages;
using ProjetoGit.Services;
using ProjetoGit.Services.Api;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoGit.ViewModel
{
    //http://www.macoratti.net/17/09/xf_dblv1.htm

    class OrgsViewModel : BaseViewModel
    {
        public ICommand OrgsCommand { get; set; }
        public ICommand SelectCommand { get; set; }

        private List<Organization> _organizationList;
        public List<Organization> OrganizationList
        {
            get { return _organizationList; }
            set { SetProperty(ref _organizationList, value); }
        }


        private ISecureStorageService _secureStorageService;
        private IDialogService _dialogService;
        private INavigationService _navigationService;
        private IGithubService _githubService;

 

        public OrgsViewModel(ISecureStorageService secureStorageService, IDialogService dialogService, INavigationService navigationService, IGithubService githubService)
        {
            this._secureStorageService = secureStorageService;
            this._dialogService = dialogService;
            this._navigationService = navigationService;
            this._githubService = githubService;

            OrgsCommand = new Command(OrgsCommandAction);
            //SelectCommand = new Command<Organization>(async(orgs)=>await SelectCommandAction(orgs));
            SelectCommand = new Command(SelectCommandAction);
            
          
        }

        private async void OrgsCommandAction()
        {

            UserDialogs.Instance.ShowLoading("Processing..");
           
            var listOrganization = await _githubService.GetListOrganization(await _secureStorageService.GetToken());
            

            if ( listOrganization != null )
            {
                
                OrganizationList = listOrganization;
              
            }
            UserDialogs.Instance.HideLoading();
            //await _dialogService.ShowAlertAsync("Button Organizaçao", "Teste01", " Ok");
        }
        
        private async void SelectCommandAction()
        {
            // TODO: redirect to new page
            await _navigationService.GoTo(new SelectRepoPage());
        }
        
    }

}
    
