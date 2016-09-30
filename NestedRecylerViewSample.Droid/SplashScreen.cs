using Android.App; 
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace NestedRecylerViewSample.Droid
{
    [Activity(Label = "Greetings App", MainLauncher = true, Theme = "@style/AppTheme.Splash", Icon = "@mipmap/ic_launcher")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.activity_splash_screen)
        {
        }
    }
}