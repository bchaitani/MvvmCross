using NestedRecylerViewSample.Core.Models;
using MvvmCross.Core.ViewModels; 
using System.Collections.ObjectModel; 

namespace NestedRecylerViewSample.Core.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    { 
        public CategoryViewModel()
        {
            CategoryItems = new ObservableCollection<Category>();
            for (int i = 0; i < 20; i++)
            {
                Category category = new Category();
                string Image = "https://www.google.com.lb/search?q=greeting+cards&biw=1920&bih=940&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiV-IyHlrLPAhXHDMAKHUk_BSgQ_AUIBigB#tbm=isch&q=christmas+greeting+cards&imgrc=4qaOd4P124c1oM%3A";
                if (i % 2 == 0)
                {
                    Image = "https://www.google.com.lb/search?q=greeting+cards&biw=1920&bih=940&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiV-IyHlrLPAhXHDMAKHUk_BSgQ_AUIBigB#tbm=isch&q=christmas+greeting+cards&imgrc=dEvoNeN97uCQ4M%3A";
                }
                category.Id = i;
                category.Title = "Card " + i;
                category.Image = Image;

                CategoryItems.Add(category);
            }
        }

        private ObservableCollection<Category> _categoryItems;
        public ObservableCollection<Category> CategoryItems
        {
            get { return _categoryItems; }
            set
            {
                _categoryItems = value;
                RaisePropertyChanged(() => CategoryItems);
            }
        }

        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                RaisePropertyChanged(() => SelectedCategory);
            }
        }

        public virtual MvxCommand<Category> CategorySelected
        {
            get
            {
                return new MvxCommand<Category>(item =>
                {
                    SelectedCategory = item;
                });
            }
        }
    }
}
