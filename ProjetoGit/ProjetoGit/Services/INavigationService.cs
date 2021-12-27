using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoGit.Services
{
    public interface INavigationService 
    {
         Task GoTo(Page page);
    }
}
