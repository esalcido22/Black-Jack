using System.Reflection;

public class Hand{
    private List<Card> _cards = new List<Card>();

    //Adds a card to the hand
    public void Add(Card NewCard){
        _cards.Add(NewCard);
    }

    //Prints out hand
    public void Print(){
        for(int i = 0; i < _cards.Count; i++)
            _cards[i].Print();
    }

    //keeps the second delear card hidden
    public void DelearPrint(){
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

}