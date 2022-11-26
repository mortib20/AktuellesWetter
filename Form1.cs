namespace Wetter
{
	public partial class WetterForm : Form
	{
		public WetterForm()
		{
			InitializeComponent();
		}

		private void UpdateWetterClick(object sender, EventArgs e)
		{
			string ort = TBOrt.Text;

			var weather = api.CurrentWeather(ort);

			LTemperatur.Text = weather.main.temp + "°C";
			LWind.Text = weather.wind.speed + " m/s";
			LRichtung.Text = weather.wind.deg + "°";
			LFeuchtigkeit.Text = weather.wind.deg + "°";
			LDruck.Text = weather.main.pressure + " hPa";
			LBeschreibung.Text = weather.weather[0].description;
		}

		API api = new();
	}
}