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

            foreach (ParagraphDTO paragraph in Paragraphs)
            {
                if (paragraph.Style == "Heading1")
                {
                    returnHtml += "<h1 class='doc-title'>" + paragraph.Content + "</h1>";
                } else if (paragraph.Style == "Normal")
                {
                    returnHtml += "<p class='doc-content'>" + paragraph.Content + "</p>";
                } else if (paragraph.Style == "Heading2")
                {
                    returnHtml += "<h2 class='doc-section'>" + paragraph.Content + "</h2>";
                } else if (paragraph.Style == "ListParagraph" && paragraph.ListItemType == "Bulleted")
                {

                }
            }



            
            return returnHtml;
        }

        public string HandleLists(List<ParagraphDTO> ListItems)
        {
            string listHtml = "";

            return listHtml;
        }
    }
}
