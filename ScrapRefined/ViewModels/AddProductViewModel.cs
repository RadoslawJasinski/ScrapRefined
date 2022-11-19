using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.ViewModels
{
    public class AddProductViewModel
    {
        private NavigationManager _navigationManager;

        public AddProductViewModel(NavigationManager navigationManager)
        {
                _navigationManager = navigationManager;
                
        }
        public async Task openAddProduct()
        {
            _navigationManager.NavigateTo("/AddProduct", false);
        }
    }
}
