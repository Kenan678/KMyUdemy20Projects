using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Text;
using System.Text.Json.Nodes;
using System.Xml;

Console.WriteLine("Api Consume Welcome");
Console.WriteLine();
Console.WriteLine("#### Select the Things ####");
Console.WriteLine();
Console.WriteLine("1-Get The City List ");
Console.WriteLine("2-City and Weather Tempurature List");
Console.WriteLine("3-Add The City ");
Console.WriteLine("4-Delete The City ");
Console.WriteLine("5-Update The City ");
Console.WriteLine("6-Get By Id to City");
Console.WriteLine();
string number;

Console.WriteLine("Select: ");
number = Console.ReadLine();
if (number == "1")
{
    string url = "https://localhost:7063/api/Wheathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            Console.WriteLine($"City:{cityName}");
        }
    }
}
if (number == "2")
{

    string url = "https://localhost:7063/api/Wheathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string temp = item["temp"].ToString();
            Console.WriteLine($"{cityName} {temp}");
        }
    }

}
if (number == "3")
{
    string cityName, country, detail;
    decimal temp;
    Console.Write("Seher adi:");
    cityName = Console.ReadLine();
    Console.Write("Olke adi:");
    country = Console.ReadLine();
    Console.Write("Hava durumu deatyi:");
    detail = Console.ReadLine();
    Console.Write("Tempratur:");
    temp = decimal.Parse(Console.ReadLine());
    string url = "https://localhost:7063/api/Wheathers";
    var newWeatherCity = new
    {
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };
    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(newWeatherCity);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
    }

}
if (number == "4")
{
    string url = "https://localhost:7063/api/Wheathers?id=";
    Console.WriteLine("Silmek istediyiniz Id yazin");
    int id = int.Parse(Console.ReadLine());
    using (HttpClient client=new HttpClient()) {
        HttpResponseMessage response= await client.DeleteAsync(url+id);
        response.EnsureSuccessStatusCode();

    }
}
if (number == "5")
{
    string url = "https://localhost:7063/api/Wheathers?id=";
    string cityName, country, detail;
    decimal temp;
    int cityId;

    Console.Write("Seher adi:");
    cityName = Console.ReadLine();
    Console.Write("Olke adi:");
    country = Console.ReadLine();
    Console.Write("Hava durumu deatyi:");
    detail = Console.ReadLine();
    Console.Write("Tempratur:");
    temp = decimal.Parse(Console.ReadLine());
    Console.Write("Seher Id:");
    cityId = int.Parse(Console.ReadLine());
    var UpdatedWeatherCity = new
    {
        CityId = cityId,
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };
    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(UpdatedWeatherCity);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PutAsync(url, content);
        response.EnsureSuccessStatusCode();
    }
}
if (number == "6")
{
    string url = "https://localhost:7063/api/Wheathers/GetByIdWeatherCity?id=";
    int id = int.Parse(Console.ReadLine());
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url + id);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        JObject weatherCityObject = JObject.Parse(responseBody);
        string cityName = weatherCityObject["cityName"].ToString();
        string detail = weatherCityObject["detail"].ToString();
        string country = weatherCityObject["country"].ToString();
        decimal temp =Decimal.Parse( weatherCityObject["temp"].ToString());
        Console.WriteLine( "seher: "+cityName+" olke: " +country+" detay: "+detail+" tempratur: "+temp);
    }
}

Console.Read();

