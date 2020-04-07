using System;

namespace Simulation_Banking_Cash_counter_Queue
{ 
        class BankingCashCounter
        {
            /// <summary>
            /// constant
            /// </summary>
            private static int accountantBalance = 5000;
            /// <summary>
            /// variable
            /// </summary>
            private static int numberOfPepoleAccountant;
            private static string name;
            private static int accountNo;
            private static int totalBalanceOfUser = 0;
            private static int count = 0;
            static void Main(string[] args)
            {
            Console.WriteLine("Welcome in Banking cash counter");
                Console.WriteLine("number of accountant");
                numberOfPepoleAccountant = Convert.ToInt32(Console.ReadLine());
                Queue myQueue = new Queue(numberOfPepoleAccountant);
                Banking bank = new Banking();
                do
                {
                    int balance = accountantBalance;
                    Console.WriteLine("1.deposit");
                    Console.WriteLine("2.Withdraw");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the accountant name");
                            name = bank.SetName();
                            Console.WriteLine("Enter the account number");
                            accountNo = bank.SetAccountNo();
                            Console.WriteLine("enter amount you want to deposit ");
                            int cashDeposit = Convert.ToInt32(Console.ReadLine());
                            totalBalanceOfUser = bank.CashDeposite(cashDeposit, balance);
                            myQueue.Enqueue(totalBalanceOfUser);
                            Console.WriteLine("available balance .." + totalBalanceOfUser);
                            myQueue.Dequeue();
                            cashDeposit = 0;
                            break;

                        case 2:
                            Console.WriteLine("Enter the accountant name");
                            name = bank.SetName();
                            Console.WriteLine("Enter the account number");
                            accountNo = bank.SetAccountNo();
                            Console.WriteLine("enter amount you want to withdraw");
                            int cashWithdraw = Convert.ToInt32(Console.ReadLine());
                            if (balance < cashWithdraw)
                            {
                                Console.WriteLine("not ifficient cash");
                            }
                            else
                            {
                                totalBalanceOfUser = bank.CashWithdraw(cashWithdraw, balance);
                                myQueue.Enqueue(totalBalanceOfUser);
                                Console.WriteLine("available balance .." + totalBalanceOfUser);
                                myQueue.Dequeue();
                                cashWithdraw = 0;
                            }
                            break;

                    }
                    count++;
                } while (count < numberOfPepoleAccountant);
                myQueue.Display();

            }

        }

   }

