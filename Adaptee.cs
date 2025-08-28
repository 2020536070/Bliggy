//2079034130

using System.Collections.Generic;
using System.IO;

public class WeatherData
{
    private string fileName;

    public WeatherData(string fileName)
    {
        this.fileName = fileName;
    }

    //Question 2.1
    public List<string[]> GetData()
    {
        string[] lines = File.ReadAllLines(fileName);

        List<string[]> csv = new List<string[]>();
        //foreach (string line in lines)
        //csv.Add(line.Split(','));

        for (int i = 0; i < lines.Length; i++)
            csv.Add(lines[i].Split(','));  

        return csv;
    } //GetData
} //class WeatherData
