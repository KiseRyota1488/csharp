using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    public class Player
    {
        public List<Card> cards = new List<Card>(18);

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
    }
}
