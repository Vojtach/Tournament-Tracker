namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        // ID pro cenu.
        public int Id { get; set; }

        // Odměna v dolarech.
        public decimal PrizeAmount { get; set; }

        // Popis pozice.
        public string PlaceName { get; set; }

        // Popis pozice (Výhra / Prohra) pro týmu.
        public int PlaceNumber { get; set; }

        // Procento celkového výdělku z turnamentu které dostane výtěz.
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
