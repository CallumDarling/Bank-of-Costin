using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
	public partial class BankMenu : Form
	{
		Account Robert = new Account("123456", "1234", 67.89);
        
        int x = 1;

		

		private void ThreadProc()
		{
			var frm = new ATM(Robert);
			frm.ShowDialog();
		}

		public BankMenu()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}
        
		private void button1_Click(object sender, EventArgs e)
		{
			Thread newATM = new Thread(new ThreadStart(ThreadProc));
			newATM.Name = Convert.ToString(x);
			newATM.Start();
			x++;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
