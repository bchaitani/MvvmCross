using MvvmCross.Core.ViewModels;
using NestedRecylerViewSample.Core.Models;
using System.Collections.ObjectModel;

namespace NestedRecylerViewSample.Core.ViewModels
{
    public class CardViewModel : BaseViewModel
    {
        public CardViewModel()
        {
            CardItems = new ObservableCollection<Card>();
            for (int i = 0; i < 20; i++)
            {
                Card card = new Card();
                string Image = "https://media.digitalprintingireland.ie/media/images/products/slides/43/greeting-cards-5.jpg";
                //if (i % 2 == 0)
                //{
                //    Image = "http://videos2watch.com/wp-content/uploads/2015/10/christmas-cards-greetings-m2eeoi7i.jpg";
                //}
                card.Id = i;
                card.Title = "Card " + i;
                card.ImageUrl = Image;

                CardItems.Add(card);
            } 
        }

        private ObservableCollection<Card> _cardItems;
        public ObservableCollection<Card> CardItems
        {
            get { return _cardItems; }
            set
            {
                _cardItems = value;
                RaisePropertyChanged(() => CardItems);
            }
        }

        private Card _selectedCard;
        public Card SelectedCard
        {
            get { return _selectedCard; }
            set
            {
                _selectedCard = value;
                RaisePropertyChanged(() => SelectedCard);
            }
        }

        public virtual MvxCommand<Card> CardSelected
        {
            get
            {
                return new MvxCommand<Card>(item =>
                {
                    SelectedCard = item;
                });
            }
        }
    }
}