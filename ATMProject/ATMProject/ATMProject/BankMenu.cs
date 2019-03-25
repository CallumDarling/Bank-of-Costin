using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
	public partial class BankMenu : Form
	{
		Account Robert = new Account("123456", "1234", 67.89);

		public BankMenu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			ATM newATM = new ATM(Robert);
			newATM.Show();
		}
	}
}
