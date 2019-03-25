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
	public partial class ATM : Form
	{
		bool checkForPin = false;
		bool checkForAccount = false;
		String savedAccountNo;
		String savedPIN;
		Account account;
		

		public ATM(Account acc)
		{
			InitializeComponent();

			login();
			account = acc;
		}

		public void login()
		{
			mainDisplay.Text = "Please enter your account number";
			checkForAccount = true;

		}
		public void selectionMenu(Account account)
		{

			int caseS = 0;

			switch (caseS)
			{
				case 1:
					takeMoney(account);
					break;
				case 2:
					checkBalance(account);
					break;
				case 3:
					Application.Exit();
					break;
				default:
					Console.WriteLine("Invalid option");
					break;
			}

		}

		public void takeMoney(Account account)
		{
			String ammountToWithdraw = Console.ReadLine();
			double ammount = Convert.ToDouble(ammountToWithdraw);

		}
		public void checkBalance(Account account)
		{

		}

		private String getScreenText()
		{
			String screenText = numberDisplay.Text;
			return screenText;
		}

		private void numberButtonPress(String buttonText)
		{
			String screenText = getScreenText();

			screenText = screenText + buttonText;

			numberDisplay.Text = screenText;
		}

	


		private void ATM_Load(object sender, EventArgs e)
		{

		}

		
		private void button1_Click(object sender, EventArgs e)
		{
			numberButtonPress("1");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			numberButtonPress("2");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			numberButtonPress("3");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			numberButtonPress("4");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			numberButtonPress("5");
		}
		private void button6_Click(object sender, EventArgs e)
		{
			numberButtonPress("6");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			numberButtonPress("7");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			numberButtonPress("8");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			numberButtonPress("9");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			numberButtonPress("0");
		}

		private void cancelBut_Click(object sender, EventArgs e)
		{
			mainDisplay.Text = "Returning your card...";
			timer1.Start();
		}

		private void clearBut_Click(object sender, EventArgs e)
		{
			numberDisplay.Text = "";
		}

		private void enterBut_Click(object sender, EventArgs e)
		{
			String screenText = numberDisplay.Text;
			bool accountNoAccepted = false;

			if(checkForAccount)
			{
				if (screenText.Equals(account.getAccountNumber()))
				{
					savedAccountNo = numberDisplay.Text;
					numberDisplay.Text = "";
					checkForAccount = false;
					accountNoAccepted = true;
				}
				else
				{
					mainDisplay.Text = "The account number must be six characters long";
					numberDisplay.Text = "";
				}
			}


			if (checkForPin)
			{
				if (screenText.Equals(account.getPIN()))
				{
					savedPIN = numberDisplay.Text;
					numberDisplay.Text = "";
					checkForPin = false;
					mainDisplay.Text = "it FUCKING WORKED CUNTMONEKY CLEAR BUTT";

					
				}
				else
				{
					mainDisplay.Text = "The PIN must be four characters long";
					numberDisplay.Text = "";
				}
			}

			if(accountNoAccepted)
			{
				mainDisplay.Text = "Please enter your PIN";
				checkForPin = true;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
