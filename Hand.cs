/*
* Hand class to simulate the hand a player or dealer would have in blackjack
* Enrique Salcido
* 8/13/2024
*/


using System.Reflection;

public class Hand{
    private List<Card> _cards = new List<Card>();

    //variable for the number of cards in hand
    private int _count = 0;
    public int Count{
        get => _count;
        set => _count = value;
    }

    //variable for the amount of money the player has
    private int _credit = 0;
    public int Credit{
        get => _credit;
        set => _credit = value;
    }

    private int _bet = 0;
    public int Bet{
        get => _bet;
        set => _bet = value;
    }

    //Adds a card to the hand
    public void Add(Card NewCard){
        _cards.Add(NewCard);
        _count = _cards.Count;
    }

    //Prints out hand
    public void Print(){
        for(int i = 0; i < _cards.Count; i++)
            _cards[i].Print();
    }

    //keeps the second delear card hidden
    public void DealerPrint(){
        _cards[0].Print();
        Console.WriteLine($"and a face down card.");
    }

    //returns the value of the current hand
    public int Value(){
        int sum = 0;
        for(int i = 0; i < _cards.Count; i++){
            sum += _cards[i].Value;
        }
        return sum;
    }

    //changes the value of an ace in hand from 11 to 1
    public void hasAce(){
        for (int i = 0; i < _cards.Count; i++){
            if(_cards[i].Denom.Equals("A") && _cards[i].Value != 1){
                _cards[i].Value = 1;
                break;
            }
        }   
    }

    //discards all cards in hand
    public void discard(){
        _cards = new List<Card>();
    }
}