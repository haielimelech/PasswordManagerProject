using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackLibrary.DataAccess;

namespace TrackLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnector Connection { get; private set; }

        //TODO - wire up the sql connection
        public static void InitializeConnections(DatabaseType db)
        {
           
            if (db==DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string CnnString (string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
