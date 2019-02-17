using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xceed.Words.NET;
using WordStuff.Controllers;

namespace WordStuff.Models
{
    public class WordDocHeader
    {
        public string Author { get; set; }
        public string Created { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
        public string headerHtml { get; set; }

        public WordDocHeader(DocX document, string filename)
        {
            var coreProperties = document.CoreProperties;
            Filename = filename;
            string jsEvent = "'loadDoc(";
            jsEvent += '"' + filename + '"';
            jsEvent += ")'";
            jsEvent = jsEvent.Replace(@"\", "");
            string clickEvent = "<a href='#' onClick=" + jsEvent + ">";
            //<a href='#' onClick='loadDoc("fileName")'>

            headerHtml = clickEvent.Replace("\\", "");
            headerHtml += "<div class='doc-header-info'>";

            Author = coreProperties["dc:creator"];
            headerHtml += "<span class='header-author'>" + Author + "</span>";

            Created = coreProperties["dcterms:created"];
            headerHtml += "<span class='header-created'>" + Created + "</span>";

            Title = document.Paragraphs.FirstOrDefault().Text;
            headerHtml += "<span class='header-title'>" + Title + "</span>";

            headerHtml += "</div></a>";

        }
    }
}