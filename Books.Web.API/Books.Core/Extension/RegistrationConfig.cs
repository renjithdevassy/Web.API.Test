using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using Books.Core.Domain.Books;
using Books.Data.Writer;
using Books.Core;
using Books.Core.Mapping;
using Books.Common;

namespace CricSmith.Core.Extensions
{
    public static class RegistrationConfig
    {
        public static void RegisterClasses(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddSingleton<IObjectMapper, ObjectMapper>();
            serviceCollection.AddSingleton<IDatabaseSettings, DatabaseSettings>();
            serviceCollection.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
          



            // for Core assembly
            serviceCollection.Scan(scan =>
                      scan.FromAssemblyOf<IBooksWriter>()
                     .AddClasses()
                     .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                     .AsMatchingInterface()
                     .WithScopedLifetime());

                     //for Data assembly
                     serviceCollection.Scan(scan =>
                      scan.FromAssemblyOf<IBooksDataWriter>()
                     .AddClasses()
                     .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                     .AsMatchingInterface()
                     .WithScopedLifetime());


        }
    }
}
