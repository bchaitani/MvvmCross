using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Binding.Droid.BindingContext;
using Java.Lang;
using MvvmCross.Binding.Droid.Views;

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
            {
                child.SetLayoutManager(new LinearLayoutManager(parent.Context, LinearLayoutManager.Horizontal, false));
                child.Adapter = new HomeCardsListAdapter(bindingContext);
            }


            return holder;
        }

        //public override void OnViewRecycled(Object holder)
        //{
        //    var image1 = ((RecyclerView.ViewHolder)holder).ItemView.FindViewById<MvxImageView>(Resource.Id.image1);
        //    var image2 = ((RecyclerView.ViewHolder)holder).ItemView.FindViewById<MvxImageView>(Resource.Id.image2);

        //    if (image1 != null)
        //    {
        //        //image1.SetImageDrawable(null);
        //        image1.Drawable.Dispose();
        //    }
        //    if (image2 != null)
        //    {
        //        //image2.SetImageDrawable(null);
        //        image2.Drawable.Dispose();
        //    }
        //}

        public override void ClearAllBindings()
        {
        }

        public class HomeCardsListAdapter : MvxRecyclerAdapter
        {
            public HomeCardsListAdapter(IMvxAndroidBindingContext bindingContext) : base(bindingContext)
            {

            }

            public override void ClearAllBindings()
            {
            }
        }
    }
}