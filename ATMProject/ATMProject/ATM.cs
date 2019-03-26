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
	public partial class ATM : Form
	{
		private bool checkForPin = false;
        private bool checkForAccount = false;
        private String savedAccountNo;
        private String savedPIN;
        private Account[] accounts;
        private Account loggedIn;
        private String accountNo;
        private bool selectM = false;
        private bool goBack = false;
        private bool takeM = false;
        //Used to show whether the semaphore should be turned on/off in the account class
        private bool semOn = false;
        private bool syncModeOn;
        

        public ATM(Account[] acc, bool syncModeOn)
		{
			InitializeComponent();

            this.syncModeOn = syncModeOn;

			login();
            accounts = acc;

            this.Text = "ATM " + Thread.CurrentThread.Name;
            
        }

		public void login()
		{
			mainDisplay.Text = "Please enter your account number";
			checkForAccount = true;

		}


		public void takeMoney()
		{
			selectM = false;
			takeM = true;
			mainDisplay.Text = "Select amount to withdraw";
			d1.Text = "Return to Main Menu";
			d2.Text = "£10";
			d3.Text = "£20";
			d4.Text = "£50";
			d5.Text = "£100";
			d6.Text = "£200";
		}
		public void checkBalance()
		{
			goBack = true;
			mainDisplay.Text = "Your current balance is: £" + loggedIn.getBalance(semOn);
			d1.Text = "Return to Main Menu";
			d2.Text = "";
			d3.Text = "";
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

		private void PINButtonPress(String buttonText)
		{
			String screenText = PINbox.Text;

			screenText = screenText + buttonText;

			PINbox.Text = screenText;
		}



		private void ATM_Load(object sender, EventArgs e)
		{

		}

		
		private void button1_Click(object sender, EventArgs e)
		{
			numberButtonPress("1");
			PINButtonPress("* ");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			numberButtonPress("2");
			PINButtonPress("* ");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			numberButtonPress("3");
			PINButtonPress("* ");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			numberButtonPress("4");
			PINButtonPress("* ");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			numberButtonPress("5");
			PINButtonPress("* ");
		}
		private void button6_Click(object sender, EventArgs e)
		{
			numberButtonPress("6");
			PINButtonPress("* ");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			numberButtonPress("7");
			PINButtonPress("* ");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			numberButtonPress("8");
			PINButtonPress("* ");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			numberButtonPress("9");
			PINButtonPress("* ");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			numberButtonPress("0");
			PINButtonPress("* ");
		}

		private void cancelBut_Click(object sender, EventArgs e)
		{
			mainDisplay.Text = "Returning your card...";
			timer1.Start();
		}

		private void clearBut_Click(object sender, EventArgs e)
		{
			numberDisplay.Text = "";
			PINbox.Text = "";
		}

        private bool searchAccountNo(String accNo)
        {
            
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accNo.Equals(accounts[i].getAccountNumber()))
                {
                    accountNo = accNo;
                    return true;
                }
            }

            return false;
        }

        private bool comparePIN(String pin)
        {

            for (int i = 0; i < accounts.Length; i++)
            {
                if(accountNo.Equals(accounts[i].getAccountNumber()) && pin.Equals(accounts[i].getPIN()))
                {
                    loggedIn = accounts[i];
                    return true;
                }
            }

            return false;
        }

        private void enterBut_Click(object sender, EventArgs e)
		{
			String screenText = numberDisplay.Text;
			bool accountNoAccepted = false;

			if(checkForAccount)
			{
				if (searchAccountNo(screenText))
				{
					savedAccountNo = numberDisplay.Text;
					numberDisplay.Text = "";
					PINbox.Text = "";
					checkForAccount = false;
					accountNoAccepted = true;
				}
				else
				{
					mainDisplay.Text = "The account number was incorrect please try again.";
					numberDisplay.Text = "";
					PINbox.Text = "";
				}
			}


			if (checkForPin)
			{
				if (comparePIN(screenText))
				{
					savedPIN = numberDisplay.Text;
					numberDisplay.Text = "";
					PINbox.Text = "";
					checkForPin = false;
					selectionMenu();

                }
				else
				{
					mainDisplay.Text = "The PIN was incorrect, please try again.";
					numberDisplay.Text = "";
					PINbox.Text = "";
				}
			}

			if(accountNoAccepted)
			{
				mainDisplay.Text = "Please enter your PIN";
				checkForPin = true;
			}
		}

		public void selectionMenu()
		{
			takeM = false;
			selectM = true;
			mainDisplay.Text = "Please select an option:";
			d1.Text = "Cash Withdrawal";
			d2.Text = "Account Balance";
			d3.Text = "Return Card";
			d4.Text = "";
			d5.Text = "";
			d6.Text = "";

		}

        public bool checkEnoughinAccount(double amountToWithdraw)
        {
            
            if (amountToWithdraw > loggedIn.getBalanceRegular())
            {
                mainDisplay.Text = "Insufficients for withdrawal";
                takeM = false;
                d1.Text = "";
                d2.Text = "";
                d3.Text = "";
                d4.Text = "";
                d5.Text = "";
                d6.Text = "";

                return false;
            }

            else
            {
                return true;
            }
        }


		public void checkWithdraw(double amountToWithdraw)
		{
			System.Diagnostics.Debug.WriteLine( "thr started" + Thread.CurrentThread.Name);
			
            //This is passsed into get/setbalance so the semaphore can be started/released
            if(syncModeOn)
            {
                semOn = true;
            }
            
            double accountBalance = loggedIn.getBalance(semOn);
                
            if(Thread.CurrentThread.Name.Equals("1"))
            {
                System.Diagnostics.Debug.WriteLine("thr " + Thread.CurrentThread.Name + " is calculating the new balance");
                Thread.Sleep(3000);
            }

            bool enoughInAccount = checkEnoughinAccount(amountToWithdraw);

            if(enoughInAccount)
            {
                mainDisplay.Text = "Please take your notes";
                loggedIn.setBalance((accountBalance - amountToWithdraw), semOn);
                takeM = false;
            }
                
			
            //Sets semOn back to false so that when you check the balance elsewhere in the program it doesn't freeze
            semOn = false;
			timer2.Start();
			
			
			System.Diagnostics.Debug.WriteLine("thrfin" + Thread.CurrentThread.Name);
			
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			Close();
		}

		private void butA_Click(object sender, EventArgs e)
		{
	
			if(goBack && !takeM)
			{
				selectionMenu();
				goBack = false;
			}

			else if (!goBack && takeM)
			{
				selectionMenu();
				takeM = false;
			}

			else if (selectM)
			{
				takeMoney();
				selectM = false;
			}

		}

		private void butB_Click(object sender, EventArgs e)
		{
			if (takeM)
			{
				checkWithdraw(10);
				takeM = false;
			}

			else if (selectM)
			{
				checkBalance();
				selectM = false;
			}
		}

		private void butC_Click(object sender, EventArgs e)
		{
			if (selectM)
			{
				Close();
				selectM = false;
			}

			else if (takeM)
			{
				checkWithdraw(20);
				takeM = false;
			}
		}

		private void butD_Click(object sender, EventArgs e)
		{
			if (takeM)
			{
				checkWithdraw(50);
				takeM = false;
			}
		}

		private void butE_Click(object sender, EventArgs e)
		{
			if (takeM)
			{
				checkWithdraw(100);
				takeM = false;
			}
		}

		private void butF_Click(object sender, EventArgs e)
		{
			if (takeM)
			{
				checkWithdraw(200);
				takeM = false;
			}

		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			selectionMenu();
			timer2.Stop();
		}
	}
}
