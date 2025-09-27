using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BankAccount
    {
        string connetionString = "server=localhost;database=command_pattern;uid=root;pwd=1234;port=3307";
        public required string AccountNumber { get; init; }
        public required string Name { get; init; }
        BankAccount() { }

        [SetsRequiredMembers]
        public BankAccount(string accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
        }
        public void deposit(decimal amount)
        {
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            string sql = String.Format("Update account SET balance = balance + {0} WHERE number = {1};", amount, AccountNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            cnn.Close();
            Console.WriteLine("Deposit " + amount);
        }
        public void withdraw(decimal amount)
        {
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            string sql = String.Format("Update account SET balance = balance - {0} WHERE number = {1};", amount, AccountNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            cnn.Close();
            Console.WriteLine("Withdraw " + amount);
        }
        public void tranfer(string receiverNumbr, decimal amount)
        {
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            string sql = String.Format("Update account SET balance = balance + {0} WHERE number = {1};", amount, receiverNumbr);
            sql += String.Format("Update account SET balance = balance - {0} WHERE number = {1};", amount, AccountNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            cnn.Close();
            Console.WriteLine("Tranfer to " + receiverNumbr + " " + amount);
        }
        public decimal checkBalance()
        {
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            string sql = String.Format("SELECT balance FROM account WHERE number = {0}", AccountNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Check Balance");
            while (reader.Read())
            {
                return Convert.ToDecimal(reader["balance"]);
            }
            return 0;
        }
    }
}
