using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using NestedRecylerViewSample.Core.ViewModels;
using NestedRecylerViewSample.Droid.Adapters;
using NestedRecylerViewSample.Droid.Utility;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.RecyclerView;
using System;

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
            recyclerView.HasFixedSize = true;
            var layoutManager = new LinearLayoutManager(Activity);
            var onScrollListener = new LoadMoreRecyclerViewOnScrollListener(layoutManager);
            onScrollListener.LoadMoreEvent += (object sender, EventArgs e) =>
            {
                ViewModel.addItems(); 
            };
            recyclerView.AddOnScrollListener(onScrollListener);
            recyclerView.SetLayoutManager(layoutManager);
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