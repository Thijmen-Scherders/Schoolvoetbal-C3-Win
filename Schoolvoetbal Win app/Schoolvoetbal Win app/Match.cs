using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimehoofdpijn_2_electric_boogaloo_FEAT_melancholie
{
    public class Match
    {
        public int id { get; set; }
        public int team1_id { get; set; }
        public string team1_name { get; set; }
        public int team2_id { get; set; }

        public string team2_name { get; set; }

        public bool finished { get; set; }
        public int team1_score { get; set; }
        public int team2_score { get; set; }
    }
}
