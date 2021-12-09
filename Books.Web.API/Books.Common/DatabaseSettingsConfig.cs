using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Common
{
    public class DatabaseSettingsConfig
    {
        public string? ConnectionString { get; set; }
        public string? MongoDBDatabaseName { get; set; }
        public string? MongoDBConnectionString { get; set; }
    }
}
