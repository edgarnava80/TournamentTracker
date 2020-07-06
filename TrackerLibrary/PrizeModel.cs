using System;
namespace TrackerLibrary
{
    public class PrizeModel
    {
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
    }
}
