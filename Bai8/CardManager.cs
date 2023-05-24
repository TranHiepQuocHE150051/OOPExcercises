using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class CardManager
    {
        private List<Card> cards;

        public CardManager()
        {
            this.cards = new List<Card>();
        }
        public void AddNewCard(Card card)
        {
            this.cards.Add(card);
        }
        public void RemoveCard(int cardId)
        {
            var card = this.cards.Where(c=>c.CardId==cardId).FirstOrDefault();
            if (card != null)
            {
                this.cards.Remove(card);
                Console.WriteLine("Remove sucess");
            }
            else
            {
                Console.WriteLine("Remove failed. Card not existed");
            }

        }
        public List<Card> GetAllCards()
        {
            return this.cards;
        }
    }
}
