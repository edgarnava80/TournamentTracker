using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    [System.Runtime.InteropServices.Guid("76FF4B19-9385-43A4-A8F4-27722E7E6435")]
    public class SQLConnector : IDataConnection
    {
        /// TODO - Make the CreatePrize method actually save to the database.
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize with its unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"));
            ///TODO - Add error handling functionality
            var p = new DynamicParameters();
            p.Add("@PlaceNumber", model.PlaceNumber);
            p.Add("@PlaceName", model.PlaceName);
            p.Add("@PrizeAmount", model.PrizeAmount);
            p.Add("@PrizePercentage", model.PrizePercentage);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");

            return model;
        }
    }
}
