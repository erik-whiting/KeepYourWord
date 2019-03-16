using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordStuff.Models
{
    public class Style
    {
        public Dictionary<string, Dictionary<string, string>> DocumentStyles { get; set; }
        public Dictionary<string, Dictionary<string, string>> HeaderStyles { get; set; }
        public Dictionary<string, Dictionary<string, string>> NavStyles { get; set; }
        public Dictionary<string, Dictionary<string, string>> PageStyles { get; set; }

        public Style()
        {
            var docHeader = new Dictionary<string, string>
            {
                { "text-align", "center" }
            };
            var docTitle = new Dictionary<string, string>
            {
                {"text-align", "center" }
            };
            var docAuthor = new Dictionary<string, string>
            {
                {"display", "inline-block" },
                {"margin", "3px" },
                { "font-weight", "bold" }
            };
            var docCreated = new Dictionary<string, string>
            {
                {"display", "inline-block" },
                {"margin", "3px" }
            };
            DocumentStyles.Add(".doc-header", docHeader);
            DocumentStyles.Add(".doc-title", docTitle);
            DocumentStyles.Add(".doc-author", docAuthor);
            DocumentStyles.Add(".doc-created", docCreated);

            var headLink = new Dictionary<string, string>
            {
                {"text-decoration",  "none"},
                {"color", "#1812e" }
            };
            var headLinkHover = new Dictionary<string, string>
            {
                {"background-color", "#eac67a" }
            };
            var docHeaderInfo = new Dictionary<string, string>
            {
                {"align-content", "center" },
                {"font-family", "'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif" }
            };
            var headerTitle = new Dictionary<string, string>
            {
                {"font-family", "'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif" }
            };
            HeaderStyles.Add(".header-link", headLink);
            HeaderStyles.Add(".header-link :hover", headLinkHover);
            HeaderStyles.Add(".doc-header-info", docHeaderInfo);
            HeaderStyles.Add(".header-title", headerTitle);

            var nav = new Dictionary<string, string>
            {
                {"height", "100%"},
                {"width", "200px"},
                {"position", "fixed"},
                {"z-index", "1"},
                {"top", "0"},
                {"left", "0"},
                {"background-color", "#18121e"},
                {"overflow-x", "hidden"},
                {"padding-top", "60px"},
                {"transition", "0.5s"}
            };
            var navLink = new Dictionary<string, string>
            {
                {"padding", "8px"},
                {"text-decoration", "none"},
                {"font-size", "25px"},
                {"color", "#eac67a"},
                {"display", "block"},
                {"transition", "0.3s"}
            };
            var navLinkHover = new Dictionary<string, string>
            {
                {"color", "#18121e"},
                {"background-color", "#984b43"}
            };
            var navLinkSubDir = new Dictionary<string, string>
            {
                {"padding", "8px 8px 8px 32px"},
                {"font-size", "20px"},
                {"color", "#eac67a"},
                {"display", "block"},
                {"transition", "0.3s"}
            };
            NavStyles.Add(".sidenav", nav);
            NavStyles.Add(".sidenav a", navLink);
            NavStyles.Add(".sidenav a:hover", navLinkHover);
            NavStyles.Add(".sidenav .nav-sub-dir", navLinkSubDir);

            var body = new Dictionary<string, string>
            {
                {"background-color", "#fff" },
            };
            var contentDiv = new Dictionary<string, string>
            {
                {"font-family", "'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif"},
                {"color", "#233237"},
                {"transition", "margin-left .5s"},
                {"padding-left", "200px"}
            };
            PageStyles.Add("body", body);
            PageStyles.Add("#content-div", contentDiv);
        }

        public void ChangeDocStyles (string element, string attribute, string value)
        {
        }
        public void ChangeHeaderStyles(string element, string value)
        {

        }
        public void ChangeNavStyles(string element, string value)
        {

        }
        public void ChangePageStyles(string element, string value)
        {

        }
    }
}