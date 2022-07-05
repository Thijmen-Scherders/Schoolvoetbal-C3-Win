using AccDing;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ultimehoofdpijn_2_electric_boogaloo_FEAT_melancholie
{
    public partial class Loginform : Form
    {
        MySqlConnection connection;
        const string connStr = "Server=localhost;Database=c3_schoolvoetbal;Uid=root;Pwd=;";
        public Loginform()
        {
            InitializeComponent();
            connection = new MySqlConnection(connStr);
            connection.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlParameter paramName;
            MySqlParameter paramPassword;

            string accountName = txbUsername.Text;
            string accountPassword = txbPassword.Text;

            try
            {
                paramName = new MySqlParameter("name", accountName);

                string passwordHash = PasswordHelper.GetSha256Hash(accountPassword, PasswordHelper.Salt);
                paramPassword = new MySqlParameter("password", passwordHash);

                string getUser = $"SELECT * FROM users WHERE password = @password AND name = @name;";

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();

                }

                MySqlCommand command = new MySqlCommand(getUser, connection);
                command.Parameters.Add(paramPassword);
                command.Parameters.Add(paramName);

                MySqlDataReader reader = command.ExecuteReader();

                bool accountadmin = false;
                string accountMoney = null;

                bool loginSuccesful = false;

                if (reader.Read())
                {
                    accountadmin = reader.GetBoolean("admin");
                    accountMoney = "50";
                    loginSuccesful = true;
                }
                reader.Close();



                if (!loginSuccesful)
                {
                    throw new Exception("Incorrecte username of password");
                }
                else
                {
                    MainForm frmMain = new MainForm(accountName, accountadmin, accountMoney);
                    frmMain.Show();
                    this.Hide();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("iets is er heel fout gegaan: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        internal void Show(int admin)
        {
            throw new NotImplementedException();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registerform form = new Registerform();
            form.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void test_Click(object sender, EventArgs e)
        {
            testing test = new testing();
            test.Show();
            this.Hide();
        }
    }
}

