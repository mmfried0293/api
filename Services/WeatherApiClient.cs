namespace API.Services;

public class WeatherApiClient
{

    private readonly string apiKey;

    public WeatherApiClient(string apiKey)
    {
        this.apiKey = apiKey;
    }



    public string GetWeather (string zipcode)
    {
        var httpClient = new HttpClient();

        var url = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q={zipcode}&aqi=no";

        var response = httpClient.GetAsync(url).Result;

        return response.Content.ReadAsStringAsync().Result;
    }

    

    

}