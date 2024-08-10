using Microsoft.VisualBasic;

class Card{
    //the suit of the card
    private char _suit;
    //creates setters and getters for _suit
    public char Suit{
        get => _suit;
        set => _suit = value;
    }
    
    private int _value = 0;
    public int Value{
        get => _value;
        set => _value = value;
    }
    
    //the denomination of the card
    private char _denom;
    //creates setters and getters for _denom
    public char Denom{
        get => _denom;
        set => _denom = value;
    }

    //constructor with suit and denomination given
    public Card(char S, int D){
        _suit = S;
        switch(D){
            case 1:
                _denom = 'A';
                _value = 11;
                break;
            case 11:
                _denom = 'J';
                _value = 10;
                break;
            case 12:
                _denom = 'Q';
                _value = 10;
                break;
            case 13:
                _denom = 'K';
                _value = 10;
                break;
            default:
                _denom = D.ToString()[0];
                _value = D;
                break;
        }
    }
}