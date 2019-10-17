using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System;

//TODO list of flipped cards 
namespace blackjack {
	class HandUtility {
		private ImageList image_list; //holds the card images
		private Form2 form; //used for drawing to form2
		private Hand hand; //the hand which is drawn
		private Point card_point; //the position to start drawing from
		private int x_offset; //used for offsetting the X position of a picturebox
		private int y_offset; //used for offsetting the Y position of a picturebox

		//constants
		private static readonly Size CARD_SIZE = new Size(72, 96);

		private List<FlippedCard>flipped_cards = new List<FlippedCard>(); //holds a list of flipped cards
		private List<PictureBox> picture_boxes = new List<PictureBox>(); //holds a list of pictureboxes

		//cosntructs a handutility
		public HandUtility(Hand hand, Point card_point, int x_offset, int y_offset, Form2 form) {
			this.hand = hand;
			this.card_point = card_point;
			this.x_offset = x_offset;
			this.y_offset = y_offset;
			this.form = form;
			this.image_list = this.form.getCardsImageList();
		}

		public HandUtility(Hand hand, Point card_point, int x_offset, Form2 form) : this(hand, card_point, x_offset, 0, form) { }
		public HandUtility(Hand hand, Point card_point, Form2 form) : this(hand, card_point, 100, 0, form) { }


		//used for drawing the cards in hand to the screen
		public void Draw() {
			if (picture_boxes.Count < hand.currentCardCount()) { //check to make sure we haven't already drawn the cards
				List<string> names = genCardName();
				for (int i = picture_boxes.Count; i < hand.currentCardCount(); i++) { //create a picturebox and then draw the card to it according to its number and suit
					picture_boxes.Add(new PictureBox());
					for (int j = 0; j < image_list.Images.Count; j++) {
						if (image_list.Images.Keys[j].ToString() == names[i]) {
							picture_boxes[i].Location = new Point(card_point.X + ( x_offset * i ), card_point.Y - ( y_offset * i ));
							picture_boxes[i].Size = CARD_SIZE;
							picture_boxes[i].Image = image_list.Images[j];
							picture_boxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
							form.Controls.Add(picture_boxes[i]);
							picture_boxes[i].BringToFront();
							break;
						}
					}
				}
			}
		}

		//used for flipping a specific card and setting its color
		public void Flip(int index, Card.CardBack color) {
			if (index <= picture_boxes.Count && index >= 0) { //checks to make sure we haven't tried flipping a non existent card
				if (( int )color <= 1 && ( int )color >= 0) {
					if (picture_boxes[index].Image != null) {
						flipped_cards.Add(new FlippedCard(picture_boxes[index].Image, index));
						string back_of_card = string.Empty;
						switch (color) {
							case Card.CardBack.BLUE:
								back_of_card = "blue back of cards.png";
								break;
							case Card.CardBack.RED:
								back_of_card = "red back of cards.png";
								break;
						}

						for (int i = 0; i < image_list.Images.Count; i++) {
							if (image_list.Images.Keys[i].ToString() == back_of_card) {
								picture_boxes[index].Image = image_list.Images[i];
								break;
							}
						}
					} else {
						throw new ArgumentOutOfRangeException();
					}
				} else {
					throw new ArgumentException("Not a color");
				}
			} else {
				throw new ArgumentOutOfRangeException();
			}
		}

		public void Flip(int index) {
			Random rand = new Random();
			Card.CardBack color = ( Card.CardBack )rand.Next(0, 2);
			Flip(index, color);
		}

		//unflips all cards that have been flipped
		public void Unflip() {
			foreach (FlippedCard flipped_card in flipped_cards) {
				picture_boxes[flipped_card.position].Image = flipped_card.front_of_card;
			}
		}

		//Unflip a specific card
		public void Unflip(int index) {
			bool flipped = false;
			if (index <= picture_boxes.Count && index >= 0) {
				foreach (FlippedCard flipped_card in flipped_cards) {
					if (flipped_card.position == index) {
						picture_boxes[flipped_card.position].Image = flipped_card.front_of_card;
						flipped = true;
					}
				}
				if (!flipped) {
					throw new ArgumentException("Card not flipped");
				}
			} else {
				throw new ArgumentOutOfRangeException();
			}
		}

		//generates a string which is used for finding the correct image to draw
		private List<string> genCardName() {
			List<string> names = new List<string>();
			foreach (Card c in hand.getHand()) {
				StringBuilder name = new StringBuilder();

				int num = ( int )c.getCardNumber();
				switch (num) {
					case 0:
						name.Append('a'); //ace
						break;
					case 10:
						name.Append('k'); //king
						break;
					case 11:
						name.Append('q'); //queen
						break;
					case 12:
						name.Append('j'); //jack
						break;
					default:
						name.Append(num + 1).ToString(); //numerical values
						break;
				}

				int suit = ( int )c.getCardSuit();
				switch (suit) {
					case 0:
						name.Append('c'); //club
						break;
					case 1:
						name.Append('h'); //heart
						break;
					case 2:
						name.Append('s'); //spade
						break;
					case 3:
						name.Append('d'); //diamond
						break;
				}

				name.Append(".png");
				names.Add(name.ToString());
			}
			return names;
		}

		//removes all pictureboxes from form
		public void clearImages() {
			foreach (PictureBox p in picture_boxes) {
				form.Controls.Remove(p);
			}
		}
	}
}
