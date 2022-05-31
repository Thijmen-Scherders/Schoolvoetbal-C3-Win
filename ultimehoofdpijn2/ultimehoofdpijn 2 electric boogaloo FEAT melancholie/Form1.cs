using AccDing;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Accounts account = new Accounts();
            List<Accounts> AccountsList = new List<Accounts>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Accounts account = new Accounts();
            List<Accounts> AccountsList = new List<Accounts>();
            AccountsList.Add(new Accounts("admin", "admin", "1", "50", "admin@email.com"));
            AccountsList.Add(new Accounts("kees", "Geheim123", "0", "50", "kees@plop.nl"));
            bool loggedin = false;
            string loginName = txbUsername.Text;
            string loginPassword = txbPassword.Text;

            try
            {
                foreach (var user in AccountsList)
                {
                    string accountName = user.name.ToString();
                    string accountPassword = user.password.ToString();
                    string accountadmin = user.admin.ToString();
                    string accountMoney = user.money.ToString();
                    string accountemail = user.email.ToString();
                    if (accountName == loginName && loginPassword == accountPassword)
                    {
                        loggedin = true;
                        MainForm frmMain = new MainForm(accountName, accountadmin, accountMoney);
                        frmMain.Show();
                        this.Hide();
                        break;
                    }
                }
                if (loggedin == false)
                {
                    MessageBox.Show("Inlog fout");
                }
            }
            catch
            {
                MessageBox.Show("error");
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
    }
}
