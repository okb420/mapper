using System;
using System.Net;
using System.Net.Http;
// using System.Net.Http.Headers;
using System.Threading.Tasks;
//This file contains the UT3 Engine Custom namespace with the Cube object
namespace UT3Engine
{
  public class Cube
  {
    static HttpClient client = new HttpClient();
    public string name;
    public Cube()
    {
        Console.WriteLine("Initialized");
        
    }
    public string Name{
        get{
            return name;
        }
        set{
            name = value;
        }
    }
    public void display(){
        Console.WriteLine(name);
    }
    
  }

  class Program
  {
    public static void Main()
    {
        RunAsync();
    }

    static async Task<UT3Engine.Cube> CreateCube(UT3Engine.Cube cube)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/", cube);
        response.EnsureSuccessStatusCode();
    }
    static async Task RunAsync(){
        client.BaseAddres = new Uri("http://localhost:3001/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );

        try {

            UT3Engine.Cube myCube = new UT3Engine.Cube();
            myCube.name = "muiz";

            var url = await CreateCube(myCube);
            Console.WriteLine("initi!");

        }
        catch{

        }
    }
}
}