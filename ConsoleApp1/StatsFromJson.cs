using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public static class StatsFromJson
    {
        public static string GetStatName(int statCode)
        {
            var dir = "C:\\Users\\g.chaniotakis\\Desktop";
            var files = Directory.GetFiles(dir);
            var file = files.FirstOrDefault(f => f.Contains("stats.json"));
            var content = File.ReadAllText(file);
            var stats = JsonConvert.DeserializeObject<ExtractStats>(content);            
            var name = stats.StatsJson.Stats.FirstOrDefault(s => s.Code == statCode).AttributeDescription;
            return name ?? "Unknown stat";
        }
    }

    public class ExtractStats
    {
        public StatsJson StatsJson { get; set; }
    }
    
    //[Serializable]
    public class StatsJson
    {            
        public StatJson[] Stats { get; set; }
    }

   // [Serializable]
    public class StatJson
    {
        
        public int CatId { get; set; }        
        public int Code { get; set; }        
        public string EnumName { get; set; }        
        public string AttributeDescription { get; set; }        
        public string AttributeName { get; set; }        
        public string Formula { get; set; }        
        public string DefaultValue { get; set; }      
        public int Scope { get; set; }        
        public int Type { get; set; }       
        public bool Streak { get; set; }        
        public string ShortTitle { get; set; }
    }
}
