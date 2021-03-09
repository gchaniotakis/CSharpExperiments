using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpExperiments
{
    public static class JsonExperiment
    {
        public static void SerializeDictionary(JsonModel model)
        {
            const string Path = "C:\\Users\\g.chaniotakis\\Desktop\\exp\\exp.json";
            var message = JsonConvert.SerializeObject(model);
            File.WriteAllText(Path, message);
        }

    }

    public class JsonModel
    {
        public Dictionary<string,int[]> Dict { get; set; }
    }
}
