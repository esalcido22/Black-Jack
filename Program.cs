/*
* An over simplified game of blackjack
* Enrique Salcido
* 8/9/2024
*/

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class Program{

    public static void dealingWithAce(Hand hand){
        if(hand.Value() > 21)
            hand.hasAce(); //if found changes the value of ace in hand to 1 instead of 11
    }

    public static void hitOrStand(Deck deck, Hand player, Hand dealer){
        //unlikely case of two aces in starting hand
        dealingWithAce(player);

        string response = "hit";
        //have to implement changing the value of aces to 1
        while(response.Equals("hit") && player.Value() <= 21){
            Console.WriteLine("Type \"hit\" to get another card and \"stand\" to stay.");
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            response = Console.ReadLine().ToLower();
            #pragma warning restore CS8602 // Dereference of a possibly null reference.

            if (response.Equals("hit")){
                player.Add(deck.Draw());
                player.Print();
            }
            //checking if changing ace value to 1 can help
            dealingWithAce(player);
        }
        return;
    }

    public static void dealerTurn(Deck deck, Hand dealer){
        dealingWithAce(dealer);
        if(dealer.Value() >= 17 && dealer.Value() <= 21){
            Console.WriteLine("The dealer stays.");
            return;
        }
        while(dealer.Value() < 17){
            Console.WriteLine("The dealer draws a card.");
            dealer.Add(deck.Draw());
            dealer.Print();
            dealingWithAce(dealer);
        }
        return;
    }

    public static void gameplayLoop(Deck deck, Hand player, Hand dealer){
        //checking for natural
        if(player.Value() == 21){
            Console.WriteLine("Natural! Congratulations you win!");
            return;
        }
        
        hitOrStand(deck, player, dealer);
        //checking if player busted
        if(player.Value() > 21){
            Console.WriteLine("BUST! You lose.");
            return;
        }

        dealerTurn(deck, dealer);
        //checking if dealer busted
        if(dealer.Value() > 21){
            Console.WriteLine("The dealer busted. You win!");
            return;
        }

        //showdown cases
        if(player.Value() == dealer.Value()){
            Console.WriteLine("The player and the dealer have the same value, neither of them win.");
            return;
        }else if(player.Value() >= dealer.Value()){
            Console.WriteLine("Congratulations you win!");
            return;
        }else{
            Console.WriteLine("The dealer wins.");
            return;
        }
    }

    public static void Main(string[] args){
        Console.WriteLine("Welcome to the table. Let's play some Blackjack!");

        string response = "again";
        #pragma warning disable CS8602 // Dereference of a possibly null reference.
        while (response.Equals("again")){
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
            //Console.WriteLine($"The value of this hand is {player.Value()}");
            Console.WriteLine("The dealer's hand:");
            dealer.Print();
            //Console.WriteLine($"The value of this hand is {dealer.Value()}");
        
        
            gameplayLoop(deck, player, dealer);
            Console.WriteLine("Type \"again\" to play again and \"quit\" to stop playing.");
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            response = Console.ReadLine();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
        #pragma warning restore CS8602 // Dereference of a possibly null reference.
        Console.WriteLine("Thank you for playing! Come again!");
    }
}