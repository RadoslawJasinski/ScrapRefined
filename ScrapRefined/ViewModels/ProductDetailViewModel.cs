using Microsoft.AspNetCore.Components;
using ScrapRefined.Models;
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
        public Product SelectedProduct { get; set; }

        public ProductDetailViewModel(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }
        public void OpenDetails(Product product)
        {
            SelectedProduct = product;
            _navigationManager.NavigateTo("/DetailsPage", false);
        }

    }
}
