using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using YamlDotNet.RepresentationModel;

namespace WordStuff.Models
{
    public class Configs
    {
        private string ConfigFileLocation = "C:\\Users\\eedee\\source\\repos\\WordStuff\\WordStuff\\config.yaml";
        public string BlogRoot { get; set; }
        public Dictionary<string, string> Groups {get; set;}

        public Configs()
        {
            var configFileStream = new StreamReader(ConfigFileLocation);
            var yaml = new YamlStream();
            yaml.Load(configFileStream);
            var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
            var groups = mapping["groups"];

            var groupDict = new Dictionary<string, string>
            {
                {"readers", (string)groups["readers"]},
                {"admin", (string)groups["admin"]},
                {"contributors", (string)groups["contributors"]}
            };

            Groups = groupDict;

            BlogRoot = (string)mapping["root"];
        }
    }
}