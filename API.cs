using System.Text.Json;

namespace Wetter
{
	using Responses;
	internal class API
	{
		readonly string Key = "";

		HttpClient http = new();

		public CurrentWeatherResponse? CurrentWeather(string ort)
		{
			try
			{
				var request = http.GetAsync($"https://api.openweathermap.org/data/2.5/weather?appid={Key}&q={ort}&units=metric&lang=de");
				request.Wait();
				var response = request.Result;

				var current = JsonSerializer.Deserialize<CurrentWeatherResponse>(response.Content.ReadAsStream());

				return current;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);

				return null;
			}
		}
	}

	namespace Responses
	{
		using Responses.CurrentWeather;

		public class CurrentWeatherResponse
		{
			public Coord? coord { get; set; }
			public Weather[]? weather { get; set; }
			public string? _base { get; set; }
			public Main? main { get; set; }
			public int visibility { get; set; }
			public Wind? wind { get; set; }
			public Clouds? clouds { get; set; }
			public int dt { get; set; }
			public Sys? sys { get; set; }
			public int timezone { get; set; }
			public int id { get; set; }
			public string? name { get; set; }
			public int cod { get; set; }
		}

		namespace CurrentWeather
		{
			public class Coord
			{
				public float lon { get; set; }
				public float lat { get; set; }
			}

			public class Main
			{
				public float temp { get; set; }
				public float feels_like { get; set; }
				public float temp_min { get; set; }
				public float temp_max { get; set; }
				public int pressure { get; set; }
				public int humidity { get; set; }
			}

			public class Wind
			{
				public float speed { get; set; }
				public int deg { get; set; }
			}

			public class Clouds
			{
				public int all { get; set; }
			}

			public class Sys
			{
				public int type { get; set; }
				public int id { get; set; }
				public string? country { get; set; }
				public int sunrise { get; set; }
				public int sunset { get; set; }
			}

			public class Weather
			{
				public int id { get; set; }
				public string? main { get; set; }
				public string? description { get; set; }
				public string? icon { get; set; }
			}
		}
	}
}
