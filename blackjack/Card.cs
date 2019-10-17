using System;

namespace blackjack {
	class Card {
		//various enums used for helping both with the readablity and expression code and 
		public enum CardNumber { ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, KING, QUEEN, JACK };
		public enum CardSuit { CLUB, HEART, SPADE, DIAMOND };
		public enum CardBack { RED, BLUE };

		static Random rand = new Random();

		private CardNumber card;  //represents a card number/value
		private CardSuit suit;  //represents a card suit e.g spade or diamond

		//sets up a randomly generated card
		public Card() {
			card = ( CardNumber )rand.Next(0, 13); //0-12, ace - jack
			suit = ( CardSuit )rand.Next(0, 4);  //club, heart, spade, diamond
		}

		//used for a case where you might want a specific card.
		public Card(CardNumber card_number, CardSuit card_suit) {
			if (!CardValidity(( int )card_number, ( int )card_suit)) {
				throw new Exception("Not a card");
			}
			this.card = card_number;
			this.suit = card_suit;
		}

		//ensures the card is valid
		private bool CardValidity(int card, int suit) {
			if (card <= 12 && card >= 0) {
				if (suit <= 3 && suit >= 0) {
					return true;
				}
			}
			return false;
		}

		public CardNumber getCardNumber() { return card; }
		public CardSuit getCardSuit() { return suit; }
	}
}
