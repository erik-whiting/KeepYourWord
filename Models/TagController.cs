using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WordStuff.Models
{
    public class TagController : ApiController
    {
        public string ToHtml(List<ParagraphDTO> Paragraphs)
        {
            string returnHtml = "";
            bool listIsOpen = false;
            bool listIsOrdered = false;

            foreach (ParagraphDTO paragraph in Paragraphs)
            {

                if (paragraph.Style == "Heading1")
                {
                    returnHtml += "";
                }
                else if (paragraph.Style == "Normal")
                {
                    returnHtml += listIsOpen ? (listIsOrdered ? "</ol>" : "</ul>") : "";
                    listIsOpen = false;
                    returnHtml += "<p class='doc-content'>" + paragraph.Content + "</p>";
                }
                else if (paragraph.Style == "Heading2")
                {
                    returnHtml += listIsOpen ? (listIsOrdered ? "</ol>" : "</ul>") : "";
                    listIsOpen = false;
                    returnHtml += "<h2 class='doc-section'>" + paragraph.Content + "</h2>";
                }
                else if (paragraph.Style == "ListParagraph" && paragraph.ListItemType == "Bulleted")
                {
                    returnHtml += listIsOpen ? "" : "<ul class='doc-ul'>";
                    returnHtml += "<li class='doc-li'>" + paragraph.Content + "</li>";
                    listIsOpen = true;
                    listIsOrdered = false;
                }
                else if (paragraph.Style == "ListParagraph" && paragraph.ListItemType == "Numbered")
                {
                    returnHtml += listIsOpen ? "" : "<ol class='doc-ol'>";
                    returnHtml += "<li class='doc-li'>" + paragraph.Content + "</li>";
                    listIsOpen = true;
                    listIsOrdered = true;
                }
            }
            return returnHtml;
        }
    }
}

