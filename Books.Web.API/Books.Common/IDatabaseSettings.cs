using System.Threading.Tasks;

namespace Books.Common
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; }

        public string MongoDBDatabaseName { get; }
        public string MongoDBConnectionString { get; }

    }
}
