using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WordStuff.Models
{
    public class DirectoryStructureDto
    {
        public string Path { get; set; }
        public string FolderName { get; set; }
        public string ParentFolder { get; set; }
        public List<string> Files = new List<string>();
        public List<DirectoryStructureDto> SubDirectoryDtos = new List<DirectoryStructureDto>();

        public DirectoryStructureDto(string path)
        {
            Path = path;
            FolderName = path.Split('\\').Last();
            ParentFolder = Directory.GetParent(path).ToString().Split('\\').Last();

            foreach (var directory in Directory.EnumerateDirectories(Path))
            {
                SubDirectoryDtos.Add(new DirectoryStructureDto(directory));
            }

            foreach (var file in Directory.EnumerateFiles(Path))
            {
                Files.Add(file.ToString().Split('\\').Last().Split('.').FirstOrDefault());
            }

        }
    }
}