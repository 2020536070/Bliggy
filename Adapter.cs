//2079034130


using Newtonsoft.Json;
using System.Collections.Generic;

public class JsonAdapter : IJsonData
{
    //Private instance of service
    private WeatherData weatherData;

    public JsonAdapter(WeatherData weatherData)
    {
        //Assign service object
        this.weatherData = weatherData;
    } //Constructor

    public string GetJson() //1
    {
        //Create and return formatted Json string

        //Simpler - No properties in the json file
        //List<string[]> csv = weatherData.GetData();      
        //return JsonConvert.SerializeObject(csv, Formatting.Indented);

        //Better - with properties in the json file
        List<string[]> csv = weatherData.GetData(); //1
        List<Dictionary<string, string>> listObjResult
            = new List<Dictionary<string, string>>(); //1
        for (int i = 1; i < csv.Count; i++)
        {
            Dictionary<string, string> objResult
                = new Dictionary<string, string>(); //1
            for (int j = 0; j < csv[0].Length; j++)
                objResult.Add(csv[0][j], csv[i][j]);
            listObjResult.Add(objResult);
        }
        return JsonConvert.SerializeObject(listObjResult, Formatting.Indented);


    } //GetJson
} //class JsonAdapter
