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
                if (listIsOpen == false)
                {
                    if (paragraph.Style == "Heading1")
                    {
                        returnHtml += "";
                    }
                    else if (paragraph.Style == "Normal")
                    {
                        returnHtml += "<p class='doc-content'>" + paragraph.Content + "</p>";
                    }
                    else if (paragraph.Style == "Heading2")
                    {
                        returnHtml += "<h2 class='doc-section'>" + paragraph.Content + "</h2>";
                    }
                    else if (paragraph.Style == "ListParagraph" && paragraph.ListItemType == "Bulleted")
                    {
                        returnHtml += "<ul class='doc-ul'><li>" + paragraph.Content + "</li>";
                        listIsOpen = true;
                        listIsOrdered = false;
                    }
                    else if (paragraph.Style == "ListParagraph" && paragraph.ListItemType == "Numbered")
                    {
                        returnHtml += "<ol class='doc-ol'><li class='doc-li'>" + paragraph.Content + "</li>";
                        listIsOpen = true;
                        listIsOrdered = true;
                    }
                }
                else
                {
                    string listCloseTag = listIsOrdered ? "</ol>" : "</ul>";
                    if (listIsOpen == true)
                    {
                        if (paragraph.Style == "Heading1")
                        {
                            returnHtml += listCloseTag;
                            listIsOpen = false;
                            returnHtml += "";
                        }
                        else if (paragraph.Style == "Normal")
                        {
                            returnHtml += listCloseTag;
                            listIsOpen = false;
                            returnHtml += "<p class='doc-content'>" + paragraph.Content + "</p>";
                        }
                        else if (paragraph.Style == "Heading2")
                        {
                            returnHtml += listCloseTag;
                            listIsOpen = false;
                            returnHtml += "<h2 class='doc-section'>" + paragraph.Content + "</h2>";
                        }
                        else if (paragraph.Style == "ListParagraph" && paragraph.ListItemType == "Bulleted")
                        {
                            returnHtml += "<li class='doc-li'>" + paragraph.Content + "</li>";
                        }
                        else if (paragraph.Style == "ListParagraph" && paragraph.ListItemType == "Numbered")
                        {
                            returnHtml += "<li class='doc-li'>" + paragraph.Content + "</li>";
                        }
                    }
                }                
            }
            return returnHtml;
        }
    }
}

