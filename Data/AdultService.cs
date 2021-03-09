using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace WebApplication7.Data
{
    public class AdultService: IAdultService

    {
    private string AdultFile = "adults.json";
    private IList<Adult> adults;
  

    public AdultService()
    {
        if (!File.Exists(AdultFile))
        {
            FileStream fs = new FileStream(AdultFile, FileMode.CreateNew);
            adults = new List<Adult>();
            string productAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(AdultFile, productAsJson);
        }
        else
        {
            ReadAdultsFromFile();
        }
    }

    private void WriteAdultsToFile()
    {
        string productAsJson = JsonSerializer.Serialize(adults);
        File.WriteAllText(AdultFile, productAsJson);
    }

    private void ReadAdultsFromFile()
    {
        string content = File.ReadAllText(AdultFile);
        adults = JsonSerializer.Deserialize<List<Adult>>(content);
    }

    public IList<Adult> getAdults()
    {
        List<Adult> tmp = new List<Adult>(adults);
        return tmp;
    }

    public void AddAdult(Adult adult)
    {
        int max = adults.Max(adult => adult.Id);
        adult.Id = ++max;
        adults.Add(adult);
        WriteAdultsToFile();
    }

    public void RemoveAdult(int adultID)
    {
        Adult toRemove = adults.First(t => t.Id == adultID);
        adults.Remove(toRemove);
        WriteAdultsToFile();
        
    }
    }
}