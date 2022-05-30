using System;
using System.Collections;
interface Bank
{
	void GetAccountDetails(int AccNumber, String Name, int AccBal);
	void ShowAccountDetails(int AccNumber);
	void GetTranscationDetails(int AccNumber, int Amt);
	void ShowLastTranscationDetails(int AccNumber);

}
class SBI : Bank
{
	Hashtable BankAccDetails = new Hashtable();
	private int AccountNumber { get; set; }
	private String AccountHolderName { get; set; }
	private int AccBalance { get; set; }
	private int TransBalance { get; set; }


	public void GetAccountDetails(int AccNumber, String Name, int AccBal)
	{
		int i = 0;
		int e=0;
		this.AccountNumber = AccNumber;
		this.AccountHolderName = Name;
		this.AccBalance = AccBal;
		this.TransBalance = 0;
		String Value = String.Format("{0},{1},{2}", AccountHolderName, AccBalance, TransBalance);
		Console.WriteLine("Your Account Number : " + AccountNumber + "\n" + "Your Account Details : " + Value);
		BankAccDetails.Add(AccountNumber, Value);
		Console.WriteLine("\n");
	}

	public void ShowAccountDetails(int AccNumber)
	{

		int num = AccNumber;
		if (BankAccDetails.Contains(num))
		{
			foreach (DictionaryEntry item in BankAccDetails)
			{
				var currentnum = Convert.ToInt16(item.Key);
				if (num == currentnum)
				{
					var details = Convert.ToString(item.Value);
					char[] spearator = { ',' };
					String[] strlist = details.Split(spearator);
					Console.WriteLine("Account Holder Name : " + strlist[0]);
					Console.WriteLine("Account Number : " + Convert.ToString(item.Key));
					Console.WriteLine("Account Balance : " + strlist[1]);
					Console.WriteLine("Last Transcations Amount : " + strlist[2]);
				}

			}
		}
		else
		{
			Console.WriteLine("We Dn't recognize your Account Number please try again !!");
		}
		Console.WriteLine("\n");
	}

	public void GetTranscationDetails(int AccNumber, int Amt)
	{
		int Number = AccNumber;
		int amt = Amt;
		if (BankAccDetails.Contains(Number))
		{
			foreach (DictionaryEntry item in BankAccDetails)
			{
				var details = Convert.ToString(item.Value);
				String Value = " ";
				char[] spearator = { ',' };
				String[] strlist = details.Split(spearator);
				int Balance = Convert.ToInt32(strlist[1]);
				if (Balance == 0)
				{
					Console.WriteLine("Your Bank Balance is Zero Please deposite some amount !!");
				}
				if (amt <= Balance)
				{
					Value = String.Format("{0},{1},{2}", strlist[0], (Convert.ToInt32(strlist[1]) - amt), amt);
					BankAccDetails[Number] = Value;
					break;
				}
				if (amt > Balance)
				{
					Console.WriteLine("Entered Amount is greater than you account balance !! ");
				}


			}
		}
		else
		{
			Console.WriteLine("We Dn't recognize your Account Number please try again !!");
		}
		Console.WriteLine("\n");
	}
	public void ShowLastTranscationDetails(int AccNumber)
	{
		int Number = Convert.ToInt32(AccNumber);
		if (BankAccDetails.Contains(Number))
		{
			foreach (DictionaryEntry item in BankAccDetails)
			{
				var details = Convert.ToString(item.Value);
				char[] spearator = { ',' };
				String[] strlist = details.Split(spearator);
				Console.WriteLine("Account Holder Name : " + strlist[0]);
				Console.WriteLine("Account Number : " + Convert.ToString(item.Key));
				Console.WriteLine("Account Balance : " + strlist[1]);
				Console.WriteLine("Last Transcations Amount : " + strlist[2]);

			}
		}
		else
		{
			Console.WriteLine("Sorry we dnt recognize you account number !! ");
		}
	}

}
class Execution
{
	public static void main(string[] args)
	{
		var s1 = new SBI();
		int flag = 1;
		try
		{
			Console.WriteLine("Enter the Account Number");
			int AccountNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the Account Holder Name");
			string AccountHolder = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Enter the Account Balance");
			int AccountBal = Convert.ToInt32(Console.ReadLine());
			s1.GetAccountDetails(AccountNumber, AccountHolder, AccountBal);
		}
		catch(Exception e)
        {
			Console.WriteLine(e.Message);
			flag = 0;
        }
		
		flag = 1;
		while (flag == 1)
		{
			Console.WriteLine("Please enter any option below : \n1.Show Account Details\n2.Get Account Details\n3.Get Transcation Details\n4.Show Last Transcation Details\n5.Exit");
			try
			{
				int user = Convert.ToInt32(Console.ReadLine());
				if (user == 1)
				{
					Console.WriteLine("Enter the Account Number");
					int ActNumber = Convert.ToInt32(Console.ReadLine());
					s1.ShowAccountDetails(ActNumber);

				}
				if (user == 2)
				{
					Console.WriteLine("Enter the Account Number");
					int ActNumber = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter the Account Holder Name");
					string ActHolder = Convert.ToString(Console.ReadLine());
					Console.WriteLine("Enter the Account Balance");
					int ActBal = Convert.ToInt32(Console.ReadLine());
					s1.GetAccountDetails(ActNumber, ActHolder, ActBal);
				}
				if (user == 3)
				{
					Console.WriteLine("Enter the Account Number");
					int AtNumber = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter the Debit Amount");
					int DtAt = Convert.ToInt32(Console.ReadLine());
					s1.GetTranscationDetails(AtNumber, DtAt);
				}
				if (user == 4)
				{
					Console.WriteLine("Enter the Account Number");
					int ANumber = Convert.ToInt32(Console.ReadLine());
					s1.ShowLastTranscationDetails(ANumber);
				}
				if (user == 5)
				{
					Console.WriteLine("Thank you for banking with us !!");
					break;
				}
				if(user<=0 || user>5)
                {
					Console.WriteLine("Please enter the valid option !!");
					
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				
			}
		}

	}
}
