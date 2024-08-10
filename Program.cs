/*
* An over simplified game of blackjack
* Enrique Salcido
* 8/9/2024
*/

Console.WriteLine("Welcome to the table. Let's play some Blackjack!");
Deck deck = new Deck();
deck.PrintDeck();
deck.Shuffle();
deck.PrintDeck();