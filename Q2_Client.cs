//2079034130

using System;
using System.Collections.Generic;

class Client
{
    static void Main(string[] args)
    {
        //Black on white
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        //Instantiate original weather data object: 1
        string fileName = "WeatherHistory.csv";
        WeatherData weatherData = new WeatherData(fileName);
        //Instantiate adapter : 2
        JsonAdapter adapter = new JsonAdapter(weatherData);

        //Get json string and display in Json format: 3
        Console.WriteLine();
        Console.WriteLine("\tJSON format");
        Console.WriteLine("\t===========");
        string json = adapter.GetJson();
        Console.WriteLine(json);

        //Wait for user
        Console.ReadKey();

    } //Main

} //class Client

