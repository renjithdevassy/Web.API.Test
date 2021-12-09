using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Books.Data.Entities.Books;
using Books.API.Models.Books;

namespace CricSmith.Core.Mapping
{
    public static class MappingConfig
    {
        public static void AddMapping(this IServiceCollection serviceCollection)
        {
            var cfg = new MapperConfiguration(x =>
            {
            
             
                x.CreateMap<BooksEntity, BooksModel>() //<source, destination>
                                                        // .ForMember(dest => dest.CreatedAt, opt => opt.Ignore()) // says to ignore a member at destination
                    .ReverseMap(); // creates mappting between destination to source

                
            });
            var mapper = cfg.CreateMapper();

            serviceCollection.AddSingleton(mapper);
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
