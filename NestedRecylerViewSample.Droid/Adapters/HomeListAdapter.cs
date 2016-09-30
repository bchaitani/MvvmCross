using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Binding.Droid.BindingContext;
using Android.Widget; 

namespace NestedRecylerViewSample.Droid.Adapters
{
    public class HomeListAdapter : MvxRecyclerAdapter
    {
        private IMvxAndroidBindingContext bindingContext; 

        public HomeListAdapter(IMvxAndroidBindingContext bindingContext) : base(bindingContext)
        {
            this.bindingContext = bindingContext;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
          
            var holder = base.OnCreateViewHolder(parent, viewType);
            var child = holder.ItemView.FindViewById<MvxRecyclerView>(Resource.Id.cards_recycler_view);
            if (child != null)
                child.SetLayoutManager(new LinearLayoutManager(parent.Context, LinearLayoutManager.Horizontal, false));


            return holder;
        } 
    } 
}