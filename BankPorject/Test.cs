//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BankPorject
//{
//    internal class Test
//    {
//    }
//}


//public static void ShowAccountDet()
//{
//    int AccNum = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(AccNum);
//    foreach (var item in AccDet)
//    {
//        Console.WriteLine(item.AccNumber);
//        if ((Convert.ToInt32(item.AccNumber)) == AccNum)
//        {
//            Console.WriteLine("Account Number : " + item.AccNumber);
//            Console.WriteLine("Account Holder Name : " + item.AccName);
//            Console.WriteLine("Account Balance : " + item.AccBalance);
//            Console.WriteLine("Last Transcation Amount  : " + item.TranscationAmt);
//        }


//    }



//}

//public static void GetTranscation()
//{
//    int Accnum = Convert.ToInt32(Console.ReadLine());
//    int Amt = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(Amt);
//    foreach (var item in AccDet)
//    {
//        Console.WriteLine(item.AccNumber);
//        if ((Convert.ToInt32(item.AccNumber)) == Accnum)
//        {
//            int Balance = item.AccBalance;
//            int index = AccDet.IndexOf(item);
//            Console.WriteLine(index);
//            if (Balance == 0)
//            {
//                Console.WriteLine("Your Bank Balance is Zero Please deposite some amount !!");

//            }
//            if (Amt <= Balance)
//            {
//                Balance = Balance - Amt;
//                AccDet[index] = (item.AccNumber, item.AccName, Balance, Amt);

//            }
//            if (Amt > Balance)
//            {
//                Console.WriteLine("Entered Amount is greater than you account balance !! ");
//            }
//        }
//        else
//        {
//            Console.WriteLine("We Dn't recognize your Account Number please try again !!");
//            break;
//        }

//    }
//}
