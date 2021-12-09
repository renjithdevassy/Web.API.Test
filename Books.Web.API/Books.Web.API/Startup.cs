﻿using Books.Common;
using CricSmith.Core.Extensions;
using CricSmith.Core.Mapping;
using Microsoft.AspNetCore.Builder;

namespace Books.Web.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static WebApplication InitializeApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }

        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddMapping();
            var databaseSettingsConfig = new DatabaseSettingsConfig
            {
                //ConnectionString = Configuration["RDBMSConnectionString"],
                MongoDBDatabaseName = Environment.GetEnvironmentVariable("DB_NAME"),
                MongoDBConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION")
            };
            builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

            builder.Services.AddSingleton(databaseSettingsConfig);

            builder.Services.RegisterClasses();
            builder.Services.AddCors(o => o.AddPolicy("Policy", builder => { builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); }));
        }
        private static void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }

    }
}
