﻿using System;
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

            //Find out if filename exists in root
            //If not, append directory to filename


            var coreProperties = document.CoreProperties;
            Filename = filename;
            string jsEvent = "'getContent(";
            filename = filename.Replace("\\", "\\\\");
            jsEvent += '"' + filename + '"';
            jsEvent += ")'";
            string clickEvent = "<a class='header-link' href='#' onClick=" + jsEvent + ">";
            //<a href='#' onClick='loadDoc("fileName")'>

            headerHtml = clickEvent; //.Replace("\\", "");
            headerHtml += "<div class='doc-header'>";

            Title = document.Paragraphs.FirstOrDefault().Text;
            headerHtml += "<h2 class='header-title'>" + Title + "</h2>";

            Author = coreProperties["dc:creator"];
            headerHtml += "<span class='doc-author'>" + Author + "</span>";

            Created = coreProperties["dcterms:created"];
            headerHtml += "<span class='doc-created'>" + Created + "</span>";

            headerHtml += "</div></a>";

        }
    }
}