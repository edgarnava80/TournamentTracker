using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFile)
        {
            if(database)
            {
                // TODO - Set up the SQL connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textFile)
            {
                // TODO - Set up the text file connector properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
