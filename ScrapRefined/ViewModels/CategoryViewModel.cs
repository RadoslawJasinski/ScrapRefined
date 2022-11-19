using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.ViewModels
{
    public class CategoryViewModel
    {
        private NavigationManager _navigationManager;

        public CategoryViewModel(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }
        public async Task OpenCategory()
        {
            _navigationManager.NavigateTo("/CategoryPage", false);
        }
    }
}
