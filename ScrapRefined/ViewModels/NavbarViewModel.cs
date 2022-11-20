using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.ViewModels
{
    public class NavbarViewModel
    {
        private NavigationManager _navigationManager;

        public NavbarViewModel(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public void OpenSite(string url, bool forceLoad)
        {
            _navigationManager.NavigateTo(url, forceLoad);
        }
    }
}
