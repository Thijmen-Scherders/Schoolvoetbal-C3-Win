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
            //connection.Open();
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
                string qry = $"INSERT INTO users(NAME,email,PASSWORD) VALUES('{accountName}','{accountemail}', '{accountPassword}');";
                MySqlCommand command = new MySqlCommand(qry, connection);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();

                }
                int rowsAdded = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAdded <= 0)
                {
                    throw new Exception("Geen rij toegevoegd");
                }
                string accountadmin = "0";
                string accountMoney = "50";
                AccountsList.Add(new Accounts(accountName, accountPassword, accountadmin, accountMoney, accountemail));
                MessageBox.Show("Account voor" + accountName + " gemaakt");
                MainForm frmMain = new MainForm(accountName, accountadmin, accountMoney);
                frmMain.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("iets is er heel fout gegaan: " + ex.Message);
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
