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
    public partial class BettingForm : Form
    {
        public bool team1;
        public bool team2;
        public bool gelijk;
        public int invest;
        public int investedT1;
        public int investedT2;
        public int investedgelijk;
        public int typebet;
        public BettingForm()
        {
            InitializeComponent();

        }


        public int typebetK
        {
            get { return typebet; }
        }
        public int investK1
        {
            get { return investedT1; }
        }        
        public int investK2
        {
            get { return investedT2; }
        }        
        public int investKG
        {
            get { return investedgelijk; }
        }
        public bool teamK1
        {
            get { return team1; }
        }
        public bool teamK2
        {
            get { return team2; }
        }
        public bool gelijkK
        {
            get { return gelijk; }
        }



        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnTeam1_Click_1(object sender, EventArgs e)
        {
            team1 = true;
            team2 = false;
            gelijk = false;
            lblselectedTeam.Text = "Team 1";
        }

        private void BtnTeam2_Click_1(object sender, EventArgs e)
        {
            team1 = false;
            team2 = true;
            gelijk = false;
            lblselectedTeam.Text = "Team 2";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            team1 = false;
            team2 = false;
            gelijk = true;
            lblselectedTeam.Text = "gelijkspel";
        }

        private void BtnLoose_Click_1(object sender, EventArgs e)
        {
            if (team1)
            {
                investedT1 = int.Parse(TxbLoose.Text);
                MessageBox.Show("uw heeft" + " " + investedT1 + " " + "op team 1 gezet!");
                
            }
            else if (team2)
            {
                investedT2 = int.Parse(TxbLoose.Text);
                MessageBox.Show("uw heeft" + " " + investedT2 + " " + "op team 2 gezet!");

            }
            else if (gelijk)
            {
                investedgelijk = int.Parse(TxbLoose.Text);
                MessageBox.Show("uw heeft" + " " + investedgelijk + " " + "op gelijkspel gezet!");

            }
            else
            {
                MessageBox.Show("Kies een team!");
            }
        }

        private void btnType1_Click(object sender, EventArgs e)
        {
            typebet = 1;
        }

        private void btnType2_Click(object sender, EventArgs e)
        {
            typebet = 2;
        }

        private void btnType3_Click(object sender, EventArgs e)
        {
            typebet = 3;
        }
    }
}
