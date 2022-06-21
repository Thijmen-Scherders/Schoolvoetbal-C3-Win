using AccDing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ultimehoofdpijn_2_electric_boogaloo_FEAT_melancholie
{
    public partial class Registerform : Form
    {
        MySqlConnection connection;
        const string connStr = "Server=localhost;Database=s4;Uid=root;Pwd=;";
        public Registerform()
        {
            InitializeComponent();
            connection = new MySqlConnection(connStr);
            connection.Open();
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            Accounts account = new Accounts();
            List<Accounts> AccountsList = new List<Accounts>();
            string accountName = Txbname.Text;
            string accountemail = Txbemail.Text;
            string accountPassword = Txbpass.Text;

            

            try
            {
                bool useHashing = true;

                MySqlParameter paramName;
                MySqlParameter paramEmail;
                MySqlParameter paramPassword;

                paramName = new MySqlParameter("user", accountName);
                paramEmail = new MySqlParameter("email", accountemail);

                if (useHashing)
                {
                    string passwordHash = PasswordHelper.GetSha256Hash(accountPassword, PasswordHelper.Salt);
                    paramPassword = new MySqlParameter("password", passwordHash);
                    
                    string getPasswordQury = "SELECT password from users where name = @user";
                    MySqlCommand getPasswordCommand = new MySqlCommand(getPasswordQury, connection);
                    getPasswordCommand.Parameters.Add(paramName);
                    
                    string opgehaaldWachtwoord = getPasswordCommand.ExecuteScalar() as string;
                    bool passwordCorrect = PasswordHelper.CheckHash(accountPassword, opgehaaldWachtwoord, PasswordHelper.Salt);
                }
                else
                {
                    paramPassword = new MySqlParameter("password", accountPassword);
                }

                string insertUserQry = $"INSERT INTO users(NAME,email,PASSWORD) VALUES(@user, @email, @password);";
                string updateUserQry = $"UPDATE users set NAME = @user, email = @email, password = @password where name = @name";


                MySqlCommand command = new MySqlCommand(insertUserQry, connection);
                command.Parameters.Add(paramName);
                command.Parameters.Add(paramEmail);
                command.Parameters.Add(paramPassword);

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();

                }

                int rowsAdded = command.ExecuteNonQuery();

                if (rowsAdded <= 0)
                {
                    throw new Exception("Geen rij toegevoegd");
                }

                string accountadmin = "0";
                string accountMoney = "50";
                AccountsList.Add(new Accounts(accountName, accountPassword, accountadmin, accountMoney, accountemail));
                MessageBox.Show("Account voor " + accountName + " gemaakt");
                MainForm frmMain = new MainForm(accountName, accountadmin, accountMoney);
                frmMain.Show();
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("iets is er heel fout gegaan: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
