using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablenUndDatentypen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAnzeigen_Click(object sender, EventArgs e)
		{
			// Datentypen für Zahlen
			int alter = 30;
			int meinAlter;
			string ausgabe = "";
			double preis = 10.87;

			meinAlter = alter;

			// Ausgabe zusammensetzen
			ausgabe =
				"Mein Alter: " + meinAlter
				+ "\n"
				+ meinAlter.ToString()
				+ "\n"
				+ "Preis: " + preis + " Euro";

			lblAnzeige.Text = ausgabe;
		}
	}
}
