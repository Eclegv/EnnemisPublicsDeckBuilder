using Blueprint41.Core;
using DeckBuilder.Model;
using DotNetEnv;
using Driver = Blueprint41.Neo4j.Persistence.Driver.v5;

public class Program
{
    public static Task Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        Console.WriteLine(builder.Environment.EnvironmentName);

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
            .AddCors()
            .AddRouting();


        WebApplication app = builder.Build();

        Console.WriteLine(configuration["Database:Url"]);
        Console.WriteLine(configuration["Database:Auth"]);
        Console.WriteLine(configuration["Database:Password"]);
        Console.WriteLine(configuration["Database:Name"]);

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

        app.Run();

        return Task.CompletedTask;
    }
}