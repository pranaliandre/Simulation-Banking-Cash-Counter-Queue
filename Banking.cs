using System;
using System.Collections.Generic;
using System.Text;

namespace Simulation_Banking_Cash_counter_Queue
{
    class Banking
    {

        /// <summary>
        /// Method to account holder how much amount withdraw cash from queue
        /// </summary>
        /// <param name="cashToWithdraw">cash withdraw</param>
        /// <param name="currentBalance">current balance in account</param>
        /// <returns></returns>
        public int CashWithdraw(int cashToWithdraw, int currentBalance)
        {
            currentBalance = currentBalance - cashToWithdraw;
            return currentBalance;
        }

        /// <summary>
        /// Method to account holder how much amount deposit cash in queue
        /// </summary>
        /// <param name="cashToDeposite"> customer deposit cash</param>
        /// <param name="currentBalance">current balance in account</param>
        /// <returns></returns>
        public int CashDeposite(int cashToDeposite, int currentBalance)
        {
            currentBalance = currentBalance + cashToDeposite;
            return currentBalance;
        }
        /// <summary>
        /// Method to take user input account holder name
        /// </summary>
        /// <returns></returns>
        public string SetName()
        {
            string name = Console.ReadLine();
            return name;
        }
        /// <summary>
        /// Method to take user input account holder account no 
        /// </summary>
        /// <returns></returns>
        public int SetAccountNo()
        {
            int accountNo = Convert.ToInt32(Console.ReadLine());
            return accountNo;
        }
    }
}
