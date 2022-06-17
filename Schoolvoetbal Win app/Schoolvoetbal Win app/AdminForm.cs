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
    public partial class AdminForm : Form
    {
        public bool Team1WinK = false;
        public bool Team2WinK = false;
        public bool GelijkspelK = false;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTeam1Admin_Click(object sender, EventArgs e)
        {
            Team1WinK = true;
            Team2WinK = false;
            GelijkspelK = false;
        }

        private void BtnTeam2Admin_Click(object sender, EventArgs e)
        {
            Team1WinK = false;
            Team2WinK = true;
            GelijkspelK = false;
        }

        private void BtnGelijkAdmin_Click(object sender, EventArgs e)
        {
            Team1WinK = false;
            Team2WinK = false;
            GelijkspelK = true;
        }
    }
}
