#define LAUNCH_BLACKJACK_GAME

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		#if LAUNCH_BLACKJACK_GAME
			Application.Run(new Form2());
		#else
			Application.Run(new Form1());
		#endif
		}
	}
}
