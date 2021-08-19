using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        // ID pro tým.
        public int Id { get; set; }

        // List členů v týmu.
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        // Jméno týmu.
        public string TeamName { get; set; }
    }
}

