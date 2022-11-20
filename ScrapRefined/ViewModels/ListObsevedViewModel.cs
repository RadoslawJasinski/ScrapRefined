using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.ViewModels
{
    public class ListObsevedViewModel
    {
        private NavigationManager _navigationManager;

        public ListObsevedViewModel(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }
        public async Task OpenListObserved()
        {
            _navigationManager.NavigateTo("/ListObserved", false);
        }
    }
}
