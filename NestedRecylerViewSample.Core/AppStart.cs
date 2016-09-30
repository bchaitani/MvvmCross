using NestedRecylerViewSample.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace NestedRecylerViewSample.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}
