/*
* An over simplified game of blackjack
* Enrique Salcido
* 8/9/2024
*/

Console.WriteLine("Welcome to the table. Let's play some Blackjack!");

//Creating and shuffling deck
Deck deck = new Deck();
deck.Shuffle();

//Creating player and dealer hands
Hand player = new Hand();
player.Add(deck.Draw());
player.Add(deck.Draw());
Console.WriteLine("The player's hand:");
player.Print();

Hand dealer = new Hand();
dealer.Add(deck.Draw());
dealer.Add(deck.Draw());
Console.WriteLine("The dealer's hand:");
dealer.Print();