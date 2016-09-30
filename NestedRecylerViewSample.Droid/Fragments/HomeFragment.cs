using MvvmCross.Droid.Support.V4;
using NestedRecylerViewSample.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;
using Android.Runtime;
using Android.OS;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using Android.Widget;
using Android.Support.V7.Widget;
using Android.Support.V4.Widget;
using NestedRecylerViewSample.Droid.Adapters;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace NestedRecylerViewSample.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("nestedrecylerviewsample.droid.fragments.HomeFragment")]
    public class HomeFragment : MvxFragment<HomeViewModel>
    {
        public new HomeViewModel ViewModel
        {
            get { return base.ViewModel; }
            set { base.ViewModel = value; }
        }

        private ProgressBar progressBar;
        private TextView txEmptyView; 
        private MvxRecyclerView recyclerView; 

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            recyclerView.SetLayoutManager(new LinearLayoutManager(Activity));
            //recyclerView.SetLayoutManager(new GridLayoutManager(Activity, 2));
            recyclerView.Adapter = new HomeListAdapter((IMvxAndroidBindingContext)BindingContext);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.fragment_home, null);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            recyclerView = view.FindViewById<MvxRecyclerView>(Resource.Id.recycler_view);
        }
    }
}