using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedRecylerViewSample.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string HOME_MENU;
        public string CATEGORIES_MENU;
        public string HISTORY_MENU;

        public MainViewModel()
        {
            HOME_MENU = "Home";
            CATEGORIES_MENU = "Categories";
            HISTORY_MENU = "History";
        }

        public void ShowHomeViewModel()
        {
            ShowViewModel<HomeViewModel>();
        }
    }
}
