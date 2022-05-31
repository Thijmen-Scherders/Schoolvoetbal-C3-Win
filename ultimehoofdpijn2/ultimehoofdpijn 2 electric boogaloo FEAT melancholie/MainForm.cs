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
    public partial class MainForm : Form
    {
        public bool team1;
        public bool team2;
        public bool gelijk;
        //^^^^^^^^^teamkeuze^^^^^^^^^
        public bool Team1Win = false;
        public bool Team2Win = false;
        public bool Gelijkspel = false;
        //^^^^^^^^^teamwin^^^^^^^^^^^
        private int Admin;
        int C3coin = 0;
        public int investment;
        public int inv1;
        public int inv2;
        public int invG;
        public int typebet;
        public MainForm(string accountName, string accountadmin, string accountMoney)
        {
            Admin = int.Parse(accountadmin);
            C3coin = int.Parse(accountMoney);
            InitializeComponent();
            lblC3coins.Text = C3coin.ToString();
            lblGebruiker.Text = accountName;
            if (Admin == 1)
            {
                BtnAdmin.Visible = true;
            }            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Form1 frmLog = new Form1();
            frmLog.Show();
            this.Hide();
        }

        private void BtnBetting_Click(object sender, EventArgs e)
        {
            if (investment > 0)
            {
                C3coin = C3coin + investment;
            }
            BettingForm betfrm = new BettingForm();
            DialogResult r = betfrm.ShowDialog();
            if(r == DialogResult.OK)
            {
                team1 = betfrm.teamK1;
                team2 = betfrm.teamK2;
                gelijk = betfrm.gelijkK;
                inv1 = betfrm.investK1;
                inv2 = betfrm.investK2;
                invG = betfrm.investKG;
                typebet = betfrm.typebetK;
                if ( inv1 > 0 )
                {
                    investment = inv1;
                    C3coin -= investment;
                }
                else if(inv2 > 0)
                {
                    investment = inv2;
                    C3coin -= investment;
                }
                else if(invG > 0)
                {
                    investment = invG;
                    C3coin -= investment;
                }
                lblC3coins.Text = C3coin.ToString();
                lblHoeveelheid.Text = investment.ToString(); ;
                if (team1)
                {
                    lblTeam.Text = " team 1!";
                }
                else if (team2)
                {
                    lblTeam.Text = " team 2!";
                }
                else if (gelijk)
                {
                    lblTeam.Text = " gelijkspel!";
                }
                else
                {
                    lblTeam.Text = " ";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm AdmForm = new AdminForm();
            DialogResult r = AdmForm.ShowDialog();
            if (r == DialogResult.OK)
            { 
                Team1Win = AdmForm.Team1WinK;
                Team2Win = AdmForm.Team2WinK;
                Gelijkspel = AdmForm.GelijkspelK;   
                
            }
        }

        private void BtnWinchecker_Click(object sender, EventArgs e)
        {
            if (team1 && Team1Win)
            {
                int winnings = investment * (typebet + 1);
                C3coin += winnings;
                team1 = false;
                team2 = false;
                gelijk = false;
                lblC3coins.Text = C3coin.ToString();
                lblHoeveelheid.Text = "niks";
                lblTeam.Text = "niemand";
                MessageBox.Show("Team 1 hebt gewonnen! Jij hebt" + " " + winnings+ " " + "C3 coins gewonnen!" );
            }
            else if (team2 && Team2Win)
            {
                int winnings = investment * (typebet + 1);
                C3coin += winnings;
                team1 = false;
                team2 = false;
                gelijk = false;
                lblC3coins.Text = C3coin.ToString();
                lblHoeveelheid.Text = "niks";
                lblTeam.Text = "niemand";
                MessageBox.Show("Team 2 hebt gewonnen! Jij hebt" + " " + winnings + " " + "C3 coins gewonnen!");
            }
            else if (gelijk && Gelijkspel)
            {
                int winnings = investment * (typebet + 1);
                C3coin += winnings;
                team1 = false;
                team2 = false;
                gelijk = false;
                lblC3coins.Text = C3coin.ToString();
                lblHoeveelheid.Text = "niks";
                lblTeam.Text = "niemand";
                MessageBox.Show("Het is Gelijkspel! Jij hebt" + " " + winnings + " " + "C3 coins gewonnen!");
            }
            else
            {
                team1 = false;
                team2 = false;
                gelijk = false;
                lblC3coins.Text = C3coin.ToString();
                lblHoeveelheid.Text = "niks";
                MessageBox.Show("je hebt verloren");
            }
        }
    }
}
