namespace TrackerLibrary.Models
{
    public class MatchUpEntryModel
    {
        // Unique ID pro matchup.
        public int Id { get; set; }

        // Unique ID pro soupeřící team.
        public int TeamCompetingId { get; set; }

        // Unique ID pro jeden z týmů.
        public TeamModel TeamCompeting { get; set; }

        // Unique ID pro scóre týmu.
        public double Score { get; set; }

        // Unique ID pro nadřazený matchup.
        public int parentMatchupId { get; set; }

        // Předchozí matchup.
        public MatchUpModel ParentMatchup { get; set; }
    }
}
