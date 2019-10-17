using System.Drawing;

namespace blackjack {
	public struct FlippedCard {
		//stores the front face of a card
		public Image front_of_card { get; }
		//stores what position the card was e.g first in hand, second in hand
		public int position { get; }

		public FlippedCard(Image front_of_card, int position) {
			this.front_of_card = front_of_card;
			this.position = position;
		}
	}
}
