using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blackjack {
	public partial class Form1 : Form {
		//colors used in form
		Color light_blue = Color.FromArgb(0, 184, 209);
		Color dark_blue = Color.FromArgb(2, 85, 115);

		//used for watermarking text
		private static readonly string fn_watermark = "First";
		private static readonly string ln_watermark = "Last";
		private static readonly string d_watermark = "Day";
		private static readonly string m_watermark = "Month";
		private static readonly string y_watermark = "Year";
		private static readonly string gen_watermark = "I am...";

		bool fn_watermarked = false;
		bool ln_watermarked = false;

		public Form1() {
			InitializeComponent();
		}

		//fill the day and year comboboxes
		private void Form1_Load(object sender, EventArgs e) {
			for (int i = 1; i < 32; i++) {
				dayComboBox.Items.Add(i);
			}

			for (int i = DateTime.Today.Year; i >= 1900; i--) {
				yearComboBox.Items.Add(i);
			}
		}

		//various checks for a coreectly filled out form
		private void submitButton_Click(object sender, EventArgs e) {
			if (!fn_watermarked) {
				MessageBox.Show("Please enter your first name.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (!ln_watermarked) {
				MessageBox.Show("Please enter your last name.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (dayComboBox.SelectedIndex == -1) {
				MessageBox.Show("Please select a day.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (monthComboBox.SelectedIndex == -1) {
				MessageBox.Show("Please select a month.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (yearComboBox.SelectedIndex == -1) {
				MessageBox.Show("Please select a year.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (genderComboBox.SelectedIndex == -1) {
				MessageBox.Show("Please select your gender.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (termsCheckBox.Checked == false) {
				MessageBox.Show("Please accept the Terms & Conditions.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (DateTime.Today.Year - ( int )yearComboBox.SelectedItem < 18) {
				MessageBox.Show("You must be over 18 to Play.", "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				string first_name = wordFormatter(firstNameTextBox.Text);
				string last_name = wordFormatter(lastNameTextBox.Text);
				string gender = string.Empty;
				int age = DateTime.Today.Year - ( int )yearComboBox.SelectedItem;

				StringBuilder dialog = new StringBuilder();

				if (genderComboBox.SelectedIndex == 0) {
					gender = "He";
				} else {
					gender = "She";
				}

				dialog.Append("The current player is " + first_name + " " + last_name + ".\n");
				dialog.Append(gender + " is " + age.ToString() + " years of age.\n");
				dialog.Append(gender + " has accepted the Terms and Conditions of Play.");

				MessageBox.Show(dialog.ToString(), "Blackjack Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.Hide();
				Form2 form2 = new Form2();
				form2.ShowDialog();
				this.Close();
			}
		}

		//capitializes the first letter of a word
		private string wordFormatter(string word) {
			if (!( string.IsNullOrEmpty(word) )) {
				return word.First().ToString().ToUpper() + word.Substring(1);
			}
			throw new ArgumentException("string argument is null or empty.");
		}

		///////////////////////////////////////////////////////////////////////
		//					Opens comboboxes when clicked   				 //
		///////////////////////////////////////////////////////////////////////
		private void genderComboBox_Click(object sender, EventArgs e) {
			genderComboBox.DroppedDown = true;
		}

		private void dayComboBox_Click(object sender, EventArgs e) {
			dayComboBox.DroppedDown = true;
		}

		private void monthComboBox_Click(object sender, EventArgs e) {
			monthComboBox.DroppedDown = true;
		}

		private void yearComboBox_Click(object sender, EventArgs e) {
			yearComboBox.DroppedDown = true;
		}

		///////////////////////////////////////////////////////////////////////
		//			      Mouse-over/mouse-down color changer				 //
		///////////////////////////////////////////////////////////////////////
		private void cancelButton_MouseEnter(object sender, EventArgs e) {
			cancelButton.FlatAppearance.BorderColor = dark_blue;
			cancelButton.ForeColor = dark_blue;
		}

		private void cancelButton_MouseLeave(object sender, EventArgs e) {
			cancelButton.FlatAppearance.BorderColor = light_blue;
			cancelButton.ForeColor = light_blue;
		}

		private void cancelButton_MouseDown(object sender, MouseEventArgs e) {
			cancelButton.FlatAppearance.BorderSize = 1;//fix for issue with visual c# bordersizing
		}

		///////////////////////////////////////////////////////////////////////
		//					Watermarking for textboxes						 //
		///////////////////////////////////////////////////////////////////////
		private void firstNameTextBox_Enter(object sender, EventArgs e) {
			if (!fn_watermarked) {
				firstNameTextBox.Text = string.Empty;
				firstNameTextBox.ForeColor = Color.Black;
				fn_watermarked = true;
			}
		}

		private void firstNameTextBox_Leave(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(firstNameTextBox.Text)) {
				firstNameTextBox.ForeColor = Color.DarkGray;
				firstNameTextBox.Text = fn_watermark;
				fn_watermarked = false;
			}
		}

		private void lastNameTextBox_Enter(object sender, EventArgs e) {
			if (!ln_watermarked) {
				lastNameTextBox.Text = string.Empty;
				lastNameTextBox.ForeColor = Color.Black;
				ln_watermarked = true;
			}
		}

		private void lastNameTextBox_Leave(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(lastNameTextBox.Text)) {
				lastNameTextBox.ForeColor = Color.DarkGray;
				lastNameTextBox.Text = ln_watermark;
				ln_watermarked = false;
			}
		}

		///////////////////////////////////////////////////////////////////////
		//					Disables input inside comboboxes				 //
		///////////////////////////////////////////////////////////////////////
		private void dayComboBox_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = true;
		}

		private void monthComboBox_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = true;
		}

		private void yearComboBox_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = true;
		}

		private void genderComboBox_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = true;
		}

		///////////////////////////////////////////////////////////////////////
		//					Combobox color change conditions				 //
		///////////////////////////////////////////////////////////////////////
		private void dayComboBox_DropDown(object sender, EventArgs e) {
			dayComboBox.ForeColor = Color.Black;
		}

		private void monthComboBox_DropDown(object sender, EventArgs e) {
			monthComboBox.ForeColor = Color.Black;
		}

		private void yearComboBox_DropDown(object sender, EventArgs e) {
			yearComboBox.ForeColor = Color.Black;
		}

		private void genderComboBox_DropDown(object sender, EventArgs e) {
			genderComboBox.ForeColor = Color.Black;
		}

		private void dayComboBox_DropDownClosed(object sender, EventArgs e) {
			if (dayComboBox.SelectedIndex == -1) {
				dayComboBox.ForeColor = Color.DarkGray;
			}
		}

		private void monthComboBox_DropDownClosed(object sender, EventArgs e) {
			if (monthComboBox.SelectedIndex == -1) {
				monthComboBox.ForeColor = Color.DarkGray;
			}
		}

		private void yearComboBox_DropDownClosed(object sender, EventArgs e) {
			if (yearComboBox.SelectedIndex == -1) {
				yearComboBox.ForeColor = Color.DarkGray;
			}
		}

		private void genderComboBox_DropDownClosed(object sender, EventArgs e) {
			if (genderComboBox.SelectedIndex == -1) {
				genderComboBox.ForeColor = Color.DarkGray;
			}
		}

		//removes all input from various controls
		private void cancelButton_Click(object sender, EventArgs e) {
			firstNameTextBox.Text = fn_watermark;
			fn_watermarked = false;
			firstNameTextBox.ForeColor = Color.DarkGray;

			lastNameTextBox.Text = ln_watermark;
			ln_watermarked = false;
			lastNameTextBox.ForeColor = Color.DarkGray;

			dayComboBox.SelectedIndex = -1;
			dayComboBox.ForeColor = Color.DarkGray;
			dayComboBox.Text = d_watermark;

			monthComboBox.SelectedIndex = -1;
			monthComboBox.ForeColor = Color.DarkGray;
			monthComboBox.Text = m_watermark;

			yearComboBox.SelectedIndex = -1;
			yearComboBox.ForeColor = Color.DarkGray;
			yearComboBox.Text = y_watermark;

			genderComboBox.SelectedIndex = -1;
			genderComboBox.ForeColor = Color.DarkGray;
			genderComboBox.Text = gen_watermark;

			termsCheckBox.Checked = false;
		}
	}
}
