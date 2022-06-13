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
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
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
                string accountadmin = "0";
                string accountMoney = "50";
                AccountsList.Add(new Accounts(accountName, accountPassword, accountadmin, accountMoney, accountemail));
                MessageBox.Show("Account voor" + accountName + " gemaakt");
                MainForm frmMain = new MainForm(accountName, accountadmin, accountMoney);
                frmMain.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("iets is er heel fout gegaan");
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
