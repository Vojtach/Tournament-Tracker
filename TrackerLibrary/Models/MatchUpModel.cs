using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchUpModel
    {
        // Unique ID pro matchup.
        public int Id { get; set; }

        // List týmů a jejich vlastností.
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();

        // ID pro vítěze.
        public int WinnerId { get; set; }

        // Vítěz. 
        public TeamModel Winner { get; set; }

        // Údaj o stavu kola ve kterém jsme.
        public int MatchupRound { get; set; }

        // Jméno pro stávající matchup.
        public string DisplayName
        {
            get
            {
                string output = "";

                foreach (MatchUpEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        }
                    }
                    else
                    {
                        output = "Match zatím není definován";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
