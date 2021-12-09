using System;
using System.Data.SqlClient;
using System.Threading.Tasks;



namespace Books.Common
{
    public class DatabaseSettings : IDatabaseSettings
    {

    //    private readonly static ConcurrentDictionary<long, string> TenantConnectionString =
     //       new ConcurrentDictionary<long, string>();

        public DatabaseSettings(DatabaseSettingsConfig config)
        {
            ConnectionString = config.ConnectionString;
            MongoDBConnectionString = config.MongoDBConnectionString;
            MongoDBDatabaseName = config.MongoDBDatabaseName;
        }

       public string ConnectionString { get;  }

        public string MongoDBDatabaseName { get; }
        public string MongoDBConnectionString { get; }


        private string _tenant;
        public string ClientDB { get { return _tenant; } }

    }
}
