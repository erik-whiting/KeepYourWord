using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xceed.Words.NET;
using WordStuff.Controllers;

namespace WordStuff.Models
{
    public class WordDoc
    {
        public string Author { get; set; }
        public string Written { get; set; }
        public string Title { get; set; }
        public List<ParagraphDTO> Paragraphs { get; set; }
        public string htmlString { get; set; }

        public WordDoc(DocX document)
        {
            htmlString = "";
            TagController tagController = new TagController();
            var coreProperties = document.CoreProperties;
            Author = coreProperties["dc:creator"];
            Written = coreProperties["dcterms:created"];

            Title = document.Paragraphs.FirstOrDefault().Text;

            foreach (var paragraph in document.Paragraphs)
            {
                if (Paragraphs == null)
                {
                    Paragraphs = new List<ParagraphDTO>();
                }
                ParagraphDTO paragraphDto = new ParagraphDTO(paragraph);
                Paragraphs.Add(new ParagraphDTO(paragraph));
            }

            htmlString = tagController.ToHtml(Paragraphs);
        }

    }
}