// http://localhost:5103/WeatherForecast/get
// http://localhost:5103/worker/getworker/
// http://localhost:5103/worker/getworker/3

using System.Net.Http;
using Newtonsoft.Json;

HttpClient hc = new HttpClient();

string res1 = hc.GetStringAsync("http://localhost:5103/worker/getworker/3").Result;
Console.WriteLine(res1);

Worker w = JsonConvert.DeserializeObject<Worker>(res1);

Console.WriteLine(w.FirstName);
Console.WriteLine(w.Age);
