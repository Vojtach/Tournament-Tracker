using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;

        // ID pro turnament.
        public int Id { get; set; }

        // Jméno turnamentu.
        public string TournamentName { get; set; }

        // Cena účasti týmu.
        public decimal EntryFee { get; set; }

        // Týmy v turnamentu.
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        // Ceny v turnamentu.
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        // List všech matchupů.
        public List<List<MatchUpModel>> Rounds { get; set; } = new List<List<MatchUpModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
