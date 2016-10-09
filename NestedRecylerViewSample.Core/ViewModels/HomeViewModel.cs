using NestedRecylerViewSample.Core.Models;
using System.Collections.ObjectModel;

namespace NestedRecylerViewSample.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {

            HomeScreenItems = new ObservableCollection<HomeScreen>();

            HomeScreen item = new HomeScreen();

            item.Type = HomeScreenDisplayType.CardsType;
            item.Cards = new ObservableCollection<Card>();
            for (int j = 0; j < 20; j++)
            {
                Card card = new Card();
                string Image = "";
                if (j % 3 == 0)
                {
                    Image = "http://4.bp.blogspot.com/-NsnrSc5uP78/UlZpnlyFbFI/AAAAAAAABjc/TKvgwmif_0E/s1600/IMG_1202.jpg";
                }
                else if (j % 2 == 0)
                {
                    Image = "http://cdnpix.com/show/imgs/5405c24dc4364cec0271a09185f50636.jpg";
                }
                else
                {
                    Image = "http://stamping.thefuntimesguide.com/files/Easy_Birthday_Card_Idea.jpg";
                }

                card.Id = j * 10;
                card.Title = "Card " + j;
                card.ImageUrl = Image;

                item.Cards.Add(card);
            }

            HomeScreenItems.Add(item);

            addItems();

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

        public void addItems()
        {
            for (int i = 0; i < 30; i++)
            {
                HomeScreen item = new HomeScreen();

                item.Type = HomeScreenDisplayType.CategoriesType;
                string Image = "";
                if (i % 4 == 0)
                {
                    Image = "http://www.planwallpaper.com/static/images/Merry-christmas-messages.jpg";
                }
                else if (i % 3 == 0)
                {
                    Image = "https://image.freepik.com/free-vector/halloween-greeting-card_23-2147519110.jpg";
                }
                else if (i % 2 == 0)
                {
                    Image = "http://www.jattdisite.com/wp-content/uploads/2016/01/Happy-New-Year-Wallpapers-3D.jpg";
                }
                else
                {
                    Image = "http://valentinedaywishes.in/wp-content/uploads/2016/01/happy-valentines-day-wishes-2016_wishes.jpg";
                }

                item.Id = i;
                item.Title = "Card " + i;
                item.ImageUrl = Image;

                HomeScreenItems.Add(item);
            }
        }
    }
}