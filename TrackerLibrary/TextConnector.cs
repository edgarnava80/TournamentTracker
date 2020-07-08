using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// TODO - Make the CreatePrize method actually save to the text file.
    /// <summary>
    /// Saves a new prize to a text file.
    /// </summary>
    /// <param name="model">The prize information.</param>
    /// <returns>The prize with its unique identifier</returns>
    public class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
