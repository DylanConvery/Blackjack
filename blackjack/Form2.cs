using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Collections.Generic;

namespace blackjack {
	public partial class Form2 : Form {
		Game game;

		//colors used in form
		Color light_blue = Color.FromArgb(0, 184, 209);
		Color dark_blue = Color.FromArgb(2, 85, 115);

		public Form2() {
			InitializeComponent();
		}

		//only start game when form is loaded and on screen
		private void Form2_Shown(object sender, EventArgs e) {
			game = new Game(this);
		}

		//calls game.hit() and checks whether your hand is over 21
		private void hitButton_Click(object sender, EventArgs e) {
			game.Hit();
		}

		//calls game.Hold() which determines a game winner
		private void holdButton_Click(object sender, EventArgs e) {
			game.Hold();
		}

		//calls game.clearBoard() which destroys all the 
		private void playAgainButton_Click(object sender, EventArgs e) {
			buttonHold.FlatAppearance.BorderSize = 2; //fix for issue with visual c# bordersizing
			game.playAgain();
		}

		public ImageList getCardsImageList() {
			return imageList1;
		}

		//used for toggling buttons on and off
		public void toggleButtons() {
			buttonHit.Enabled = !buttonHit.Enabled;
			buttonHit.Visible = !buttonHit.Visible;
			buttonHold.Enabled = !buttonHold.Enabled;
			buttonHold.Visible = !buttonHold.Visible;
			playAgainButton.Enabled = !playAgainButton.Enabled;
			playAgainButton.Visible = !playAgainButton.Visible;
		}

		///////////////////////////////////////////////////////////////////////
		//			      Mouse-over/mouse-down color changer				 //
		///////////////////////////////////////////////////////////////////////
		private void buttonHold_MouseEnter(object sender, EventArgs e) {
			buttonHold.FlatAppearance.BorderColor = dark_blue;
			buttonHold.ForeColor = dark_blue;
		}

		private void buttonHold_MouseLeave(object sender, EventArgs e) {
			buttonHold.FlatAppearance.BorderColor = light_blue;
			buttonHold.ForeColor = light_blue;
		}

		private void buttonHold_MouseDown(object sender, MouseEventArgs e) {
			buttonHold.FlatAppearance.BorderSize = 1; //fix for issue with visual c# bordersizing
		}

		private void rulesToolStripMenuItem_Click(object sender, EventArgs e) {
			fileReader("../../rules.txt");
		}

		private void cardValuesToolStripMenuItem_Click(object sender, EventArgs e) {
			fileReader("../../cards.txt");
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		//used for reading text
		private void fileReader(string path) {
			//DANGER: doesn't make sure the file it opens is a text file.
			try {
				System.IO.StreamReader file = new System.IO.StreamReader(@path);
				StringBuilder text = new StringBuilder();
				string line;
				while (( line = file.ReadLine() ) != null) {
					text.Append(line + "\n");
				}
				MessageBox.Show(text.ToString(), "Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch (System.IO.DirectoryNotFoundException excep) {
				MessageBox.Show(excep.ToString(), "Rules", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch (System.IO.FileNotFoundException excep) {
				MessageBox.Show(excep.ToString(), "Rules", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

