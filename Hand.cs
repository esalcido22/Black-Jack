using System.Reflection;

class Hand{
    private List<Card> _cards = new List<Card>();

    //Adds a card to the hand
    public void Add(Card NewCard){
        _cards.Add(NewCard);
    }

    //Prints out hand
    public void Print(){
        for(int i = 0; i < _cards.Count; i++){
            _cards[i].Print();
        }
    }

}