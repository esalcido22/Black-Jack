/*
* Deck class to simulate a standard 52 card deck
* Enrique Salcido
* 8/13/2024
*/

using System.Globalization;
using System.Net.Security;
using System.Runtime.CompilerServices;

public class Deck{
    
    private List<Card> _cards = new List<Card>();
    private static Random  rng = new Random();

    //lets you choose the number of standard decks you want to use
    private int numDecks = 1;

    //the suits and face card denominations
    private static char[] _suits = [(char) 3, (char) 4, (char) 5, (char) 6];

    public Deck(){
        //creating the numbered cards
        for(int i = 1; i <= numDecks; i++)
            for(int j = 1; j < 14; j++)
                foreach(char suit in _suits)
                    _cards.Add(new Card(suit, j));
    }

    public Card Draw(){
        Card drawn = _cards[0];
        _cards.RemoveAt(0);
        return drawn;
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
    public void Print(){
        for (int i = 0; i < _cards.Count; i++)
        {
            _cards[i].Print();
        }
        Console.WriteLine($"The deck has {_cards.Count} many cards.");
    }
}