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
        Account[] accountList = new Account[3];
        bool syncModeOn = false;

        int x = 1;

		

		private void ThreadProc()
		{
			var frm = new ATM(accountList, syncModeOn);
			frm.ShowDialog();
		}

		public BankMenu()
		{
			InitializeComponent();
            accountList[0] = new Account("111111", "1111", 300);
            accountList[1] = new Account("222222", "2222", 750);
            accountList[2] = new Account("333333", "3333", 3000);
        }


		private void Form1_Load(object sender, EventArgs e)
		{

		}
        
		private void button1_Click(object sender, EventArgs e)
		{
			Thread newATM = new Thread(new ThreadStart(ThreadProc));
			newATM.Name = Convert.ToString(x);
			newATM.Start();
            if(x == 1)
            {
                x++;
            }
            else
            {
                x--;
            }
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

        private void syncMode_CheckedChanged(object sender, EventArgs e)
        {
            syncModeOn = syncMode.Checked;
        }
    }
}
