using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of matches for each round.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner of a match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the matchup round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
