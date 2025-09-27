using Library;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Security.Principal;

namespace ATM
{
    public partial class Form1 : Form
    {
        ATM atm = new ATM();
        BankAccount account;

        string connetionString = "server=localhost;database=command_pattern;uid=root;pwd=1234;port=3307";
        public Form1()
        {
            InitializeComponent();
            panelLogin.BringToFront();
        }
                private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ATM";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string accNumber = textBoxLoginAccNum.Text;
            string password = textBoxLoginPassword.Text;

            string sql = String.Format("SELECT name FROM account WHERE number = {0} AND password = {1}", accNumber, password);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string accName = reader["name"].ToString();
                account = new BankAccount(accNumber, accName);
                panelMenu.BringToFront();
            }

            //MessageBox.Show("Welcome Khun " + account.Name);
            cnn.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            textBoxDepositAmount.Text = string.Empty;
            panelDeposit1.BringToFront();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            textBoxWithDrawAmount.Text = string.Empty;
            panelWithDraw1.BringToFront();
        }


        private void btnTranfer_Click(object sender, EventArgs e)
        {
            textBoxTranferRecvNum.Text = string.Empty;
            textBoxTranferAmount.Text = string.Empty;
            panelTranfer1.BringToFront();
        }

        private void btnChackBalance_Click(object sender, EventArgs e)
        {
            atm.Command = new CheckBalance(account);
            atm.executeCommand();   // executeCommand return void

            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string sql = String.Format("SELECT number, name, balance FROM account WHERE number = {0}", account.AccountNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                richTextBoxChekBalance.Text = "Account Number: " + reader["number"];
                richTextBoxChekBalance.Text += "\nName: " + reader["name"];
                richTextBoxChekBalance.Text += "\nBalance: " + reader["balance"] + " ฿";
            }

            cnn.Close();
            panelCheckBalance.BringToFront();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void btnDeposit1Next_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(textBoxDepositAmount.Text);

            richTextBoxDepositInformation.Text = "Account Number: " + account.AccountNumber;
            richTextBoxDepositInformation.Text += "\nName: " + account.Name;
            richTextBoxDepositInformation.Text += "\nDeposit Amount: " + amount + " ฿";

            panelDeposit2.BringToFront();
        }

        private void btnDeposit1Cancel_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }

        private void btnDeposit2Confirm_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(textBoxDepositAmount.Text);
            atm.Command = new Deposit(account, amount);
            atm.executeCommand();

            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string sql = String.Format("SELECT number, name, balance FROM account WHERE number = {0}", account.AccountNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                richTextBoxDepositStatement.Text = "Account Number: " + reader["number"];
                richTextBoxDepositStatement.Text += "\nName: " + reader["name"];
                richTextBoxDepositStatement.Text += "\nDeposit Amount: " + amount + " ฿";
                richTextBoxDepositStatement.Text += "\nBalance: " + reader["balance"] + " ฿";
            }

            cnn.Close();
            panelDeposit3.BringToFront();
        }

        private void btnDeposit2Back_Click(object sender, EventArgs e)
        {
            panelDeposit1.BringToFront();
        }

        private void btnDeposit3Exit_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void btnDeposit3Continue_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }

        private void btnWithDraw1Next_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(textBoxWithDrawAmount.Text);

            richTextBoxWithDrawInformation.Text = "Account Number: " + account.AccountNumber;
            richTextBoxWithDrawInformation.Text += "\nName: " + account.Name;
            richTextBoxWithDrawInformation.Text += "\nWithDraw Amount: " + amount + " ฿";

            panelWithDraw2.BringToFront();
        }

        private void btnWithDraw1Cancel_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }

        private void btnWithDraw2Confirm_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(textBoxWithDrawAmount.Text);
            atm.Command = new Withdraw(account, amount);
            atm.executeCommand();

            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string sql = String.Format("SELECT number, name, balance FROM account WHERE number = {0}", account.AccountNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                richTextBoxWithDrawStatement.Text = "Account Number: " + reader["number"];
                richTextBoxWithDrawStatement.Text += "\nName: " + reader["name"];
                richTextBoxWithDrawStatement.Text += "\nDeposit Amount: " + amount + " ฿";
                richTextBoxWithDrawStatement.Text += "\nBalance: " + reader["balance"] + " ฿";
            }

            cnn.Close();
            panelWithDraw3.BringToFront();
        }

        private void btnWithDraw2Back_Click(object sender, EventArgs e)
        {
            panelDeposit1.BringToFront();
        }

        private void btnWithDraw3Exit_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }


        private void btnWithDraw3Continue_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }

        private void btnTranfer1Next_Click(object sender, EventArgs e)
        {
            string recvNum = textBoxTranferRecvNum.Text;
            decimal amount = Convert.ToDecimal(textBoxTranferAmount.Text);

            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string sql = String.Format("SELECT name FROM account WHERE number = {0}", recvNum);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string recvName = reader["name"].ToString();
                richTextBoxTranferInformation.Text = "Account Number: " + account.AccountNumber;
                richTextBoxTranferInformation.Text += "\nName: " + account.Name;
                richTextBoxTranferInformation.Text += "\nTranfer to: " + recvNum + " ( " + recvName + " )";
                richTextBoxTranferInformation.Text += "\nTranfer Amount: " + amount + " ฿";

                panelTranfer2.BringToFront();
            }
        }

        private void btnTranfer1Cancel_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }

        private void btnTranfer2Confirm_Click(object sender, EventArgs e)
        {
            string recvNum = textBoxTranferRecvNum.Text;
            decimal amount = Convert.ToDecimal(textBoxTranferAmount.Text);
            atm.Command = new Tranfer(account, recvNum, amount);
            atm.executeCommand();

            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string sql = String.Format("SELECT number, name, balance FROM account WHERE number = {0}", account.AccountNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                richTextBoxTranferStatement.Text = "Account Number: " + reader["number"];
                richTextBoxTranferStatement.Text += "\nName: " + reader["name"];
                richTextBoxTranferInformation.Text += "\nTranfer to: " + recvNum;
                richTextBoxTranferStatement.Text += "\nTarnfer Amount: " + amount + " ฿";
                richTextBoxTranferStatement.Text += "\nBalance: " + reader["balance"] + " ฿";
            }

            cnn.Close();
            panelTranfer3.BringToFront();
        }

        private void btnTranfer2Back_Click(object sender, EventArgs e)
        {
            panelTranfer1.BringToFront();
        }

        private void btnTranfer3Exit_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void btnTranfer3Continue_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }

        private void btnCheckBalanceExit_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void btnCheckBalanceContinue_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }
    }
}
