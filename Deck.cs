using System.Globalization;
using System.Net.Security;
using System.Runtime.CompilerServices;

class Deck{
    
    private List<Card> _cards = new List<Card>();
    private static Random  rng = new Random();

    //the suits and face card denominations
    private static char[] suits = [(char) 3, (char) 4, (char) 5, (char) 6];

    public Deck(){
        //creating the numbered cards
        for(int i = 1; i < 14; i++)
            foreach(char suit in suits)
                _cards.Add(new Card(suit, i));
    }

    public void Draw(){
        //put card in discard
    }

    //Shuffles the deck
    public void Shuffle(){
        int n = _cards.Count;
        while(n > 1){
            n--;
            int k = rng.Next(n+1);
            Card temp = _cards[k];
            _cards[k] = _cards[n];
            _cards[n] = temp;
        }
    }

    //used mostly testing, making sure the deck is properly made and shuffled
    public void PrintDeck(){
        for (int i = 0; i < _cards.Count; i++)
        {
            Console.WriteLine($"({_cards[i].Suit}, {_cards[i].Denom}, {_cards[i].Value})");
        }
        Console.WriteLine($"The deck has {_cards.Count} many cards.");
    }
}