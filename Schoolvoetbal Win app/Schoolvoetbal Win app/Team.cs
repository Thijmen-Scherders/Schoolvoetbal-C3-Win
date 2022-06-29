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
    public partial class Team : Form
    {
        MySqlConnection connection;
        const string connStr = "Server=localhost;Database=s4;Uid=root;Pwd=;";

        public Team()
        {
            InitializeComponent();
            connection = new MySqlConnection(connStr);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
