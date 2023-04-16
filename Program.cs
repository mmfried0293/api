using API.Services;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Configuration.AddJsonFile("appsettings.json");

app.MapGet("/", () => "Hello World!!!");

app.MapGet("/{zipcode}", (string zipcode) => 
{
    var apiKey = app.Configuration["Weather:ApiKey"];
    var client = new WeatherApiClient(apiKey);
    return client.GetWeather(zipcode);
} );

app.Run();
