using Library;
using MySql.Data.MySqlClient;

namespace MobileBanking
{
    public partial class Form1 : Form
    {
        BankAccount account;
        MobileBanking mBanking = new MobileBanking();
        string connetionString = "server=localhost;database=command_pattern;uid=root;pwd=1234;port=3307";
        const char BAHT_SIGN = '฿';
        public Form1()
        {
            InitializeComponent();

            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string sql = String.Format("SELECT number, name FROM account WHERE number = {0} AND password = {1}", 0002, 1234);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                account = new BankAccount(reader["number"].ToString(), reader["name"].ToString());
            }
            cnn.Close();

            labelAccName.Text = account.Name;
            labelAccNumber.Text = account.AccountNumber;
            labelBalance.Text = account.checkBalance().ToString();

            panelMain.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Mobile Banking";
        }
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            labelBalance.Text = account.checkBalance().ToString();
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            labelTranfer1AccName.Text = account.Name;
            labelTranfer1AccNumber.Text = account.AccountNumber;
            labelTranfer1Balance.Text = account.checkBalance().ToString() + BAHT_SIGN;

            panelTranfer1.BringToFront();
        }

        private void btnWithdrawWithoutCard_Click(object sender, EventArgs e)
        {
            labelWithdrawWithoutCard1AccName.Text = account.Name;
            labelWithdrawWithoutCard1AccNumber.Text = account.AccountNumber;
            labelWithdrawWithoutCard1AccBalance.Text = account.checkBalance().ToString() + BAHT_SIGN;

            decimal balance = account.checkBalance();
            btnWithdrawWithoutCard1Amount1.Enabled = false;
            btnWithdrawWithoutCard1Amount2.Enabled = false;
            btnWithdrawWithoutCard1Amount3.Enabled = false;
            btnWithdrawWithoutCard1Amount4.Enabled = false;
            btnWithdrawWithoutCard1Amount5.Enabled = false;
            btnWithdrawWithoutCard1Amount6.Enabled = false;

            if (balance >= Convert.ToDecimal(btnWithdrawWithoutCard1Amount1.Text))
            {
                btnWithdrawWithoutCard1Amount1.Enabled = true;
            }
            if (balance >= Convert.ToDecimal(btnWithdrawWithoutCard1Amount2.Text))
            {
                btnWithdrawWithoutCard1Amount2.Enabled = true;
            }
            if (balance >= Convert.ToDecimal(btnWithdrawWithoutCard1Amount3.Text))
            {
                btnWithdrawWithoutCard1Amount3.Enabled = true;
            }
            if (balance >= Convert.ToDecimal(btnWithdrawWithoutCard1Amount4.Text))
            {
                btnWithdrawWithoutCard1Amount4.Enabled = true;
            }
            if (balance >= Convert.ToDecimal(btnWithdrawWithoutCard1Amount5.Text))
            {
                btnWithdrawWithoutCard1Amount5.Enabled = true;
            }
            if (balance >= Convert.ToDecimal(btnWithdrawWithoutCard1Amount6.Text))
            {
                btnWithdrawWithoutCard1Amount6.Enabled = true;
            }

            panelWithdrawWithoutCard1.BringToFront();
        }

        private void btnTranfer1Next_Click(object sender, EventArgs e)
        {
            labelTranfer2AccName.Text = account.Name;
            labelTranfer2AccNumber.Text = account.AccountNumber;
            labelTranfer2AccBalance.Text = account.checkBalance().ToString() + BAHT_SIGN;

            string recvNumber = textBoxTranfer1RecvNumber.Text;
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string sql = String.Format("SELECT number, name FROM account WHERE number = {0}", recvNumber);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                labelTranfer2RecvName.Text = reader["name"].ToString();
                labelTranfer2RecvNumber.Text = reader["number"].ToString();
            }
            cnn.Close();
            labelTranfer2Amount.Text = textBoxTranfer1Amount.Text + BAHT_SIGN;

            string recvNum = labelTranfer2RecvNumber.Text;
            decimal amount = Convert.ToDecimal(textBoxTranfer1Amount.Text);
            mBanking.Command = new Tranfer(account, recvNum, amount);

            panelTranfer2.BringToFront();
        }

        private void btnTranfer2Confirm_Click(object sender, EventArgs e)
        {
            mBanking.executeCommand();

            MessageBox.Show("Tranfer successed!");

            labelBalance.Text = account.checkBalance().ToString();
            panelMain.BringToFront();
        }

        private void btnTranfer1Cancel_Click(object sender, EventArgs e)
        {
            panelMain.BringToFront();
        }

        private void btnTranfer2Cancel_Click(object sender, EventArgs e)
        {
            panelTranfer1.BringToFront();
        }

        private void btnWithdrawWithoutCard1Amount1_Click(object sender, EventArgs e)
        {
            textBoxWithdrawWithoutCard1Amount.Text = "100";
        }

        private void btnWithdrawWithoutCard1Amount2_Click(object sender, EventArgs e)
        {
            textBoxWithdrawWithoutCard1Amount.Text = "200";
        }

        private void btnWithdrawWithoutCard1Amount3_Click(object sender, EventArgs e)
        {
            textBoxWithdrawWithoutCard1Amount.Text = "500";
        }

        private void btnWithdrawWithoutCard1Amount4_Click(object sender, EventArgs e)
        {
            textBoxWithdrawWithoutCard1Amount.Text = "1000";
        }

        private void btnWithdrawWithoutCard1Amount5_Click(object sender, EventArgs e)
        {
            textBoxWithdrawWithoutCard1Amount.Text = "3000";
        }

        private void btnWithdrawWithoutCard1Amount6_Click(object sender, EventArgs e)
        {
            textBoxWithdrawWithoutCard1Amount.Text = "5000";
        }

        private void btnWithdrawWithoutCard1Next_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(textBoxWithdrawWithoutCard1Amount.Text);

            mBanking.Command = new Withdraw(account, amount);
            mBanking.executeCommand();

            MessageBox.Show("Withdraw Code is 1 2 3 4 5 ");

            labelBalance.Text = account.checkBalance().ToString();
            panelMain.BringToFront();
        }

        private void btnWithdrawWithoutCard1Cancel_Click(object sender, EventArgs e)
        {
            panelMain.BringToFront();
        }

    }
}
