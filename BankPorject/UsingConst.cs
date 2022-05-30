using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPorject
{
    class UsingConst
    {
        public int AccNumber { get; set; }
        public string AccName { get; set; }

        public int AccBalance { get; set; }

        public int TranscationAmt { get; set; }

        public UsingConst() { }
        public UsingConst(int AccNum, string AcName, int AccBal, int Transcation)
        {
            AccNumber = AccNum;
            AccName = AcName;
            AccBalance = AccBal;
            TranscationAmt = 0;

        }
        public static List<UsingConst> AccDet = new List<UsingConst>();

        public static List<UsingConst> getAccountDet()
        {

            Console.WriteLine("Enter the Account Number");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Account Holder Name");
            string AccountHolder = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Account Balance");
            int AccountBal = Convert.ToInt32(Console.ReadLine());
            AccDet.Add(new UsingConst(AccountNumber, AccountHolder, AccountBal,0));
            return AccDet;
            Console.WriteLine("\n");
        }

        public static void ShowAccountDet()
        {
            try
            {
                Console.WriteLine("Enter the account number to display");
                int AccNum = Convert.ToInt32(Console.ReadLine());
                if (AccNum > 0)
                {
                    foreach (var item in AccDet)
                    {

                        if ((Convert.ToInt32(item.AccNumber)) == AccNum)
                        {
                            Console.WriteLine("Account Number : " + item.AccNumber);
                            Console.WriteLine("Account Holder Name : " + item.AccName);
                            Console.WriteLine("Account Balance : " + item.AccBalance);
                            Console.WriteLine("Last Transcation Amount  : " + item.TranscationAmt);
                        }
                    }
                }
                else
                {
                    throw new Exception("Negative number entered");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Enter only Valid account number");
            }
            Console.WriteLine("\n");
        }

        public static void GetTranscationDet()
        {
            try
            {
                Console.WriteLine("Enter the Account number : ");
                int Accnum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Amount : ");
                int Amt = Convert.ToInt32(Console.ReadLine());
                int Flag = 0;
                if (Accnum > 0 && Amt > 0)
                { 
                    foreach (var item in AccDet)
                    {
                        if ((Convert.ToInt32(item.AccNumber)) == Accnum)
                        {
                            Flag = 1;
                            int Balance = item.AccBalance;
                            int index = AccDet.IndexOf(item);
                            if (Balance == 0)
                            {
                                Console.WriteLine("Your Bank Balance is Zero Please deposite some amount !!");

                            }
                            if (Amt <= Balance)
                            {
                                Balance = Balance - Amt;
                                item.TranscationAmt = Amt;
                                item.AccBalance = Balance;
                                Console.WriteLine("Your current Balance: " + Balance);
                            }
                            if (Amt > Balance)
                            {
                                Console.WriteLine("Entered Amount is greater than you account balance !! ");
                            }
                            break;
                        }



                    }
                    if (Flag == 0)
                    {
                        Console.WriteLine("Sorry we dnt recogize you");
                    }
                }
                else
                {
                    throw new Exception("Negative number entered");
                }
                Console.WriteLine("\n");
            }
            catch(Exception)
            {
                Console.WriteLine("Please check your Input and try again");
            }
            
        }


        class exceute
        {

            
            
            static void Main()
            {

                
                
                while (true)
                {
                    Console.WriteLine("Please enter any option below : \n1.Show Existing Account Details\n2.Create new Account\n3.Make a Transcation\n4.Exit\n");
                    try
                    {
                        int user = Convert.ToInt32(Console.ReadLine());
                        if (user == 1)
                        {
                            UsingConst.ShowAccountDet();
                        }
                        if (user == 2)
                        {
                            UsingConst.getAccountDet();
                        }
                        if (user == 3)
                        {
                            UsingConst.GetTranscationDet();
                        }
                        if (user == 4)
                        {
                            break;
                        }
                        if (user <= 0 || user > 4)
                        {
                            Console.WriteLine("Please enter the valid option !!");

                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("You have entered Incorrect input please check and try again");
                    }



                }
            }
        }




    }
}
