//#define DEBUG_CARDS

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace blackjack {
	class Game {
		//game constants
		private static readonly int TWENTY_ONE = 21;
		private static readonly int HOUSE_THRESHOLD = 16;
		private static readonly int ACE_MULTIPLIER = 10;
		private static readonly int TOTAL_CARDS_ALLOWED = 5;

		//playerhand and househand objects
		private Hand user_hand;
		private Hand house_hand;

		//handutility objects used for the drawing of hands to the screen
		private HandUtility user_image_util;
		private HandUtility house_image_util;

		private Form2 form;

		//start game by giving both the player and house 2 cards each
		public Game(Form2 form) {
			this.form = form;
			Play();
		}

		//generates a new card and give it to the player
		public void Hit() {
			user_hand.drawCard();
			user_image_util.Draw();

			if (Sum(user_hand) == TWENTY_ONE) {
				Hold();
			} else if (Sum(user_hand) > TWENTY_ONE) {
				form.toggleButtons();
				MessageBox.Show("You went bust, you lose.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
			} else if (user_hand.currentCardCount() >= TOTAL_CARDS_ALLOWED) {
				form.toggleButtons();
				MessageBox.Show("You got a five-card Charlie, you win!", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		//plays the end game scenario, playing the dealers role.
		public void Hold() {
			form.toggleButtons();

			house_image_util.Unflip(0);
			while (Sum(house_hand) <= HOUSE_THRESHOLD && house_hand.currentCardCount() < TOTAL_CARDS_ALLOWED) {
				house_hand.drawCard();
				house_image_util.Draw();
			}

			if (Sum(house_hand) > TWENTY_ONE) {
				if (Sum(user_hand) == TWENTY_ONE) {
					MessageBox.Show("You got Blackjack!", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
				} else {
					MessageBox.Show("House went bust, you win!", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
			} else {
				calculateScore();
			}
		}

		//checks score and determines a winnner
		private void calculateScore() {
			int user_total = Sum(user_hand);
			int house_total = Sum(house_hand);

			if (user_total > house_total) {
				if (user_total == TWENTY_ONE) {
					MessageBox.Show("You got Blackjack!", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
				} else {
					MessageBox.Show("You Win!", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
			} else if (user_total < house_total) {
				if (house_total == TWENTY_ONE) {
					MessageBox.Show("House got Blackjack.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
				} else {
					MessageBox.Show("You Lose.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
			} else {
				MessageBox.Show("It's a draw.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		//calculates the sum of a hand
		private int Sum(Hand hand) {
			bool have_ace = false;
			int total = 0;

			foreach (Card card in hand.getHand()) {
				Card.CardNumber card_number = card.getCardNumber();
				if (card_number == Card.CardNumber.ACE) {
					have_ace = true;
				}
				switch (card_number) {
					case Card.CardNumber.KING:
					case Card.CardNumber.QUEEN:
					case Card.CardNumber.JACK:
						total += 10;
						break;
					default:
						total += ( int )card_number + 1;
						break;
				}
			}
			//ace case
			if (have_ace) {
				if (total + ACE_MULTIPLIER <= 21) {
					total += ACE_MULTIPLIER;
				}
			}
			return total;
		}

		//cleans up the cards drawn to the screen
		public void playAgain() {
			form.toggleButtons();
			user_image_util.clearImages();
			house_image_util.clearImages();
			Play();
		}

		//initalize a blackjack game
		public void Play() {
		#if DEBUG_CARDS
			user_hand = new Hand(new List<Card> { new Card(Card.CardNumber.ACE,Card.CardSuit.CLUB), new Card(Card.CardNumber.KING,Card.CardSuit.CLUB) });
			house_hand = new Hand(new List<Card> { new Card(Card.CardNumber.ACE, Card.CardSuit.CLUB), new Card(Card.CardNumber.FOUR, Card.CardSuit.CLUB) });
		#else
			user_hand = new Hand(new List<Card> { new Card(), new Card() });
			house_hand = new Hand(new List<Card> { new Card(), new Card() });
		#endif
			user_image_util = new HandUtility(user_hand, new Point(100, 320), 30, 6, this.form);
			house_image_util = new HandUtility(house_hand, new Point(100, 90), 30, this.form);

			user_image_util.Draw();
			house_image_util.Draw();
			house_image_util.Flip(0);

			if (Sum(user_hand) == TWENTY_ONE) {
				Hold();
			}
		}
	}
}
