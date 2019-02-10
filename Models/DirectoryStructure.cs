using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WordStuff.Models
{
    public class DirectoryStructure
    {
        private Configs Config = new Configs();
        private IEnumerable<string> DirectoryPaths { get; set; }
        public List<DirectoryStructureDto> directoryStructureDtos = new List<DirectoryStructureDto>();

        public DirectoryStructure()
        {
            
            DirectoryPaths = Directory.EnumerateDirectories(Config.BlogRoot.ToString());
            foreach (var directory in DirectoryPaths)
            {
                directoryStructureDtos.Add(new DirectoryStructureDto(directory));
            }
        }
    }
}