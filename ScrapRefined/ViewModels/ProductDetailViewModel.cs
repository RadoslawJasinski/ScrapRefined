using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.ViewModels
{
    public class ProductDetailViewModel
    {
        private NavigationManager _navigationManager;

        public ProductDetailViewModel(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }
        public async Task OpenDetails()
        {
            _navigationManager.NavigateTo("/DetailsPage", false);
        }

    }
}
