/*
* An over simplified game of blackjack
* Enrique Salcido
* 8/9/2024
*/

public static class Program{

    public static void gameplayLoop(Hand player, Hand dealer){
        if(player.Value() == 21){
            Console.WriteLine("Congratulations you win!");
            return;
        }
        Console.WriteLine("No instant win.");
        return;
    }

    public static void Main(string[] args){
        Console.WriteLine("Welcome to the table. Let's play some Blackjack!");

        //Creating and shuffling deck
        Deck deck = new Deck();
        deck.Shuffle();


        //Creating player and dealer hands
        Hand player = new Hand();
        Hand dealer = new Hand();

        //drawning hands for player and dealer
        player.Add(deck.Draw());
        dealer.Add(deck.Draw());
        player.Add(deck.Draw());
        dealer.Add(deck.Draw());

        //printing hands
        Console.WriteLine("The player's hand:");
        player.Print();
        Console.WriteLine($"The value of this hand is {player.Value()}");
        Console.WriteLine("The dealer's hand:");
        dealer.Print();
        Console.WriteLine($"The value of this hand is {dealer.Value()}");

        gameplayLoop(player, dealer);
    }

}