using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using System.Xml;

Console.WriteLine("Api Consume Welcome");
Console.WriteLine();
Console.WriteLine("#### Select the Things ####");
Console.WriteLine();
Console.WriteLine("1-Get The City List ");
Console.WriteLine("2-City and Weather Tempurature List");
Console.WriteLine("3-Delete The City ");
Console.WriteLine("4-Update The City ");
Console.WriteLine("5-Get By Id to City");
Console.WriteLine();
string number;

Console.WriteLine("Select: ");
number = Console.ReadLine();
if (number == "1")
{
    string url = "https://localhost:7063/api/Wheathers";
    using(HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray=JArray.Parse(responseBody);   
        foreach(var item in jArray)
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
        if (number == "3")
        {
        https://localhost:7063/api/Wheathers
            Console.WriteLine("City Deleted side :");
        }
        Console.Read();
    }
}



