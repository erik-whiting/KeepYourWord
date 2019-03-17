using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xceed.Words.NET;
using WordStuff.Controllers;
using System.Web.Http;
using WordStuff.Models;

namespace WordStuff.Models
{
    public class WordDoc
    {
        public string Author { get; set; }
        public string Created { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string ContainingFolder { get; set; }
        public List<ParagraphDTO> Paragraphs { get; set; }
        public string htmlString { get; set; }

        public WordDoc(DocX document, string fileName, bool ToBeReviewed = false)
        {
            Configs config = new Configs();
            FileName = fileName;
            htmlString = "";
            TagController tagController = new TagController();
            var coreProperties = document.CoreProperties;
            
            Author = coreProperties["dc:creator"];
            Created = coreProperties["dcterms:created"];
            Title = document.Paragraphs.FirstOrDefault().Text;

            htmlString += "<h1 class='doc-title'>" + Title + "</h1>";
            htmlString += "<div class='doc-header'><span class='doc-author'>" + Author + "</span>";
            htmlString += "<span class='doc-created'>" + Created + "</span></div>";

            foreach (var paragraph in document.Paragraphs)
            {
                if (Paragraphs == null)
                {
                    Paragraphs = new List<ParagraphDTO>();
                }
                ParagraphDTO paragraphDTO = new ParagraphDTO(paragraph);
                Paragraphs.Add(paragraphDTO);
            }

            htmlString += tagController.ContentToHtml(Paragraphs);

            if (ToBeReviewed)
            {
                htmlString += "<br /><br />";
                htmlString += "<button type='button' onClick='approve()'>Approve Article</button>";
                var dirControl = new DirectoryStructureController();
                var ds = new DirectoryStructure();
                htmlString += "<select id='destination'>"; 
                foreach (var directory in ds.directoryStructureDtos)
                {
                    if (directory.FolderName != config.ReviewFolder)
                    {
                        htmlString += "<option value='" + directory.FolderName + "'>" + directory.FolderName + "</option>";
                    }
                }
                htmlString += "</select>";
                htmlString += "<br />";
                htmlString += "<button type='button' onClick='reject()'>Reject Article</button>";
                htmlString += "<br />";
                htmlString += "<p id='filename'>" + FileName.Split('\\')[2] + "</p>";
                
            }

        }

    }
}