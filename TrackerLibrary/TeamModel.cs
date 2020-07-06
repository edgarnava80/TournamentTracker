using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the list of persons in a team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents the name of the team.
        /// </summary>
        public string TeamName { get; set; }

       
    }
}
