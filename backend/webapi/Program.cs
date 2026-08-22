using System.Text.Json.Serialization;
using Blueprint41.Core;
using DeckBuilder.Model;
using DotNetEnv;
using webapi.Nodes.Cards.Repository;
using webapi.Nodes.CardSets.Repository;
using webapi.Nodes.CardSets.Service;
using Driver = Blueprint41.Neo4j.Persistence.Driver.v5;

public class Program
{
    public static Task Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        if (builder.Environment.EnvironmentName == "Development")
            Env.TraversePath().Load();

        builder
            .Configuration
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        IConfiguration configuration = builder.Configuration;

        // builder.Services
        //     .AddHttpContextAccessor()
        //     .AddScoped<UserService, UserService>();

        builder.Services
				.AddHttpContextAccessor()
				.AddScoped<CardRepository, CardRepository>()
				.AddScoped<CardSetService, CardSetService>()
				.AddScoped<CardSetRepository, CardSetRepository>();

        builder.Services
            .AddCors()
            .AddRouting()
            .AddControllers()
            .AddJsonOptions(options =>
            { 
            options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            });;


        WebApplication app = builder.Build();

        Driver.Neo4jPersistenceProvider provider =
            new(
                configuration["Database:Url"],
                configuration["Database:Auth"],
                configuration["Database:Password"],
                configuration["Database:Name"]!);

        PersistenceProvider.CurrentPersistenceProvider = provider;

        Datastore model = new();
        model.Execute(true);

        if (builder.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

        app
            .UseWebSockets()
            .UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.Run();

        return Task.CompletedTask;
    }
}