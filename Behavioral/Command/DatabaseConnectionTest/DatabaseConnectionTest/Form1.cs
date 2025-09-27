using MySql.Data.MySqlClient;

namespace DatabaseConnectionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=command_pattern;uid=root;pwd=1234;port=3307";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                string sql = "select * from account";
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader reader = cmd.ExecuteReader();

                string txt = "";
                while (reader.Read()) { 
                    txt += reader["name"] + "\n";
                }

                MessageBox.Show(txt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
