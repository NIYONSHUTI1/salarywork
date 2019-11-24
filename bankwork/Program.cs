using System;

namespace bankwork
{
   class Program
    {
        static void Main(string[] args)
        {
            int amount = 50000, deposit, withdraw;
            int option, pin = 0, x = 0;
            Console.WriteLine("writte your pin ");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("bank app\n");
                Console.WriteLine("enter first name");
                string firstname = Console.ReadLine();
                Console.WriteLine("enter Lastname");
                string Lastname = Console.ReadLine();
                Console.WriteLine(" enter  gender");
                string gender = Console.ReadLine();
                Console.WriteLine("enter Account Number");
                int account = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1. check balance\n");
                Console.WriteLine("2. Withdraw money \n");
                Console.WriteLine("3. Deposit money \n");
                Console.WriteLine("4. exist \n");
                Console.WriteLine("----------------\n\n");
                Console.WriteLine("select: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n YOUR BALANCE IS RFW : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER amount to withdraw: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n  ENTER THE AMOUNT minimum  100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n  COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }

                        break;
                    case 3:
                        Console.WriteLine("\n THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("well deposited..");
                        Console.WriteLine("TOTAL BALANCE IS : {0}", amount);
                        break;
                    default:
                        Console.WriteLine("\n thx…");
                        break;
                }

                Console.WriteLine("\n\n thx for using our service ");
            }
        }
    }

}