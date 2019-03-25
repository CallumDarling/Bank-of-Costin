using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATMProject
{
	public class Account
	{
		private String accountNumber;
		private String PIN;
		private double balance;
        Semaphore sem = new Semaphore(1, 1);



        public Account(String aNumber, String pin, double bal)
		{
			accountNumber = aNumber;
			PIN = pin;
			balance = bal;
		}

		public String getAccountNumber()
		{
			return accountNumber;
		}
		public String getPIN()
		{
			return PIN;
		}
		public double getBalance(bool semOn)
		{
            if(semOn)
            {
                sem.WaitOne();
            }

			return balance;
            
		}

		public void setBalance(double newBal, bool semOn)
		{
          
			balance = newBal;
            if (semOn)
            {
                sem.Release();
            }
        }

	}
}
