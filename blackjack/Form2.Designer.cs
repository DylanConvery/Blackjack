namespace blackjack
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.buttonHit = new System.Windows.Forms.Button();
			this.buttonHold = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.playAgainButton = new System.Windows.Forms.Button();
			this.House = new System.Windows.Forms.Label();
			this.Player = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cardValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonHit
			// 
			this.buttonHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
			this.buttonHit.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonHit.FlatAppearance.BorderSize = 0;
			this.buttonHit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
			this.buttonHit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
			this.buttonHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHit.ForeColor = System.Drawing.Color.White;
			this.buttonHit.Location = new System.Drawing.Point(570, 457);
			this.buttonHit.Name = "buttonHit";
			this.buttonHit.Size = new System.Drawing.Size(148, 68);
			this.buttonHit.TabIndex = 1;
			this.buttonHit.Text = "Hit";
			this.buttonHit.UseVisualStyleBackColor = false;
			this.buttonHit.Click += new System.EventHandler(this.hitButton_Click);
			// 
			// buttonHold
			// 
			this.buttonHold.BackColor = System.Drawing.Color.White;
			this.buttonHold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
			this.buttonHold.FlatAppearance.BorderSize = 2;
			this.buttonHold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.buttonHold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.buttonHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHold.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
			this.buttonHold.Location = new System.Drawing.Point(570, 389);
			this.buttonHold.Name = "buttonHold";
			this.buttonHold.Size = new System.Drawing.Size(148, 62);
			this.buttonHold.TabIndex = 2;
			this.buttonHold.Text = "Stand";
			this.buttonHold.UseVisualStyleBackColor = false;
			this.buttonHold.Click += new System.EventHandler(this.holdButton_Click);
			this.buttonHold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonHold_MouseDown);
			this.buttonHold.MouseEnter += new System.EventHandler(this.buttonHold_MouseEnter);
			this.buttonHold.MouseLeave += new System.EventHandler(this.buttonHold_MouseLeave);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "blue back of cards.png");
			this.imageList1.Images.SetKeyName(1, "2c.png");
			this.imageList1.Images.SetKeyName(2, "2d.png");
			this.imageList1.Images.SetKeyName(3, "2h.png");
			this.imageList1.Images.SetKeyName(4, "2s.png");
			this.imageList1.Images.SetKeyName(5, "3c.png");
			this.imageList1.Images.SetKeyName(6, "3d.png");
			this.imageList1.Images.SetKeyName(7, "3h.png");
			this.imageList1.Images.SetKeyName(8, "3s.png");
			this.imageList1.Images.SetKeyName(9, "4c.png");
			this.imageList1.Images.SetKeyName(10, "4d.png");
			this.imageList1.Images.SetKeyName(11, "4h.png");
			this.imageList1.Images.SetKeyName(12, "4s.png");
			this.imageList1.Images.SetKeyName(13, "5c.png");
			this.imageList1.Images.SetKeyName(14, "5d.png");
			this.imageList1.Images.SetKeyName(15, "5h.png");
			this.imageList1.Images.SetKeyName(16, "5s.png");
			this.imageList1.Images.SetKeyName(17, "6c.png");
			this.imageList1.Images.SetKeyName(18, "6d.png");
			this.imageList1.Images.SetKeyName(19, "6h.png");
			this.imageList1.Images.SetKeyName(20, "6s.png");
			this.imageList1.Images.SetKeyName(21, "7c.png");
			this.imageList1.Images.SetKeyName(22, "7d.png");
			this.imageList1.Images.SetKeyName(23, "7h.png");
			this.imageList1.Images.SetKeyName(24, "7s.png");
			this.imageList1.Images.SetKeyName(25, "8c.png");
			this.imageList1.Images.SetKeyName(26, "8d.png");
			this.imageList1.Images.SetKeyName(27, "8h.png");
			this.imageList1.Images.SetKeyName(28, "8s.png");
			this.imageList1.Images.SetKeyName(29, "9c.png");
			this.imageList1.Images.SetKeyName(30, "9d.png");
			this.imageList1.Images.SetKeyName(31, "9h.png");
			this.imageList1.Images.SetKeyName(32, "9s.png");
			this.imageList1.Images.SetKeyName(33, "10c.png");
			this.imageList1.Images.SetKeyName(34, "10d.png");
			this.imageList1.Images.SetKeyName(35, "10h.png");
			this.imageList1.Images.SetKeyName(36, "10s.png");
			this.imageList1.Images.SetKeyName(37, "ac.png");
			this.imageList1.Images.SetKeyName(38, "ad.png");
			this.imageList1.Images.SetKeyName(39, "ah.png");
			this.imageList1.Images.SetKeyName(40, "as.png");
			this.imageList1.Images.SetKeyName(41, "jc.png");
			this.imageList1.Images.SetKeyName(42, "jd.png");
			this.imageList1.Images.SetKeyName(43, "jh.png");
			this.imageList1.Images.SetKeyName(44, "js.png");
			this.imageList1.Images.SetKeyName(45, "kc.png");
			this.imageList1.Images.SetKeyName(46, "kd.png");
			this.imageList1.Images.SetKeyName(47, "kh.png");
			this.imageList1.Images.SetKeyName(48, "ks.png");
			this.imageList1.Images.SetKeyName(49, "qc.png");
			this.imageList1.Images.SetKeyName(50, "qd.png");
			this.imageList1.Images.SetKeyName(51, "qh.png");
			this.imageList1.Images.SetKeyName(52, "qs.png");
			this.imageList1.Images.SetKeyName(53, "red back of cards.png");
			// 
			// playAgainButton
			// 
			this.playAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
			this.playAgainButton.Enabled = false;
			this.playAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.playAgainButton.FlatAppearance.BorderSize = 0;
			this.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
			this.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
			this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playAgainButton.ForeColor = System.Drawing.Color.White;
			this.playAgainButton.Location = new System.Drawing.Point(258, 457);
			this.playAgainButton.Name = "playAgainButton";
			this.playAgainButton.Size = new System.Drawing.Size(224, 68);
			this.playAgainButton.TabIndex = 4;
			this.playAgainButton.Text = "Play Again?";
			this.playAgainButton.UseVisualStyleBackColor = false;
			this.playAgainButton.Visible = false;
			this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
			// 
			// House
			// 
			this.House.AutoSize = true;
			this.House.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.House.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
			this.House.Location = new System.Drawing.Point(12, 129);
			this.House.Name = "House";
			this.House.Size = new System.Drawing.Size(72, 30);
			this.House.TabIndex = 6;
			this.House.Text = "House";
			// 
			// Player
			// 
			this.Player.AutoSize = true;
			this.Player.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Player.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
			this.Player.Location = new System.Drawing.Point(12, 347);
			this.Player.Name = "Player";
			this.Player.Size = new System.Drawing.Size(69, 30);
			this.Player.TabIndex = 7;
			this.Player.Text = "Player";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(741, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.cardValuesToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// informationToolStripMenuItem
			// 
			this.informationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informationToolStripMenuItem.Image")));
			this.informationToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
			this.informationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.informationToolStripMenuItem.Text = "Rules";
			this.informationToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
			// 
			// cardValuesToolStripMenuItem
			// 
			this.cardValuesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cardValuesToolStripMenuItem.Image")));
			this.cardValuesToolStripMenuItem.Name = "cardValuesToolStripMenuItem";
			this.cardValuesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.cardValuesToolStripMenuItem.Text = "Card values";
			this.cardValuesToolStripMenuItem.Click += new System.EventHandler(this.cardValuesToolStripMenuItem_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(741, 549);
			this.Controls.Add(this.Player);
			this.Controls.Add(this.House);
			this.Controls.Add(this.playAgainButton);
			this.Controls.Add(this.buttonHold);
			this.Controls.Add(this.buttonHit);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.Text = "Blackjack";
			this.Shown += new System.EventHandler(this.Form2_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonHold;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button playAgainButton;
		private System.Windows.Forms.Label House;
		private System.Windows.Forms.Label Player;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cardValuesToolStripMenuItem;
	}
}

