using System.Collections.Generic;
using System.Linq;
using System;

namespace blackjack {
	class Hand {
		//holds newly drawn cards but you initially start with 2 cards
		private List<Card> my_hand;

		//cretes an empty hand
		public Hand() {
			my_hand = new List<Card>();
		}

		//create a hand with one card
		public Hand(Card card) {
			my_hand = new List<Card> { card };
		}

		//create a hand with a list of cards
		public Hand(List<Card> initial_hand) {
			my_hand = initial_hand;
		}

		//returns a readonly version of my_hand
		public IReadOnlyList<Card> getHand() {
			return my_hand.AsReadOnly();
		}

		//returns the current amount of cards in hand
		public int currentCardCount() {
			return my_hand.Count();
		}

		//generates a new card and adds it to your hand
		public void drawCard() {
			my_hand.Add(new Card());
		}

		//add a specific card to your hand
		public void addCard(Card card) {
			my_hand.Add(card);
		}

		//remove the last card in your hand
		public void removeCard() {
			my_hand.Remove(my_hand.Last());
		}

		//remove card at specified postiion
		public void removeCard(int index) {
			if (my_hand.Any()) { //check if my_hand has been initialized
				if (index <= my_hand.Count && index >= 0) {
					my_hand.RemoveAt(index);
				} else {
					throw new ArgumentOutOfRangeException();
				}
			} else {
				throw new ArgumentOutOfRangeException();
			}
		}
	}
}
