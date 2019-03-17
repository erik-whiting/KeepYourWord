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
        public bool ReviewFolder { get; set; }
        public bool IsRoot { get; set; }
        public List<string> Files = new List<string>();
        public List<DirectoryStructureDto> Directories = new List<DirectoryStructureDto>();

        public DirectoryStructureDto(string path)
        {
            Configs config = new Configs();
            Path = path.Replace("'", "");
            var parsedPaths = path.Split('\\');
            FolderName = parsedPaths.Last();
            parsedPaths = parsedPaths.Take(parsedPaths.Count() - 1).ToArray();
            IsRoot = FolderName == config.RootName;
            ReviewFolder = FolderName == config.ReviewFolder;

            if (!IsRoot)
            {
                while (parsedPaths.Last() != config.RootName)
                {
                    FolderName = parsedPaths.Last() + '\\' + FolderName;
                    parsedPaths = parsedPaths.Take(parsedPaths.Count() - 1).ToArray();
                }
            }

            ParentFolder = Directory.GetParent(path).ToString().Split('\\').Last();

            //If parent is not root, add to path
            if (Directory.EnumerateDirectories(Path) != null)
            {
                foreach (var directory in Directory.EnumerateDirectories(Path))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(directory);

                    if (!directoryInfo.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        Directories.Add(new DirectoryStructureDto(directory));
                    }
                        
                }
            }

            foreach (var file in Directory.EnumerateFiles(Path))
            {
                Files.Add(file.ToString().Split('\\').Last().Split('.').FirstOrDefault());
            }

        }
    }
}