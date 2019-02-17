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
        public List<DirectoryStructureDto> Directories = new List<DirectoryStructureDto>();

        public DirectoryStructureDto(string path)
        {
            Path = path;
            FolderName = path.Split('\\').Last();
            ParentFolder = Directory.GetParent(path).ToString().Split('\\').Last();

            if (Directory.EnumerateDirectories(Path) != null)
            {
                foreach (var directory in Directory.EnumerateDirectories(Path))
                {
                    Directories.Add(new DirectoryStructureDto(directory));
                }
            }

            foreach (var file in Directory.EnumerateFiles(Path))
            {
                Files.Add(file.ToString().Split('\\').Last().Split('.').FirstOrDefault());
            }

        }
    }
}