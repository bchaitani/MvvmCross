using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.RecyclerView.ItemTemplates;
using System.Collections.Generic;
using NestedRecylerViewSample.Core.ViewModels;
using NestedRecylerViewSample.Core.Models;

namespace NestedRecylerViewSample.Droid.Utility
{
    public class HomePageItemTemplateSelector : MvxTemplateSelector<HomeScreen>
    {
        public override int GetItemLayoutId(int fromViewType)
        {
            return fromViewType == 0 ?
                Resource.Layout.view_newest :
                Resource.Layout.view_categories;
        }

        protected override int SelectItemViewType(HomeScreen forItemObject)
        { 
            return forItemObject.Type == HomeScreenDisplayType.CardsType ? 0 : 1;
        } 
    }
}