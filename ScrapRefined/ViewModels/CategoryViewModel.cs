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
        private IndexViewModel _indexViewModel;

        public CategoryViewModel(NavigationManager navigationManager, IndexViewModel indexViewModel)
        {
            _navigationManager = navigationManager;
            _indexViewModel = indexViewModel;
        }
        public void OpenCategory()
        {
            _navigationManager.NavigateTo("/CategoryPage", false);
        }
        public void OpenIndexByCategory(int id)
        {
            _indexViewModel.Products = _indexViewModel.AllProducts.Where(p => p.Category.Id == id);
            _indexViewModel.IsFirstLoading = false;
            _navigationManager.NavigateTo("/", true);
        }
        public void OpenIndexBoth()
        {
            _indexViewModel.IsFirstLoading = true;
            _navigationManager.NavigateTo("/", true);
        }
    }
}
