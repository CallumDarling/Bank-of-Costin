using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
	public class Account
	{
		private String accountNumber;
		private String PIN;
		private double balance;

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
		public double getBalance()
		{
			return balance;
		}
		
	}
}
