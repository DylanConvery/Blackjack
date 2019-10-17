namespace blackjack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.okayButton = new System.Windows.Forms.Button();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.Name = new System.Windows.Forms.Label();
			this.Birthday = new System.Windows.Forms.Label();
			this.termsCheckBox = new System.Windows.Forms.CheckBox();
			this.genderComboBox = new System.Windows.Forms.ComboBox();
			this.Gender = new System.Windows.Forms.Label();
			this.monthComboBox = new System.Windows.Forms.ComboBox();
			this.yearComboBox = new System.Windows.Forms.ComboBox();
			this.dayComboBox = new System.Windows.Forms.ComboBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// okayButton
			// 
			this.okayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
			this.okayButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.okayButton.FlatAppearance.BorderSize = 0;
			this.okayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
			this.okayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
			this.okayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okayButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okayButton.ForeColor = System.Drawing.Color.White;
			this.okayButton.Location = new System.Drawing.Point(64, 367);
			this.okayButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.okayButton.Name = "okayButton";
			this.okayButton.Size = new System.Drawing.Size(270, 39);
			this.okayButton.TabIndex = 9;
			this.okayButton.Text = "Okay";
			this.okayButton.UseVisualStyleBackColor = false;
			this.okayButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.lastNameTextBox.Location = new System.Drawing.Point(200, 41);
			this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(165, 29);
			this.lastNameTextBox.TabIndex = 3;
			this.lastNameTextBox.Text = "Last";
			this.lastNameTextBox.Enter += new System.EventHandler(this.lastNameTextBox_Enter);
			this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Leave);
			// 
			// Name
			// 
			this.Name.AutoSize = true;
			this.Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name.Location = new System.Drawing.Point(25, 18);
			this.Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(52, 21);
			this.Name.TabIndex = 1;
			this.Name.Text = "Name";
			// 
			// Birthday
			// 
			this.Birthday.AutoSize = true;
			this.Birthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Birthday.Location = new System.Drawing.Point(25, 83);
			this.Birthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Birthday.Name = "Birthday";
			this.Birthday.Size = new System.Drawing.Size(68, 21);
			this.Birthday.TabIndex = 10;
			this.Birthday.Text = "Birthday";
			// 
			// termsCheckBox
			// 
			this.termsCheckBox.AutoSize = true;
			this.termsCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.termsCheckBox.Location = new System.Drawing.Point(64, 337);
			this.termsCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.termsCheckBox.Name = "termsCheckBox";
			this.termsCheckBox.Size = new System.Drawing.Size(261, 25);
			this.termsCheckBox.TabIndex = 8;
			this.termsCheckBox.Text = "I accept the Terms and Conditions";
			this.termsCheckBox.UseVisualStyleBackColor = true;
			// 
			// genderComboBox
			// 
			this.genderComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.genderComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genderComboBox.ForeColor = System.Drawing.Color.DarkGray;
			this.genderComboBox.FormattingEnabled = true;
			this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.genderComboBox.Location = new System.Drawing.Point(29, 172);
			this.genderComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.genderComboBox.Name = "genderComboBox";
			this.genderComboBox.Size = new System.Drawing.Size(336, 29);
			this.genderComboBox.TabIndex = 7;
			this.genderComboBox.Text = "I am...";
			this.genderComboBox.DropDown += new System.EventHandler(this.genderComboBox_DropDown);
			this.genderComboBox.DropDownClosed += new System.EventHandler(this.genderComboBox_DropDownClosed);
			this.genderComboBox.Click += new System.EventHandler(this.genderComboBox_Click);
			this.genderComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderComboBox_KeyPress);
			// 
			// Gender
			// 
			this.Gender.AutoSize = true;
			this.Gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Gender.Location = new System.Drawing.Point(25, 149);
			this.Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Gender.Name = "Gender";
			this.Gender.Size = new System.Drawing.Size(61, 21);
			this.Gender.TabIndex = 11;
			this.Gender.Text = "Gender";
			// 
			// monthComboBox
			// 
			this.monthComboBox.DropDownHeight = 300;
			this.monthComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthComboBox.ForeColor = System.Drawing.Color.DarkGray;
			this.monthComboBox.FormattingEnabled = true;
			this.monthComboBox.IntegralHeight = false;
			this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
			this.monthComboBox.Location = new System.Drawing.Point(119, 106);
			this.monthComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.monthComboBox.Name = "monthComboBox";
			this.monthComboBox.Size = new System.Drawing.Size(150, 29);
			this.monthComboBox.TabIndex = 5;
			this.monthComboBox.Text = "Month";
			this.monthComboBox.DropDown += new System.EventHandler(this.monthComboBox_DropDown);
			this.monthComboBox.DropDownClosed += new System.EventHandler(this.monthComboBox_DropDownClosed);
			this.monthComboBox.Click += new System.EventHandler(this.monthComboBox_Click);
			this.monthComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthComboBox_KeyPress);
			// 
			// yearComboBox
			// 
			this.yearComboBox.DropDownHeight = 300;
			this.yearComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yearComboBox.ForeColor = System.Drawing.Color.DarkGray;
			this.yearComboBox.FormattingEnabled = true;
			this.yearComboBox.IntegralHeight = false;
			this.yearComboBox.Location = new System.Drawing.Point(275, 106);
			this.yearComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.yearComboBox.Name = "yearComboBox";
			this.yearComboBox.Size = new System.Drawing.Size(89, 29);
			this.yearComboBox.TabIndex = 6;
			this.yearComboBox.Text = "Year";
			this.yearComboBox.DropDown += new System.EventHandler(this.yearComboBox_DropDown);
			this.yearComboBox.DropDownClosed += new System.EventHandler(this.yearComboBox_DropDownClosed);
			this.yearComboBox.Click += new System.EventHandler(this.yearComboBox_Click);
			this.yearComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearComboBox_KeyPress);
			// 
			// dayComboBox
			// 
			this.dayComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.dayComboBox.DropDownHeight = 300;
			this.dayComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dayComboBox.ForeColor = System.Drawing.Color.DarkGray;
			this.dayComboBox.FormattingEnabled = true;
			this.dayComboBox.IntegralHeight = false;
			this.dayComboBox.Location = new System.Drawing.Point(29, 106);
			this.dayComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dayComboBox.Name = "dayComboBox";
			this.dayComboBox.Size = new System.Drawing.Size(84, 29);
			this.dayComboBox.TabIndex = 4;
			this.dayComboBox.Text = "Day";
			this.dayComboBox.DropDown += new System.EventHandler(this.dayComboBox_DropDown);
			this.dayComboBox.DropDownClosed += new System.EventHandler(this.dayComboBox_DropDownClosed);
			this.dayComboBox.Click += new System.EventHandler(this.dayComboBox_Click);
			this.dayComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dayComboBox_KeyPress);
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.firstNameTextBox.Location = new System.Drawing.Point(29, 41);
			this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(165, 29);
			this.firstNameTextBox.TabIndex = 2;
			this.firstNameTextBox.Text = "First";
			this.firstNameTextBox.Enter += new System.EventHandler(this.firstNameTextBox_Enter);
			this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTextBox_Leave);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.White;
			this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
			this.cancelButton.FlatAppearance.BorderSize = 2;
			this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
			this.cancelButton.Location = new System.Drawing.Point(64, 412);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(270, 39);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
			this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
			this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(119, 206);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 111);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(395, 479);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.dayComboBox);
			this.Controls.Add(this.yearComboBox);
			this.Controls.Add(this.monthComboBox);
			this.Controls.Add(this.Gender);
			this.Controls.Add(this.genderComboBox);
			this.Controls.Add(this.termsCheckBox);
			this.Controls.Add(this.Birthday);
			this.Controls.Add(this.Name);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.okayButton);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			//this.Name = "Form1";
			this.Text = "Welcome";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label Name;
		private System.Windows.Forms.Label Birthday;
		private System.Windows.Forms.CheckBox termsCheckBox;
		private System.Windows.Forms.ComboBox genderComboBox;
		private System.Windows.Forms.Label Gender;
		private System.Windows.Forms.ComboBox monthComboBox;
		private System.Windows.Forms.ComboBox yearComboBox;
		private System.Windows.Forms.ComboBox dayComboBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}