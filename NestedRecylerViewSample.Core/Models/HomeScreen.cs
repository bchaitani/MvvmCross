using System.Collections.ObjectModel;

namespace NestedRecylerViewSample.Core.Models
{
    public class HomeScreen
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public HomeScreenDisplayType Type { get; set; }
        // Category properties
        public ObservableCollection<Category> Categories;

        // Cards List
        public ObservableCollection<Card> Cards { get; set; }
    }

    public enum HomeScreenDisplayType
    {
        CardsType,
        CategoriesType,
        CategoriesTitle
    }
}
