using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xceed.Words.NET;

namespace WordStuff.Models
{
    public class ParagraphDTO
    {
        public string Style { get; set; }
        public string Content { get; set; }
        public string ListItemType { get; set; }

        public ParagraphDTO(Paragraph paragraph)
        {
            Style = paragraph.StyleName;
            Content = paragraph.Text;
            ListItemType = paragraph.ListItemType.ToString();
        }
    }
}