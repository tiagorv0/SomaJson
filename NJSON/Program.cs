using System;
using NJSON.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;

namespace NJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(@"C:\Users\Tiago Vazzoller\Desktop\data.json");
            var targetJson = @"C:\Users\Tiago Vazzoller\Desktop\result.json";

            //var js = new DataContractJsonSerializer(typeof(Number));
            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            //var number = (Number)js.ReadObject(ms);

            var number2 = JsonConvert.DeserializeObject<Number>(json);

            int soma = number2.Number1 + number2.Number2;

            Result r = new Result(soma);

            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = System.Text.Json.JsonSerializer.Serialize(r,options);
            File.WriteAllText(targetJson, jsonString);


            Console.ReadKey();
        }
    }
}
