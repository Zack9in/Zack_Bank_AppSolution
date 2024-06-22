using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zack_Bank_App
{
    internal class Transaction
    {
        public Guid Id { get; set; }

        public Account  Deposit(float DepositAmount)
        {
            // accountBalance += DepositAmount;
            
            Account newAccount = new Account();

            Console.WriteLine($"Your account balance is {newAccount.AccountBalance}");
            newAccount.AccountBalance += DepositAmount;
            return newAccount;
        }

        public void Withdraw(float WithdrawAmount)
        {
            // accountBalance -= WithdrawAmount;
            //Account newAccount = new Account();
            //newAccount.AccountBalance -= WithdrawAmount;
        }

        public void Transfer()
        {
            //accountBalance(sender) -= TransferAmount;
            //accountBalance(receiver) += TransferAmount;
        }
    }
}
