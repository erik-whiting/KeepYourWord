using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WordStuff.Models
{
    public class Configs
    {
        public string ConfigFileLocation = "C:\\Users\\eedee\\source\\repos\\WordStuff\\WordStuff\\config.yaml";
        public string BlogRoot { get; set; }

        public Configs()
        {
            BlogRoot = "C:\\Users\\eedee\\Documents\\mastersStuff\\Spring19\\SW Engr\\kywroot";
        }
    }
}