using System;
using System.Text;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;

public class Data
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        string DRIVER = "SQL SERVER";
        string SERVER = "LANZ\\SQLEXPRESS";
        string DATABASE = "TestDatabase";

        string connection_string = $"Data Source=(LocalDB)\\MSSQLLocalDB;initial catalog=mastder;" +
                "Integrated Security=True;Connect Timeout=30;User ID=Lanz;pwd=Kurumi";
            
        using (SqlConnection connection = new SqlConnection(connection_string))
        {
            connection.Open();
        }
    }
}

/*
public class Program
{
    public static void Main(string[] args)
    {
        Data data = new Data(){ Name = "Lanz", Age = 20};

        HttpClient client = new System.Net.Http.HttpClient();

        StringContent content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        
        var response = client.PostAsync("http://127.0.0.1:5000/", content).Result;
        Console.WriteLine(((int)response.StatusCode));
        if (response.IsSuccessStatusCode)
        {
            var responseContent = response.Content; 

            string responseString = responseContent.ReadAsStringAsync().Result;

            Console.WriteLine(responseString);
        }   
    }
}
*/