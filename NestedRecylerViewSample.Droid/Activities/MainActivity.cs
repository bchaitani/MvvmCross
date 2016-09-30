using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using NestedRecylerViewSample.Core.ViewModels;
using BottomNavigationBar;
using Android.Support.Design.Widget;
using BottomNavigationBar.Listeners;
using Android.Graphics; 
using Android.Widget; 

namespace NestedRecylerViewSample.Droid.Activities
{
    [Activity(Label ="MainActivity", Theme = "@style/AppTheme")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        public new MainViewModel ViewModel
        {
            get { return base.ViewModel; }
            set { base.ViewModel = value; }
        }

        private BottomBar _bottomBar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            ViewModel.ShowHomeViewModel();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            _bottomBar.OnSaveInstanceState(outState);
        }   
    }
}