using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface Command
    {
        public string ClassName { get; }
        void execute();
    }
    public class Deposit : Command
    {
        public string ClassName { get => this.GetType().Name; }
        BankAccount account;
        decimal amount;
        public Deposit(BankAccount account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
        }
        public void execute()
        {
            account.deposit(amount);
        }
    }
    public class Withdraw : Command
    {
        public string ClassName { get => this.GetType().Name; }
        BankAccount account;
        decimal amount;
        public Withdraw(BankAccount account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
        }
        public void execute()
        {
            account.withdraw(amount);
        }
    }
    public class Tranfer : Command
    {
        public string ClassName { get => this.GetType().Name; }
        BankAccount account;
        string receiverNumber;
        decimal amount;
        public Tranfer(BankAccount account, string receiverNumber, decimal amount)
        {
            this.account = account;
            this.receiverNumber = receiverNumber;
            this.amount = amount;
        }
        public void execute()
        {
            account.tranfer(receiverNumber, amount);
        }
    }
    public class CheckBalance : Command
    {
        public string ClassName { get => this.GetType().Name; }
        BankAccount account;
        public CheckBalance(BankAccount account)
        {
            this.account = account;
        }
        public void execute()
        {
            account.checkBalance();
        }
    }
}
