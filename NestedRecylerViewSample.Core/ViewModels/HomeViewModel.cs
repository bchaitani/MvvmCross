using NestedRecylerViewSample.Core.Models; 
using System.Collections.ObjectModel;

namespace NestedRecylerViewSample.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    { 
        public HomeViewModel()
        { 

            HomeScreenItems = new ObservableCollection<HomeScreen>();
            for (int i = 0; i < 20; i++)
            {
                HomeScreen item = new HomeScreen();
                if (i == 0)
                {
                    item.Type = HomeScreenDisplayType.CardsType;
                    item.Cards = new ObservableCollection<Card>();
                    for (int j = 0; j < 20; j++) {
                        Card card = new Card();
                        string Image = "https://media.digitalprintingireland.ie/media/images/products/slides/43/greeting-cards-5.jpg"; 
                        card.Id = j*10;
                        card.Title = "Card " + j;
                        card.ImageUrl = Image;

                        item.Cards.Add(card);
                    }
                }
                else
                {
                    item.Type = HomeScreenDisplayType.CategoriesType;
                    string Image = "https://media.digitalprintingireland.ie/media/images/products/slides/43/greeting-cards-5.jpg";
                    item.Id = i;
                    item.Title = "Card " + i;
                    item.ImageUrl = Image;
                }

                HomeScreenItems.Add(item);

            } 
        }

        private ObservableCollection<HomeScreen> homeScreenItems;
        public ObservableCollection<HomeScreen> HomeScreenItems
        {
            get { return homeScreenItems; }
            set
            {
                homeScreenItems = value;
                RaisePropertyChanged(() => HomeScreenItems);
            }
        }

        private ObservableCollection<Category> homeScreenCategories;
        public ObservableCollection<Category> HomeScreenCategories
        {
            get { return homeScreenCategories; }
            set
            {
                homeScreenCategories = value;
                RaisePropertyChanged(() => HomeScreenCategories);
            }
        }

        private ObservableCollection<Card> homeScreenCards;
        public ObservableCollection<Card> HomeScreenCards
        {
            get { return homeScreenCards; }
            set
            {
                homeScreenCards = value;
                RaisePropertyChanged(() => HomeScreenCards);
            }
        }
    }
}