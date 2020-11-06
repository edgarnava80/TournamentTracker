using System;
namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents where this price ranks on the list of prizes.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the prize place.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amont of money granted for this prize. It would be set to cero if the amount
        /// is set as a percentage.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the amont of money granted for this prize as a percentage of the total amount of money
        /// collected for the tournamnet.
        /// </summary>
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
