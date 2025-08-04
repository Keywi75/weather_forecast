using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] cities = new string[] {
                "Hanoi", "Ho Chi Minh", "Hue", "Da Nang", "Hai Phong", "Can Tho",
                "Nha Trang", "Vung Tau", "Da Lat", "Quy Nhon", "Ha Long", "Bien Hoa",
                "Thanh Hoa", "Vinh", "Rach Gia", "Bac Lieu", "Pleiku", "Buon Ma Thuot",
                "My Tho", "Phan Thiet", "Tuy Hoa", "Cao Bang", "Lang Son",
                "Lao Cai", "Yen Bai", "Son La", "Dien Bien Phu", "Thai Nguyen", "Nam Dinh"
            };
            foreach (string city in cities)
            {
                City.Items.Add(city);
            }
            City.SelectedIndex = 0;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Date";
            dataGridView1.Columns[1].Name = "Description";
            dataGridView1.Columns[2].Name = "Temperature (°C)";
            dataGridView1.Columns[3].Name = "Pressure (hPa)";
            dataGridView1.Columns[4].Name = "Humidity (%)";
            dataGridView1.Columns[5].Name = "Clouds (%)";
            dataGridView1.Columns[6].Name = "Wind (m/s)";
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (City.SelectedItem == null)
            {
                MessageBox.Show("Please select a city!");
                return;
            }

            string city = City.SelectedItem.ToString();
            string apiKey = "75078a8c6e2bcf7ba4744cf56423b092"; 
            string weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
            string forecastUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string weatherResponse = await client.GetStringAsync(weatherUrl);
                    JObject weatherJson = JObject.Parse(weatherResponse);

                    des.Text = weatherJson["weather"][0]["description"].ToString();
                    temp.Text = weatherJson["main"]["temp"].ToString() + " °C";
                    press.Text = weatherJson["main"]["pressure"].ToString() + " hPa";
                    hum.Text = weatherJson["main"]["humidity"].ToString() + " %";
                    cloud.Text = weatherJson["clouds"]["all"].ToString() + " %";
                    wind.Text = weatherJson["wind"]["speed"].ToString() + " m/s";

                    string icon = weatherJson["weather"][0]["icon"].ToString();
                    string iconUrl = $"http://openweathermap.org/img/wn/{icon}@2x.png";
                    pictureBox1.Load(iconUrl);

                    string forecastResponse = await client.GetStringAsync(forecastUrl);
                    JObject forecastJson = JObject.Parse(forecastResponse);

                    dataGridView1.Rows.Clear();

                    foreach (var item in forecastJson["list"])
                    {

                        long unixTime = long.Parse(item["dt"].ToString());
                        DateTime date = DateTimeOffset.FromUnixTimeSeconds(unixTime).DateTime;

                        string description = item["weather"][0]["description"].ToString();
                        string temperature = item["main"]["temp"].ToString() + " °C";  
                        string pressure = item["main"]["pressure"].ToString() + " hPa";  
                        string humidity = item["main"]["humidity"].ToString() + " %";  
                        string clouds = item["clouds"]["all"].ToString() + " %";  
                        string wind = item["wind"]["speed"].ToString() + " m/s";  

                   
                        string[] row = new string[]
                        {
                            date.ToString("dd/MM/yyyy HH:mm:ss"),
                            description,
                            temperature,
                            pressure,
                            humidity,
                            clouds,
                            wind
                        };

                        dataGridView1.Rows.Add(row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calling API: " + ex.Message);
                }
            }
        }
    }
}
