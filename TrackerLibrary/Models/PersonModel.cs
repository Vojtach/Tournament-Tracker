namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        // ID pro člověka..
        public int Id { get; set; }

        // Jméno.
        public string FirstName { get; set; }

        // Příjmení.
        public string LastName { get; set; }

        // Email.
        public string EmailAddress { get; set; }

        // Telefon.
        public string CellphoneNumber { get; set; }

        // Celé jméno.
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
